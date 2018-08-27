using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace MyComp.EMS.Data.DI
{
    public class AutofacModule :Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EMSDBContext>();
        }
    }
}
