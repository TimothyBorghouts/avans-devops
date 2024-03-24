using Avans_DevOps.Domain.Users;

namespace Avans_DevOps.Domain.Forum
{
    public class Post
    {
        public string Content { get; set; }
        public User Author { get; set; }
        public DateTime Date { get; set; }

        public Post(string content, User author)
        {
            Content = content;
            Author = author;
            Date = DateTime.Now;
        }
    }
}
