using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MOVIES2.Models;

namespace MOVIES2.Data
{
    public class MOVIES2Context : DbContext
    {
        public MOVIES2Context (DbContextOptions<MOVIES2Context> options)
            : base(options)
        {
        }

        public DbSet<MOVIES2.Models.Movie> Movie { get; set; } = default!;
    }
}
