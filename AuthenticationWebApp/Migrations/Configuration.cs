namespace AuthenticationWebApp.Migrations
{
    using AuthenticationWebApp.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AuthenticationWebApp.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AuthenticationWebApp.Models.ApplicationDbContext context)
        {
            if (!context.Roles.Any(x => x.Name == "Admin"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager  = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole() { Name = "Admin" };
                manager.Create(role);
            }

            if (!context.Roles.Any(x => x.Name == "User"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole() { Name = "User" };
                manager.Create(role);
            }

            var passwordHash = new PasswordHasher();
            if (!context.Users.Any( x=> x.UserName == "passno9000@hotmail.com"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser()
                {
                    UserName = "passno9000@hotmail.com",
                    Email = "passno9000@hotmail.com",
                    PasswordHash = passwordHash.HashPassword("192!Osfp192")
                };

                manager.Create(user);
                manager.AddToRole(user.Id, "Admin");
            }
            if (!context.Users.Any(x => x.UserName == "192osfp192@gmail.com"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser()
                {
                    UserName = "192osfp192@gmail.com",
                    Email = "192osfp192@gmail.com",
                    PasswordHash = passwordHash.HashPassword("192!Osfp192")
                };

                manager.Create(user);
                manager.AddToRole(user.Id, "User");
            }
        }
    }
}
