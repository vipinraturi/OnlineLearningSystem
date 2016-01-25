using Evis.eLearning.Business.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Evis.eLearning.Data;
using Evis.eLearning.Data.Model;

namespace Evis.eLearning.Business
{
    public class CategoryBO : ICategoryBO
    {
        IUnitOfWork _uof = null;

        public CategoryBO()
        {
            _uof = new UnitOfWork();
        }

        public void AddCategory(Data.Model.Category category)
        {
            var categoryRepository = _uof.GetRepository<Category>();
            categoryRepository.Insert(category);
            
            _uof.Commit();

        }
    }
}
