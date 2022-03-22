using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Core.Royalty
{
    public class LoyaltyRewardRules
    {
        [Key]
        public int RewardId { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string EndDate { get; set; }
        public string ProjectId { get; set; }
        public string IsDeleted { get; set; }
        public int ModifiedBy { get; set; }
        public string ModifiedDate { get; set; }
        public string StartDate { get; set; }
        public string units { get; set; }
    }
}
