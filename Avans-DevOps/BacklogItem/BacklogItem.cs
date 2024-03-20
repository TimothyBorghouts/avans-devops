using Avans_DevOps.BacklogItem.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avans_DevOps.BacklogItem
{
    public class BacklogItem
    {
        State ToDoState;
        State DoingState;
        State ReadyForTestingState;
        State TestingState;
        State TestedState;
        State DoneState;

        private string name { get; set; }
        private List<Activity> Activities { get; }

        public BacklogItem(string name) {
            ToDoState = new ToDoState(this);
            DoingState = new DoingState(this);
            ReadyForTestingState = new ReadyForTestingState(this);
            TestingState = new TestingState(this);
            TestedState = new TestedState(this);
            DoneState = new DoneState(this);

            this.name = name;
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

    }
}
