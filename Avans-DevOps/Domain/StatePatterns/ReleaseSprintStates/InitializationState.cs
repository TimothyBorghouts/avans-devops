using Avans_DevOps.Domain.Sprint;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avans_DevOps.Domain.States.ReleaseSprintStates
{
    public class InitializationState : IReleaseSprintStates
    {
        private ReleaseSprint releaseSprint;

        public InitializationState(ReleaseSprint releaseSprint)
        {
            this.releaseSprint = releaseSprint;
        }

        public void SetToCanceledState()
        {
            releaseSprint.ChangeState(new CanceledState(releaseSprint));
            Console.WriteLine("Release Sprint changed to state Canceled.");
        }

        public void SetToExecutingState()
        {
            releaseSprint.ChangeState(new ExecutingState(releaseSprint));
            Console.WriteLine("Release Sprint changed to state Executing.");
        }

        public void SetToFinishedState()
        {
            throw new NotImplementedException();
        }

        public void SetToInitializationState()
        {
            throw new NotImplementedException();
        }
    }
}
