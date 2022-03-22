using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Core.Sales
{
    public class SalesOrderPaymentDetailedTrans
    {
        [Key]
        public int SOPDTransId { get; set; }
        public int RedemptionId { get; set; }
        public int SOHTransId { get; set; }
        public int SOPTTransId { get; set; }
        public string AmountPaid { get; set; }
        public string Customersignature { get; set; }
        public string RedeemedPoint { get; set; }
        public string CreateDate { get; set; }
        public int CreateBy { get; set; }
        public string ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
        public string IsDeleted { get; set; }
    }
}
