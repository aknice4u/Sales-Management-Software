using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Core.PickUps
{
    public class PickupOrderTransaction
    {
        [Key]
        public int PtransId { get; set; }
        public int WareHouseId { get; set; }
        public int ProjectId { get; set; }
        public int ProductId { get; set; }
        public int PickUpTransGroupId { get; set; }
        public int Quantity { get; set; }
        public int SampleQty { get; set; }
        public string Address { get; set; }
        public string AppliedPickupPrice { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public string ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
        public string IsDeleted { get; set; }
    }
}
