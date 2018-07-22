using MySql.Data.MySqlClient;
using System;
using ResoflexClientHandlingSystem.Role;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
