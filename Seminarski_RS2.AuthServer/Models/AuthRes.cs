using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seminarski_RS2.AuthServer.Models
{
    public class AuthRes
    {
        public bool Result { get; set; } = false;
        public string Token { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public bool IsLockedOut { get; set; } = false;
        public bool IsNotAllowed { get; set; } = false;
        public bool RequiresTwoFactor { get; set; } = false;
    }
}
