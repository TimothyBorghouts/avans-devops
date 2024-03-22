using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avans_DevOps.Domain.Users
{
    public abstract class User
    {
        private string Name;
        private string Email;
        private string Password;

        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }

    }
}
