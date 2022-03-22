using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Core.UserTracking
{
    public class Login
    {
        [Key]
        public int LoginId { get; set; }
        public string IsLogin { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string LoginTime { get; set; }
        public string LogoutTime { get; set; }
        public string UserId { get; set; }
    }
}
