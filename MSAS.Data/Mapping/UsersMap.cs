using MSAS.Core.UsersMgt;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Data.Mapping
{
    public partial class UsersMap : EntityTypeConfiguration<Users>
    {
        public UsersMap()
        {
            this.ToTable("Users");
            this.HasKey(c => c.UserId);
            this.Property(c => c.RoleId).IsRequired();
            this.Property(c => c.UserName).IsRequired();
            this.Property(c => c.Password).IsRequired();
            this.Property(c => c.IsActive).IsRequired();
            this.Property(c => c.CreateDate).IsRequired();
            this.Property(c => c.CreatedBy).IsRequired();
            this.Property(c => c.ModifiedBy).IsRequired();
            this.Property(c => c.ModifiedDate).IsRequired();
            this.Property(c => c.UserConId).IsRequired();
            this.Property(c => c.FirstName).IsRequired();
            this.Property(c => c.MiddleName).IsRequired();
            this.Property(c => c.LastName).IsRequired();
            this.Property(c => c.Address).IsRequired();

            this.Property(c => c.City).IsRequired();
            this.Property(c => c.LGA).IsRequired();
            this.Property(c => c.State).IsRequired();
            this.Property(c => c.PhoneNo).IsRequired();
            this.Property(c => c.Mobile).IsRequired();
            this.Property(c => c.Country).IsRequired();

            this.Property(c => c.Remarks).IsRequired();
            this.Property(c => c.Email).IsRequired();
            this.Property(c => c.Tracking).IsRequired();
            this.Property(c => c.IsPermitted).IsRequired();
            this.Property(c => c.IsLogin).IsRequired();
        }
    }
}
