using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeWebAPI.Business.Abstract;
using TradeWebAPI.Business.Concrete;
using TradeWebAPI.DataAccess.Abstract;
using TradeWebAPI.DataAccess.Concrete.EntityFramework;

namespace TradeWebAPI.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>();
            builder.RegisterType<EfProductDal>().As<IProductDal>();
        }
    }
}
