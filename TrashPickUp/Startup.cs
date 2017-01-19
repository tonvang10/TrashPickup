using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using TrashPickUp.Models;

[assembly: OwinStartupAttribute(typeof(TrashPickUp.Startup))]
namespace TrashPickUp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            createRolesandUsers();
        }


        // In this method we will create default User roles and Admin user for login   
        private void createRolesandUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

  
            if (!roleManager.RoleExists("Admin"))
            {

                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);

                        

                var user = new ApplicationUser();
                user.UserName = "Trash";
                user.Email = "jason@jasonrhart.com";

                string userPWD = "password";

                var chkUser = UserManager.Create(user, userPWD);

  
                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "Admin");

                }
            }

   
            if (!roleManager.RoleExists("Employee"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Employee";
                roleManager.Create(role);

            }

  
            if (!roleManager.RoleExists("Customer"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Customer";
                roleManager.Create(role);

            }
        }
    }
}
