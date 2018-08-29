using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class ExpenseDetailSchedule
    {
        private ExpenseType expType;
        private Schedule scheduleOfExp;
        private Project projectOfSchedule;
        private double amount;
        private string comment;

        public ExpenseDetailSchedule()
        {
        }
        public ExpenseDetailSchedule(ExpenseType expType, Schedule scheduleOfExp, Project projectOfSchedule, double amount, string comment)
        {
            this.expType = expType;
            this.scheduleOfExp = scheduleOfExp;
            this.projectOfSchedule = projectOfSchedule;
            this.amount = amount;
            this.comment = comment;
        }
        
        public Project ProjectOfSchedule { get => projectOfSchedule; set => projectOfSchedule = value; }
        public double Amount { get => amount; set => amount = value; }
        public string Comment { get => comment; set => comment = value; }
       internal ExpenseType ExpType { get => expType; set => expType = value; }

        internal Schedule ScheduleOfExp { get => scheduleOfExp; set => scheduleOfExp = value; }


    }
}
