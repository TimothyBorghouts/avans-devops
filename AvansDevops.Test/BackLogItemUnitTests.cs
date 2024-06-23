using Avans_DevOps.Domain;
using Avans_DevOps.Domain.States.BacklogItemStates;
using Avans_DevOps.Domain.Users;
using Moq;

namespace AvansDevops.Test
{
    public class BackLogItemUnitTests
    {
        Mock<BacklogItem> backlogItemMock = new Mock<BacklogItem>();

        private Developer mockDeveloper = new Developer("timothy", "timothy@gmail.com", "email");
        private BacklogItem mockBacklogItem = new BacklogItem("inlog pagina maken",
            new Developer("timothy", "timothy@gmail.com", "email"));

        [Fact]
        public void BacklogItemsCanHaveActivities()
        {
            //Arrange
            Activity activity = new Activity("buttons allignen", mockDeveloper);
            Activity secondActivity = new Activity("buttons allignen", mockDeveloper);
            Activity thirdActivity = new Activity("buttons allignen", mockDeveloper);

            //Act
            mockBacklogItem.AddActivity(activity);
            mockBacklogItem.AddActivity(secondActivity);
            mockBacklogItem.AddActivity(thirdActivity);

            //Assert
            Assert.Equal(3, mockBacklogItem.GetActivities().Count);
        }

        [Fact]
        public void BacklogItemsCanChangeState()
        {
            //Arrange

            //Act
            mockBacklogItem.SetDoingState();

            //Assert
            Assert.IsType<DoingState>(mockBacklogItem.GetState());
            
        }

        [Fact]
        public void BacklogItemCannotSkipStates()
        {
            //Arrange

            //Act
            //No act needed BacklogItem cannot skip states, so it should throw an not implemented exception

            //Assert
            Assert.Throws<NotImplementedException>(() => mockBacklogItem.SetTestedState());
        }

        [Fact]
        public void ActivtiesCanFinish()
        {
            //Arrange
            Activity activity = new Activity("buttons allignen", mockDeveloper);
            mockBacklogItem.AddActivity(activity);

            //Act
            activity.finishActivity();

            //Assert
            Assert.True(activity.IsFinished());
        }

        [Fact]
        public void BacklogItemCanOnlyBeFinishedWhenActivitiesAreFinished()
        {
            //Arrange
            Activity activity = new Activity("buttons allignen", mockDeveloper);
            mockBacklogItem.AddActivity(activity);

            //Act
            mockBacklogItem.SetDoingState();
            mockBacklogItem.SetReadyForTestingState();
            mockBacklogItem.SetTestingState();
            mockBacklogItem.SetTestedState();
            activity.finishActivity();
            mockBacklogItem.SetDoneState();

            //Assert
            Assert.IsType<DoneState>(mockBacklogItem.GetState());
        }   

        [Fact]
        public void BacklogItemCannotBeFinishedWithoutFinishingAllActivities()
        {
            //Arrange
            Activity activity = new Activity("buttons allignen", mockDeveloper);
            Activity secondActivity = new Activity("buttons allignen", mockDeveloper);
            mockBacklogItem.AddActivity(activity);
            mockBacklogItem.AddActivity(secondActivity);

            //Act
            //Walking through the states
            mockBacklogItem.SetDoingState();
            mockBacklogItem.SetReadyForTestingState();
            mockBacklogItem.SetTestingState();
            mockBacklogItem.SetTestedState();

            //Assert
            Assert.Throws<InvalidOperationException>(() => mockBacklogItem.SetDoneState());
        }   

        [Fact]
        public void SubscribeThrowsNotImplementedException()
        {
            //Arrange

            //Act

            //Assert
            Assert.Throws<NotImplementedException>(() => mockBacklogItem.subscribe());
        }

        [Fact]
        public void UnsubscribeThrowsNotImplementedException()
        {
            //Arrange

            //Act

            //Assert
            Assert.Throws<NotImplementedException>(() => mockBacklogItem.unsubscribe());
        }

        [Fact]
        public void NotifyThrowsNotImplementedException()
        {
            //Arrange

            //Act

            //Assert
            Assert.Throws<NotImplementedException>(() => mockBacklogItem.notify());
        }
    }
}