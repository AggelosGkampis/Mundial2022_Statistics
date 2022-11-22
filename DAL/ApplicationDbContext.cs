using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DAL.Initializers;
using Entities;

namespace DAL
{
    public class ApplicationDbContext : DbContext   
    {

        public ApplicationDbContext() :base("Sindesmos")
        {
            Database.SetInitializer<ApplicationDbContext>(new MockUpDbInitializer());
            Database.Initialize(false);
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configure Team & Coach entity
            modelBuilder.Entity<Team>()
                        .HasOptional(s => s.Coach) // Mark Coach property optional in Team entity
                        .WithRequired(ad => ad.Team); // mark Team property as required in Coach entity. Cannot save Coach without Team
        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Coach> Coaches { get; set; }
    }
}
