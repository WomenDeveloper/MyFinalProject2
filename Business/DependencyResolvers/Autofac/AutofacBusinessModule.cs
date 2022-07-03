using System;
using Autofac;
using Business.Abstract;
using Business.Concreate;
using DataAccess.Abstract;
using DataAccess.Concreate.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();

        }
        public AutofacBusinessModule()
        {
        }
    }
}

