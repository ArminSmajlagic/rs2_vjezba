using DB.DB_Access;
using Models.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_API.Security
{
    public class AuthService
    {
        private readonly DB_Context _db;
        public AuthService(DB_Context db)
        {
            _db = db;
        }

        public async Task<Korisnik> GetUser(string username)
        {
            return _db.korisnici.FirstOrDefault(x => x.username == username);
        }
    }
}
