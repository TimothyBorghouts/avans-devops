using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avans_DevOps.Domain.Strategy_Pattern
{
    public interface IExportStrategy
    {
        public void Export(SprintReport sprintReport);
    }
}
