using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Login
    {
        private int ID { get; set; }
        private string Name { get; set; }
        private string Password { get; set; }
        public Login(string name,string password)
        {
            Name = name;
            Password = password;
        }


        public bool checkLogin()
        {
            if (Name == "admin" && Password == "admin")
                return true;
            return false;

        }
    }
}
