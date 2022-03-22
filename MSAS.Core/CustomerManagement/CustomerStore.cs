using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Core.CustomerManagement
{
    public class CustomerStore
    {
        [Key]
        public int StoreTypeId { get; set; }
        public string StoreType { get; set; }
    }
}
