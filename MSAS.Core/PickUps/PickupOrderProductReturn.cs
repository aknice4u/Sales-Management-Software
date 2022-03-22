using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Core.PickUps
{
    public class PickupOrderProductReturn
    {
        [Key]
        public int PRTransId { get; set; }
        public int PTransId { get; set; }
        public int ProductRutrnGroupId { get; set; }
        public string SeqNum { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
        public string Address { get; set; }
        public string IsDeleted { get; set; }
    }
}
