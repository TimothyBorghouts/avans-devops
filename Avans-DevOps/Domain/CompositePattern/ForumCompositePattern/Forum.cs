using Avans_DevOps.Domain.Sprint;

namespace Avans_DevOps.Domain.Forum
{
    public class Forum
    {
        public string Title { get; set; }
        public ReleaseSprint sprint { get; set; }
        public List<DiscussionThread> Threads { get; set; }

        public Forum(string title)
        {
            Title = title;
            Threads = new List<DiscussionThread>();
        }

        public List<DiscussionThread> GetAllThreads()
        {
           return Threads;
        }

        public void AddThread(DiscussionThread thread)
        {
            Threads.Add(thread);
        }

        public void RemoveThread(DiscussionThread thread)
        {
            Threads.Remove(thread);
        }
    }
}
