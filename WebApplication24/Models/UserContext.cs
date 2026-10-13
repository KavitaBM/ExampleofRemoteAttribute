using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication24.Models
{
    public class ContextCls:DbContext
    {
        public ContextCls() : base("myconn") { }

        public DbSet<User> Users { get; set; }
        public DbSet<Country> Countries { get; set; }
    }
}