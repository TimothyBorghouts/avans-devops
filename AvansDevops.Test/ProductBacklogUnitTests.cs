using Avans_DevOps.Domain;
using Avans_DevOps.Domain.Users;

namespace Avans_DevOps.Tests
{
    public class ProductBacklogTests
    {
        [Fact]
        public void AddItem_ShouldAddBacklogItemToList()
        {
            // Arrange
            var productBacklog = new ProductBacklog();
            BacklogItem backlogItem = new BacklogItem("inlog pagina maken",
            new Developer("timothy", "timothy@gmail.com", "email"));

        // Act
        productBacklog.addItem(backlogItem);

            // Assert
            Assert.Contains(backlogItem, productBacklog.GetBacklogItems());
        }

        [Fact]
        public void Constructor_ShouldInitializeBacklogItems()
        {
            // Arrange & Act
            var productBacklog = new ProductBacklog();

            // Assert
            Assert.NotNull(productBacklog.GetBacklogItems());
            Assert.Empty(productBacklog.GetBacklogItems());
        }
    }
}
