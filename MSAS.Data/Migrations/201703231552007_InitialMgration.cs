namespace MSAS.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMgration : DbMigration
    {
        public override void Up()
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<MSASContext, Configuration>());
        }
        
        public override void Down()
        {
        }
    }
}
