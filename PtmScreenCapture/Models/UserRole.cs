﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PtmScreenCapture.Models
{
    internal class UserRole : IMongoDoc
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
