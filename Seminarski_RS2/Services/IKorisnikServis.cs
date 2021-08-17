using Models.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_API.Models;

namespace WEB_API.Services
{
    public interface IKorisnikServis:ICrudService<Korisnik, User, KorsinikSearchObject>
    {
    }
}
