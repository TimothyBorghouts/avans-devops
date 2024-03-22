using Avans_DevOps.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avans_DevOps.Domain
{
    public class Activity
    {
        private string name { get; set; }
        private bool isDone { get; set; }
        private Developer developer { get; set; }
        public Activity(string name,  Developer developer)
        {
            this.name = name;
            this.developer = developer;
            isDone = false;
        }
    }
}
