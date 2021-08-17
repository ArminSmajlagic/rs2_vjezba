using DB.DB_Access;
using Models.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_API.Models;

namespace WEB_API.Services
{
    public class KorisnikServis:CRUDService<Korisnik, User, KorsinikSearchObject>,IKorisnikServis
    {
        public KorisnikServis(DB_Context _db) :base(_db){}

        public override IEnumerable<Korisnik> Get(KorsinikSearchObject q)
        {
            return __db.Set<Korisnik>().Where(x=>x.username==q.name && q.code==x.password).ToList();
        }
    }
}
