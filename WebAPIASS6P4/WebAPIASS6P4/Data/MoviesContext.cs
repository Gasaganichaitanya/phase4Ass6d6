using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPIASS6P4.Models;

namespace WebAPIASS6P4.Data
{
    public class MoviesContext : DbContext
    {
        public MoviesContext (DbContextOptions<MoviesContext> options)
            : base(options)
        {
        }

        public DbSet<WebAPIASS6P4.Models.Movies> Movies { get; set; } = default!;
    }
}
