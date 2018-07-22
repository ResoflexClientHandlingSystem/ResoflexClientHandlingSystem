using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class User : Staff
    {
        private string uName;
        private string pword;
        private string permission;

        public User(string uName, string pword, string permission, int staffId) : base (staffId)
        {
            this.uName = uName;
            this.pword = pword;
            this.permission = permission;
        }

        public User(string uName, string pword, string permission, string[] telNumber) : base(telNumber)
        {
            this.uName = uName;
            this.pword = pword;
            this.permission = permission;
        }

        public User(string uName, string pword, string permission)
        {
            this.uName = uName;
            this.pword = pword;
            this.permission = permission;
        }
    }
}
