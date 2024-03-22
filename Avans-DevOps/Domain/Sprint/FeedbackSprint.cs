using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avans_DevOps.Domain.Sprint
{
    internal class FeedbackSprint : Sprint
    {
        public FeedbackSprint(string name, DateTime startDate, DateTime endDate) : base(name, startDate, endDate)
        {
        }
    }
}
