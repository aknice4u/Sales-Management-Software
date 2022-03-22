using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Core.EntityCodes
{
    public class EntityCode
    {
        [Key]
        public int EntityCodeId { get; set; }
        public int ConId { get; set; }
        public int EntityCodeTypeId { get; set; }
    }
}
