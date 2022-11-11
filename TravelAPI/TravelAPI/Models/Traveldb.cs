using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TravelAPI.Models
{

    public class Traveldb : DropCreateDatabaseIfModelChanges<TravelContext>
    {
        protected override void Seed(TravelContext context)
        {
            List<Admin> admin = new List<Admin>();
            admin.Add(new Admin() {AdminId=1, AdminEmail = "admin@gmail.com", AdminPassword = "admin",RememberMe=false });
            context.Admins.AddRange(admin);
            List<User> users = new List<User>();
            users.Add(new User() { UserId = 1, FirstName = "Pravalli",LastName="Aaaaa",Email="sweety@gmail.com", Password = "sweety",ConfirmPassword="sweety",RememberMe=true });
           
            context.Users.AddRange(users);
            context.SaveChanges();
            base.Seed(context);
        }
    }
}