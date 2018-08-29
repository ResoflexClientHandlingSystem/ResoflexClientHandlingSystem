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

         Project projectOfSchedule;
         Schedule scheduleOfIou;
           float amount;
       string Comment;
        private object projectID;

        public CashIssuingForm()
        {
            InitializeComponent();
            iouIdDisplay();

        }


        public CashIssuingForm(Project projectOfIou, Schedule scheduleOfIou)
        {
            InitializeComponent();
            iouIdDisplay();


        }

        private void CashIssuingForm_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ExpenseDetailSchedule ed = new ExpenseDetailSchedule();


            ed.ScheduleOfExp = new Schedule(int.Parse(scheduleId.Text.ToString()));
            ed.ProjectOfSchedule = new Project(int.Parse(projectIdBox.Text.ToString()));
            ed.Amount = float.Parse(amountTxtBox.Text);
            ed.Comment = details.Text.ToString();


            Database.CashIssue(ed);



    }

        public void iouIdDisplay()
        {
            MySqlDataReader r = DBConnection.getData("select iou_id from iou order by iou_id desc ");
            r.Read();
            iouIdBox.Text = (r.GetInt16("iou_id") + 1).ToString();


            r.Close();

        }


        /* private void staffNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
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
         */

    }
}
