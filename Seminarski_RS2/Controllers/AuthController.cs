using Microsoft.AspNetCore.Mvc;
using Models.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_API.Security;

namespace WEB_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : Controller
    {
        private readonly AuthService _service;
        public AuthController(AuthService service)
        {
            _service = service;
        }

        public async Task<Korisnik> Login(string username,string password)
        {
            var entity = await _service.GetUser(username);

            if (entity == null)
            {
                throw new Exception("User nije pronađen!");
            }
            if (entity.password != password)
            {

                throw new Exception("Password nije tacan!");
            }

            return entity;
        }
    }
}
