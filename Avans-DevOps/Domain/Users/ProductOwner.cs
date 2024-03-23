using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avans_DevOps.Domain.Users
{
    public class ProductOwner : User
    {
        public ProductOwner(string name, string email, string notificationPlace ) : base(name, email, notificationPlace)
        {
        }
    }
}
