using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Data
{
    public class RazorPagesActorContext : DbContext
    {
        public RazorPagesActorContext (DbContextOptions<RazorPagesActorContext> options)
            : base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        public DbSet<RazorPagesMovie.Models.Movie> Movie { get; set; } = default!;
        public DbSet<RazorPagesMovie.Models.Actor> Actor { get; set; } = default!;
    }
}
