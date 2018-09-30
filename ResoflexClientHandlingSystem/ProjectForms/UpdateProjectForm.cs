using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using MySql.Data.MySqlClient;
using ResoflexClientHandlingSystem.Common;
using ResoflexClientHandlingSystem.Core;
using ResoflexClientHandlingSystem.Role;

namespace ResoflexClientHandlingSystem
{
    public partial class UpdateProjectForm : MetroFramework.Forms.MetroForm
    {
        int projID;
        string name;
        string desc;
        int projSubCatID;
        int projectCatID;
        int clientID;
        DateTime install;
        DateTime firstTrainComp;
        DateTime secondTrainComp;
        int visits;
        DateTime warDate;
        int warPeriod;
        string supTerms;
        string visitTerms;
        string warrTerms;
        private string pname;
        private string clientname;
        private string description;
        private string supporttrms;
        private string visittrms;
        private string warrantytrms;

        public UpdateProjectForm( string name, string desc, int projSubCatID, int projCatID, int clientID, string supTerms, string visitTerms, string warrTerms)
        {
            
            this.name = name;
            this.desc = desc;
            this.projSubCatID = projSubCatID;
            this.clientID = clientID;
            this.projectCatID = projectCatID;
            this.supTerms = supTerms;
            this.visitTerms = visitTerms;
            this.warrTerms = warrTerms;

            InitializeComponent();
        }

        public UpdateProjectForm()
        {
            InitializeComponent();
        }

        public UpdateProjectForm(string pname, string clientname, string description, string supporttrms, string visittrms, string warrantytrms, int catid, int subcatid)
        {
            this.pname = pname;
            this.clientname = clientname;
            this.description = description;
            this.supporttrms = supporttrms;
            this.visittrms = visittrms;
            this.warrantytrms = warrantytrms;
            this.projectCatID = catid;
            this.projSubCatID = subcatid;
            string catname = "";

            try
            {
                MySqlDataReader reader = DBConnection.getData("SELECT sub_cat_name from proj_sub_category where proj_cat_id =  projectCatID and proj_sub_cat_id = projSubCatID;");

                if (reader.Read())
                {
                    catname = reader["sub_cat_name"].ToString();

                }
                reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

            InitializeComponent();

            metroComboBox1.SelectedText = clientname;
            metroComboBox1.Enabled = false;
            nameTxt.Text = pname;
            nameTxt.Enabled = false;
            catComboBox.SelectedText = catname;
            catComboBox.Enabled = false;
            DescripTxt.Text = description;
            DescripTxt.Enabled = false;
            visitTermTxt.Text = visittrms;
            visitTermTxt.Enabled = false;
            warTerTxt.Text = warrantytrms;
            warTerTxt.Enabled = false;
            supTermTxt.Text = supporttrms;
            supTermTxt.Enabled = false;

        }
        private void UpdateProjectForm_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlDataReader reader = DBConnection.getData("select name from client");

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

            try
            {
                MySqlDataReader reader = DBConnection.getData("select sub_cat_name from proj_sub_category");

                while (reader.Read())
                {
                    catComboBox.Items.Add(reader.GetValue(0).ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }



            nameTxt.Text = name;
            DescripTxt.Text = desc;
            catComboBox.Text = "" +projSubCatID;
            supTermTxt.Text = supTerms;
            visitTermTxt.Text = visitTerms;
            warTerTxt.Text = warrTerms;

        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel11_Click(object sender, EventArgs e)
        {

        }

        public void emailClient(String email)
        {
            string subject = "Project Successfully Added";
            string message = "Your Project successfully added to our DataBase. Thank you";

            try
            {
                bool isSuccess = Internet.sendMail(email, subject, message);

                if (isSuccess)
                {

                    MessageBox.Show("Project Successfully Added!", "Project Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    MessageBox.Show("Project added mail sent");
                }
                else
                {
                    MessageBox.Show(" Email not Sended. Please check your Internet connection");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!");
            }
        }


        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string name = nameTxt.Text;
                string description = DescripTxt.Text;

                string catago = catComboBox.Text.ToString();
                string supportTerms = supTermTxt.Text;
                string visitTerms = visitTermTxt.Text;
                string warrentyTerms = warTerTxt.Text;

                Client client;

                MySqlDataReader reader = DBConnection.getData("select client_id from client where name='" + metroComboBox1.SelectedItem.ToString() + "';");


                int cid = 0;

                while (reader.Read())
                {
                    cid = int.Parse(reader.GetValue(0).ToString());
                }

                reader.Close();

                client = new Client(cid);

                try
                {
                    MySqlDataReader reader3 = DBConnection.getData("select proj_sub_cat_id, proj_cat_id from proj_sub_category where sub_cat_name='" + catComboBox.SelectedItem.ToString() + "'");

                    if (reader3.Read())
                    {
                        projSubCatID = Int32.Parse(reader3.GetValue(0).ToString());
                        projectCatID = Int32.Parse(reader3.GetValue(1).ToString());


                    }
                    reader3.Close();

                } catch (Exception ex)
                {

                }

                ResoflexClientHandlingSystem.Role.Project project = new Role.Project(name, description, client, projSubCatID, projectCatID, supportTerms, visitTerms, warrentyTerms);

                Database.addProject(project);


                notifySuccessProjectAdding.Icon = SystemIcons.Application;
                notifySuccessProjectAdding.BalloonTipText = "Project Successfully Added!";
                notifySuccessProjectAdding.ShowBalloonTip(1000);

                int pid = 0;

                try
                {
                    MySqlDataReader reader1 = DBConnection.getData("Select proj_id from project where proj_name='" + project.ProjectName + "'and client_id='" + project.ClientOfProject.ClientID + "';");

                    while (reader1.Read())
                    {
                        pid = int.Parse(reader1["proj_id"].ToString());
                    }
                    reader1.Close();


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }

                UserOperation operation = new UserOperation(new Role.UserLog(Logglobals.id), "Added a new Project", pid);

                try{

                    Database.addOp(operation);

                    String email;


                    try
                    {
                        MySqlDataReader reader1 = DBConnection.getData("Select email from client where client_id='" + client.ClientID + "'");

                        while (reader1.Read())
                        {
                            email = reader1["email"].ToString();
                            emailClient(email);
                        }
                        reader1.Close();

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.StackTrace);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Project Updating", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void catComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            nameTxt.Text = "RFS Online POS System";
            DescripTxt.Text = "Create webbased Point of Sales system for RFS";
            warTerTxt.Text = "Regular Warranty with basic conditions";
            visitTermTxt.Text = "2 Free Visits for training";
            supTermTxt.Text = "Team Viewer Support when client needed";
        }
    }

 
       
    
    
}
