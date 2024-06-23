using Avans_DevOps.Domain.AdapterPattern;
using Avans_DevOps.Domain.ObserverPattern;

namespace AvansDevops.Test
{
    public class NotificationUnitTests
    {
        private INotificationListener _notificationListener;

        [Fact]
        public void SmsAdapterSendsNotification()
        {
            //Arrange
            _notificationListener = new SMSNotificationAdapter();

            //Act
            _notificationListener.SendNotification("Test");

            //Assert
            Assert.Equal("SMS: Test", _notificationListener.SendNotification("Test"));
        }

        [Fact]
        public void SmsAdapterUpdatesNotification()
        {
            //Arrange
            _notificationListener = new SMSNotificationAdapter();

            //Act
            string test = _notificationListener.Update("update 1.0");

            //Assert
            Assert.Equal("Updating...", test);
        }

        [Fact]
        public void EmailAdapterSendsNotification()
        {
            //Arrange
            _notificationListener = new EmailNoticationAdapter();

            //Act
            string test = _notificationListener.SendNotification("Test");

            //Assert
            Assert.Equal("Email: Test", test);
        }

        [Fact]
        public void EmailAdapterUpdatesNotification()
        {
            //Arrange
            _notificationListener = new EmailNoticationAdapter();

            //Act
            string test = _notificationListener.Update("update 1.0");

            //Assert
            Assert.Equal("Updating...", test);
        }

        [Fact]
        public void SlackAdapterSendsNotification()
        {
            //Arrange
            _notificationListener = new SlackNoticationAdapter();

            //Act
            string test = _notificationListener.SendNotification("Test");

            //Assert
            Assert.Equal("Slack: Test", test);
        }

        [Fact]
        public void SlackAdapterUpdatesNotification()
        {
            //Arrange
            _notificationListener = new SlackNoticationAdapter();

            //Act
            string test = _notificationListener.Update("update 1.0");

            //Assert
            Assert.Equal("Updating...", test);
        }
    }
}
