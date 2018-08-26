using MySql.Data.MySqlClient;
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
    public partial class CashIssuingForm : MetroFramework.Forms.MetroForm


    {

        private Project projectOfIou;
        private Schedule scheduleOfIou;
        private DateTime date;
        private float amount;
        private string detail;


        public CashIssuingForm()
        {
            InitializeComponent();


        }

        public CashIssuingForm(Project projectOfIou, Schedule scheduleOfIou, DateTime date, float amount, string detail)
        {
            InitializeComponent();
            this.projectOfIou = projectOfIou;
            this.scheduleOfIou = scheduleOfIou;
            this.date = date;
            this.amount = amount;
            this.detail = detail;
        }

        private void CashIssuingForm_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
           

            DateTime date = cashDateTimeTxtBox.Value;
            float amount = float.Parse(amountTxtBox.Text);

    }


        private void staffNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillstaffCmbBox();
            string staffName = staffNameComboBox.SelectedItem.ToString();
            staffNameComboBox.SelectedIndex = 1;

        }


        private void fillstaffCmbBox()
            {
                staffNameComboBox.Items.Clear();

                try
                {
                    MySqlDataReader reader = DBConnection.getData("select staff_id, name from staff");

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            staffNameComboBox.Items.Add(reader.GetString("name"));
                        }
                    }

                    reader.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error in filling the Staff comboBox!", "staff Filler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            


        }

       
    }
}
