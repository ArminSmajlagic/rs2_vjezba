using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_API.Services
{
    public interface IWriteService<T, TMap, TSearch> where TSearch : class
    {
        public TMap Insert(T obj);
        public TMap Update(int id, T obj);
    }
}
