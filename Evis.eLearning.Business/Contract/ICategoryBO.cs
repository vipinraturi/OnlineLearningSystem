using Evis.eLearning.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evis.eLearning.Business.Contract
{
    public interface ICategoryBO
    {
        void AddCategory(Category category);
    }
}
