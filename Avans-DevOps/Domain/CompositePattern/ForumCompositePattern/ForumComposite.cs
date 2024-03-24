using Avans_DevOps.Domain.Forum;

namespace Avans_DevOps.Domain.CompositePattern.ForumCompositePattern
{
    public class ForumComposite
    {
        public void AddThread(DiscussionThread thread, Forum.Forum forum )
        {
            forum.Threads.Add(thread);
        }

        public void RemoveThread(DiscussionThread thread, Forum.Forum forum)
        {
            forum.Threads.Remove(thread);
        }

        public List<DiscussionThread> GetAllThreadsFromForum(Forum.Forum forum)
        {
            return forum.Threads;
        }

        public void AddReactionToThread(Post post, DiscussionThread thread)
        {
            thread.Posts.Add(post);
        }

        public List<Post> GetAllReactionsFromThread(DiscussionThread thread)
        {
            return thread.Posts;
        }
    }
}
