﻿using ResoflexClientHandlingSystem.ProjectExpenses.ProjectExpReports;
using System;

namespace ResoflexClientHandlingSystem
{
    public partial class ProjectExpensesMainForm : MetroFramework.Forms.MetroForm
    {
        public ProjectExpensesMainForm()
        {
            InitializeComponent();
        }

        private void ExpensesTypeForm_Load(object sender, EventArgs e)
        {
            
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            string qry = "select p.proj_name, c.name, IFNULL(COUNT(e.proj_id), 0) as nos, IFNULL(SUM(ex.amount),0) as exp from project p inner join client c on " +
                         "p.client_id=c.client_id LEFT join event e on e.proj_id=p.proj_id LEFT join exp_detail_event ex on ex.proj_id=.p.proj_id GROUP BY p.proj_id;";

            ProjectExpensesMainReport frm = new ProjectExpensesMainReport(qry);

            frm.Show();
        }
    }
}
