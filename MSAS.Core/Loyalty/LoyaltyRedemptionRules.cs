using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Core.Royalty
{
    public class LoyaltyRedemptionRules
    {
        [Key]
        public int RedemptionId { get; set; }
        public string ConvertionPoint { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string EndDate { get; set; }
        public string GiftId { get; set; }
        public string IsDeleted { get; set; }
        public int ModifiedBy { get; set; }
        public string ModifiedDate { get; set; }
        public string StartDate { get; set; }
        public string ValueAmt { get; set; }
    }
}
