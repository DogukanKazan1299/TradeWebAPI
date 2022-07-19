using Autofac;
using Autofac.Extensions.DependencyInjection;
using TradeWebAPI.Business.Abstract;
using TradeWebAPI.Business.Concrete;
using TradeWebAPI.Business.DependencyResolvers.Autofac;
using TradeWebAPI.DataAccess.Abstract;
using TradeWebAPI.DataAccess.Concrete.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//internal static IHostBuilder CreateHostBuilder(string[] args)=>Host.CreateDefaultBuilder(args).UseServiceProviderFactory(new AutofacServiceProviderFactory())
//    .ConfigureContainer<ContainerBuilder>(builder => { builder.RegisterModule(new AutofacBusinessModule()); })

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

builder.Services.AddControllersWithViews();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Host.ConfigureContainer<ContainerBuilder>(builder => builder.RegisterType<ProductManager>().As<IProductService>());
builder.Host.ConfigureContainer<ContainerBuilder>(builder => builder.RegisterType<EfProductDal>().As<IProductDal>());


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
