using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Core.ClientManagement
{
    public class ClientUDFS
    {
        [Key]
        public int ClientUDFId { get; set; }
        public string UDF1_desc { get; set; }
        public string UDF1_enabled { get; set; }
        public string UDF1_Id { get; set; }
        public string UDF2_desc { get; set; }
        public string UDF2_enabled { get; set; }
        public string UDF2_Id { get; set; }
        public string UDF3_desc { get; set; }
        public string UDF3_enabled { get; set; }
        public string UDF3_Id { get; set; }
    }
}
