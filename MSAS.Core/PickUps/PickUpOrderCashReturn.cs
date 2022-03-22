using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Core.PickUps
{
    public class PickUpOrderCashReturn
    {
        [Key]
        public int PCTransId { get; set; }
        public int PTransId { get; set; }
        public int SeqNum { get; set; }
        public string Amount { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
        public string IsDeleted { get; set; }
    }
}
