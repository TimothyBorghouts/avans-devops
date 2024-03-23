using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avans_DevOps.Domain.States.BacklogItemStates
{
    public class ReadyForTestingState : IBacklogItemState
    {
        BacklogItem backlogItem;

        public ReadyForTestingState(BacklogItem backlogItem)
        {
            this.backlogItem = backlogItem;
        }

        public void SetToDo()
        {
            backlogItem.changeState(new ToDoState(backlogItem));
            Debug.WriteLine("Changed to state ToDo.");
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
            backlogItem.changeState(new TestingState(backlogItem));
            Debug.WriteLine("Changed to state Testing.");
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
