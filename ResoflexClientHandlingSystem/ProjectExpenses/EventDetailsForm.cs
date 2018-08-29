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

namespace ResoflexClientHandlingSystem
{
    public partial class EventDetailsForm : MetroFramework.Forms.MetroForm
    {
        public EventDetailsForm()
        {
            InitializeComponent();

            projectNameDisplay();
            eventDisplay();
        }

        private void EventDetailsForm_Load(object sender, EventArgs e)
        {

        }

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

        }

        private void projectName_SelectedIndexChanged(object sender, EventArgs e)
        {
            income.Text = "";
            totalExp.Text = "";
            balance.Text = "";

            double total = 0;
            double inc = 0;

            MySqlDataReader re = DBConnection.getData("select e.type, amount, paymentType from exp_detail_event ede, expense_type e where ede.proj_id = ("
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
        }
    }
}
