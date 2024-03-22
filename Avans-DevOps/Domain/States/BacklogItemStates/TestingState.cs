using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }

        public void SetDone()
        {
            throw new NotImplementedException();
        }
    }
}
