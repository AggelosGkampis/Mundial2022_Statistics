using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entities;
using System.Data.Entity.Migrations;

namespace DAL.Initializers
{
    internal class MockUpDbInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            // Seeding Teams

            Team t1 = new Team() { Name = "Brazil", Rating = 9.5, SquadSize = 22, PhotoUrl = "" };
            Team t2 = new Team() { Name = "Brazil", Rating = 9.5, SquadSize = 22, PhotoUrl = "" };
            Team t3 = new Team() { Name = "Brazil", Rating = 9.5, SquadSize = 22, PhotoUrl = "" };
            Team t4 = new Team() { Name = "Brazil", Rating = 9.5, SquadSize = 22, PhotoUrl = "" };
            Team t5 = new Team() { Name = "Brazil", Rating = 9.5, SquadSize = 22, PhotoUrl = "" };
            Team t6 = new Team() { Name = "Brazil", Rating = 9.5, SquadSize = 22, PhotoUrl = "" };
            Team t7 = new Team() { Name = "Brazil", Rating = 9.5, SquadSize = 22, PhotoUrl = "" };
            Team t8 = new Team() { Name = "Brazil", Rating = 9.5, SquadSize = 22, PhotoUrl = "" };
            Team t9 = new Team() { Name = "Brazil", Rating = 9.5, SquadSize = 22, PhotoUrl = "" };

            context.Teams.AddOrUpdate(t1, t2, t3, t4, t5, t6, t7, t8, t9);
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
