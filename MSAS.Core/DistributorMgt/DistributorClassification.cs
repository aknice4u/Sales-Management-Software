using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Core.DistributorMgt
{
    public class DistributorClassification
    {
        [Key]
        public int DistributorClassificationId { get; set; }
        public string ClassificationType { get; set; }
    }
}
