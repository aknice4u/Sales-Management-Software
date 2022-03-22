using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Core.EntityCodes
{
    public class EntityCodeLookUp
    {
        [Key]
        public int EntityCodeTypeId { get; set; }
        public string EntityName { get; set; }
    }
}
