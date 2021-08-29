using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_API.Services;

namespace WEB_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CRUDController<T, TMap,TSearch> : Controller where TSearch : class
    {
        private readonly ICrudService<T,TMap,TSearch> _service;
        public CRUDController(ICrudService<T, TMap, TSearch> service)
        {
            _service = service;
        }

       [HttpGet]
        public virtual IEnumerable<TMap>  Get([FromQuery] TSearch t)
        {
            return _service.Get(t);
        }

        [HttpGet("{id}")]
        public virtual T Get(int id)
        {
            return _service.GetByID(id);
        }
    }
}
