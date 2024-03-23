using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avans_DevOps.Domain.Sprint;

namespace Avans_DevOps.Domain.Forum
{
    public class Forum
    {
        public string Title { get; set; }
        public ReleaseSprint sprint { get; set; }
        public List<DiscussionThread> Threads { get; set; }

        public Forum(string title)
        {
            Title = title;
            Threads = new List<DiscussionThread>();
        }
    }
}
