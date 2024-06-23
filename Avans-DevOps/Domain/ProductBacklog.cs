namespace Avans_DevOps.Domain
{
    public class ProductBacklog
    {
        private List<BacklogItem> backlogItems { get; }
        public ProductBacklog()
        {
            backlogItems = new List<BacklogItem>();
        }

        public void addItem(BacklogItem backlogItem)
        {
            backlogItems.Add(backlogItem);
        }

        public IReadOnlyList<BacklogItem> GetBacklogItems()
        {
            return backlogItems.AsReadOnly();
        }
    }
}
