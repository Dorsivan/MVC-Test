using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Statler_and_Waldorf_Demo.Models
{
    public class Statler_and_Waldorf_DemoContext : DbContext
    {
        public Statler_and_Waldorf_DemoContext (DbContextOptions<Statler_and_Waldorf_DemoContext> options)
            : base(options)
        {
        }

        public DbSet<Statler_and_Waldorf_Demo.Models.Movie> Movie { get; set; }
    }
}
