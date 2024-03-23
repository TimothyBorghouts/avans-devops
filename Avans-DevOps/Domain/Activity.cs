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
        private string Name { get; set; }
        public bool IsDone { get; set; }
        private Developer Developer { get; set; }
        public Activity(string name,  Developer developer)
        {
            this.Name = name;
            this.Developer = developer;
            IsDone = false;
        }

        public void finishActivity()
        {
            IsDone = true;
        }

        public bool IsFinished()
        {
            return IsDone;
        }
    }
}
