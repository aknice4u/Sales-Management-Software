using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Core.ProductManagement
{
    public class ProductSurveyMaster
    {
        [Key]
        public int ProductSurveyMasterId { get; set; }
        public string SurveyName { get; set; }
        public int ClientId { get; set; }
        public int ProductId { get; set; }
        public int CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string Discription { get; set; }
        public string IsDeleted { get; set; }
        public int ModifiedBy { get; set; }
        public string ModifiedDate { get; set; }
        public int Limit { get; set; }

    }
}
