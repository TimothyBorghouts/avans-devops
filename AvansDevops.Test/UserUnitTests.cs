using Avans_DevOps.Domain.Users;

namespace AvansDevops.Test
{
    public class UserUnitTests
    {
        [Fact]
        public void CanCreateDeveloper()
        {
            // Arrange
            User user = new Developer("John", "test@mail.com", "mail");

            // Act

            // Assert
            Assert.NotNull(user);
            Assert.Equal("John", user.GetName());
        }

        [Fact]
        public void CanCreateProductOwner()
        {
            // Arrange
            User user = new ProductOwner("John", "test@mail.com", "mail");

            // Act

            // Assert
            Assert.NotNull(user);
            Assert.Equal("John", user.GetName());
        }

        [Fact]
        public void CanCreateScrumMaster()
        {
            // Arrange
            User user = new ScrumMaster("John", "test@mail.com", "mail");

            // Act

            // Assert
            Assert.NotNull(user);
            Assert.Equal("John", user.GetName());
        }

        [Fact]
        public void CanCreateTester()
        {
            // Arrange
            User user = new Tester("John", "test@mail.com", "mail");

            // Act

            // Assert
            Assert.NotNull(user);
            Assert.Equal("John", user.GetName());

        }
    }
}
