using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Core.CustomerManagement
{
    public class CustomerSurveyMaster
    {
        [Key]
        public int CustSurveyMasterId { get; set; }
        public int ClientId { get; set; }
        public int CreatedBy { get; set; }
        public int CreatedDate { get; set; }
        public string IsDeletd { get; set; }
        public string Limit { get; set; }
        public string ModifiedBy { get; set; }
        public string ModifiedDate { get; set; }
        public string SurveyName { get; set; }
    }
}
