using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Core.AgencyMgt
{
    public class Agency
    {
        [Key]
        public int AgencyId {get; set; }
        public string Adresss { get; set; }
        public string AgencyName { get; set; }
        public string BizPOCFirstName { get; set; }
        public string BizPOCLastName { get; set; }
        public string BizPOCMobile { get; set; }
        public string BizPOCFirstPhone { get; set; }
        public int City { get; set; }
        public string State { get; set; }
        public int LGA { get; set; }
        public int ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
        public int PackageId { get; set; }
        public int Remarks { get; set; }
        public int SubscriptionDate { get; set; }
        public int TechPOCFirstName { get; set; }
        public int TechPOCLastName { get; set; }
        public int TechPOCPhone { get; set; }
        public int IsDeleted { get; set; }
        public int IsActive { get; set; }
        public int ExpiryDate { get; set; }
    }
}
