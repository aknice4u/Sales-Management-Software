using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Core.UserTracking
{
    public class FieldUserTracking
    {
        [Key]
        public int FieldUserId { get; set; }
        public string Address { get; set; }
        public string IsLogin { get; set; }
        public string IsLogout { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string trackTime { get; set; }
        public string UserProfile { get; set; }
    }
}
