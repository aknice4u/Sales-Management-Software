using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Core.CustomerManagement
{
    public class CustomerClassification
    {
        [Key]
        public int CustClassificationId { get; set; }
        public string ClassificationType { get; set; }

    }
}
