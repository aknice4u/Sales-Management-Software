using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Core.CustomerManagement
{
    public class CustomerSurveyAssign
    {
        [Key]
        public int CustomerSurveyAssignId { get; set; }
        public int CustomerId { get; set; }
        public string CustomerSurveyMasterId { get; set; }
    }
}
