using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MSAS.Models.StateLGA
{
    public class StateViewModel
    {
        [Key]
        public int StateId { get; set; }
        public string StateName { get; set; }
    }
}