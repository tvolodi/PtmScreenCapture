using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PtmScreenCapture.Models
{
    internal class BaseMongoDoc : IMongoDoc
    {
        public string Id { get; set; }
    }
}
