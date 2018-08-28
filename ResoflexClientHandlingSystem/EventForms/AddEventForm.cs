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
    public partial class AddEventForm : MetroFramework.Forms.MetroForm
    {
        private DataTable engGrid = new DataTable();
        private DataTable feedbackGrid = new DataTable();

        //service engineer datasource
        public DataTable serviceEngDataSource()
        {
            MySqlDataReader reader = DBConnection.getData("select staff_id, first_name, last_name from staff");

            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();

            dt1.Load(reader);

            dt2.Columns.Add("staff_id", typeof(int));
            dt2.Columns.Add("fullname", typeof(string));

            foreach (DataRow dr in dt1.Rows)
            {
                DataRow row;

                row = dt2.NewRow();
                row["staff_id"] = dr["staff_id"];
                row["fullname"] = dr["first_name"].ToString() + " " + dr["last_name"].ToString();
                dt2.Rows.Add(row);
            }

            reader.Close();

            return dt2;
        }

        //travelling mode datasource
        public DataTable travelModeDataSource()
        {
            MySqlDataReader reader = DBConnection.getData("select id, details from travelingmode");

            DataTable dt = new DataTable();
            dt.Load(reader);

            reader.Close();

            return dt;
        }

        public DataTable accomodationDataSource()
        {
            MySqlDataReader reader = DBConnection.getData("select id, details from accomodation");

            DataTable dt = new DataTable();
            dt.Load(reader);

            reader.Close();

            return dt;
        }

        public DataTable projectDataSource()
        {
            MySqlDataReader reader = DBConnection.getData("select proj_id, proj_name from project");

            DataTable dt = new DataTable();
            dt.Load(reader);

            reader.Close();

            return dt;
        }

        public DataTable clientDataSource()
        {
            MySqlDataReader reader = DBConnection.getData("select client_id, name from client");

            DataTable dt = new DataTable();
            dt.Load(reader);

            reader.Close();

            return dt;
        }

        public DataTable scheduleTypeDataSource()
        {
            MySqlDataReader reader = DBConnection.getData("select visit_type_id, type from visit_type ");

            DataTable dt = new DataTable();
            dt.Load(reader);

            reader.Close();

            return dt;
        }

        public AddEventForm()
        {
            InitializeComponent();

            projectName.DataSource = projectDataSource();
            projectName.ValueMember = "proj_id";
            projectName.DisplayMember = "proj_name";

            eventClientName.DataSource = clientDataSource();
            eventClientName.ValueMember = "client_id";
            eventClientName.DisplayMember = "name";

            scheduleType.DataSource = scheduleTypeDataSource();
            scheduleType.ValueMember = "visit_type_id";
            scheduleType.DisplayMember = "type";

            travelingMode.DataSource = travelModeDataSource();
            travelingMode.ValueMember = "id";
            travelingMode.DisplayMember = "details";

            accomodation.DataSource = accomodationDataSource();
            accomodation.ValueMember = "id";
            accomodation.DisplayMember = "details";

            serviceEngCombo.DataSource = serviceEngDataSource();
            serviceEngCombo.ValueMember = "staff_id";
            serviceEngCombo.DisplayMember = "fullname";

            //to resolve startup bug
            projectNameChange();

            //eng grid columns
            engGrid.Columns.Add("staff_id", typeof(int));
            engGrid.Columns.Add("fullname", typeof(string));

            //feedback grid columns
            feedbackGrid.Columns.Add("staff_id", typeof(int));
            feedbackGrid.Columns.Add("fullname", typeof(string));
            feedbackGrid.Columns.Add("feedback", typeof(string));
            feedbackGrid.Columns.Add("task", typeof(string));

            serviceEngGrid.DataSource = engGrid;
            clientFeedback.DataSource = feedbackGrid;

            serviceEngFeed.DataSource = engGrid;
            serviceEngFeed.ValueMember = "staff_id";
            serviceEngFeed.DisplayMember = "fullname";
        }

        private void AddEventForm_Load(object sender, EventArgs e)
        {

        }

        private void schCancel_Click(object sender, EventArgs e)
        {

        }

        private void addExpenses(object sender, EventArgs e)
        {

        }

        //when project name combox box is changed
        public void onProjectNameChange(object sender, EventArgs e)
        {
            projectNameChange();
        }

        public void projectNameChange()
        {
            int proj_id = int.Parse(projectName.SelectedValue.ToString());
            int client_id;

            MySqlDataReader reader = DBConnection.getData("select s.sch_no, p.client_id from schedule s, project p where s.proj_id =" + proj_id + " and (p.proj_id = s.proj_id);");

            DataTable dt = new DataTable();
            dt.Load(reader);

            eventsSch.DataSource = dt;
            eventsSch.ValueMember = "sch_no";
            eventsSch.DisplayMember = "sch_no";

            DataRow row = dt.Rows[0];

            eventClientName.SelectedValue = row["client_id"];

            reader.Close();
        }

        //adding service engineers
        private void addEng_MouseClick(object sender, MouseEventArgs e)
        {
            DataRow row;

            row = engGrid.NewRow();
            row["staff_id"] = serviceEngCombo.SelectedValue;
            row["fullname"] = serviceEngCombo.Text.ToString();
            engGrid.Rows.Add(row);

        }

        //removing service engineers
        private void removeSerEng_Click(object sender, EventArgs e)
        {
            for (int i = engGrid.Rows.Count - 1; i >= 0; i--)
            {
                DataRow r = engGrid.Rows[i];
                DataGridViewRow gr = serviceEngGrid.CurrentRow;

                if (r["staff_id"].ToString().Equals(gr.Cells[0].Value.ToString()))
                {
                    engGrid.Rows[i].Delete();

                    break;
                }
            }
        }

        private void addFeedback_MouseClick(object sender, MouseEventArgs e)
        {
            DataRow row;

            row = feedbackGrid.NewRow();
            row["staff_id"] = serviceEngFeed.SelectedValue;
            row["fullname"] = serviceEngFeed.Text.ToString();
            row["feedback"] = feedback.Text.ToString();
            row["task"] = eventTask.Text.ToString();
            feedbackGrid.Rows.Add(row);

        }

        private void eventSave_Click(object sender, EventArgs e)
        {

        }

        private void serviceEngGrid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }
    }
}
