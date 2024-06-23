namespace Avans_DevOps.Domain.VisitorPattern
{
    public class Command
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Command(string name) 
        { 
            Name = name;
        }
    }
}
