using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Core.Sales
{
    public class SalesCreditSettlementTrans
    {
        [Key]
        public int SCSTransId { get; set; }
        public int SOHTransId { get; set; }
        public string DueDate { get; set; }
        public string CreditSettlementAmount { get; set; }
        public string CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public string ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
        public string IsDeleted { get; set; }
    }
}
