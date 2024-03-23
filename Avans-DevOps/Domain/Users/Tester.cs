using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avans_DevOps.Domain.Users
{
    public class Tester : User
    {
        public Tester(string name, string email, string notificationPlace) : base(name, email, notificationPlace)
        {
        }
    }
}
