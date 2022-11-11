using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;



namespace TravelAPI.Models
{

    public class TravelContext : DbContext
    {
        public TravelContext() : base("name=TravelDB")
        {
            Database.SetInitializer<TravelContext>(new Traveldb());
        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }

       
       

    }
}