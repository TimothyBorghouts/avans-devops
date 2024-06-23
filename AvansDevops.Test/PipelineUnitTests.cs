using Avans_DevOps.Domain.VisitorPattern;
using Moq;

namespace AvansDevops.Test
{
    public class PipelineUnitTests
    {
        Pipeline pipeline = new Pipeline();
        PipelineComposite pipelineComposite = new PipelineComposite();

        [Fact]
        public void PipelineCanHaveFolder()
        {
            // Arrange
            Folder folder = new Folder("Folder 1");

            // Act
            pipelineComposite.AddFolder(pipeline, folder);

            // Assert
            Assert.Single(pipeline.Folders);
        }

        [Fact]
        public void PipelineFoldersAreCorrect()
        {
            // Arrange
            Folder folder = new Folder("Folder 1");
            Folder folder2 = new Folder("Folder 2");

            // Act
            pipelineComposite.AddFolder(pipeline, folder);
            pipelineComposite.AddFolder(pipeline, folder2);

            // Assert
            Assert.Equal(2, pipeline.Folders.Count);
            Assert.Equal("Folder 1", pipeline.Folders[0].Name);
            Assert.Equal("Folder 2", pipeline.Folders[1].Name);
        }

        [Fact]
        public void PipelineCanRemoveFolder()
        {
            // Arrange
            Folder folder = new Folder("Folder 1");

            // Act
            pipelineComposite.AddFolder(pipeline, folder);
            pipelineComposite.RemoveFolder(pipeline, folder);

            // Assert
            Assert.Empty(pipeline.Folders);
        }

        [Fact]
        public void CommandsCanBeRemoved()
        {

           // Arrange
            Folder folder = new Folder("Folder 1");
            Command command = new Command("Command 1");

            // Act
            pipelineComposite.AddFolder(pipeline, folder);
            pipelineComposite.AddCommand(folder, command);
            pipelineComposite.RemoveCommand(folder, command);

            // Assert
            Assert.Empty(pipeline.Folders[0].Commands);
        }

        [Fact]
        public void FolderCanHaveSubFolder()
        {
            // Arrange
            Folder folder = new Folder("Folder 1");
            SubFolder subFolder = new SubFolder("SubFolder 1");

            // Act
            pipelineComposite.AddFolder(pipeline, folder);
            pipelineComposite.AddSubFolder(folder, subFolder);

            // Assert
            Assert.Single(pipeline.Folders[0].SubFolders);
            Assert.Equal("SubFolder 1", pipeline.Folders[0].GetSubFolder("SubFolder 1").Name);
            Assert.Equal("SubFolder 1", pipeline.Folders[0].GetSubFolder(subFolder).Name);
        }

        [Fact]
        public void FolderCanRemoveSubFolder()
        {
            // Arrange
            Folder folder = new Folder("Folder 1");
            SubFolder subFolder = new SubFolder("SubFolder 1");

            // Act
            pipelineComposite.AddFolder(pipeline, folder);
            pipelineComposite.AddSubFolder(folder, subFolder);
            pipelineComposite.RemoveSubFolder(folder, subFolder);

            // Assert
            Assert.Empty(pipeline.Folders[0].SubFolders);
        }

        [Fact]
        public void FolderCanCommand()
        {
            // Arrange
            Folder folder = new Folder("Folder 1");
            Command command = new Command("Command 1");

            // Act
            pipelineComposite.AddFolder(pipeline, folder);
            pipelineComposite.AddCommand(folder, command);

            // Assert
            Assert.Single(pipeline.Folders[0].Commands);
        }

        [Fact]
        public void SubFolderCanHaveCommand()
        {
            // Arrange
            Folder folder = new Folder("Folder 1");
            SubFolder subFolder = new SubFolder("SubFolder 1");
            Command command = new Command("Command 1");

            // Act
            pipelineComposite.AddFolder(pipeline, folder);
            pipelineComposite.AddSubFolder(folder, subFolder);
            pipeline.Folders[0].SubFolders[0].AddCommand(command);

            // Assert
            Assert.Single(pipeline.Folders[0].SubFolders[0].Commands);
            Assert.Equal("Command 1", pipeline.Folders[0].SubFolders[0].Commands[0].Name);
        }

        [Fact]
        public void CommandsCanBeVisited()
        {
            // Arrange
            Folder folder = new Folder("Folder 1");
            SubFolder subFolder = new SubFolder("SubFolder 1");
            Command command = new Command("Command 1");

            // Act
            pipelineComposite.AddFolder(pipeline, folder);
            pipelineComposite.AddCommand(folder, command);

            // Assert
            IVisitor visitor = new ConcreteVisitor();
            Assert.Equal("Command: Command 1", visitor.Visit(pipeline.Folders[0].Commands[0]));
        }

        [Fact]
        public void SubFoldersCanBeVisited()
        {
            // Arrange
            Folder folder = new Folder("Folder 1");
            SubFolder subFolder = new SubFolder("SubFolder 1");
            Command command = new Command("Command 1");

            // Act
            pipelineComposite.AddFolder(pipeline, folder);
            pipelineComposite.AddSubFolder(folder, subFolder);

            // Assert
            IVisitor visitor = new ConcreteVisitor();
            Assert.Equal("SubFolder: SubFolder 1", visitor.Visit(pipeline.Folders[0].SubFolders[0]));
        }
    }
}
