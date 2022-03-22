using MSAS.Core.ClientManagement;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Data.Mapping
{
    public partial class ClientsMap : EntityTypeConfiguration<Client>
    {
        public ClientsMap()
        {
            this.ToTable("Clients");

            this.Property(c => c.Email).IsRequired();
            this.Property(c => c.Password).IsRequired();
            this.Property(c => c.IsActive).IsRequired();
            this.Property(c => c.CreatedDate).IsRequired();
            this.Property(c => c.CreatedBy).IsRequired();
            this.Property(c => c.ModifiedBy).IsRequired();
            this.Property(c => c.ModifiedDate).IsRequired();
            this.Property(c => c.BizPOCMobile).IsRequired();
            this.Property(c => c.BizPOCFirstName).IsRequired();
            this.Property(c => c.BizPOCLastName).IsRequired();
            this.Property(c => c.BizPOCPhone).IsRequired();
            this.Property(c => c.Address).IsRequired();

            this.Property(c => c.City).IsRequired();
            this.Property(c => c.LGA).IsRequired();
            this.Property(c => c.State).IsRequired();
            this.Property(c => c.Name).IsRequired();

            this.Property(c => c.Remarks).IsRequired();
        }
            
        }
}
