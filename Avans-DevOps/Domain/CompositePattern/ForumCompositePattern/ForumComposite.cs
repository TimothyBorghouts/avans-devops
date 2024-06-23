using Avans_DevOps.Domain.Forum;

namespace Avans_DevOps.Domain.CompositePattern.ForumCompositePattern
{
    public class ForumComposite
    {
        public void AddPost(Post post, DiscussionThread thread)
        {
            thread.Posts.Add(post);
        }

        public void RemovePost(Post post, DiscussionThread thread)
        {
            thread.Posts.Remove(post);
        }

        public List<Post> GetAllThreadsPosts(DiscussionThread thread)
        {
            return thread.Posts;
        }
    }
}
