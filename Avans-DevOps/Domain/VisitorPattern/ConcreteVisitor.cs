namespace Avans_DevOps.Domain.VisitorPattern
{
    public class ConcreteVisitor : IVisitor
    {
        public string Visit(Command command)
        {
            return $"Command: {command.Name}";
        }

        public string Visit(SubFolder subFolder)
        {
            return $"SubFolder: {subFolder.Name}";
        }
    }
}
