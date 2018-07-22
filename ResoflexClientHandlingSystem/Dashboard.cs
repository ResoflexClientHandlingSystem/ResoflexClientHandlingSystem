﻿using System;
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
    public partial class Dashboard : MetroFramework.Forms.MetroForm
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            ClientForm frm = new ClientForm();

            frm.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            dateTimeLbl.Text = DateTime.Now.ToString("MMMM dd, yyyy");

            setAttendance();
        }

        private void setAttendance()
        {
            metroLabel2.Text = "12";
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            ProjectForm frm = new ProjectForm();

            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            ClientForm frm = new ClientForm();

            frm.Show();
        }
    }
}
