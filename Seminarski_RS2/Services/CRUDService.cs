using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DB.DB_Access;
using Models.API;
using WEB_API.Models;

namespace WEB_API.Services
{
    public class CRUDService<T,TMap,TSearch> : ICrudService<T, TMap, TSearch> where TSearch:class where T:class
    {

        protected readonly DB_Context __db;
        public readonly IMapper __mapper;

        public CRUDService(DB_Context db, IMapper mapper)
        {
            __db = db;
            __mapper = mapper;

        }

        public virtual IEnumerable<TMap> Get(TSearch t = null)
        {

            return __mapper.Map<IEnumerable<TMap>>(__db.Set<T>().ToList());
        }

        public T GetByID(int i)
        {
            return __db.Set<T>().Find(i);
        }

        public TMap Insert(T obj)
        {
            throw new NotImplementedException();
        }

        public TMap Update(int id, T obj)
        {
            throw new NotImplementedException();
        }

        //public virtual async Task<T> Login(string username, string psw)
        //{
        //    var entity = __db.Set<T>().FirstOrDefault();

        //    return entity;
        //}

    }
}
