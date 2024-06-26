﻿using Avans_DevOps.Domain.Sprint;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avans_DevOps.Domain.States.FeedbackSprintStates
{
    public class CanceledState : IFeedbackSprintState
    {
        private FeedbackSprint feedbackSprint;

        public CanceledState(FeedbackSprint feedbackSprint)
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
            feedbackSprint.ChangeState(new InitializationState(feedbackSprint));
            Console.WriteLine("Feedback Sprint changed to state Initialized.");
        }
    }
}
