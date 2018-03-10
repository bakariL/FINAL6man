using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;


namespace TV5.Models
{
    public class OurdbContext : DbContext 
    {
        public DbSet<SignUp> userSignUp { get; set; }
    }
}