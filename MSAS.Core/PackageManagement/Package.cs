using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Core.PackageManagement
{
    public class Package
    {
        public int PackageId { get; set; }
        public string PackageName { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
        public string IsDeleted { get; set; }
    }
}
