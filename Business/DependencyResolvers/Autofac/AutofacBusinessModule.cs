using Autofac;
using Business.Abstract;
using Business.Concreate;
using DataAccess.Abstract;
using DataAccess.Concreate.EntitiyFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance(); 
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();
        }
    }
}
