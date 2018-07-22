using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class Staff
    {
        private int staffId;
        private String firstName;
        private String lastName;
        private String nic;
        private String address;
        private String[] telNumber;
        private String email;
        private Designation designation;

        private List<Attendance> attendance;

        public Staff()
        {
        }

        public Staff(int staffId)
        {
            this.StaffId = staffId;
        }

        public Staff(string[] telNumber)
        {
            this.TelNumber = telNumber;
        }

        public Staff(int staffId, Designation designation, string firstName, string lastName, string nic, string address, string[] telNumber, string email)
        {
            this.StaffId = staffId;
            this.Designation = designation;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Nic = nic;
            this.Address = address;
            this.TelNumber = telNumber;
            this.Email = email;
        }

        public int StaffId { get => staffId; set => staffId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Nic { get => nic; set => nic = value; }
        public string Address { get => address; set => address = value; }
        public string[] TelNumber { get => telNumber; set => telNumber = value; }
        public string Email { get => email; set => email = value; }
        internal List<Attendance> Attendance { get => attendance; set => attendance = value; }
        internal Designation Designation { get => designation; set => designation = value; }
    }
}
