using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_API.Models;
using WEB_API.Services;

namespace WEB_API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class KorisniciKontroller:CRUDController<Korisnik,User,KorsinikSearchObject>
    {
        public KorisniciKontroller(IKorisnikServis servis):base(servis)
        {

        }
    }
}
