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

namespace ResoflexClientHandlingSystem.OfficeExpensesForm
{
    public partial class OfficeExpensesMainForm : MetroFramework.Forms.MetroForm
    {
        public OfficeExpensesMainForm()
        {
            InitializeComponent();
        }

        private void OfficeExpensesMainForm_Load(object sender, EventArgs e)
        {
            metroGrid1.DataSource = maingrid();
            fillTiles();
            if (Userglobals.uname == "")
            {
                profilebtn.Visible = false;
            }
            else
            {
                profilebtn.Visible = true;
                profilebtn.Text = Userglobals.uname;
            }

            metroGrid1.Columns[0].Visible = false;
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

        }


        private DataTable maingrid()
        {
            DataTable table = new DataTable();

            MySqlDataReader reader = DBConnection.getData("select o.off_exp_id, s.first_name as Employee, o.date as Date, o.type as Type ,o.Category as Category, o.amount as Amount from office_expenses o, staff s where s.staff_id=o.staff_id order by o.off_exp_id desc limit 10");

            table.Load(reader);
            
            return table;
        }


        //tiles
        private void fillTiles()
        {
            try
            {

                MySqlDataReader reader = DBConnection.getData("select IFNULL(SUM(amount), 0) from office_expenses ");

                while (reader.Read())
                {
                    tile1.Text = "Rs." + reader.GetDouble(0);
                }

                reader.Close();

                reader = DBConnection.getData("select IFNULL(SUM(amount), 0) from office_expenses where  type='Direct'");

                while (reader.Read())
                {
                    tile2.Text = "Rs." + reader.GetDouble(0);
                }

                reader.Close();

                reader = DBConnection.getData("select IFNULL(MAX(amount), 0) from office_expenses ");

                while (reader.Read())
                {
                    tile3.Text = (reader.GetValue(0).ToString());
                }

                reader.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }


        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            OfficeExpenses.CashPaymentForm rfm = new OfficeExpenses.CashPaymentForm();
            rfm.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            IOUMain frm = new IOUMain();
            frm.ShowDialog();
           
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            OfficeExpensesForm.SalaryMain frm = new OfficeExpensesForm.SalaryMain();
            frm.Show();
        }



        //search
        private void searchProjectTxtBox_TextChanged(object sender, EventArgs e)
        {

            string qry = "";
            string projectNameTxt = searchProjectTxtBox.Text;


            qry = "Select p.type, p.date, p.Category,p.amount, s.first_name from office_expenses p inner join staff s on s.staff_id=p.staff_id where s.first_name like '%" + projectNameTxt + "%' or p.Category like '%" + projectNameTxt + "%'";

            try
            {
                MySqlDataReader reader = DBConnection.getData(qry);

                if (reader.HasRows)
                {
                    System.Data.DataTable table1 = new System.Data.DataTable();

                    table1.Load(reader);

                    metroGrid1.DataSource = table1;
                }
                else
                {
                    reader.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Invalid data!\n" + exc.StackTrace, "Project finder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Dashboard frm = new Dashboard();
            this.Hide();
            frm.ShowDialog();
            this.Close();

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            OfficeExpensesForm.OfficeExpReports rpt = new OfficeExpReports();
            rpt.Show();
        }
    }
}
 