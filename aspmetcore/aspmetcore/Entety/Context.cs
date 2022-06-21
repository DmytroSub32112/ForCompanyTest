using aspmetcore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspmetcore.Entety
{
    public class Context : DbContext
    {
        public DbSet<Comment> Comments {get;set;}
        public DbSet<Photo> Photos {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=forworktdb;Trusted_Connection=True;");
        }
    }
}
