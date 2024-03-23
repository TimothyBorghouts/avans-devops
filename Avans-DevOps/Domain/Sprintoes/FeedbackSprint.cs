using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avans_DevOps.Domain.Users;

namespace Avans_DevOps.Domain.Sprint
{
    public class FeedbackSprint : Sprint
    {
        public FeedbackSprint(string name, DateTime startDate, DateTime endDate) : base(name, startDate, endDate)
        {
        }
    }
}
