using Avans_DevOps.Domain.States.FeedbackSprintStates;
using Avans_DevOps.Domain.Strategy_Pattern;
using Avans_DevOps.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avans_DevOps.Domain.Sprint
{
    public abstract class Sprint
    {
        private string Name { get; set; }
        private DateTime StartDate { get; set; }
        private DateTime EndDate { get; set; }
        private List<BacklogItem> BacklogItems { get; set; }

        public Sprint(string name, DateTime startDate, DateTime endDate)
        {
            this.Name = name;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        public void ExportSprintReport(string companyName, string logo, string projectName, string version, DateTime date, IExportStrategy exportStrategy)
        {
            SprintReport sprintReport = new SprintReport(companyName, logo, projectName, version, date);
            sprintReport.SetStrategy(exportStrategy);
            sprintReport.Export();
        }
    }
}
