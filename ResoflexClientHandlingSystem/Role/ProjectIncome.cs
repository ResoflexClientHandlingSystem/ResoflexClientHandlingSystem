using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class ProjectIncome
    {
        private int projectID;
        
        public ProjectIncome(){ }
        
        public ProjectIncome(int projectID)
        {
            projectID = ProjectID;
        }

        public int ProjectID { get => projectID; set => projectID = value; }
    }
}