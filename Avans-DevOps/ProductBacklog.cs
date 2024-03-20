using Avans_DevOps.BacklogItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avans_DevOps.BacklogItem;

namespace Avans_DevOps
{
    public class ProductBacklog
    {
        private List<BacklogItem.BacklogItem> backlogItems { get;}
        public ProductBacklog() { 
            
            backlogItems = new List<BacklogItem.BacklogItem>();
        }

        public void addItem(BacklogItem.BacklogItem backlogItem)
        {
            backlogItems.Add(backlogItem);
        }
    }
}
