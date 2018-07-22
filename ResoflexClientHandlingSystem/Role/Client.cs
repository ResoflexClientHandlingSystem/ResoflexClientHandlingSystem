using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class Client
    {
        private int clientID;
        private string firstName;
        private string lastName;
        private string address;
        private string[] phoneNo = new string[2];
        private string nic;
        private string email;
        private string fax;
        private List<Project> projectList;

        public Client()
        {
        }

        public Client(string firstName, string lastName, string address, string[] phoneNo, string fax, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.phoneNo = phoneNo;
            this.fax = fax;
            this.email = email;
        }

        public Client(int clientId)
        {
            this.clientID = clientId;
        }

        public int ClientID { get => clientID; set => clientID = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Address { get => address; set => address = value; }
        public string[] PhoneNo { get => phoneNo; set => phoneNo = value; }
        public string NIC { get => nic; set => nic = value; }
        public string Email { get => email; set => email = value; }
        public string Fax { get => fax; set => fax = value; }
        internal List<Project> ProjectList { get => projectList; set => projectList = value; }
    }
}
