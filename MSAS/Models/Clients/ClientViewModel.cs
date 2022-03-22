using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MSAS.Models.Clients
{
    public class ClientViewModel
    {
        [Key]
        public int ClientId { get; set; }
        public string Address { get; set; }
        public string BizPOCFirstName { get; set; }
        public string BizPOCLastName { get; set; }
        public string BizPOCMobile { get; set; }
        public string BizPOCPhone { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int LGA { get; set; }
        public int CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string IsActive { get; set; }
        public string IsDeleted { get; set; }
        public int ModifiedBy { get; set; }
        public string ModifiedDate { get; set; }
        public string Name { get; set; }
        public string Remarks { get; set; }

    }
}