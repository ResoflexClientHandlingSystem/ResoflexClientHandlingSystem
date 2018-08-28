using MySql.Data.MySqlClient;
using ResoflexClientHandlingSystem.Common;
using ResoflexClientHandlingSystem.Core;
using ResoflexClientHandlingSystem.Role;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResoflexClientHandlingSystem.ScheduleForms
{
    public partial class UpdateScheduleForm : MetroFramework.Forms.MetroForm
    {
        DataTable engGrid = new DataTable();

        private Schedule schedule;

        public UpdateScheduleForm()
        {
            InitializeComponent();
        }

        public UpdateScheduleForm(Schedule schedule)
        {
            InitializeComponent();

            projectName.DataSource = projectDataSource();
            projectName.ValueMember = "proj_id";
            projectName.DisplayMember = "proj_name";

            schClientName.DataSource = clientDataSource();
            schClientName.ValueMember = "client_id";
            schClientName.DisplayMember = "name";

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

            this.schedule = schedule;
            int proj_id = schedule.ProjectOfSchedule.ProjectID;

            //filling the data grids
            prevSchedulesGrid.DataSource = getPrevSchedules(proj_id);

            //getting client name; 
            MySqlDataReader clientName = DBConnection.getData("select c.client_id from project p, client c " +
                                                            "where p.proj_id =" + proj_id + " and (p.client_id = c.client_id)");

            clientName.Read();

            MessageBox.Show(clientName.GetString("client_id") + proj_id);

            projectName.SelectedValue = proj_id;
            schClientName.SelectedValue = clientName.GetString("client_id");
            scheduleType.SelectedValue = schedule.Type.EventTypeId;

            schNo.Text = this.schedule.ScheduleId.ToString();
            todoList.Text = this.schedule.TodoList.ToString();

            //getting all the service eng
            ArrayList eng = this.schedule.ServEngineer;

            engGrid.Columns.Add("staff_id", typeof(int));
            engGrid.Columns.Add("fullname", typeof(string));

            foreach (var item in eng)
            {
                DataRow row;
                Staff s = (Staff) item;

                row = engGrid.NewRow();
                row["staff_id"] = s.StaffId;
                row["fullname"] = s.FirstName + " " + s.LastName;

                engGrid.Rows.Add(row);
            }

            serviceEngGrid.DataSource = engGrid;

            resoBox.Text = this.schedule.Resource.ToString();
            accomodation.Text = this.schedule.AccommodationMode.ToString();
            travelingMode.Text = this.schedule.TravelMode.ToString();
            meals.Text = this.schedule.Meals.ToString();
            checkList.Text = this.schedule.Checklist.ToString();
            schStartDate.Value = this.schedule.To;
            schEndDate.Value = this.schedule.From;
            schLogs.Text = this.schedule.Logs;

            clientName.Close();
        }

        public DataTable getPrevSchedules(int proj_id)
        {
            DataTable dt = new DataTable();

            MySqlDataReader prevSch = DBConnection.getData("select s.sch_no, s.to_date_time, s.from_date_time from schedule s, project p, client c" +
                                                            " where s.proj_id = " + proj_id + " and (s.proj_id = p.proj_id) and (c.client_id = p.client_id);");

            dt.Load(prevSch);

            prevSch.Close();

            return dt;
        }

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

        //adding eng
        private void addEng_Click(object sender, EventArgs e)
        {
            int staff_id = int.Parse(serviceEngCombo.SelectedValue.ToString());

            //checking and updating grid
            if (Database.addServiceEngineer(schedule, staff_id))
            {
                DataRow row;

                row = engGrid.NewRow();
                row["staff_id"] = staff_id;
                row["fullname"] = serviceEngCombo.SelectedItem.ToString();
                engGrid.Rows.Add(row);

                MessageBox.Show("Service Engineer assigned");
            }


        }

        //deleteing eng
        private void removeSerEng_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = serviceEngGrid.CurrentRow;

            int staff_id = int.Parse(row.Cells[0].Value.ToString());

            //checking and updating grid
            if (Database.deleteServiceEngineer(schedule, staff_id))
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

                MessageBox.Show("Service Engineer removed from schedule");
            }
        }

        private void schUpdate_Click(object sender, EventArgs e)
        {
            Schedule schedule = new Schedule();

            ArrayList serviceEng = new ArrayList();

            //getting service eng details from grid
            foreach (DataRow dr in engGrid.Rows)
            {
                serviceEng.Add(new Staff((int)dr[0]));
            }

            schedule.ScheduleId = int.Parse(schNo.Text.ToString());
            schedule.ProjectOfSchedule = new Project(int.Parse(projectName.SelectedValue.ToString()));
            schedule.Type = new EventType(int.Parse(scheduleType.SelectedValue.ToString()));
            schedule.ServEngineer = serviceEng;
            schedule.To = Convert.ToDateTime(schEndDate.Text.ToString() + " " + schEndTime.Text.ToString());
            schedule.From = Convert.ToDateTime(schStartDate.Text.ToString() + " " + schStartTime.Text.ToString());
            schedule.TodoList = todoList.Text.ToString();
            schedule.Resource = resoBox.Text.ToString();
            schedule.Checklist = checkList.Text.ToString();
            schedule.TravelMode = travelingMode.Text.ToString();
            schedule.AccommodationMode = accomodation.Text.ToString();
            schedule.Meals = meals.Text.ToString();
            schedule.Logs = schLogs.Text.ToString();

            //checking if the insertion is successful
            if (Database.updateSchedule(schedule))
            {
                //sending mails
                if (schSendMail.Checked)
                {
                    foreach (var ary in schedule.ServEngineer)
                    {
                        Staff s = (Staff)ary;

                        MySqlDataReader reader = DBConnection.getData("select email, first_name, last_name from staff where staff_id = " + s.StaffId + " ");

                        reader.Read();

                        string subject = "New Schedule Added";
                        string body = "Dear " + reader.GetString("first_name") + " " + reader.GetString("last_name") +
                            "\n A new schedule has been added for project " + projectName.Text.ToString() + ". Please check your schedules ASAP.";

                        Internet.sendMail(reader.GetString("email"), subject, body);

                        reader.Close();
                    }
                }

                MessageBox.Show("Schedule Successfully Updated !");
                this.Close();
            }
        }

        private void addReso_Click(object sender, EventArgs e)
        {
            string resources = schReso.Text.ToString();
            schReso.Text = "";

            resoBox.AppendText(resources + " ");
            resoBox.AppendText(Environment.NewLine);
        }
    }
}
