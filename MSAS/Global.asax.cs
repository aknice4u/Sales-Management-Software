using MSAS.DependencyMgt;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using MSAS.Data.Migrations;

using MSAS.Data;

namespace MSAS
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            DependencyConfigure.Initialize();
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MSASContext, Configuration>());

            var context = new MSASContext();
            //var initializeMigrations = new MigrateDatabaseToLatestVersion<MSASContext, Configuration>();

            //initializeMigrations.InitializeDatabase(context);


        }
    }
}
