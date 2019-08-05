using LNRS.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LNRS.Data
{
    public class Seed
    {
        public static async Task CreateUserRoles(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            //Adding User Role
            var userCheck = await roleManager.RoleExistsAsync("User");
            if (!userCheck)
            {
                //create the roles and seed them to the database
                await roleManager.CreateAsync(new IdentityRole("User"));
            }
            //Adding Admin Role
            var adminCheck = await roleManager.RoleExistsAsync("Admin");
            if (!adminCheck)
            {
                //create the roles and seed them to the database
                await roleManager.CreateAsync(new IdentityRole("Admin"));
            }
        }

        public static async Task CreateAdminUser(IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            //Adding Admin user
            var adminUser = await userManager.FindByEmailAsync("adminpw@lexicon.com");
            if (adminUser == null)
            {
                var AdminPW = new ApplicationUser()
                {
                    FirstName = "Admin",
                    LastName = "PW",
                    UserName = "adminpw@lexicon.com",
                    Email = "adminpw@lexicon.com"
                };
                //create the user and seed to the database
                await userManager.CreateAsync(AdminPW, "Abc123!");
                await userManager.AddToRoleAsync(AdminPW, "Admin");
            }
        }

        internal static object CreateUserRoles(object serviceProvider)
        {
            throw new NotImplementedException();
        }
    }
}
