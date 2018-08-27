using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using Autofac.Integration;
using System.Web.Http;
using Autofac.Integration.WebApi;
using MyComp.EMS;

namespace MyComp.EMS.API
{
    public class ContainerConfig
    {
        public static IContainer Config()
        {
            var builder = new ContainerBuilder();

            builder.RegisterApiControllers(typeof(WebApiApplication).Assembly);
            builder.RegisterType<MyComp.EMS.Repositories.Repositories.VerticalRepository>()
                    .As<MyComp.EMS.Repositories.Interfaces.IVerticalRepository>();
            builder.RegisterModule(new Repositories.DI.AutofacModule());
            IContainer container = builder.Build();
            return container;
        }
    }
}