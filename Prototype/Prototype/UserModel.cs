using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class UserModel
    {
        public void UserModelInit()
        {
            id = -1;
            Name = "";
            Username = "";
            Password = "";
            Role = "";
            Status = false;
        }

        public int id { get; set; }
        public String Name { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public String Role { get; set; }
        public Boolean Status { get; set; }

    }
}
