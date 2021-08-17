using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Models.API;

namespace DB.DB_Access
{
    public class DB_Context:DbContext
    {
        public DB_Context(DbContextOptions opt):base(opt){}

        public DbSet<User> korisnici { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder opt_builder)
        {
            opt_builder.UseSqlServer(@"Server = MAGNETPC;Database = RSII_Seminarski;Trusted_Connection = true;");
        }
    }
}
