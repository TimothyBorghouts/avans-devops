using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avans_DevOps.Domain.Users;

namespace Avans_DevOps.Domain.Sprint
{
    public class ReleaseSprint : Sprint
    {
        public ReleaseSprint(string name, DateTime startDate, DateTime endDate, List<User> users) : base(name, startDate, endDate, users)
        {
        }
    }
}
