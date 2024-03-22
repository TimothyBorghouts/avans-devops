using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avans_DevOps.Domain
{
    public class ProductBacklog
    {
        private List<BacklogItem> backlogItems { get; }
        public ProductBacklog()
        {

            backlogItems = new List<BacklogItem>();
        }

        public void addItem(BacklogItem backlogItem)
        {
            backlogItems.Add(backlogItem);
        }
    }
}
