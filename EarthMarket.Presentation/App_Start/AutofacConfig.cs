using Autofac;
using Autofac.Integration.Mvc;
using EarthMarket.DataAccess.Abstract;
using EarthMarket.DataAccess.Concrete;
using EarthMarket.DataAccess.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace EarthMarket.Presentation.App_Start
{
    public class AutofacConfig
    {
        public static void Initialize()
        {
           
            RegisterServices(new ContainerBuilder());
        }
      
        private static void RegisterServices(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(
            Assembly.GetExecutingAssembly())
            .PropertiesAutowired();


            //EF DbContext
            builder.RegisterType<EFDbContext>()
            .As<DbContext>().InstancePerRequest();

            //Repositories
            // Register repositories by using Autofac's OpenGenerics feature

            builder.RegisterGeneric(typeof(EntityRepository<>))
            .As(typeof(IEntityRepository<>))
            .InstancePerRequest();


            //Services

            
            builder.RegisterType<MarketService>()
            .As<IMarketService>()
            .InstancePerRequest();

            // Set the MVC dependency resolver to use Autofac
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }
    }
}