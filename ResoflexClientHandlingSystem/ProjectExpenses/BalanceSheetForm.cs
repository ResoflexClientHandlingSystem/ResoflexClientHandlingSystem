using System;
using ResoflexClientHandlingSystem.Core;
using MySql.Data.MySqlClient;
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
    public partial class BalanceSheetForm : MetroFramework.Forms.MetroForm
    {
        DataTable bSheet = new DataTable();

        public BalanceSheetForm()
        {
            InitializeComponent();

           // projectNameDisplay();
            //eventDisplay();

            bSheet.Columns.Add("In_Date",typeof(DateTime));
            bSheet.Columns.Add("In_Amount", typeof(double));
            bSheet.Columns.Add("Out_Type", typeof(string));
            bSheet.Columns.Add("Out_Date", typeof(DateTime));
            bSheet.Columns.Add("Out_PaymentType", typeof(string));
            bSheet.Columns.Add("Out_Amount", typeof(double));
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /*
        public void projectNameDisplay()
        {
            MySqlDataReader reader = DBConnection.getData("select proj_id,proj_name from project");

            DataTable dt = new DataTable();

            dt.Load(reader);

            projectName.DataSource = dt;
            projectName.ValueMember = "proj_id";
            projectName.DisplayMember = "proj_name";

            reader.Close();

        }

        public void eventDisplay()
        {
            MySqlDataReader r = DBConnection.getData("select event_id from event");
            DataTable d = new DataTable();

            d.Load(r);

            eventBox.DataSource = d;
            eventBox.ValueMember = "event_id";
            eventBox.DisplayMember = "event_id";

            r.Close();

        }*/

        public void getGridData(object sender, EventArgs e)
        {
            
            MySqlDataReader reader = DBConnection.getData("select in_date, amount from project_exp_in_amount");

            DataTable inTable = new DataTable();
            inTable.Load(reader);

            reader.Close();

            MySqlDataReader rdr = DBConnection.getData("select e.type, ede.dateOfExp, ede.paymentType, ede.amount from exp_detail_event ede, expense_type e where ede.exp_type_id = e.exp_type_id order by ede.dateOfExp;");

            DataTable edEvent = new DataTable();
            edEvent.Load(rdr);

            rdr.Close();


            foreach (DataRow item1 in inTable.Rows)
            {
                DataRow row;

                row = bSheet.NewRow();
                row["In_Date"] = item1["in_date"];
                row["In_Amount"] = item1["amount"];
                
                foreach (DataRow item2 in edEvent.Rows)
                {
                    if(item1["in_date"].ToString().Equals(item2["dateOfExp"].ToString()))
                    {
                        row["Out_Type"] = item2["type"];
                        row["Out_Date"] = item2["dateOfExp"];
                        row["Out_PaymentType"] = item2["paymentType"];
                        row["Out_Amount"] = item2["amount"];
                        bSheet.Rows.Add(row);
                        row = bSheet.NewRow();
                    }
                    else
                    {
                        bSheet.Rows.Add(row);
                        row = bSheet.NewRow();
                        break;
                    }
                }

                
            }
            

            exp_grid_box.DataSource = bSheet;
        }

        private void BalanceSheetForm_Load(object sender, EventArgs e)
        {

        }

        /*private void projectName_SelectedIndexChanged(object sender, EventArgs e)
        {
            income.Text = "";
            totalExp.Text = "";
            balance.Text = "";

            double total = 0;
            double inc = 0;

            MySqlDataReader re = DBConnection.getData("select e.type, amount, paymenType from exp_detail_event ede, expense_type e where ede.proj_id = (" 
                + projectName.SelectedValue + " and ede.event_id = " + eventBox.SelectedValue + ") and e.exp_type_id = ede.exp_type_id;");
            DataTable da = new DataTable();

            da.Load(re);

            exp_grid_box.DataSource = da;

            foreach (DataRow row in da.Rows)
            {
                total += double.Parse(row[1].ToString()); 
            }

            totalExp.Text = total.ToString();

            re.Close();

            MySqlDataReader reader = DBConnection.getData("select amount from project_exp_in_amount where project_id = " + projectName.SelectedValue + " and event_id = " + eventBox.SelectedValue + ";");

            if (reader.Read())
            {
                inc = reader.GetFloat("amount");

                income.Text = inc.ToString();

                balance.Text = (inc - total).ToString();
            }

            reader.Close();
        }*/
    }
}
