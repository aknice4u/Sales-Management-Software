using MSAS.Core.StatesLGA;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MSAS.Models.StateLGA
{
    public class LGAViewModel
    {
        [Key]
        public int LGAId { get; set; }
        public int StateId { get; set; }
        public virtual State States { get; set; }
        public string LGAName { get; set; }
    }
}