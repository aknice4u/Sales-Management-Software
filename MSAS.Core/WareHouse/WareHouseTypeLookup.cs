using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Core.WareHouse
{
    public class WareHouseTypeLookup
    {
        [Key]
        public int WareHouseTypeId { get; set; }
        public string WareHouseType { get; set; }
        
    }
}
