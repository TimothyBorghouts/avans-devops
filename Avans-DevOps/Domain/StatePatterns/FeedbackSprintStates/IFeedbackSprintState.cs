using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avans_DevOps.Domain.States.FeedbackSprintStates
{
    public interface IFeedbackSprintState
    {
        public void SetToInitializationState();
        public void SetToExecutingState();
        public void SetToFinishedState();
        public void SetToCanceledState();
    }
}
