using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_API.Services
{
    public interface ICrudService<T,TMap,TSearch>:IReadService<T, TMap, TSearch>,IWriteService<T, TMap, TSearch> where TSearch : class  
    {
        //public Task<T> Login(string username, string psw);

    }
}
