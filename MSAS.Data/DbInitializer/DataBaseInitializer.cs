using MSAS.Data.Migrations;
//using MSAS.Data.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Data.DbInitializer
{
    public class DataBaseInitializer : IDatabaseInitializer<MSASContext>
    {
        public void InitializeDatabase(MSASContext context)
        {
            context.Database.CreateIfNotExists();
            //context.Database.Initialize(new MigrateDatabaseToLatestVersion<MSASContext, Configuration>());
           Database.SetInitializer(new MigrateDatabaseToLatestVersion<MSASContext, Configuration>());
            

        }
    }
}
