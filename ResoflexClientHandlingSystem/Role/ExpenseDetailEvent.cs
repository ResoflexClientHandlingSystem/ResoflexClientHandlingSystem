using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    public class ExpenseDetailEvent
    {
        private ExpenseType expType;
        private Event eventOfExp;
        private Project projectOfEvent;
        private double amount;
        private string comment;
        private string paymentType;

        public ExpenseDetailEvent()
        {

        }

        public ExpenseDetailEvent(ExpenseType expType, Event eventOfExp, Project projectOfEvent, double amount, string comment, string paymentType)
        {
            this.ExpType = expType;
            this.EventOfExp = eventOfExp;
            this.ProjectOfEvent = projectOfEvent;
            this.Amount = amount;
            this.Comment = comment;
            this.PaymentType = paymentType;
        }

        public Project ProjectOfEvent { get => projectOfEvent; set => projectOfEvent = value; }
        public double Amount { get => amount; set => amount = value; }
        public string Comment { get => comment; set => comment = value; }
        public string PaymentType { get => paymentType; set => paymentType = value; }
        internal ExpenseType ExpType { get => expType; set => expType = value; }
        internal Event EventOfExp { get => eventOfExp; set => eventOfExp = value; }
    }
}
