using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPageMove.Models;

namespace RazorPageMove.Data
{
    public class RazorPagesMoveContext : DbContext
    {
        public RazorPagesMoveContext (DbContextOptions<RazorPagesMoveContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPageMove.Models.Movie> Movie { get; set; }
    }
}
