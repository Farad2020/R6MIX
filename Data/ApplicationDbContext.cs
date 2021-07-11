using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace R6MIX.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<R6MIX.Models.Operator> Operator { get; set; }
        public DbSet<R6MIX.Models.Side> Side { get; set; }
        public DbSet<R6MIX.Models.Loadout> Loadout { get; set; }



    }
}
