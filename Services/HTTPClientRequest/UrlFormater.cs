using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.HTTPClientRequest
{
    public static class UrlFormater
    {
        public static string default_url { get { return "http://localhost:52859"; } set { default_url = value; } }
        public static string URL() { return default_url; }
    }
}
