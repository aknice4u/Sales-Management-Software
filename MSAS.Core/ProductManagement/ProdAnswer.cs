using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Core.ProductManagement
{
    public class ProdAnswer
    {
        public int ProductAnswerId { get; set; }
        public string CustomerId { get; set; }
        public int ProdSurveyOptionsId { get; set; }
        public int UserId { get; set; }
        public string OptionAns { get; set; }
        public string FreeHandAnswer { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string Adress { get; set; }
        public DateTime SurveyDate { get; set; }
    }
}
