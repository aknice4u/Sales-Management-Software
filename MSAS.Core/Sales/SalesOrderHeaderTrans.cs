using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Core.Sales
{
    public class SalesOrderHeaderTrans
    {
        [Key]
        public int SOHTransId { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public int SalesTransGroupId { get; set; }
        public int PTransId { get; set; }
        public string SerialNumber { get; set; }
        public string TotaAmountOwed { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string Address { get; set; }
        public int Discount { get; set; }
        public int SalesQuantity { get; set; }
        public string Remark { get; set; }
        public string DiscountUsed { get; set; }
        public string CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public string ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
        public int IsDeleted { get; set; }
    }
}
