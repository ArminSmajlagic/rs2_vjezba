using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DB.DB_Access;
using Models.API;
using WEB_API.Models;

namespace WEB_API.Services
{
    public class CRUDService<T,TMap,TSearch> : ICrudService<T, TMap, TSearch> where TSearch:class where T:class
    {

        public readonly DB_Context __db;

        public CRUDService(DB_Context db)
        {
            __db = db;
        }

        public virtual IEnumerable<T> Get(TSearch t = null)
        {
            return __db.Set<T>().ToList();
        }

        public T GetByID(int i)
        {
            return __db.Set<T>().Find(i);
        }
    }
}
