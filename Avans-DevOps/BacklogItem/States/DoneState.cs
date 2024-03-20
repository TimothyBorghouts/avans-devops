using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avans_DevOps.BacklogItem.States
{
    public class DoneState : State
    {
        BacklogItem backlogItem;

        public DoneState(BacklogItem backlogItem) { 
            this.backlogItem = backlogItem;
        }
    }
}
