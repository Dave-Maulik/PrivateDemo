using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    public interface IOperations
    {
        void AddUser(User user);

        User GetOne(User user);
    }
}
