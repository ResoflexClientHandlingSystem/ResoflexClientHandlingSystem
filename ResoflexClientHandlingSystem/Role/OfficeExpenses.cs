using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class Office_Expenses:Expenses
    {
        private int oExp;
        private string department;
       
        public Office_Expenses(int OExp,string Department, int expID, string type, double amount) :base(expID,type,amount)
        {
            oExp = OExp;
            department = Department;
        }

        public int OExp { get => oExp; set => oExp = value; }
        public string Department { get => department; set => department = value; }
    }
}
