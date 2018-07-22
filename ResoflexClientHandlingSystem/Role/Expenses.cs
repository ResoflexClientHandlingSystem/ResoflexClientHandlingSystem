using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class Expenses
    {
        private int expID;
        private string type;
        private double amount;
        
        public Expenses()
        {
        }

        public Expenses(int expID, string type, double amount)
        {
            ExpID = expID;
            Type = type;
            Amount = amount;
        }

        public int ExpID { get => expID; set => expID = value; }
        public string Type{ get => type; set => type = value; }
        public double Amount { get => amount; set => amount= value; }
    }
}
