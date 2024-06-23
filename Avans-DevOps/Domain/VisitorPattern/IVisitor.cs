namespace Avans_DevOps.Domain.VisitorPattern
{
    public interface IVisitor
    {
        string Visit(Command command);
        string Visit(SubFolder subFolder);
    }
}
