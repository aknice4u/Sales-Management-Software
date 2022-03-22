using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Core.CustomerManagement
{
    public class CustSurveyOption
    {
        [Key]
        public int CustSurveyOptionId { get; set; }
        public int CustSurveyMasterId { get; set; }
        public string isDeleted { get; set; }
        public string IsFreeHand { get; set; }
        public string IsOptional { get; set; }
        public string Options { get; set; }
        public string Question { get; set; }
    }
}
