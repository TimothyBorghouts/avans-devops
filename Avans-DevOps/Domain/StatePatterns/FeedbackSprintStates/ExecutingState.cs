using Avans_DevOps.Domain.Sprint;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avans_DevOps.Domain.States.FeedbackSprintStates
{
    public class ExecutingState : IFeedbackSprintState
    {
        private FeedbackSprint feedbackSprint;

        public ExecutingState(FeedbackSprint feedbackSprint)
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
            throw new NotImplementedException();
        }

        public void SetToFinishedState()
        {
            feedbackSprint.ChangeState(new FinishedState(feedbackSprint));
            Console.WriteLine("Feedback Sprint changed to state Finished.");
        }

        public void SetToInitializationState()
        {
            throw new NotImplementedException();
        }
    }
}
