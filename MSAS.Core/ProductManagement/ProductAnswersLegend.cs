using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Core.ProductManagement
{
    public class ProductAnswersLegend
    {
        [Key]
        public int ProductAnswersLegendsId { get; set; }
        public int ProductSurveyMasterId { get; set; }
        public int CustomerId { get; set; }
        public string Visibility { get; set; }
        public string Merchandising { get; set; }
        public string Pricing { get; set; }
        public string Availablity { get; set; }
        public int UserId { get; set; }
        public string SurveyDate { get; set; }








        
    }
}
