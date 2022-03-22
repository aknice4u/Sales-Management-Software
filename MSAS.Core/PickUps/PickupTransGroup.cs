using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Core.PickUps
{
    public class PickupTransGroup
    {
        [Key]
        public int PickupTransGroupId { get; set; }
    }
}
