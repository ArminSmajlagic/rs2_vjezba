using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.HTTPClient
{
    public class _CRUD_Requests_Service<T>
    {
        public _CRUD_Requests_Service()
        {

        }

        public List<T> Get()
        {
            return new List<T>() { };
        }

        public List<T> GetByID()
        {
            return new List<T>() { };
        }
    }
}
