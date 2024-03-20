using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avans_DevOps
{
    public class Project
    {
        private string Name { get; set; }
        private ProductBacklog productBacklog {get;}

        public Project (string name, ProductBacklog productBacklog)
        {
            this.Name = name;
            this.productBacklog = productBacklog;
        }
    }
}
