using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class Staff_expenses:Expenses
    {
        private int staffID;
        private List<Attendance> attendnceList;
        private String staffExpType;

        public Staff_expenses()
        {
        }

        public Staff_expenses(int StaffID, String staffExpType, int expID, string type, double amount) : base(expID, type, amount)
        {
            this.staffExpType = staffExpType;
            staffID = StaffID;
        }

        public int StaffId { get => staffID; set => staffID = value; }
        //public string[] Attendance { get => attendance; set => attendance = value; }
    }


}
