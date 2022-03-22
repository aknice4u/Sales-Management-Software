using MSAS.Core.StatesLGA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Data.Mapping
{
    public class LGAMap:EntityTypeConfiguration<LGA>
    {
        public LGAMap()
        {
            this.ToTable("LGA");
            this.HasKey(c => c.LGAId);
            this.Property(c => c.StateId).IsRequired();
            this.Property(c => c.LGAName).IsRequired();
            this.HasRequired(c => c.States).WithMany(ca => ca.LGAs).HasForeignKey(c => c.StateId);

        }

    }
}
