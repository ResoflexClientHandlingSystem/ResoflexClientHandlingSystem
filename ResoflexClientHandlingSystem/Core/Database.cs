using MySql.Data.MySqlClient;
using System;
using ResoflexClientHandlingSystem.Role;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ResoflexClientHandlingSystem.Core
{
    class Database
    {
        public static void saveClient(Client client)
        {
            try
            {
                DBConnection.updateDB("insert into client (name, address, phone_mobile, phone_office, fax, email)" +
                                      " values ('" + client.FirstName + " " + client.LastName + "', '" + client.Address + "', " +
                                      "'" + client.PhoneNo[0] + "', '" + client.PhoneNo[1] + "', '" + client.Fax + "', " +
                                      "'" + client.Email + "')");
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "Add client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void addUsers(User user)
        {
            try
            {
                DBConnection.updateDB("insert into user (user_id, u_name, password, permission) values ("+user.StaffId+",'"+user.UName+"','"+user.Pword+"','"+user.Permission+"')");
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static void addLog(Role.UserLog log)
        {
            try
            {
                DBConnection.updateDB("insert into user_log (user_id, logged_in_dateTime, detail, ip) values " +
                    "(" + log.User.UserId+ ",'" + log.LoggedInDateTime + "','" + log.Detail + "', '" + log.Ip + "')");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Something went wrong!", "Logging in", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void updateLog(Role.UserLog log)
        {
            try
            {
                DBConnection.updateDB("update user_log set logged_out_dateTime='" + log.LoggedOutDateTime + "', detail='" + log.Detail + "' where log_id = '" + log.LogId + "';");
                    
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Something went wrong!", "Logging out", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void updateClient(Client client)
        {
            try
            {
                DBConnection.updateDB("update client set name='" + client.FirstName + " " + client.LastName + "', " +
                                      "address='" + client.Address + "', phone_mobile='" + client.PhoneNo[0] + "', " +
                                      "phone_office='" + client.PhoneNo[1] + "', fax='" + client.Fax + "', email='" + client.Email + "' " +
                                      "where client_id=" + client.ClientID);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void updateUser(User user)
        {
            try
            {
                DBConnection.updateDB("update user set u_name='" + user.UName + "', password='" +
                    user.Pword + "' where user_id = "+ user.UserId + ";");
            }
            catch (Exception)
            {
                MessageBox.Show("", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
        public static void addProject(ResoflexClientHandlingSystem.Role.Project project)
        {
            Client client = project.ClientOfProject;

            try
            {
                DBConnection.updateDB("insert into project (client_id, proj_name, proj_sub_cat_id, description, warranty_terms, visit_terms, support_terms)"
                                        + " values (" + client.ClientID
                                        + ",'" + project.ProjectName
                                        + "'," + project.ProjectSubID
                                        + ",'" + project.Projectdesc
                                        + "','" + project.WarrantyTerms
                                        + "','" + project.VisitTerms
                                        + "','" + project.SupportTerms + "')");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error" + exc, "Project NOT added", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        public static void addProjectCat(ResoflexClientHandlingSystem.Role.ProjectCategory projectCat)
        {


            try
            {
                DBConnection.updateDB("insert into proj_category (cat_name) values ('" + projectCat.CategoryName + "')");

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error" + exc, "Project NOT added", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static void updateProject(ResoflexClientHandlingSystem.Role.Project project)
         {
             try
             {
                DBConnection.updateDB("UPDATE project SET first_init_date ='"+project.FirstInitDate+"', training_comp_first_end_date='"+project.TEndDate1+"', training_comp_second_end_date='"+project.TEndDate2+"', warranty_start_date='"+project.WarrantyStart+"', warranty_period='"+project.WarrantyPeriod+"' WHERE proj_name='"+project.ProjectName+"';");
             }
             catch (Exception exc)
             {
                 MessageBox.Show("Error" + exc, "Project NOT added", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }

        public static void addRecord(Attendance atten)
        {
            MySqlDataReader reader1021 = DBConnection.getData("select * from attendanceview where DATE(in_time) = '" + atten.InTime + "%' and staff_id = '" + atten.EmployeeNo + "'");
            
            if (reader1021.HasRows == false)
            {
                reader1021.Close();
                //  try
                // {
                DBConnection.updateDB("insert into attendance(staff_id, in_time, out_time, total_hours)values('" + atten.EmployeeNo + "','" + atten.InTime + "', '" + atten.OutTime + "','" + atten.HoursWorked + "')");
                
                // }
                // catch (Exception)
                //  {
                // MessageBox.Show("Something went wrong!", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                // }
            }
            else
            {
                MessageBox.Show("There is another record with the same date!", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reader1021.Close();

            }
        }

        public static void addJobPerformance(JobPerformance jobPerformanceObj)
        {
            try
            {
                DBConnection.updateDB("insert into job_performance(staff_id, perf_year, knowledge, saftey, quality, adaptability, productivity, Initiative)values" +
                    "('" + jobPerformanceObj.StaffId + "','" + jobPerformanceObj.PerfYear.ToString("yyyy/M/d") + "', '" + jobPerformanceObj.Knowledge + "', '" + jobPerformanceObj.Safety + "'," +
                    "'" + jobPerformanceObj.Quality + "','" + jobPerformanceObj.Adaptability + "','" + jobPerformanceObj.Productivity + "','" + jobPerformanceObj.Initiative + "')");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong!'" + ex + "'", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void updateJobPerformance(JobPerformance jobPerformanceObj)//This update does not work
        {
            try
            {
                DBConnection.updateDB("update job_performance set knowledge = '" + jobPerformanceObj.Knowledge + "'," +
                    "saftey = '" + jobPerformanceObj.Safety + "'," +
                    "quality =  '" + jobPerformanceObj.Quality + "'," +
                    "adaptability = '" + jobPerformanceObj.Adaptability + "'," +
                    "productivity = '" + jobPerformanceObj.Productivity + "'," +
                    "Initiative = '" + jobPerformanceObj.Initiative + "'" +
                    "where perf_year = '" + jobPerformanceObj.PerfYear.ToString("yyyy/M/d") + "'");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong!'" + ex + "'", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void addClientRelations(ClientRelations clientRelationsObj)
        {

            try
            {

                DBConnection.updateDB("insert into client_relations(staff_id, rel_year, telephone_skills, problem_resolution, salesmanship, pro_activeness, politeness)values('" + clientRelationsObj.StaffId + "','" + clientRelationsObj.RelYear.ToString("yyyy/M/d") + "', '" + clientRelationsObj.TelephoneSkills + "', '" + clientRelationsObj.ProblemResolution + "','" + clientRelationsObj.Salesmanship + "','" + clientRelationsObj.ProActiveness + "','" + clientRelationsObj.Politeness + "')");
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static void updateClientRelations(ClientRelations clientRelationsObj)
        {

            try
            {

                DBConnection.updateDB("update client_relations set" +
                    " telephone_skills = '" + clientRelationsObj.TelephoneSkills + "'," +
                    " problem_resolution = '" + clientRelationsObj.ProblemResolution + "', salesmanship = '" + clientRelationsObj.Salesmanship + "'," +
                    " pro_activeness = '" + clientRelationsObj.ProActiveness + "', politeness = '" + clientRelationsObj.Politeness + "' where rel_year = '" + clientRelationsObj.RelYear.ToString("yyyy/M/d") + "'");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong! + '" + ex + "'", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static void addCommunicationSkills(CommunicationSkills communicationSkillsObj)
        {

            try
            {

                DBConnection.updateDB("insert into communication_skills(staff_id, comm_year, influence, presentation, relationship, listening, negotiation)values('" + communicationSkillsObj.StaffId + "','" + communicationSkillsObj.CommYear + "', '" + communicationSkillsObj.Influence + "', '" + communicationSkillsObj.Presentation + "','" + communicationSkillsObj.Relationships + "','" + communicationSkillsObj.Listening + "','" + communicationSkillsObj.Negotiation + "')");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrongYAYA! +'" + ex + "' ", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static void updateCommunicationSkills(CommunicationSkills communicationSkillsObj)//This update works
        {

            try
            {

                DBConnection.updateDB("update communication_skills set influence = '" + communicationSkillsObj.Influence + "', presentation = '" + communicationSkillsObj.Presentation + "', relationship = '" + communicationSkillsObj.Relationships + "' , listening = '" + communicationSkillsObj.Listening + "', negotiation = '" + communicationSkillsObj.Negotiation + "' where comm_year = '" + communicationSkillsObj.CommYear.ToString("yyyy/M/d") + "'");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrongYAYA! +'" + ex + "' ", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        public static void addInterpersonalSkills(InterpersonalSkills interpersonalSkillsObj)
        {

            try
            {

                DBConnection.updateDB("insert into interpersonal_skills(staff_id, inter_year, interaction_with_customers, interaction_with_supervisors, interaction_with_clients, motivational_skills, leadership)values('" + interpersonalSkillsObj.StaffId + "','" + interpersonalSkillsObj.InterYear + "', '" + interpersonalSkillsObj.InteractionWithCoworkers + "', '" + interpersonalSkillsObj.InteractionWithSupervisors + "','" + interpersonalSkillsObj.InteractionWithClients + "','" + interpersonalSkillsObj.MotivationalSkills + "','" + interpersonalSkillsObj.Leadership + "')");
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static void updateInterpersonalSkills(InterpersonalSkills interpersonalSkillsObj)
        {

            try
            {

                DBConnection.updateDB("update interpersonal_skills set interaction_with_customers ='" + interpersonalSkillsObj.InteractionWithCoworkers + "' , interaction_with_supervisors = '" + interpersonalSkillsObj.InteractionWithSupervisors + "', interaction_with_clients = '" + interpersonalSkillsObj.InteractionWithClients + "', motivational_skills = '" + interpersonalSkillsObj.MotivationalSkills + "', leadership = '" + interpersonalSkillsObj.Leadership + "' where inter_year = '" + interpersonalSkillsObj.InterYear.ToString("yyyy/M/d") + "'");
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void addProjectShortcomings(ProjectShortcomings projectShortcomings)
        {

            try
            {

                DBConnection.updateDB("insert into project_shortcomings(staff_id,proj_id,event_id,description)values('" + projectShortcomings.StaffId + "','" + projectShortcomings.ProjectId + "','" + projectShortcomings.EventId + "','" + projectShortcomings.Description + "')");
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static void updateProjectShortcomings(ProjectShortcomings projectShortcomings)
        {

            try
            {

                DBConnection.updateDB("update project_shortcomings set description = '" + projectShortcomings.Description + "',proj_id = '" + projectShortcomings.ProjectId + "',event_id = '" + projectShortcomings.EventId + "' where staff_id = '" + projectShortcomings.StaffId + "'");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong! '" + ex + "'", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static void deleteProjectShortcomings(ProjectShortcomings projectShortcomings)
        {

            try
            {

                DBConnection.updateDB("delete from project_shortcomings where staff_id = '" + projectShortcomings.StaffId + "'");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong! '" + ex + "'", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static void updateRecord(Attendance atten)
        {

        }

        public static void addStaff(Staff staff)
        {
            try
            {
                DBConnection.updateDB("insert into staff(first_name, last_name, " +
                    "nic, desig_id, p_address, s_address, tel1, tel2, email, basic_salary, ot_rate) " +
                    "values('" + staff.FirstName + "','" + staff.LastName + "','" + staff.Nic+ "'," +
                    "'" + staff.pAddress + "','" + staff.sAddress + "','" + staff.TelNumber + "'," +
                    "'" + staff.Email+ "','" + staff.Facebook + "','" + staff.LinkedIn + "'," +
                    "'" + staff.BasicSalary + "','" + staff.OtRate + "','" + staff.Designation + "')");
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "Add Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
        //Adding a new schedule
        public static Boolean addSchedule(Schedule schedule)
        {
            try
            {
                //for now
                schedule.Vehicle = " ";
                schedule.Mileage = 0;

                DBConnection.updateDB("insert into schedule (proj_id, visit_type_id, vehicle_details, mileage, to_date_time, " +
                    "from_date_time, to_do_list, resource, check_list, travelling_mode, accommodation, meals, logs) " +
                    "VALUES (" + schedule.ProjectOfSchedule.ProjectID + ", " + schedule.Type.EventTypeId + ", '" + schedule.Vehicle + "'," +
                    "" + schedule.Mileage + ", '" + schedule.To.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + schedule.From.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + schedule.TodoList + "', " +
                    "'" + schedule.Resource + "', '" + schedule.Checklist + "', '" + schedule.TravelMode + "'," +
                    " '" + schedule.AccommodationMode + "', '" + schedule.Meals + "', '" + schedule.Logs + "'); ");

                foreach (var ary in schedule.ServEngineer)
                {
                    Staff s = (Staff)ary;

                    DBConnection.updateDB("insert into schedule_technicians(sch_no, staff_id, proj_id) values (" + schedule.ScheduleId + ", " + s.StaffId + ", " + schedule.ProjectOfSchedule.ProjectID + ")");
                }

                return true;

            }
            catch (Exception e)
            {

                MessageBox.Show("Something went wrong!\n" + e.GetType(), "Add Schedule", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        public static Boolean deleteSchedule(Schedule schedule)
        {

            try
            {
                DBConnection.updateDB("delete from schedule where proj_id = " + schedule.ProjectOfSchedule.ProjectID + " and sch_no = " + schedule.ScheduleId + ";");

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong!\n" + e.GetType(), "Schedule Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        //adding service eng
        public static Boolean addServiceEngineer(Schedule schedule, int staff_id)
        {
            try
            {
                DBConnection.updateDB("insert into schedule_technicians (proj_id, sch_no, staff_id ) values (" + schedule.ProjectOfSchedule.ProjectID + "," + schedule.ScheduleId + ", " + staff_id + ");");

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong!\n" + e.GetType(), "Schedule Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        //removing service eng
        public static Boolean deleteServiceEngineer(Schedule schedule, int staff_id)
        {
            try
            {
                DBConnection.updateDB("delete from schedule_technicians where proj_id = " + schedule.ProjectOfSchedule.ProjectID + " and sch_no = " + schedule.ScheduleId + " and staff_id = " + staff_id + ";");

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong!\n" + e.GetType(), "Schedule Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        public static Boolean updateSchedule(Schedule schedule)
        {
            try
            {
                //for now
                schedule.Vehicle = " ";
                schedule.Mileage = 0;

                DBConnection.updateDB("update schedule set visit_type_id = " + schedule.Type.EventTypeId + ", to_date_time = '" + schedule.To.ToString("yyyy-MM-dd HH:mm:ss") +
                    "', from_date_time ='" + schedule.From.ToString("yyyy-MM-dd HH:mm:ss") + "', to_do_list = '" + schedule.TodoList + "', resource = " +
                    "'" + schedule.Resource + "', check_list = '" + schedule.Checklist + "', travelling_mode = '" + schedule.TravelMode + "'," +
                    " accommodation = '" + schedule.AccommodationMode + "', meals = '" + schedule.Meals + "', logs = '" + schedule.Logs + "' where proj_id = "
                    + schedule.ProjectOfSchedule.ProjectID + " and sch_no = " + schedule.ScheduleId + ";");

                return true;

            }
            catch (Exception e)
            {

                MessageBox.Show("Something went wrong!\n" + e.GetType(), "Add Schedule", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }
      
        public static void saveChangerequest(ProjectRequest req)
        {
            try
            {
                DBConnection.updateDB("insert into proj_request (proj_id, request, added_date, urgent) " +
                    "values (" + req.ProjectOfRequest.ProjectID + ", '" + req.Request + "', '" + req.AddedDate.ToString("yyyy/MM/d HH:mm:ss") + "', " + req.Urgent + ")");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Something went wrong!\n" + exc, "Add Change Request", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
