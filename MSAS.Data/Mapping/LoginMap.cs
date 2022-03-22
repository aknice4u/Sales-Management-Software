using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using System.Data.Entity.ModelConfiguration;
using MSAS.Core.UsersMgt;

namespace MSAS.Domain.Mapping
{
   public partial class LoginMap:EntityTypeConfiguration<Users>
    {
       public LoginMap()
       {
           this.ToTable("Users");
           this.HasKey(c => c.UserId);
           this.Property(c => c.Email).IsRequired();
           this.Property(c => c.Password).IsRequired();
           
       }    
        
    }
}
