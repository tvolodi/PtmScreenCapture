﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PtmScreenCapture.Models
{
    internal class User : BaseMongoDoc
    {
        public string Login    { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }

        public UserRole Role { get; set; } = new UserRole();
    }
}
