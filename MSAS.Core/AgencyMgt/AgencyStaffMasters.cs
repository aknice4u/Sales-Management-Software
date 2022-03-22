using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Core.AgencyMgt
{
    public class AgencyStaffMasters
    {
        [Key]
        public int AgencyMasterId { get; set; }
        public int AgencyStaffId { get; set; }
        public string Clientient { get; set; }
        public string UserId { get; set; }
    }
}
