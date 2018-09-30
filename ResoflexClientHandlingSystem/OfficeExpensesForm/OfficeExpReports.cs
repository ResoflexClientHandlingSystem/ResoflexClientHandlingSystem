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

namespace ResoflexClientHandlingSystem.OfficeExpensesForm
{
    public partial class OfficeExpReports : MetroFramework.Forms.MetroForm
    {
        public OfficeExpReports()
        {
            InitializeComponent();
        }

        private void OfficeExpReports_Load(object sender, EventArgs e)
        {


            MySqlDataReader reader = DBConnection.getData("select first_name from staff");

            while (reader.Read())
            {
                metroComboBox1.Items.Add(reader.GetValue(0).ToString());
            }

            reader.Close();

        }


        //user ID to textbox
        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlDataReader reader = DBConnection.getData("select staff_id from staff where first_name='" + metroComboBox1.SelectedItem.ToString() + "';");

                while (reader.Read())
                {
                    metroTextBox1.Text = (reader.GetValue(0).ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void metroButton1_Click(object sender, EventArgs e)
        {
            string dateFormat = "yyyy-MM-dd";
            string qry = "select e.date, s.first_name, e.Category,e.amount from office_expenses e, staff s where s.staff_id=e.staff_id and type='Direct' and date between '"+ metroDateTime1.Value.ToString(dateFormat) + "'  and '" + metroDateTime2.Value.ToString(dateFormat) + "';";
            DataSet(qry);
            
            Console.WriteLine("Hello '"+ metroDateTime2.Value.ToString(dateFormat) + "'");
        }


        //direct
        private void DataSet(string qry)
        {
            DataTable table = new DataTable();
            MySqlDataReader reader;

            table.Columns.Add("date", typeof(DateTime));
            table.Columns.Add("first_name", typeof(string));
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("amount", typeof(double));


            try
            {
                reader = DBConnection.getData(qry);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        table.Rows.Add( reader.GetDateTime("date"), reader.GetString("first_name"), reader.GetString("Category"), reader.GetDouble("amount"));
                    }

                }
                reader.Close();

                OfficeExpensesForm.Reports.OfficeDirExp report = new Reports.OfficeDirExp();

                report.Database.Tables["OffDirect"].SetDataSource(table);
                

                crystalReportViewer1.ReportSource = null;
                crystalReportViewer1.ReportSource = report;


            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());

            }

        }

        //IOU
        private void DataSet2(string qry)
        {
            DataTable table = new DataTable();
            MySqlDataReader reader;

            table.Columns.Add("date", typeof(DateTime));
            table.Columns.Add("first_name", typeof(string));
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("amount", typeof(double));


            try
            {
                reader = DBConnection.getData(qry);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        table.Rows.Add(reader.GetDateTime("date"), reader.GetString("first_name"), reader.GetString("Category"), reader.GetDouble("amount"));
                    }

                }
                reader.Close();

                OfficeExpensesForm.Reports.OfficeIOUExp report = new Reports.OfficeIOUExp();

                report.Database.Tables["OffDirect"].SetDataSource(table);


                crystalReportViewer1.ReportSource = null;
                crystalReportViewer1.ReportSource = report;


            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());

            }

        }



        //salary monthly
        private void DataSet3(string qry)
        {
            DataTable table = new DataTable();
            MySqlDataReader reader;

            
            table.Columns.Add("first_name", typeof(string));
            table.Columns.Add("basic_sal_amount", typeof(double));
            table.Columns.Add("allowance", typeof(double));
            table.Columns.Add("etf_epf_amount", typeof(double));
            table.Columns.Add("rate", typeof(int));
            table.Columns.Add("hours", typeof(int));
            table.Columns.Add("sal_date", typeof(DateTime));
            table.Columns.Add("gross_sal", typeof(double));
            table.Columns.Add("net_sal", typeof(double));



            try
            {
                reader = DBConnection.getData(qry);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        table.Rows.Add(reader.GetString("first_name"), reader.GetDouble("basic_sal_amount"), reader.GetDouble("allowance"), reader.GetDouble("etf_epf_amount"), reader.GetInt32("rate"), reader.GetInt32("hours"), reader.GetDateTime("sal_date"), reader.GetDouble("gross_sal"), reader.GetDouble("net_sal"));
                    }

                }
                reader.Close();

                OfficeExpensesForm.Reports.SalByMonth report = new Reports.SalByMonth();

                report.Database.Tables["Sal"].SetDataSource(table);


                crystalReportViewer1.ReportSource = null;
                crystalReportViewer1.ReportSource = report;


            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());

            }

        }


        //salary employee
        private void DataSet4(string qry)
        {
            DataTable table = new DataTable();
            MySqlDataReader reader;


            table.Columns.Add("first_name", typeof(string));
            table.Columns.Add("basic_sal_amount", typeof(double));
            table.Columns.Add("allowance", typeof(double));
            table.Columns.Add("etf_epf_amount", typeof(double));
            table.Columns.Add("rate", typeof(int));
            table.Columns.Add("hours", typeof(int));
            table.Columns.Add("sal_date", typeof(DateTime));
            table.Columns.Add("gross_sal", typeof(double));
            table.Columns.Add("net_sal", typeof(double));



            try
            {
                reader = DBConnection.getData(qry);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        table.Rows.Add(reader.GetString("first_name"), reader.GetDouble("basic_sal_amount"), reader.GetDouble("allowance"), reader.GetDouble("etf_epf_amount"), reader.GetInt32("rate"), reader.GetInt32("hours"), reader.GetDateTime("sal_date"), reader.GetDouble("gross_sal"), reader.GetDouble("net_sal"));
                    }

                }
                reader.Close();

                OfficeExpensesForm.Reports.SalbyEmp report = new Reports.SalbyEmp();

                report.Database.Tables["Sal"].SetDataSource(table);


                crystalReportViewer1.ReportSource = null;
                crystalReportViewer1.ReportSource = report;


            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());

            }

        }



        private void metroButton2_Click(object sender, EventArgs e)
        {
            string dateFormat = "yyyy-MM-dd";
            string qry = "select e.date, s.first_name, e.Category,e.amount from office_expenses e, staff s where s.staff_id=e.staff_id and type='IOU' and date between '" + metroDateTime1.Value.ToString(dateFormat) + "'  and '" + metroDateTime2.Value.ToString(dateFormat) + "';";
            DataSet2(qry);
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            string dateFormat = "yyyy-MM-dd";
            string qry = "select t.first_name, s.basic_sal_amount , s.allowance , s.etf_epf_amount , s.rate ,s.hours ,   s.sal_date, s.gross_sal , s.net_sal  from salary s , staff t where s.staff_id=t.staff_id and s.sal_date between '" + metroDateTime4.Value.ToString(dateFormat) + "' and '" + metroDateTime3.Value.ToString(dateFormat) + "';";
            DataSet3(qry);
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

            
            string qry = "select t.first_name, s.sal_date, s.basic_sal_amount , s.allowance , s.etf_epf_amount , s.rate ,s.hours ,s.gross_sal , s.net_sal   from salary s , staff t where s.staff_id=t.staff_id and s.staff_id='"+metroTextBox1.Text.ToString()+"'";
            DataSet4(qry);


            
        }
    }
}
