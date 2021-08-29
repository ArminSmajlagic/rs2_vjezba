using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopClient.Services
{
    public static class URLService
    {
        private readonly static string base_url = "https://localhost:44379/";

        public static string UrlFormater(string verb,string param=null)
        {
            string url = base_url;

            if (verb == "Get")
                url += "Korisnici";
            //else if (verb=="GetByObject" &&)
            if (verb == "GetByID" && !string.IsNullOrEmpty(param))
                url += "Korisnici/"+ param;
            return url;
        }
    }
}
