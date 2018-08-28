using ResoflexClientHandlingSystem.Role;
using ResoflexClientHandlingSystem.Common;
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
using ResoflexClientHandlingSystem.Core;
using System.Collections;

namespace ResoflexClientHandlingSystem
{
    public partial class AddScheduleForm : MetroFramework.Forms.MetroForm
    {
        private DataTable engGrid = new DataTable();

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

        //Constructor
        public AddScheduleForm()
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

            //to resolve startup bug
            projectNameChange();

            engGrid.Columns.Add("staff_id", typeof(int));
            engGrid.Columns.Add("fullname", typeof(string));

            serviceEngGrid.DataSource = engGrid; 
        }

        private void AddScheduleForm_Load(object sender, EventArgs e)
        {
            
        }

        //when project name combox box is changed
        public void onProjectNameChange(object sender, EventArgs e)
        {
            projectNameChange();
        }

        //when client name is changed
        public void onClientNameChnage()
        {
            int client_id = int.Parse(schClientName.SelectedValue.ToString());


        }

        //project name change method
        public void projectNameChange()
        {
            int proj_id = int.Parse(projectName.SelectedValue.ToString());
            int client_id;

            prevSchedulesGrid.DataSource = getPrevSchedules(proj_id);

            MySqlDataReader reader = DBConnection.getData("select s.sch_no, p.client_id from schedule s, project p " +
                                                            "where s.proj_id =" + proj_id + " and (p.proj_id = s.proj_id) order by sch_no DESC limit 0, 1;");

            if (reader.Read())
            {

                int sn = reader.GetInt16("sch_no") + 1;
                client_id = reader.GetInt16("client_id");

                schNo.Text = sn.ToString();
                schClientName.SelectedValue = client_id;
            }

            reader.Close();
        }

        //data for prevScheGrid
        public DataTable getPrevSchedules(int proj_id)
        {
            DataTable dt = new DataTable();

            MySqlDataReader prevSch = DBConnection.getData("select s.sch_no, s.to_date_time, s.from_date_time from schedule s, project p, client c" +
                                                            " where s.proj_id = " + proj_id + " and (s.proj_id = p.proj_id) and (c.client_id = p.client_id);");

            dt.Load(prevSch);

            prevSch.Close();

            return dt;
        }

        //adding service engineers
        private void addEng_Click(object sender, MouseEventArgs e)
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
            for (int i = engGrid.Rows.Count - 1;  i >= 0 ; i--)
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

        //adding resources
        private void addReso_Click(object sender, EventArgs e)
        {
            string resources = schReso.Text.ToString();
            schReso.Text = "";

            resoBox.AppendText(resources + " ");
            resoBox.AppendText(Environment.NewLine);
        }

        //adding a new schedule
        private void schSave_Click(object sender, EventArgs e)
        {
            Schedule schedule = new Schedule();

            ArrayList serviceEng = new ArrayList();

            foreach (DataRow dr in engGrid.Rows)
            {
                serviceEng.Add(new Staff((int)dr[0]));
            }

            schedule.ScheduleId = int.Parse(schNo.Text.ToString());
            schedule.ProjectOfSchedule= new Project(int.Parse(projectName.SelectedValue.ToString()));
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
            if (Database.addSchedule(schedule))
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
                            "\n A new schedule has been added for project " + projectName.Text.ToString() + ". Please check your schedules ASAP." ;

                        Internet.sendMail(reader.GetString("email"), subject, body);

                        reader.Close();
                    }
                }

                MessageBox.Show("Schedule Successfully Added !");
                this.Close();
            }
            
        }

        //closing form
        private void schCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //resetting form
        private void schReset_Click(object sender, EventArgs e)
        {

        }
    }
}
