using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avans_DevOps.Domain.ObserverPattern
{
    public interface INotificationListener
    {
        public void Update(string message);
    }
}
