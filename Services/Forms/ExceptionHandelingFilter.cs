using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Forms
{
    public class ExceptionHandelingFilter: Exception
    {

        public List<string> _errors { get; set; }
        public List<DateTime> _errorTimes { get; set; }
        public ExceptionHandelingFilter(string singleError=null, List<DateTime> multipleErrorTimes=null, List<string> multipleErrors=null) :base(singleError)
        {

        }

        public string ToStringErrorList()
        {
            string result="";
            int j = 0;
            foreach (string i in _errors)
            {             
                result += " \n" + i;
                result += " --- " + _errorTimes.ToArray()[j++];
            }
            return result;
        }

    }
}
