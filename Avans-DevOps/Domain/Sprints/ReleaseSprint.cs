using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avans_DevOps.Domain.States.ReleaseSprintStates;
using Avans_DevOps.Domain.Users;

namespace Avans_DevOps.Domain.Sprint
{
    public class ReleaseSprint : Sprint
    {
        public IReleaseSprintStates ReleaseSprintState { get; set; }

        public ReleaseSprint(string name, DateTime startDate, DateTime endDate) : base(name, startDate, endDate)
        {
            ReleaseSprintState = new InitializationState(this);
        }

        public void ChangeState(IReleaseSprintStates releaseSprintState)
        {
            ReleaseSprintState = (IReleaseSprintStates)releaseSprintState;
        }

        public void SetInitializeState()
        {
            ReleaseSprintState.SetToInitializationState();
        }

        public void SetExecuteState()
        {
            ReleaseSprintState.SetToExecutingState();
        }

        public void SetFinishState()
        {
            ReleaseSprintState.SetToFinishedState();
        }

        public void SetCancelState()
        {
            ReleaseSprintState.SetToCanceledState();
        }
    }
}
