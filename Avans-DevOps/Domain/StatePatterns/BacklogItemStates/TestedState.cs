using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avans_DevOps.Domain.States.BacklogItemStates
{
    public class TestedState : IBacklogItemState
    {
        BacklogItem backlogItem;

        public TestedState(BacklogItem backlogItem)
        {
            this.backlogItem = backlogItem;
        }

        public void SetToDo()
        {
            backlogItem.changeState(new ToDoState(backlogItem));
            Console.WriteLine("Backlog Item changed to state ToDo.");
        }

        public void SetDoing()
        {
            throw new NotImplementedException();
        }

        public void SetReadyForTesting()
        {
           backlogItem.changeState(new ReadyForTestingState(backlogItem));
            Console.WriteLine("Backlog Item changed to state ReadyForTesting.");
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
            if (backlogItem.AreActivitiesDone())
            {
                backlogItem.changeState(new DoneState(backlogItem));
            } else
            {
                throw new InvalidOperationException("Not all activities are done.");
            }

            Console.WriteLine("Changed to state Done.");
        }
    }
}
