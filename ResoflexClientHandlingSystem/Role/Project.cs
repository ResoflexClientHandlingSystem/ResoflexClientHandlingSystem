using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class Project
    {
        private int projectID;
        private string projectName;
        private int clientID;
        private string projectType;
        private int project_subID;
        private DateTime firstInitDate;
        private DateTime tEndDate1;
        private DateTime tEndDate2;
        private DateTime warrantyStart;
        private DateTime warrantyEnd;
        private string supportTerms;
        private string warrantyTerms;
        private int noOfVisits;
        
        public Project()
        {

        }

        public Project(int projectID, string projectName, int clientID, string projectType, int project_subID, DateTime firstInitDate, DateTime tEndDate1, DateTime tEndDate2, DateTime warrantyStart, DateTime warrantyEnd, string supportTerms, string warrantyTerms, int noOfVisits)
        {
            this.projectID = projectID;
            this.projectName = projectName;
            this.clientID = clientID;
            this.projectType = projectType;
            this.project_subID = project_subID;
            this.firstInitDate = firstInitDate;
            this.tEndDate1 = tEndDate1;
            this.tEndDate2 = tEndDate2;
            this.warrantyStart = warrantyStart;
            this.warrantyEnd = warrantyEnd;
            this.supportTerms = supportTerms;
            this.warrantyTerms = warrantyTerms;
            this.noOfVisits = noOfVisits;
        }
    }
}