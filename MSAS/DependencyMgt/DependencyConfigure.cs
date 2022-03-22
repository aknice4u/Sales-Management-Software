using Autofac;
using MSAS.Core;
using MSAS.Data;
using MSAS.Services.ClientServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac.Integration.Mvc;
using System.Data.Entity;
using MSAS.Services.StateLGAServices;


namespace MSAS.DependencyMgt
{
    internal class DependencyConfigure
    {
        public static void Initialize()
        {
            var builder = new ContainerBuilder();
            DependencyResolver.SetResolver(new Dependency(RegisterServices(builder)));
        }

        private static IContainer RegisterServices(ContainerBuilder builder)
        {

            builder.RegisterAssemblyTypes(
                typeof(MvcApplication).Assembly
                ).PropertiesAutowired();

            //deal with your dependencies here
            builder.RegisterType<MSASContext>().As<IDbContext>().InstancePerDependency();

            builder.RegisterGeneric(typeof(EfRepository<>)).As(typeof(IRepository<>));

            builder.RegisterType<UserService>().As<IUserService>();
            builder.RegisterType<StateService>().As<IStateService>();
            builder.RegisterType<LGAService>().As<ILGAService>();
           /* builder.RegisterType<ClientService>().As<IClientService>();
            builder.RegisterType<UserRolesService>().As<IUserRolesService>();
            builder.RegisterType<RoleAuthenticationService>().As<IRoleAuthenticationService>();
            */


            return
                builder.Build();
        }

    }
}