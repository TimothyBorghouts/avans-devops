using Avans_DevOps.Domain.Sprint;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            feedbackSprint.ChangeState(new CanceledState(feedbackSprint));
            Console.WriteLine("Feedback Sprint changed to state Canceled.");
        }

        public void SetToExecutingState()
        {
            feedbackSprint.ChangeState(new ExecutingState(feedbackSprint));
            Console.WriteLine("Feedback Sprint changed to state Executing.");
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
