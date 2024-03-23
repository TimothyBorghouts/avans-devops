using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avans_DevOps.Domain.Strategy_Pattern
{
    public class PngStrategy : IExportStrategy
    {
        public void Export(SprintReport sprintReport)
        {
            //build a stringbuilder with the sprintreport data
            //StringBuilder sb = new StringBuilder();
            //sb.AppendLine("-------------png---------------");
            //sb.AppendLine("Company Name: " + sprintReport.companyName);
            //sb.AppendLine("Logo: " + sprintReport.logo);
            //sb.AppendLine("Project Name: " + sprintReport.projectName);
            //sb.AppendLine("Version: " + sprintReport.version);
            //sb.AppendLine("Date: " + sprintReport.date);

            //get the string from the stringbuilder
            //string sprintReportString = sb.ToString();
            //Console.WriteLine(sprintReportString);
        }
    }
}
