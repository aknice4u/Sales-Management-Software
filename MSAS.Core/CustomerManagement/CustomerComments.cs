using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Core.CustomerManagement
{
    public class CustomerComments
    {
        [Key]
        public int CustomerCommentsId { get; set; }
        public string Address { get; set; }
        public string CustomerId { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string SurveyDate { get; set; }
        public string SurveyMasterId { get; set; }
        public string SurveyType { get; set; }
        public string UserId { get; set; }
    }
}
