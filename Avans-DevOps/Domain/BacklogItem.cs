using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Avans_DevOps.Domain.States.BacklogItemStates;
using Avans_DevOps.Domain.Sprint;
using Avans_DevOps.Domain.Users;


namespace Avans_DevOps.Domain
{
    public class BacklogItem
    {
        IBacklogItemState ToDoState;
        IBacklogItemState DoingState;
        IBacklogItemState ReadyForTestingState;
        IBacklogItemState TestingState;
        IBacklogItemState TestedState;
        IBacklogItemState DoneState;

        private string Name { get; set; }
        private List<Activity> Activities { get; }
        private Developer Developer { get; set; }
        private IBacklogItemState BacklogItemState { get; set; }

        public BacklogItem(string Name, Developer Developer)
        {
            BacklogItemState = new ToDoState(this);
            this.Name = Name;
            this.Developer = Developer;
            Activities = new List<Activity>();
        }

        public List<Activity> GetActivities()
        {
            return Activities;
        }

        public void AddActivity(Activity activity)
        {
            Activities.Add(activity);
        }

        public void SetTodoState()
        {
            BacklogItemState.setToDo();
        }

        public void SetDoingState()
        {
            BacklogItemState.SetDoing();
        }

        public void SetReadyForTestingState()
        {
            BacklogItemState.SetReadyForTesting();
        }

        public void SetTestingState()
        {
            BacklogItemState.SetTesting();
        }

        public void SetTestedState()
        {
            BacklogItemState.SetTested();
        }

        public void SetDoneState()
        {
            BacklogItemState.SetDone();
        }
    }
}
