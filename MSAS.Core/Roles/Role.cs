﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Core.Roles
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        public string RoleType { get; set; }
    }
}
