using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avans_DevOps.Domain.Strategy_Pattern
{
    public class PdfStrategy : IExportStrategy
    {
        public void Export(SprintReport sprintReport)
        {
            //build a stringbuilder with the sprintreport data
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("-------------pdf---------------");
            sb.AppendLine("Company Name: " + sprintReport.CompanyName);
            sb.AppendLine("Logo: " + sprintReport.Logo);
            sb.AppendLine("Project Name: " + sprintReport.ProjectName);
            sb.AppendLine("Version: " + sprintReport.Version);
            sb.AppendLine("Date: " + sprintReport.Date);

            //get the string from the stringbuilder
            string sprintReportString = sb.ToString();
            Console.WriteLine(sprintReportString);
        }
    }
}
