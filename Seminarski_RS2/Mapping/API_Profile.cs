using AutoMapper;
using Models.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_API.Models;

namespace WEB_API.Mapping
{
    public class API_Profile :Profile
    {

        public API_Profile()
        {
            CreateMap<Korisnik, User>();
        }

    }
}
