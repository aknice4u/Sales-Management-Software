using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Core.Royalty
{
    public class LoyaltyGift
    {
        [Key]
        public int GiftId { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string Discription { get; set; }
        public string IsDeleted { get; set; }
        public string ModifiedBy { get; set; }
        public string ModifiedDate { get; set; }
        public string Name { get; set; }
        public int ProjectId { get; set; }
    }

}
