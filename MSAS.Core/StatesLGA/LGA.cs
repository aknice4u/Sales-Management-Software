using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Core.StatesLGA
{
    public class LGA
    {
        [Key]
        public int LGAId { get; set; }
        public int StateId { get; set; }
        public virtual State States { get; set; }
        public string LGAName { get; set; }
    }
}
