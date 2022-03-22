using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Core.Sales
{
    public class SampleLimit
    {
        [Key]
        public int SampleId { get; set; }
        public int UserId { get; set; }
        public int SampleLimit1 { get; set; }
    }
}
