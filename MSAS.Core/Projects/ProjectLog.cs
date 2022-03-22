using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Core.Projects
{
    public class ProjectLog
    {
        [Key]
        public int ProjectLogId { get; set; }
        public int ProjectId { get; set; }
        public string RemarkDate{ get; set; }
        public string CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public string ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
        public int IsDeleted { get; set; }
    }
}
