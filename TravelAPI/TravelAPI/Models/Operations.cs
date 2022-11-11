using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelAPI.Models
{
    public class Operations
    {
        TravelContext context = new TravelContext();

        public List<Admin> GetAdmin()
        {
            return context.Admins.ToList();
        }
        public Admin GetAdmin(int id)
        {
            return context.Admins.ToList().Find(x => x.AdminId== id);
        }
        public void PostAdmin(Admin admin)
        {
            context.Admins.Add(admin);
            context.SaveChanges();
        }
        public void PutAdmin(int id, Admin admin)
        {
            var found = context.Admins.ToList().Find(x => x.AdminId == id);
            context.Admins.Remove(found);
            context.Admins.Add(admin);
            context.SaveChanges();
        }
        public void DeleteAdmin(int id)
        {
            var found = context.Admins.ToList().Find(x => x.AdminId == id);
            context.Admins.Remove(found);
            context.SaveChanges();
        }






        public List<User> GetUser()
        {
            return context.Users.ToList();
        }
        public User GetUser(int id)
        {
            return context.Users.ToList().Find(x => x.UserId == id);
        }
        public void PostUser(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }
        public void PutUser(int id, User user)
        {
            var found = context.Users.ToList().Find(x => x.UserId == id);
            context.Users.Remove(found);
            context.Users.Add(user);
            context.SaveChanges();
        }
        public void DeleteUser(int id)
        {
            var found = context.Users.ToList().Find(x => x.UserId == id);
            context.Users.Remove(found);
            context.SaveChanges();
        }
       
      
           
       
    }
}