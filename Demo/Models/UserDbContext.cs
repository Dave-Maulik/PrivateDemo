using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class UserDbContext : DbContext
    {
        public DbSet<User> Details { get; set; }
    }
}