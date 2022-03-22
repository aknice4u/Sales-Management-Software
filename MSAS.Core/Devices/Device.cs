using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Core.Devices
{
    public class Device
    {
        [Key]
        public int DeviceId { get; set; }
        public string UserId { get; set; }
    }
}
