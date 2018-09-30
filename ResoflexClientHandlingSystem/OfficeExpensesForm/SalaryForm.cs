using ResoflexClientHandlingSystem.Core;
using ResoflexClientHandlingSystem.Role;
using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResoflexClientHandlingSystem.OfficeExpenses;

namespace ResoflexClientHandlingSystem
{
    public partial class SalaryForm : MetroFramework.Forms.MetroForm
    {
        public SalaryForm()
        {
            InitializeComponent();

        }

        private void Sal_Load(object sender, EventArgs e)
        {


            try
            {
                MySqlDataReader reader = DBConnection.getData("select first_name from staff ");

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

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel11_Click(object sender, EventArgs e)
        {

        }
       

        private void empid_SelectedIndexChanged(object sender, EventArgs e)
        {
            getdata();
        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {


        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                double basicSal = Double.Parse(basicsal.Text.ToString());
                int Rate = Int32.Parse(rate.Text.ToString());
                int Hours = Int32.Parse(hours.Text.ToString());
                double Allowance = Double.Parse(allowance.Text.ToString());
                double deductions = Double.Parse(metroTextBox13.Text.ToString());
                double ep1 = double.Parse(metroTextBox1.Text.ToString());

                int otHrs = 0;

                if (Hours > 240)
                    otHrs = Hours % 240;

                double gross_sal = basicSal + Allowance +((double)Rate * otHrs);
                double gross = basicSal + Allowance;

                double net_sal = gross_sal - (deductions+ep1) ;


               
                netSal.Text = "" + net_sal;
                metroTextBox12.Text = "" + gross_sal;
              
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid informations to all fileds", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }


        public void getdata()
        {
            MySqlDataReader reader = DBConnection.getData("select * from staff where staff_id = " + empid.Text.ToString()+ ";");

            if (reader.Read())
            {

                basicsal.Text = reader.GetDouble("basic_salary").ToString();
                rate.Text = reader.GetDouble("ot_rate").ToString();
                /*hours.Text = reader.GetDouble("hours").ToString();
                days.Text = reader.GetDouble("days").ToString();
                allowance.Text = reader.GetDouble("allowance").ToString();
                etf.Text = reader.GetDouble("etf_epf_amount").ToString();*/

            }


            reader.Close();

            //string stdt = start.Value.ToString("yyyy-MM-dd");
            //string eddt = end.Value.ToString("yyyy-MM-dd");


            MySqlDataReader reader1 = DBConnection.getData("SELECT SUM(total_hours) as total_hours FROM attendance WHERE (in_time = 2018 - 08 - 08 <= 2018 - 08 - 10) and staff_id = " + empid.Text.ToString());

            if (reader1.Read())
            {
                hours.Text = reader1.GetDouble("total_hours").ToString();
            }

            reader1.Close();

            //MySqlDataReader rdr = DBConnection.getData("select in_time, out_time attendance where staff_id = " + empid.SelectedValue + ";");


        }




        /*
                private void metroButton2_Click(object sender, EventArgs e)
                /*{
                    O= new PaidForm();
                    p.Show();
                }*/

        private void empid_SelectedIndexChanged_1(object sender, EventArgs e)
        {

           

            
        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void EndDatetime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel11_Click_1(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            ResoflexClientHandlingSystem.Role.Salary sal = new ResoflexClientHandlingSystem.Role.Salary();

            sal.Empid = int.Parse(empid.Text.ToString());
            sal.BasicSalAmount = double.Parse(basicsal.Text.ToString());
            sal.Rate = int.Parse(rate.Text.ToString());

            int hrs = int.Parse(hours.Text.ToString());

            if (hrs > 240)
            {
                double temp = hrs - 240;

                temp = temp * sal.Rate;

                temp = temp + int.Parse(allowance.Text.ToString());

                temp = sal.BasicSalAmount + temp;

                sal.Gross = temp;

               // sal.Net = temp - double.Parse(epf.Text.ToString());
            }
            else
            {
                sal.Gross = sal.BasicSalAmount + int.Parse(allowance.Text.ToString());

              //  sal.Net = sal.BasicSalAmount - double.Parse(epf.Text.ToString());
            }


            sal.Hours = new Attendance(hrs);
            sal.Allowance = float.Parse(allowance.Text.ToString());
            sal.EtfEpf = double.Parse(metroTextBox1.Text.ToString());
            sal.Net = double.Parse(netSal.Text.ToString());

            Database.addSalary(sal);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

            Paid pay = new Paid();
            this.Hide();
            pay.Show();

        }

        private void metroLabel15_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            try
            {
                double basicSal = Double.Parse(basicsal.Text.ToString());
                double Allowance = Double.Parse(allowance.Text.ToString());

                double balall = basicSal + Allowance;
                double epf = (balall * 8 / 100); // deduc
                double etf = (balall * 3 / 100); //from gov


                metroTextBox1.Text = "" + epf;
                metroTextBox2.Text = "" + etf;
            }
            catch
            {

            }
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void allowance_Click(object sender, EventArgs e)
        {

        }

        private void allowance_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double basicSal = Double.Parse(basicsal.Text.ToString());
                double Allowance = Double.Parse(allowance.Text.ToString());

                double balall = basicSal + Allowance;
                double epf = (basicSal * 8 / 100); // deduc
                double etf = (basicSal * 3 / 100); //from gov


                metroTextBox1.Text = "" + epf;
                metroTextBox2.Text = "" + etf;
            }catch (FormatException)
            {
                MessageBox.Show("Please enter valid number for Allowances","Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroButton3_Click_1(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlDataReader reader = DBConnection.getData("select staff_id from staff where first_name='" + metroComboBox1.SelectedItem.ToString() + "';");

                while (reader.Read())
                {
                    empid.Text = (reader.GetValue(0).ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

            try
            {
                MySqlDataReader reader = DBConnection.getData("select staff_id from staff where first_name='" + metroComboBox1.SelectedItem.ToString() + "';");

                while (reader.Read())
                {
                    empid.Text = (reader.GetValue(0).ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }


            //geting basic salary
            try
            {
                MySqlDataReader reader = DBConnection.getData("select basic_salary from staff where staff_id= '"+empid.Text.ToString()+"'");

                while (reader.Read())
                {

                    basicsal.Text = (reader.GetValue(0).ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

            //geting total hours
            DateTime curdate = DateTime.Now;
            curdate = curdate.AddDays(-30);
            string a = DateTime.Now.ToString("yyyy-MM-dd");
            string b = curdate.ToString("yyyy-MM-dd");

            Console.WriteLine("\n\n" + b + "\n\n");
            Console.WriteLine("\n\n" +a+ "\n\n");
            try
            {
                MySqlDataReader reader = DBConnection.getData("select sum(total_hours) from attendance where out_time between '"+b+"'  and '"+a+"' and staff_id='" + empid.Text.ToString()+"'");

                while (reader.Read())
                {

                    hours.Text = (reader.GetValue(0).ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }



            //geting ot rate
            try
            {
                MySqlDataReader reader = DBConnection.getData("select ot_rate from staff where staff_id='" + empid.Text.ToString() + "'");

                while (reader.Read())
                {

                    rate.Text = (reader.GetValue(0).ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}

    