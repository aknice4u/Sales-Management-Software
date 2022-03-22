namespace MSAS.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public class Configuration : DbMigrationsConfiguration<MSAS.Data.MSASContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
           // ContextKey = "MSASContext";
           
        }

        protected override void Seed(MSAS.Data.MSASContext context)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MSASContext, Configuration>());
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
