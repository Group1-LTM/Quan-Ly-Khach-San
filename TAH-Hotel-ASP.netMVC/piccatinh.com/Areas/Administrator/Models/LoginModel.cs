﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace piccatinh.com.Areas.Administrator.Models
{
    public class LoginModel
    {
        [Required]
        public string username { set; get; }
        public string password { set; get; }
        public bool rememberme { set; get; }
        
    }
}