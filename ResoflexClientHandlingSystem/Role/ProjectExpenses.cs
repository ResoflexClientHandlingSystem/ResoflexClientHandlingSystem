using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class Project_Expenses:Expenses
    {
        private int projectID;
        private int eventID;
        private string category;

        public Project_Expenses(int ProjectID,int EventID,string Category, int expID, string type, double amount) :base(expID, type, amount) {

            projectID = ProjectID;
            eventID = EventID;
            category = Category;
        }

        public int ProjectID { get => projectID; set => projectID = value; }
        public int EventID { get => eventID; set => eventID = value; }
        public string Category { get => category; set => category= value; }
    }
}
