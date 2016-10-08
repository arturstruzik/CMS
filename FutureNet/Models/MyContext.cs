using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FutureNet.Models
{
    public class MyContext : DbContext
    {
        public MyContext()
            : base()
        {

        }

        public DbSet<PremiumUser> PremiumUsers { get; set; }
        public DbSet<Contact> Contacts { get; set; }

    }
}