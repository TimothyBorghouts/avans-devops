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
            Assert.Equal(1, mockForum.Threads.Count);
            Assert.Equal(1, mockForumComposite.GetAllThreadsFromForum(mockForum).Count);
        }

        [Fact]
        public void GetAllThreadsFromForum()
        {
            //Arrange
            DiscussionThread thread = new DiscussionThread("First thread");
            DiscussionThread secondThread = new DiscussionThread("Second thread");

            //Act
            mockForumComposite.AddThread(thread, mockForum);
            mockForumComposite.AddThread(secondThread, mockForum);

            //Assert
            Assert.Equal(2, mockForumComposite.GetAllThreadsFromForum(mockForum).Count);
        }

        [Fact]
        public void ThreadCanHavePosts()
        {
            //Arrange
            DiscussionThread thread = new DiscussionThread("First thread");
            Post post = new Post("First post", mockDeveloper);

            //Act
            mockForumComposite.AddThread(thread, mockForum);
            mockForumComposite.AddReactionToThread(post, thread);

            //Assert
            Assert.Equal(1, thread.Posts.Count);
        }

        [Fact]
        public void GetAllReactionsFromThread()
        {
            //Arrange
            DiscussionThread thread = new DiscussionThread("First thread");
            Post post = new Post("First post", mockDeveloper);
            Post secondPost = new Post("Second post", mockDeveloper);

            //Act
            mockForumComposite.AddThread(thread, mockForum);
            mockForumComposite.AddReactionToThread(post, thread);
            mockForumComposite.AddReactionToThread(secondPost, thread);

            //Assert
            Assert.Equal(2, mockForumComposite.GetAllReactionsFromThread(thread).Count);
        }

        [Fact]
        public void ForumCanRemoveThreads()
        {
            //Arrange
            DiscussionThread thread = new DiscussionThread("First thread");

            //Act
            mockForumComposite.AddThread(thread, mockForum);
            mockForumComposite.RemoveThread(thread, mockForum);

            //Assert
            Assert.Empty(mockForumComposite.GetAllThreadsFromForum(mockForum));
        }
    }
}
