using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Core.Projects
{
    public class ProjectFunctionLookup
    {
        [Key]
        public int ProjectFunctionLookupId { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
    }
}
