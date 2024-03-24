using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avans_DevOps.Domain.States.FeedbackSprintStates;
using Avans_DevOps.Domain.Users;

namespace Avans_DevOps.Domain.Sprint
{
    public class FeedbackSprint : Sprint
    {
        public IFeedbackSprintState FeedbackSprintState { get; set; }

        public FeedbackSprint(string name, DateTime startDate, DateTime endDate) : base(name, startDate, endDate)
        {
            FeedbackSprintState = new InitializationState(this);
        }

        public void ChangeState(IFeedbackSprintState feedbackSprintState)
        {
            FeedbackSprintState = (IFeedbackSprintState)feedbackSprintState;
        }

        public void Initialize()
        {
            FeedbackSprintState.SetToInitializationState();
        }

        public void Execute()
        {
            FeedbackSprintState.SetToExecutingState();
        }

        public void Finish()
        {
            FeedbackSprintState.SetToFinishedState();
        }

        public void Cancel()
        {
            FeedbackSprintState.SetToCanceledState();
        }
    }
}
