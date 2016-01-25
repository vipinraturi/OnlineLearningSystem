/********************************************************************************
 * File Name    : CategoryRepository.cs
 * Company Name : EVIS
 * Author       : Shambhoo Kumar
 * Created On   : 01/23/2016
 * Description  : Insert/Delete/Update records for Category
 *******************************************************************************/
using Evis.eLearning.Data;
using Evis.eLearning.Data.Contract;
using Evis.eLearning.Data.Model;
//using Evis.eLearning.Infrastructure;

namespace Evis.eLearning.Data
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
    }
}
