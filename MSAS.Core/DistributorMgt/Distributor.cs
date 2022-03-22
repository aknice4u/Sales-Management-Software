using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Core.DistributorMgt
{
    public class Distributor
    {
        [Key]
        public int DistributorId { get; set; }
        public int ClientId { get; set; }
        public string Address { get; set; }
        public int AgencyId { get; set; }
        public string BizPOCFirstName { get; set; }
        public string BizPOCLastName { get; set; }
        public string BizPOCMobile { get; set; }
        public string BizPOCPhone { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string LGA { get; set; }
        public int CreatedBY { get; set; }
        public string CreatedDate { get; set; }
        public string Email { get; set; }
        public string IsActive { get; set; }
        public string IsDeleted { get; set; }
        public string ModifiedBy { get; set; }
        public string ModifiedDate { get; set; }
        public string DistributorClassification { get; set; }
        public string DistributorName { get; set; }
        public string Remarks { get; set; }
    }
}
