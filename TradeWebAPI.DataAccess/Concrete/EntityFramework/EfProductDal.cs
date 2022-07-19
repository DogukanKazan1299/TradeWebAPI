using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeWebAPI.Core.DataAccess.EntityFramework;
using TradeWebAPI.DataAccess.Abstract;
using TradeWebAPI.DataAccess.Concrete.EntityFramework.Contexts;
using TradeWebAPI.Entities.Concrete;

namespace TradeWebAPI.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntittRepositoryBase<Product,NorthwindContext>,IProductDal
    {
    }
}
