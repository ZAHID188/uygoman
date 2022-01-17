using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uygoman.Models;

namespace uygoman.DATA
{
    public class AppDBContext: DbContext
    {

        public AppDBContext(DbContextOptions<AppDBContext>options) :base(options)
        {

        }
        public DbSet<Admin> Admins { get; set; }


    }
}
