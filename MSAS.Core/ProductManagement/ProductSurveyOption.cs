using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Core.ProductManagement
{
    public class ProductSurveyOption
    {
        [Key]
        public int ProdSurveyOptionId { get; set; }
        public int ProductSurveyMasterId { get; set; }
        public string Question { get; set; }
        public string IsOptional { get; set; }
        public string Options { get; set; }
        public string IsDeleted { get; set; }
    }

}
