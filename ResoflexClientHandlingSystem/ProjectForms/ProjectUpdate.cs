using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using MySql.Data.MySqlClient;
using ResoflexClientHandlingSystem.Common;
using ResoflexClientHandlingSystem.Core;
using ResoflexClientHandlingSystem.Role;

namespace ResoflexClientHandlingSystem
{
    public partial class ProjectUpdate : MetroFramework.Forms.MetroForm
    {
        int projID;
        int clientID;
        DateTime install;
        DateTime firstTrainComp;
        DateTime secondTrainComp;
        DateTime warDate;
        int warPeriod;

        public ProjectUpdate(DateTime firstTrainComp, DateTime secondTrainComp, DateTime install, DateTime warDate, int warPeriod)
        {
            

            this.firstTrainComp = firstTrainComp;
            this.secondTrainComp = secondTrainComp;
            this.install = install;
            this.warDate = warDate;
            this.warPeriod = warPeriod;

            InitializeComponent();
        }

        public ProjectUpdate()
        {
            InitializeComponent();
        }

        private void ProjectUpdate_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlDataReader reader = DBConnection.getData("select proj_name from project");

                while (reader.Read())
                {
                    metroComboBox1.Items.Add(reader.GetValue(0).ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void metroLabel10_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            {
                string projname = metroComboBox1.Text;
                DateTime firstTran = firstTraCompDate.Value;
                DateTime secondTran = secoTraCompDate.Value;
                DateTime ins = installDate.Value;
                DateTime warSt = warStarDate.Value;
                int warPer = Int32.Parse(warrPerTxt.Text);

              
                try
                {

                    ResoflexClientHandlingSystem.Role.Project project = new Role.Project(projname, firstTran, secondTran, ins, warSt, warPer);

                    Database.updateProject(project);

                    MessageBox.Show("Project Updated Successfully!");
                    notifyIcon1.Icon = SystemIcons.Application;
                    notifyIcon1.BalloonTipText = "Project Updated!";
                    notifyIcon1.ShowBalloonTip(1000);

                }
                catch (Exception)
                {

                    MessageBox.Show("Error, Project not Updated!");


                }

            }
        }

        private void warStarDate_ValueChanged(object sender, EventArgs e)
        {


           
            DateTime warSt = warStarDate.Value;

            if (!Validation.isFuture(warSt))
            {
                MessageBox.Show("Invalid Date");
            }
           
        }

        private void firstTraCompDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime firstTran = firstTraCompDate.Value;


            if (Validation.isFuture(firstTran))
            {
                MessageBox.Show("Invalid Date");
            }

            
        }

        private void secoTraCompDate_ValueChanged(object sender, EventArgs e)
        {

            DateTime firstTran = firstTraCompDate.Value;
            DateTime secondTran = secoTraCompDate.Value;

            if (Validation.isFuture(secondTran))
            {
                MessageBox.Show("Invalid Date");
            }

            if (firstTraCompDate.Value > secoTraCompDate.Value)
            {
                MessageBox.Show("Second training complete date must be after the first training complete date");
            }
        }
    }

}