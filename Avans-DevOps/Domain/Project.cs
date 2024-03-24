using Avans_DevOps.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Avans_DevOps.Domain.Forum;


namespace Avans_DevOps.Domain
{
    public class Project
    {
        private string Name { get; set; }
        private ProductBacklog productBacklog { get; set; }
        //private Forum forum { get; set; }

        private List<Pipeline> pipelines { get; set; }

        private ScrumMaster scrumMaster { get; set; }
        private ProductOwner productOwner { get; set; }
        private List<Developer> developers { get; set; }    
        private List<Tester> testers { get; set; }


        public Project(string name, ProductBacklog productBacklog, ScrumMaster scrumMaster, ProductOwner productOwner, List<Developer> developers, List<Tester> testers)
        {
            Name = name;
            this.productBacklog = productBacklog;
            this.scrumMaster = scrumMaster;
            this.productOwner = productOwner;
            this.developers = developers;
            this.testers = testers;
        }

        //public void AddSprint(Sprint sprint)
        //{
        //    sprints.Add(sprint);
        //}

        public void AddPipeline(Pipeline pipeline)
        {
            pipelines.Add(pipeline);
        }
    }
}
