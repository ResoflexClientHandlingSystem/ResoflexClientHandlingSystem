using MySql.Data.MySqlClient;
using ResoflexClientHandlingSystem.Common;
using ResoflexClientHandlingSystem.Core;
using ResoflexClientHandlingSystem.Role;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResoflexClientHandlingSystem
{

    public partial class AddExpensesForm : MetroFramework.Forms.MetroForm
    {
        ExpenseType expType;
        Event eventOfExp;
        Project projectOfEvent;
        double amount;
        string comment;

        public AddExpensesForm()
        {
            InitializeComponent();

            fillExpensesTypeCmbBox();
        }

        public AddExpensesForm(int proj_id, int event_id)
        {
            InitializeComponent();

            eventID.Text = eventID.ToString();
            fillExpensesTypeCmbBox();
        }

        private void CategorySetupForm_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void ExpensesTypeComboBox(object sender, EventArgs e)
        {
            fillExpensesTypeCmbBox();
        }

        private void fillExpensesTypeCmbBox()
        {

            try
            {
                MySqlDataReader reader = DBConnection.getData("select exp_type_id, type from expense_type");

                DataTable dt = new DataTable();
                dt.Load(reader);

                expenseType.DataSource = dt;
                expenseType.ValueMember = "exp_type_id";
                expenseType.DisplayMember = "type";

                reader.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Error in filling the Staff comboBox!", "Expense_type Filler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
