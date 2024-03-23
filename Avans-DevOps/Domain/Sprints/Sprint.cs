using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avans_DevOps.Domain.Users;

namespace Avans_DevOps.Domain.Sprint
{
    public abstract class Sprint
    {
        private string name { get; set; }
        private DateTime startDate { get; set; }
        private DateTime endDate { get; set; }
        private List<User> Users { get; set; }

        public Sprint(string name, DateTime startDate, DateTime endDate, List<User> users)
        {
            this.name = name;
            this.startDate = startDate;
            this.endDate = endDate;
            this.Users = users;
        }
    }
}
