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
    public partial class ClientForm : MetroFramework.Forms.MetroForm
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clientGrid.DataSource = getClients();

            clientGrid.Columns[0].Visible = false;
        }

        private DataTable getClients()
        {
            DataTable table = new DataTable();

            MySqlDataReader reader = DBConnection.getData("select * from client");

            table.Load(reader);

            return table;
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

        }

        private void addNewClientBtn_Click(object sender, EventArgs e)
        {
            AddNewClientForm frm = new AddNewClientForm();
            
            frm.ShowDialog(this);

            clientGrid.DataSource = getClients();
        }
    }
}
