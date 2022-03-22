using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Core.CustomerManagement
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string Address { get; set; }
        public string BizPOCFirstName { get; set; }
        public string BizPOCLastName { get; set; }
        public string BizPOCMobile { get; set; }
        public string BizPOCPhone { get; set; }
        public string BusinessType { get; set; }
        public string City { get; set; }
        public int ClientId { get; set; }
        public int CreatedBy { get; set; }
        public string CusomerClassificationId { get; set; }
        public string CustomerName { get; set; }
        public string Discount { get; set; }
        public string Email { get; set; }
        public string IsActive { get; set; }
        public string IsCreditAccount { get; set; }
        public string IsDeleted { get; set; }
        public int LGA { get; set; }
        public string State { get; set; }
        public int ModifiedBy { get; set; }
        public string ModifiedDate { get; set; }
        public string Pin { get; set; }
        public string CreditLimit { get; set; }
        public string Remarks { get; set; }
        public string RewardBalance { get; set; }
        public string StoreTypeId { get; set; }
        public string Udf1_Id { get; set; }
        public string Udf2_Id { get; set; }
        public string Udf3_Id { get; set; }




    }
}
