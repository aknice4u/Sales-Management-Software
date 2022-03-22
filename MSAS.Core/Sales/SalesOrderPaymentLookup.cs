using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Core.Sales
{
    public class SalesOrderPaymentLookup
    {
        [Key]
        public int SOPTTransId { get; set; }
        public string Payment { get; set; }
    }
}
