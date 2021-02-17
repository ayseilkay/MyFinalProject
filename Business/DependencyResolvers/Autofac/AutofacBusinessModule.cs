using Autofac;// bagımlııkları ortadan kaldırmak için kullanıcaz, ıoc contaner yapısına sahip
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();// singleınstance tek bir intance oluşturuyor.
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();// singleınstance tek bir intance oluşturuyor.
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
