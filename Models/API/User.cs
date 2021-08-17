using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.API
{
    public class  User
    {
        [Key]
        public int id { get; set; }

        [StringLength(20,MinimumLength =3)]
        public string username { get; set; }
            
        [StringLength(20, MinimumLength = 5)]
        public string password { get; set; }

        [StringLength(25,MinimumLength =4)]
        public string ime_prezime { get; set; }       

        [StringLength(250)]
        public string img { get; set; }
    }
}
