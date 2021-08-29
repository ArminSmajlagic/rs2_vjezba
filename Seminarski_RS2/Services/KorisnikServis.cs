using AutoMapper;
using DB.DB_Access;
using Microsoft.AspNetCore.Mvc;
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
        public KorisnikServis(DB_Context _db,IMapper _mapper) :base(_db,_mapper){}

        public override IEnumerable<User> Get(KorsinikSearchObject q=null)
        {
            var entity = __db.korisnici.AsQueryable();//Set<Korisnik>().AsQueryable();
            if (q != null)
            {
                
                if (!string.IsNullOrEmpty(q?.name))
                {
                    entity = entity.Where(x => x.username == q.name);
                }
                else if (q?.id != null)
                {
                    entity = entity.Where(x => x.id == q.id);
                }else if(q?.code!=null){
                    entity = entity.Where(x => x.password == q.code);
                }

               //entity = entity.Where(x => x.username == q.name);
            }

            return __mapper.Map<List<User>>(entity.ToList());
        }
    }
}
