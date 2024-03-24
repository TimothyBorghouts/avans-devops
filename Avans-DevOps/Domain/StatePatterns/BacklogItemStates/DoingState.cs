using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avans_DevOps.Domain.States.BacklogItemStates
{
    public class DoingState : IBacklogItemState
    {
        BacklogItem backlogItem;

        public DoingState(BacklogItem backlogItem)
        {
            this.backlogItem = backlogItem;
        }

        public void SetToDo()
        {
            throw new NotImplementedException();
        }

        public void SetDoing()
        {
            throw new NotImplementedException();
        }

        public void SetReadyForTesting()
        {
            backlogItem.changeState(new ReadyForTestingState(backlogItem));
            Debug.WriteLine("Changed to state ReadyForTesting.");
        }

        public void SetTesting()
        {
            throw new NotImplementedException();
        }

        public void SetTested()
        {
            throw new NotImplementedException();
        }

        public void SetDone()
        {
            throw new NotImplementedException();
        }
    }
}
