﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Try3.Models
{
    public class User : IdentityUser
    {
     
        public string Name { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }


       
    }
}
