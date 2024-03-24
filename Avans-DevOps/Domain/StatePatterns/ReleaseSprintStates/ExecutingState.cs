using Avans_DevOps.Domain.Sprint;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avans_DevOps.Domain.States.ReleaseSprintStates
{
    public class ExecutingState : IReleaseSprintStates
    {
        private ReleaseSprint releaseSprint;

        public ExecutingState(ReleaseSprint releaseSprint)
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
            throw new NotImplementedException();
        }

        public void SetToFinishedState()
        {
            releaseSprint.ChangeState(new FinishedState(releaseSprint));
            Console.WriteLine("Release Sprint changed to state Finished.");
        }

        public void SetToInitializationState()
        {
            throw new NotImplementedException();
        }
    }
}
