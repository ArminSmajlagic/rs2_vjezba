using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_API.Services
{
    public interface IReadService<T,TMap,TSearch> where TSearch:class
    {
        public IEnumerable<TMap> Get(TSearch t = null);
        public T GetByID(int i);
    }
}
