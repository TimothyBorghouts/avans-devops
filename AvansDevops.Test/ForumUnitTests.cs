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
            DiscussionThread thread2 = new DiscussionThread("First thread");

            //Act
            mockForum.AddThread(thread);
            mockForum.AddThread(thread2);

            //Assert
            Assert.Equal(2, mockForum.Threads.Count);
            Assert.Equal(2, mockForum.GetAllThreads().Count);
        }

        [Fact]
        public void GetAllThreadsFromForum()
        {
            //Arrange
            DiscussionThread thread = new DiscussionThread("First thread");
            DiscussionThread thread2 = new DiscussionThread("Second thread");

            //Act
            mockForum.AddThread(thread);
            mockForum.AddThread(thread2);

            //Assert
            Assert.Equal(2, mockForum.GetAllThreads().Count);
            Assert.Equal("First thread", mockForum.GetAllThreads()[0].Title);
            Assert.Equal("Second thread", mockForum.GetAllThreads()[1].Title);
        }

        [Fact]
        public void ThreadCanHavePosts()
        {
            //Arrange
            DiscussionThread thread = new DiscussionThread("First thread");
            Post post = new Post("First post", mockDeveloper);

            //Act
            mockForum.AddThread(thread);
            mockForumComposite.AddPost(post, thread);

            //Assert
            Assert.Single(mockForumComposite.GetAllThreadsPosts(thread));
        }

        [Fact]
        public void GetAllReactionsFromThread()
        {
            //Arrange
            DiscussionThread thread = new DiscussionThread("First thread");
            Post post = new Post("First post", mockDeveloper);
            Post secondPost = new Post("Second post", mockDeveloper);

            //Act
            mockForum.AddThread(thread);
            mockForumComposite.AddPost(post, thread);
            mockForumComposite.AddPost(secondPost, thread);

            //Assert
            Assert.Equal(2, mockForumComposite.GetAllThreadsPosts(thread).Count);
        }

        [Fact]
        public void ForumCanRemovePost()
        {
            //Arrange
            DiscussionThread thread = new DiscussionThread("First thread");
            Post post = new Post("First post", mockDeveloper);

            //Act
            mockForum.AddThread(thread);
            mockForumComposite.AddPost(post, thread);
            mockForumComposite.RemovePost(post, thread);

            //Assert
            Assert.Empty(mockForumComposite.GetAllThreadsPosts(thread));
        }

        [Fact]
        public void ForumCanRemoveThread()
        {
            //Arrange
            DiscussionThread thread = new DiscussionThread("First thread");
            DiscussionThread thread2 = new DiscussionThread("Second thread");

            //Act
            mockForum.AddThread(thread);
            mockForum.AddThread(thread2);
            mockForum.RemoveThread(thread);

            //Assert
            Assert.Single(mockForum.Threads);
        }
    }
}
