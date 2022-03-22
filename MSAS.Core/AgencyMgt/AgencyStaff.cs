using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Core.AgencyMgt
{
    public class AgencyStaff
    {
        [Key]
        public int AgencyStaffId { get; set; }
        public string AgencyFunctionList { get; set; }
        public string FuctionListUrl { get; set; }
    }
}
