using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    public class Project
    {
        private int projectID;
        private string projectName;
        private string projectdesc;
        private Client clientOfProject;
        private int projectSubID;
        private DateTime firstInitDate;
        private DateTime tEndDate1;
        private DateTime tEndDate2;
        private DateTime warrantyStart;
        private int warrantyPeriod;
        private string supportTerms;
        private string warrantyTerms;
        private string visitTerms;
        private int proj_id;

        public Project(int projectID, string projectName, string projectdesc, Client ClientOfProject, int projectSubID, DateTime firstInitDate, DateTime tEndDate1, DateTime tEndDate2, DateTime warrantyStart, int warrantyPeriod, string supportTerms, string warrantyTerms, string visitTerms)
        {
            this.ProjectID = projectID;
            this.ProjectName = projectName;
            this.Projectdesc = projectdesc;
            this.ClientOfProject = ClientOfProject;
            this.ProjectSubID = projectSubID;
            this.FirstInitDate = firstInitDate;
            this.TEndDate1 = tEndDate1;
            this.TEndDate2 = tEndDate2;
            this.WarrantyStart = warrantyStart;
            this.WarrantyPeriod = warrantyPeriod;
            this.SupportTerms = supportTerms;
            this.WarrantyTerms = warrantyTerms;
            this.VisitTerms = visitTerms;
        }

        public Project(string projectName, string projectdesc, Client ClientOfProject, int projectSubID, string supportTerms, string warrantyTerms, string visitTerms)
        {
            this.ProjectName = projectName;
            this.Projectdesc = projectdesc;
            this.ClientOfProject = ClientOfProject;
            this.ProjectSubID = projectSubID;
            this.SupportTerms = supportTerms;
            this.WarrantyTerms = warrantyTerms;
            this.VisitTerms = visitTerms;
        }

        public Project(DateTime tEndDate1, DateTime tEndDate2, DateTime firstInitDate, DateTime warrantyStart, int warrantyPeriod)
        {
            this.TEndDate1 = tEndDate1;
            this.TEndDate2 = tEndDate2;
            this.FirstInitDate = firstInitDate;
            this.WarrantyStart = warrantyStart;
            this.WarrantyPeriod = warrantyPeriod;
        }

        public Project(int proj_id)
        {
            this.ProjectID = proj_id;
        }

        public int ProjectID { get => projectID; set => projectID = value; }
        public string ProjectName { get => projectName; set => projectName = value; }
        public string Projectdesc { get => projectdesc; set => projectdesc = value; }
        public Client ClientOfProject { get => clientOfProject; set => clientOfProject = value; }
        public int ProjectSubID { get => projectSubID; set => projectSubID = value; }
        public DateTime FirstInitDate { get => firstInitDate; set => firstInitDate = value; }
        public DateTime TEndDate1 { get => tEndDate1; set => tEndDate1 = value; }
        public DateTime TEndDate2 { get => tEndDate2; set => tEndDate2 = value; }
        public DateTime WarrantyStart { get => warrantyStart; set => warrantyStart = value; }
        public int WarrantyPeriod { get => warrantyPeriod; set => warrantyPeriod = value; }
        public string SupportTerms { get => supportTerms; set => supportTerms = value; }
        public string WarrantyTerms { get => warrantyTerms; set => warrantyTerms = value; }
        public string VisitTerms { get => visitTerms; set => visitTerms = value; }
    }
}