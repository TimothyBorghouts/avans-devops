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
    }
}
