using Avans_DevOps.Domain.Sprint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avans_DevOps.Domain.States.ReleaseSprintStates
{
    public class CanceledState : IReleaseSprintStates
    {
        private ReleaseSprint releaseSprint;
        public CanceledState(ReleaseSprint releaseSprint)
        {
            this.releaseSprint = releaseSprint;
        }

        public void SetToCanceledState()
        {
            throw new NotImplementedException();
        }

        public void SetToExecutingState()
        {
            throw new NotImplementedException();
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
