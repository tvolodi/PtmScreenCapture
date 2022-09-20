using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PtmScreenCapture.Models
{
    internal interface IMongoDoc
    {
        public string? Id { get; set; }
    }
}
