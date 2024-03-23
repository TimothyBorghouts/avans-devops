using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avans_DevOps.Domain.Forum
{
    public class Thread
    {
        public string Title { get; set; }
        public List<Post> Posts { get; set; }

        public Thread(string title)
        {
            Title = title;
            Posts = new List<Post>();
        }
    }
}
