using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeWebAPI.Business.Abstract;
using TradeWebAPI.Core.Utilities.Results;
using TradeWebAPI.DataAccess.Abstract;
using TradeWebAPI.Entities.Concrete;

namespace TradeWebAPI.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public IDataResult<List<Category>> GetList()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetList().ToList());
        }
    }
}
