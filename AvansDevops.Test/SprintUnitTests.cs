using Avans_DevOps.Domain.Factory_Pattern;
using Avans_DevOps.Domain.Sprint;
using Avans_DevOps.Domain.Strategy_Pattern;

namespace AvansDevops.Test
{
    public class SprintUnitTests
    {
        SprintFactory sprintFactory = new SprintFactory();

        [Fact]
        public void CanCreateFeedackSprint()
        {
            // Arrange
            string sprintType = "Feedback";
            string name = "Sprint 1";
            DateTime startDate = new DateTime(2024, 1, 1);
            DateTime endDate = new DateTime(2024, 3, 30);

            // Act
            var sprint = sprintFactory.CreateSprint(sprintType, name, startDate, endDate);

            // Assert
            Assert.IsType<FeedbackSprint>(sprint);
        }

        [Fact]
        public void CanCreateReleaseSprint()
        {
            // Arrange
            string sprintType = "Release";
            string name = "Sprint 2";
            DateTime startDate = new DateTime(2024, 3, 1);
            DateTime endDate = new DateTime(2024, 6, 30);

            // Act
            var sprint = sprintFactory.CreateSprint(sprintType, name, startDate, endDate);

            // Assert
            Assert.IsType<ReleaseSprint>(sprint);
        }

        [Fact]
        public void CanExportSprintReport()
        {
            // Arrange
            string sprintType = "Feedback";
            string name = "Sprint 1";
            DateTime startDate = new DateTime(2024, 1, 1);
            DateTime endDate = new DateTime(2024, 3, 30);
            string companyName = "Avans";
            string logo = "logo.png";
            string projectName = "DevOps";
            string version = "1.0";
            DateTime date = new DateTime(2024, 3, 30);

            // Act
            var sprint = sprintFactory.CreateSprint(sprintType, name, startDate, endDate);
            sprint.ExportSprintReport(companyName, logo, projectName, version, date, new PdfStrategy());

            // Assert
            Assert.True(true);
        }
    }
}
