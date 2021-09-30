using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using WEB_API.Services;

namespace WEB_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CRUDController<T, TMap,TSearch> : Controller where TSearch : class
    {
        protected readonly ICrudService<T,TMap,TSearch> _service;

        public CRUDController(ICrudService<T, TMap, TSearch> service)
        {
            _service = service;
        }

       // [Authorize]
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

       // [Authorize]
        [HttpPost("{id}")]
        public virtual TMap Update(int id,T obj)
        {
            return _service.Update(id,obj);
        }

      //  [Authorize]
        [HttpPut]
        public virtual TMap Insert(T obj)
        {
            return _service.Insert(obj);
        }







        //[Route("/Login")]
        //public IActionResult Login()
        //{
        //    var claims = new List<Claim>()
        //    {
        //        new Claim(JwtRegisteredClaimNames.Sub,"id"),
        //        new Claim("theis","that")
        //    };


        //    var algoritham = SecurityAlgorithms.HmacSha256;

        //    byte[] bytes = Encoding.UTF8.GetBytes("the_secret_key_!$%&/()=");

        //    var key = new SymmetricSecurityKey(bytes);

        //    var creds = new SigningCredentials(key,algoritham);

        //    var token = new JwtSecurityToken("https://localhost:44379/Login", "https://localhost:44379/Login", claims,notBefore:DateTime.Now,expires:DateTime.Now, creds);

        //    var JSON_token = new JwtSecurityTokenHandler().WriteToken(token);

        //    return Ok(new { access_token = JSON_token});
        //}
    }
}
