namespace Avans_DevOps.Domain.VisitorPattern
{
    public class SubFolder
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Command> Commands { get; set; }

        public SubFolder(string name) 
        {
            Name = name;
            Commands = new List<Command>();
        }

        public void AddCommand(Command command)
        {
            Commands.Add(command);
        }
    }
}
