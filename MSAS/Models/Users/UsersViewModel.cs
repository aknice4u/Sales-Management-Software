using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MSAS.Models.Users
{
    public class UsersViewModel
    {
        [Key]
        public int UserId { get; set; }
        public string RoleId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string IsActive { get; set; }
        public string CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string IsDeleted { get; set; }

        public int UserConId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int LGA { get; set; }
        public string State { get; set; }
        public string PhoneNo { get; set; }
        public string Mobile { get; set; }
        public string Country { get; set; }
        public string Remarks { get; set; }
        public string Email { get; set; }
        public string Tracking { get; set; }

        public string IsPermitted { get; set; }
        public string IsLogin { get; set; }
    }
}