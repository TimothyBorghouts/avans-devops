using Avans_DevOps.Domain.CompositePattern.ForumCompositePattern;
using Avans_DevOps.Domain.Forum;
using Avans_DevOps.Domain.Users;

namespace AvansDevops.Test
{
    public class ForumUnitTests
    {
        private Forum mockForum = new Forum("Avans DevOps Forum");
        private ForumComposite mockForumComposite = new ForumComposite();
        private Developer mockDeveloper = new Developer("timothy", "timothy@mail.com", "mail");

        [Fact]
        public void ForumCanHaveThreads()
        {
            //Arrange
            DiscussionThread thread = new DiscussionThread("First thread");

            //Act
            mockForumComposite.AddThread(thread, mockForum);

            //Assert
            Assert.Equal(1, mockForumComposite.GetAllThreadsFromForum(mockForum).Count);
        }
    }
}
