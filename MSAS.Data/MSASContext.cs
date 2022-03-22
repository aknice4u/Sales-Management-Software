using MSAS.Core.UsersMgt;
using MSAS.Data.Migrations;
using MSAS.Data.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Data
{
    public class MSASContext : DbContext, IDbContext
    {
        static MSASContext()
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<MSASContext, Configuration>());
        }
        public MSASContext()
            : base("Name=MSASContext") 
        {
          //Database.SetInitializer(new MigrateDatabaseToLatestVersion<MSASContext, Configuration>());    
        }
        //public DbSet<Users> user { get; set; }
       
      
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

         Database.SetInitializer(new MigrateDatabaseToLatestVersion<MSASContext, Configuration>());
           /* var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
           .Where(type => !String.IsNullOrEmpty(type.Namespace))
           .Where(type => type.BaseType != null && type.BaseType.IsGenericType && type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));
            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(configurationInstance);
            }*/

         base.OnModelCreating(modelBuilder);
          modelBuilder.Configurations.Add(new UsersMap());
         modelBuilder.Configurations.Add(new ClientsMap());
         modelBuilder.Configurations.Add(new StatesMap());
         modelBuilder.Configurations.Add(new LGAMap());
           
                        

        }

       public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }
        

       

    }
}
