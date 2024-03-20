using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avans_DevOps.BacklogItem.States
{
    public class DoingState : State
    {
        BacklogItem backlogItem;

        public DoingState(BacklogItem backlogItem) { 
            this.backlogItem = backlogItem;
        }
    }
}
