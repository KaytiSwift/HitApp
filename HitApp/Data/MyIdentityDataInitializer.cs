using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HitApp.Data
{
    public class MyIdentityDataInitializer
    {
        public static void SeedUsers(UserManager<IdentityUser> userManager)
        {
            if (userManager.FindByNameAsync("Kyle").Result == null)
            {
                IdentityUser user = new IdentityUser();
                user.UserName = "kyle@gmail.com";
                user.Email = "kyle@gmail.com";

                IdentityResult result = userManager.CreateAsync
                (user, "Wwkd123!").Result;
            }

            if (userManager.FindByNameAsync("Jen").Result == null)
            {
                IdentityUser user = new IdentityUser();
                user.UserName = "jen@gmail.com";
                user.Email = "jen@gmail.com";

                IdentityResult result = userManager.CreateAsync
                (user, "Jenny123!").Result;
            }
        }
    }
}
