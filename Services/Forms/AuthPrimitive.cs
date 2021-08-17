using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Forms
{
    public class AuthPrimitive
    {
        private string status { get; set; }

        public AuthPrimitive()
        {
           
        }

        public string ValidateCreds(string value)
        {
            if (value == "adam")
                status = "AuithPrim is good";
            else
                //status = "bitch AuthPrimitive aint good";
                throw new ExceptionHandelingFilter("bitch AuthPrimitive aint good");

            return status;
        }
    }
}
