using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Login
    {
        //Fields
        private string _username;
        private string _password;

        //Properties
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        //Constructors
        public Login() { }

        public Login(string username, string password)
        {
            Username = username;
            Password = password;
        }

        //Methods
        public override string ToString()
        {
            return string.Format("Username: {0}\n" +
                "Password: {1}\n",
                Username, Password);
        }//end ToString
    }//end class
}//end namespace
