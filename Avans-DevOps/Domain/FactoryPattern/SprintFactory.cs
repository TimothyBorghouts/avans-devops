

using Avans_DevOps.Domain.Sprint;

namespace Avans_DevOps.Domain.Factory_Pattern
{
    public class SprintFactory
    {
        public Domain.Sprint.Sprint CreateSprint(string sprintType, string name, DateTime startDate, DateTime endDate)
        {
            Domain.Sprint.Sprint sprint = null;

            if (sprintType == "Feedback")
            {
                sprint = new FeedbackSprint(name, startDate, endDate);
            }
            else if (sprintType == "Release")
            {
                sprint = new ReleaseSprint(name, startDate, endDate);
            }

            return sprint;
        }
    }
}
