using Avans_DevOps.Domain.Sprint;
using Avans_DevOps.Domain.States.FeedbackSprintStates;

namespace AvansDevops.Test
{
    public class SprintUnitTest
    {
        FeedbackSprint mockFeedbackSprint = new FeedbackSprint("Feedback sprint", DateTime.Now, DateTime.Now.AddDays(7));
        ReleaseSprint mockReleaseSprint = new ReleaseSprint("Release sprint", DateTime.Now, DateTime.Now.AddDays(7));

        [Fact]
        public void CanCreateFeedbackSprint()
        {
            //Arrange
            FeedbackSprint feedbackSprint = new FeedbackSprint("Feedback sprint", DateTime.Now, DateTime.Now.AddDays(7));

            //Act

            //Assert
            Assert.NotNull(feedbackSprint);
        }

        [Fact]
        public void SprintStartsWithInitialize()
        {
            //Arrange

            //Act

            //Assert
            Assert.IsType<InitializationState>(mockFeedbackSprint.FeedbackSprintState);
        }

        [Fact]
        public void SprintCanChangeToExecutingState() {
            //Arrange

            //Act
            mockFeedbackSprint.SetExecuteState();

            //Assert
            Assert.IsType<ExecutingState>(mockFeedbackSprint.FeedbackSprintState);
        }

        [Fact]
        public void SprintCannotSkipToFinishedState()
        {
            //Arrange

            //Act

            //Assert
            Assert.Throws<NotImplementedException>(() => mockFeedbackSprint.SetFinishState());
        }

        [Fact]
        public void SprintCannotGoBackToInitializationState()
        {
            //Arrange

            //Act

            //Assert
            Assert.Throws<NotImplementedException>(() => mockFeedbackSprint.SetInitializeState());
        }

        [Fact]
        public void SprintCannotGoBackToCanceledState()
        {
            //Arrange

            //Act
            mockFeedbackSprint.SetCancelState();
            //Assert
            Assert.IsType<CanceledState>(mockFeedbackSprint.FeedbackSprintState);
        }

        [Fact]
        public void ReleaseSprintCannotSkipToFinishedState()
        {
            //Arrange

            //Act

            //Assert
            Assert.Throws<NotImplementedException>(() => mockReleaseSprint.SetFinishState());
        }

        [Fact]
        public void ReleaseSprintCannotGoBackToInitializationState()
        {
            //Arrange

            //Act

            //Assert
            Assert.Throws<NotImplementedException>(() => mockReleaseSprint.SetInitializeState());
        }

        [Fact]
        public void SprintCanChangeToFinishedState()
        {
            //Arrange

            //Act
            mockFeedbackSprint.SetExecuteState();
            mockFeedbackSprint.SetFinishState();

            //Assert
            Assert.IsType<FinishedState>(mockFeedbackSprint.FeedbackSprintState);
        }
    }
}
