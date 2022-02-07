using Autofac;
using ECommerceSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceSystem
{
    public class WebModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterType<>().As;
            builder.RegisterType<ProductListModel>().AsSelf();
            base.Load(builder);
        }
    }
}
