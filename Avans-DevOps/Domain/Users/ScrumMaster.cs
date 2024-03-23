using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avans_DevOps.Domain.Users
{
    public class ScrumMaster : User
    {
        public ScrumMaster(string name, string email, string password, string notificationPlace) : base(name, email, password, notificationPlace)
        {
        }
    }
}
