using Autofac;
using ECommerceSystem.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceSystem.Common
{
    public class CommonModule : Module
    {
        
        protected override void Load( ContainerBuilder builder)
        {
            
            builder.RegisterType<DateTimeUtility>().As<IDateTimeUtility>()
                .InstancePerLifetimeScope();
            
            base.Load(builder);
        }
    }
}
