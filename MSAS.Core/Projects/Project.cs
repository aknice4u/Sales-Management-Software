using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Core.Project
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        public int ClientId { get; set; }
        public int PTypeId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public string Remark { get; set; }
        public string CloseOutDate { get; set; }
        public string CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public string ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
        public int IsDeleted { get; set; }
    }
}
