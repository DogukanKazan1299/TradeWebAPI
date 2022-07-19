using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeWebAPI.Core.DataAccess;
using TradeWebAPI.Entities.Concrete;

namespace TradeWebAPI.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
    }
}
