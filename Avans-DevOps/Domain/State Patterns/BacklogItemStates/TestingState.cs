using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avans_DevOps.Domain.States.BacklogItemStates
{
    public class TestingState : IBacklogItemState
    {
        BacklogItem backlogItem;

        public TestingState(BacklogItem backlogItem)
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
            throw new NotImplementedException();
        }

        public void SetTesting()
        {
            throw new NotImplementedException();
        }

        public void SetTested()
        {
            backlogItem.changeState(new TestedState(backlogItem));
            Debug.WriteLine("Changed to state Tested.");
        }

        public void SetDone()
        {
            throw new NotImplementedException();
        }
    }
}
