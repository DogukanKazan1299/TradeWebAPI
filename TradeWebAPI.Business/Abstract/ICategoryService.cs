using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeWebAPI.Core.Utilities.Results;
using TradeWebAPI.Entities.Concrete;

namespace TradeWebAPI.Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetList();
    }
}
