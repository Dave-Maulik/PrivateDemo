using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class DatabaseOperations : IOperations
    {
        UserDbContext Db;
        public DatabaseOperations()
        {
            Db = new UserDbContext();
        }
        public void AddUser(User user)
        {
            Db.Details.Add(user);
            Db.SaveChanges();
        }

        public User GetOne(User user)
        {
            var data = Db.Details.Find(user.id);
            return data;
        }
    }
}