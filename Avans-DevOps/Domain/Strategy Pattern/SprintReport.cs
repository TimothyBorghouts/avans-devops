using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Avans_DevOps.Domain.Users;

namespace Avans_DevOps.Domain.Strategy_Pattern
{
    public class SprintReport
    {
        public IExportStrategy ExportStrategy = null!;
        public List<User> team = new List<User>();
        public string CompanyName { get; set;}
        public string Logo { get; set; }
        public string ProjectName { get; set; }
        public string Version { get; set; }
        public DateTime Date { get; set; }


        public SprintReport(string companyName, string logo, string projectName, string version, DateTime Date)
        {
            this.CompanyName = companyName;
            this.Logo = logo;
            this.ProjectName = projectName;
            this.Version = version;
            this.Date = Date;
        }

        public void Export()
        {
            ExportStrategy.Export(this);
        }

        public void SetStrategy(IExportStrategy exportStrategy)
        {
            ExportStrategy = exportStrategy;
        }
    }
}
