using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Avans_DevOps.Domain.States.BacklogItemStates;

namespace Avans_DevOps.Domain.States.BacklogItemStates
{
    public class ToDoState : IBacklogItemState
    {
        private BacklogItem backlogItem;

        public ToDoState(BacklogItem backlogItem)
        {
            this.backlogItem = backlogItem;
        }

        public void SetToDo()
        {
            throw new NotImplementedException();
        }

        public void SetDoing()
        {
            backlogItem.SetDoingState();
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
