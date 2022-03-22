using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Core.ProductManagement
{
    public class ProductReturnGroup
    {
        [Key]
        public string ProductReturnGroupsId { get; set; }
    }
}
