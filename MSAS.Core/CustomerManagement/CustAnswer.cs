using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Core.CustomerManagement
{
    public class CustAnswer
    {
        [Key]
        public int CustAnswerId { get; set; }
        public string Address { get; set; }
        public int CustomerId { get; set; }
        public string CustomerSurveyOptionsId { get; set; }
        public string FreeHandAns { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string OptionalAnswers { get; set; }
        public string SurveyDate { get; set; }
        public int UserId { get; set; }
    }
}
