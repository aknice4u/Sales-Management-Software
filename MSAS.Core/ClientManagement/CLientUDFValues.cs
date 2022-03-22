using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Core.ClientManagement
{
    public class CLientUDFValues
    {
        [Key]
        public int UDFId { get; set; }
        public int AgencyId { get; set; }
        public string Value { get; set; }
    }
}
