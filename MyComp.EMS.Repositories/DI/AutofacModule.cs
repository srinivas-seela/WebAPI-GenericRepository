using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyComp.EMS.Data;
using MyComp.EMS.Data.Interfaces;
using Autofac;

namespace MyComp.EMS.Repositories.DI
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
            builder.RegisterModule(new MyComp.EMS.Data.DI.AutofacModule());
        }
    }
}
