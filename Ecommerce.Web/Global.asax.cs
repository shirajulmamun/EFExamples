using AutoMapper;
using Ecommerce.Models.EntityModels;
using Ecommerce.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Ecommerce.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            Mapper.Initialize(cfg => {
                cfg.CreateMap<ProductEntryVM, Product>();
                cfg.CreateMap<Product, ProductEntryVM>();
            });
        }
    }
}
