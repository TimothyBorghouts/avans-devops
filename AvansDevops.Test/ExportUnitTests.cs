using Avans_DevOps.Domain.Strategy_Pattern;
using Avans_DevOps.Domain.Users;

namespace AvansDevops.Test
{
    public class ExportUnitTests
    {
        SprintReport sprintReport = new SprintReport("Avans", "AvansLogo", "DevOps", "1.0", DateTime.Now.Date);
        
        [Fact]
        public void CanMakeSprintReport()
        {
            // Arrange

            // Act

            // Assert
            Assert.NotNull(sprintReport);
            Assert.Equal("Avans", sprintReport.CompanyName);
            Assert.Equal("AvansLogo", sprintReport.Logo);
            Assert.Equal("DevOps", sprintReport.ProjectName);
            Assert.Equal("1.0", sprintReport.Version);
            Assert.Equal(DateTime.Now.Date, sprintReport.Date);
        }

        [Fact]
        public void CanAddTeamMember()
        {
            // Arrange
            User user = new Developer("John", "joedoe@mail.com", "mail");
            
            // Act
            sprintReport.AddTeamMember(user);

            // Assert
            Assert.Single(sprintReport.team);
        }

        [Fact]
        public void CanSetPdfStrategy()
        {
            // Arrange
            IExportStrategy exportStrategy = new PdfStrategy();
            
            // Act
            sprintReport.SetStrategy(exportStrategy);

            // Assert
            Assert.NotNull(sprintReport.ExportStrategy);
        }

        [Fact]
        public void CanSetPngStrategy()
        {
            // Arrange
            IExportStrategy exportStrategy = new PngStrategy();
            
            // Act
            sprintReport.SetStrategy(exportStrategy);

            // Assert
            Assert.NotNull(sprintReport.ExportStrategy);
        }

        [Fact]
        public void CanExportPdf()
        {
            // Arrange
            IExportStrategy exportStrategy = new PdfStrategy();
            sprintReport.SetStrategy(exportStrategy);
            
            // Act
            sprintReport.Export();

            // Assert
            Assert.NotNull(sprintReport.ExportStrategy);
        }

        [Fact]
        public void CanExportPng()
        {
            // Arrange
            IExportStrategy exportStrategy = new PngStrategy();
            sprintReport.SetStrategy(exportStrategy);
            
            // Act
            sprintReport.Export();

            // Assert
            Assert.NotNull(sprintReport.ExportStrategy);
        }
    }
}
