using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Core.Projects
{
    public class ProjectFunction
    {
        [Key]
        public int ProjectFunctionId { get; set; }
        public int ProjectFunctionLookupId { get; set; }
        public int ProjectId { get; set; }
    }
}
