using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcCreditApp3.Models
{
    public class CreditsDbInitializer : DropCreateDatabaseIfModelChanges<CreditContext>
    {
        protected override void Seed(CreditContext context)
        {
            var userManager = new ApplicationUserManager(new
            UserStore<ApplicationUser>(context));
            var roleManager = new RoleManager<IdentityRole>(new
            RoleStore<IdentityRole>(context));
            var role1 = new IdentityRole { Name = "admin" };
            var role2 = new IdentityRole { Name = "user" };
            roleManager.Create(role1);
            roleManager.Create(role2);

            var admin = new ApplicationUser
            {
                Email =
            "admin@mail.ru",
                UserName = "admin@mail.ru"
            };
            string password = "qwerty_311";
            var result = userManager.Create(admin, password);

            if (result.Succeeded)
            {
                userManager.AddToRole(admin.Id, role1.Name);
                userManager.AddToRole(admin.Id, role2.Name);
            }

            context.Credits.Add(new Credit
            { Head = "Ипотечный кредит", Period = 10, Sum = 1000000, Procent = 15 });
            context.Credits.Add(new Credit
            { Head = "Образовательный кредит", Period = 7, Sum = 300000, Procent = 10 });
            context.Credits.Add(new Credit
            { Head = "Потребительский кредит", Period = 5, Sum = 500000, Procent = 19 });
            base.Seed(context);
        }
    }
}