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

        public string GetOne(User user)
        {
            var data = Db.Details.FirstOrDefault(u => u.Password == user.Password);
            return data.Password;
        }
    }
}