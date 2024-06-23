using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avans_DevOps.Domain.ObserverPattern;
using Avans_DevOps.Domain.States.BacklogItemStates;
using Avans_DevOps.Domain.Users;


namespace Avans_DevOps.Domain
{
    public class BacklogItem : IObservable
    {
        IBacklogItemState ToDoState;
        IBacklogItemState DoingState;
        IBacklogItemState ReadyForTestingState;
        IBacklogItemState TestingState;
        IBacklogItemState TestedState;
        IBacklogItemState DoneState;
        INotificationListener NotificationListener;

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

        public void changeState(IBacklogItemState state)
        {
            BacklogItemState = state;
        }

        public IBacklogItemState GetState()
        {
            return BacklogItemState;
        }

        public void SetTodoState()
        {
            BacklogItemState.SetToDo();
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

        public List<Activity> GetActivities()
        {
            return Activities;
        }

        public void AddActivity(Activity activity)
        {
            Activities.Add(activity);
        }

        public void RemoveActivity(Activity activity)
        {
            Activities.Remove(activity);
        }

        public bool AreActivitiesDone()
        {
            foreach (Activity activity in Activities)
            {
                if (!activity.IsDone)
                {
                    return false;
                }
            }
            return true;
        }

        public void subscribe()
        {
            throw new NotImplementedException();
        }

        public void unsubscribe()
        {
            throw new NotImplementedException();
        }

        public void notify()
        {
            throw new NotImplementedException();
        }
    }
}
