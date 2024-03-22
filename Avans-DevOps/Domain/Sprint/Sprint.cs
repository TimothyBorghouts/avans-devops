using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avans_DevOps.Domain.Sprint
{
    public class Sprint
    {
        private string name { get; set; }
        private DateTime startDate { get; set; }
        private DateTime endDate { get; set; }

        public Sprint(string name, DateTime startDate, DateTime endDate)
        {
            this.name = name;
            this.startDate = startDate;
            this.endDate = endDate;
        }
    }
}
