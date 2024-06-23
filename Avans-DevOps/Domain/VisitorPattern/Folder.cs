namespace Avans_DevOps.Domain.VisitorPattern
{
    public class Folder
    {
        public string Name { get; set; }
        public List<SubFolder> SubFolders { get; set; }
        public List<Command> Commands { get; set; }

        public Folder(string name) 
        {
            Name = name;
            SubFolders = new List<SubFolder>();
            Commands = new List<Command>();
        }

        public SubFolder GetSubFolder(string name)
        {
            return SubFolders.FirstOrDefault(sf => sf.Name == name);
        }
        public SubFolder GetSubFolder(SubFolder sub)
        {
            return SubFolders.FirstOrDefault(sf => sf == sub);
        }
    }
}
