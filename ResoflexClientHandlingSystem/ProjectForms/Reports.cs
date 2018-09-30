using MySql.Data.MySqlClient;
using ResoflexClientHandlingSystem.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResoflexClientHandlingSystem.ProjectForms
{
    public partial class Reports : MetroFramework.Forms.MetroForm
    {


        public Reports()
        {
            InitializeComponent();

        }

        private void Reports_Load(object sender, EventArgs e)
        {
            MySqlDataReader reader = DBConnection.getData("select proj_name from project");

            while (reader.Read())
            {
                metroComboBox1.Items.Add(reader.GetValue(0).ToString());
            }

            reader.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string qry = "select p.proj_id , p.proj_name ,p.description , c.name ,p.first_init_date , p.warranty_start_date , p.warranty_period , count(e.event_id) as event_id, sum(a.amount) as amount from project p, client c, project_exp_in_amount a, event e where p.client_id=c.client_id and a.project_id=e.proj_id and a.project_id=p.proj_id and p.proj_id='" + metroTextBox1.Text.ToString()+"';";
            DataSet(qry);
        }



        private void DataSet(string qry)
        {
            DataTable table = new DataTable();
            MySqlDataReader reader;

            table.Columns.Add("proj_id", typeof(Int32));
            table.Columns.Add("proj_name", typeof(string));
            table.Columns.Add("description", typeof(string));
            table.Columns.Add("name", typeof(string));
            table.Columns.Add("first_init_date", typeof(DateTime));
            table.Columns.Add("warranty_start_date", typeof(DateTime));
            table.Columns.Add("warranty_period", typeof(int));
            table.Columns.Add("event_id", typeof(Int32));
            table.Columns.Add("amount", typeof(double));

            
            try
            {
                reader = DBConnection.getData(qry);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        table.Rows.Add(reader.GetInt32("proj_id"),reader.GetString("proj_name"), reader.GetString("description"), reader.GetString("name"), reader.GetDateTime("first_init_date"), reader.GetDateTime("warranty_start_date"), reader.GetInt32("warranty_period"), reader.GetInt32("event_id"), reader.GetDouble("amount"));
                    }

                }
                reader.Close();

                ProjectReports.ProjectRepot1 report = new ProjectReports.ProjectRepot1();

                report.Database.Tables["Project_1"].SetDataSource(table);

                crystalReportViewer1.ReportSource = null;
                crystalReportViewer1.ReportSource = report;


            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());

            }

        }


        //dataset 2

        private void DataSet2(string qry2)
        {
            DataTable table = new DataTable();
            MySqlDataReader reader;

          
            table.Columns.Add("proj_name", typeof(string));
            table.Columns.Add("in_date", typeof(DateTime));
            table.Columns.Add("amount", typeof(double));


            try
            {
                reader = DBConnection.getData(qry2);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        table.Rows.Add(reader.GetString("proj_name"),reader.GetDateTime("in_date"), reader.GetDouble("amount"));
                    }

                }
                reader.Close();

                ProjectReports.Proj_Exp report = new ProjectReports.Proj_Exp();

                report.Database.Tables["Proj_exp"].SetDataSource(table);
                

                crystalReportViewer1.ReportSource = null;
                crystalReportViewer1.ReportSource = report;


            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());

            }

        }



        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlDataReader reader = DBConnection.getData("select proj_id from project where proj_name='" + metroComboBox1.SelectedItem.ToString() + "';");

                while (reader.Read())
                {
                    metroTextBox1.Text = (reader.GetValue(0).ToString());
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            string dateFormat = "yyyy-MM-dd";


            string qry2 = "select p.proj_name,  a.in_date, a.amount from project p, project_exp_in_amount a where p.proj_id=a.project_id and a.in_date between '"+ metroDateTime1.Value.ToString(dateFormat) + "' and '"+ metroDateTime2.Value.ToString(dateFormat) + "' ";
            DataSet2(qry2);
        }
    }
}


   

