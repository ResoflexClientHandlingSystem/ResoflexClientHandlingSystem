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
    public partial class ProjectManager : MetroFramework.Forms.MetroForm
    {
        public ProjectManager()
        {
            InitializeComponent();

        }

        private void ProjectManager_Load(object sender, EventArgs e)
        {

        }

        private void scheduleBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void eventBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {

        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            ScheduleForm sf = new ScheduleForm();
            this.Close();
            sf.Show();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            EventForm ef = new EventForm();
            this.Close();
            ef.Show();
        }

        private void btnTasks_Click(object sender, EventArgs e)
        {

        }
    }
}
