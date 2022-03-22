using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Core.PackageManagement
{
    public class PackagesProfile
    {
        public int PackageProfileId { get; set; }
        public int PackageId { get; set; }
        public int TotalClients { get; set; }
        public int TotalUsers { get; set; }
        public string TotalProjects { get; set; }
        public int PakageAge { get; set; }
        public string CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public string ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string IsDeleted { get; set; }
        public int TotalCustomerSurvey { get; set; }
        public int TotalProductSurvey { get; set; }
        public int CustomerSurveyLimit { get; set; }

    }
}
