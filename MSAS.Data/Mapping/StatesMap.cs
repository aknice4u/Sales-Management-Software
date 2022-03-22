using MSAS.Core.StatesLGA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Data.Mapping
{
    public class StatesMap:EntityTypeConfiguration<State>
    {
        public StatesMap()
        {
            this.ToTable("State");
            this.HasKey(c => c.StateId);
            this.Property(c => c.StateName).IsRequired();

        }
           
       }    
}
