namespace Avans_DevOps.Domain.VisitorPattern
{
    public class Pipeline
    {
        public List<Folder> Folders { get; set; }

        public Pipeline() 
        { 
            Folders = new List<Folder>(); 
        }

    }
}
