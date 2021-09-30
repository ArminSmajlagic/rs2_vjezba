using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seminarski_RS2.AuthServer.Models
{
    public class AuthRequest
    {
        public string username { get; set; }
        public string password { get; set; }
    }
}
