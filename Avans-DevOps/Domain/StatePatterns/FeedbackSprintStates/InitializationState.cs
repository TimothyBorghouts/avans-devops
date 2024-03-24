using Avans_DevOps.Domain.Sprint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avans_DevOps.Domain.States.FeedbackSprintStates
{
    public class InitializationState : IFeedbackSprintState
    {
        private FeedbackSprint feedbackSprint;

        public InitializationState(FeedbackSprint feedbackSprint)
        {
            this.feedbackSprint = feedbackSprint;
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
