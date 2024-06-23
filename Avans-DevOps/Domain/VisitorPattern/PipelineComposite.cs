namespace Avans_DevOps.Domain.VisitorPattern
{
    public class PipelineComposite
    {
        public void AddFolder(Pipeline pipe, Folder folder)
        {
            pipe.Folders.Add(folder);
        }

        public void RemoveFolder(Pipeline pipe, Folder folder)
        {
            pipe.Folders.Remove(folder);
        }

        public void AddSubFolder(Folder folder, SubFolder subFolder)
        {
            folder.SubFolders.Add(subFolder);
        }

        public void RemoveSubFolder(Folder folder, SubFolder subFolder)
        {
            folder.SubFolders.Remove(subFolder);
        }

        public void AddCommand(Folder folder, Command command)
        {
            folder.Commands.Add(command);
        }

        public void RemoveCommand(Folder folder, Command command)
        {
            folder.Commands.Remove(command);
        }
    }
}
