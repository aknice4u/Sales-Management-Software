using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Core.ClientManagement
{
    public class ClientProducts
    {
        [Key]
        public int ProductId { get; set; }
        public string BarCode { get; set; }
        public int Category { get; set; }
        public int ClientId { get; set; }
        public int CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string IsDeleted { get; set; }
        public string IsSample { get; set; }
        public int ModifiedBy { get; set; }
        public string ModifiedDate { get; set; }
        public int NoOfSamples { get; set; }
        public string PickUpPrice { get; set; }
        public string ProductName { get; set; }
        public string RewardPoint { get; set; }
        public string SalePrice { get; set; }
        public string Spec { get; set; }
        public string Unit { get; set; }
        public string UseFixedPriceOnly { get; set; }
    }
}
