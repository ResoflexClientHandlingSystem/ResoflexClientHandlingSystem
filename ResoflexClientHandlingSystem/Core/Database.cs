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
                    Staff s = (Staff) ary;

                    DBConnection.updateDB("insert into schedule_technicians(sch_no, staff_id, proj_id) values (" + schedule.ScheduleId + ", " + s.StaffId + ", " + schedule.ProjectOfSchedule.ProjectID + ")");
                }

                return true;

            }
            catch (Exception e)
            {

                MessageBox.Show("Something went wrong!\n" + e.GetType() , "Add Schedule", MessageBoxButtons.OK, MessageBoxIcon.Error);

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


        /* public static void updateProject(ResoflexClientHandlingSystem.Role.Project project)
         {
             try
             {
                 DBConnection.updateDB("update project set (client_id, proj_name, proj_sub_cat_id, description, warranty_terms, visit_terms, support_terms)"
                                         + " values (" + project.ClientID
                                         + ",'" + project.ProjectName
                                         + "'," + project.Project_subID
                                         + ",'" + project.ProjectDesc
                                         + "','" + project.WarrantyTerms
                                         + "','" + project.VisitTerms
                                         + "','" + project.SupportTerms + "')");
             }
             catch (Exception exc)
             {
                 MessageBox.Show("Error" + exc, "Project NOT added", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }*/

        public static void addRecord(Attendance atten)
        {
            try
            {
                DBConnection.updateDB("insert into attendance(employee_no, name, in_time, out_time, hours_worked)values('" + atten.EmployeeNo + "','" + atten.Name + "', '" + atten.InTime + "', '" + atten.OutTime + "','" + atten.HoursWorked + "')");
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void addJobPerformance(JobPerformance jobPerformanceObj)
        {

            try
            {
                DBConnection.updateDB("insert into jobperformance(date, emp_no, knowledge, safety, quality, adaptability, productivity, Initiative, total)values('" + jobPerformanceObj.Date + "','" + jobPerformanceObj.EmployeeNo + "', '" + jobPerformanceObj.Knowledge + "', '" + jobPerformanceObj.Safety + "','" + jobPerformanceObj.Quality + "','" + jobPerformanceObj.Adaptability + "','" + jobPerformanceObj.Productivity + "','" + jobPerformanceObj.Initiative + "','" + jobPerformanceObj.Total + "')");
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "Add job performance", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        public static void AddExpenses(ExpenseDetailEvent addExpense)
        {
            // 1 , 1 , 1500 ,'adsx','2018-08-28', 'IOU'

            try
            {
                string date = DateTime.Now.ToString("yyyy-MM-dd");

                int eti = addExpense.ExpType.ExpTypeId;
                int ei = addExpense.EventOfExp.EventId;
                int p = addExpense.ProjectOfEvent.ProjectID;
                double a = addExpense.Amount;
                string c = addExpense.Comment;
                string pt = addExpense.PaymentType;

                DBConnection.updateDB("insert into exp_detail_event (exp_type_id, event_id, proj_id, amount, comment, dateOfExp, paymentType) values" +
                    " (" + eti + ", " + ei + " , " + p + " , " + a + " ,'" + c + "','" + date + "', '" + pt + "');");

                MessageBox.Show("Expenses successfully added!");

            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong!", "Add Expenses", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }


        public static void CashIssue(ExpenseDetailSchedule cashIssue)
        {
            try
            {
                string date = DateTime.Now.ToString("yyyy-MM-dd");

                int e = cashIssue.ScheduleOfExp.ScheduleId;
                int p = cashIssue.ProjectOfSchedule.ProjectID;
                double a = cashIssue.Amount;
                string c = cashIssue.Comment;


                DBConnection.updateDB("insert into iou ( proj_id, sch_no , date,amount , detail) values" + "("+e+" , "+p+" ,'"+date+"', " +a+" , '"+c+"');");

                MessageBox.Show("Expenses successfully added!");


            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "Add Expenses", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
