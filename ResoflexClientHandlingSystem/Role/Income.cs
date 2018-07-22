using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class Income
    {
        private int incomeID;
        private double amount;
        private string type;
        private ProjectIncome[] pIncome;
        
        public Income()
        {
        }

        public Income(int incomeID, double amount, string type)
        {
            IncomeID = incomeID;
            Amount = amount;
            Type = type;
        }

        public int IncomeID { get => incomeID; set => incomeID = value; }
        public double Amount { get => amount; set => amount = value; }
        public string Type { get => type; set => type = value; }
    }
}