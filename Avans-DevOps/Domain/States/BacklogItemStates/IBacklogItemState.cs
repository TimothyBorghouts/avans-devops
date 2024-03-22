using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avans_DevOps.Domain.States.BacklogItemStates
{
    public interface IBacklogItemState
    {
        public void SetToDo();
        public void SetDoing();
        public void SetReadyForTesting();
        public void SetTesting();
        public void SetTested();
        public void SetDone();
    }
}
