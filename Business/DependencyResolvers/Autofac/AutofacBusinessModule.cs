using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.Jwt;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {


            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<TourOrderManager>().As<ITourOrderService>();
            builder.RegisterType<EfTourOrderDal>().As<ITourOrderDal>();

            builder.RegisterType<FromCityManager>().As<IFromCityService>();
            builder.RegisterType<EfFromCityDal>().As<IFromCityDal>();

            builder.RegisterType<PackageManager>().As<IPackageService>();
            builder.RegisterType<EfPackageDal>().As<IPackageDal>();

            builder.RegisterType<PlanManager>().As<IPlanService>();
            builder.RegisterType<EfPlanDal>().As<IPlanDal>();

            builder.RegisterType<ToCityManager>().As<IToCityService>();
            builder.RegisterType<EfToCityDal>().As<IToCityDal>();

            builder.RegisterType<PackagePropertyManager>().As<IPackagePropertyService>();
            builder.RegisterType<EfPackagePropertyDal>().As<IPackagePropertyDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
}
