using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Core.WareHouse
{
    public class WareHouse
    {
        public int WareHouseId { get; set; }
        public int WareHouseConId { get; set; }
        public int WareHouseTypeId { get; set; }
        public string WareHouseName { get; set; }
        public string PIN { get; set; }
        public string BizPOCFirstName { get; set; }
        public string BizPOCLastName { get; set; }
        public string PizPOCPhone { get; set; }
        public string BizPOCMobile { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Remarks { get; set; }
        public string City { get; set; }
        public string state { get; set; }
        public int LGA { get; set; }
        public string CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string IsDeleted { get; set; }
        public string IsActive { get; set; }
    }
}
