using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussneisObject
{
   public class admin_login
    {
        private string _username;
        private string _password;
        private string _full_name;
        public string full_name
        {
            get { return _full_name; }
            set { _username = value; }
        }
        public string password
        {
            get { return _password; }
            set { _password = value; }
        }


        public string username
        {
            get { return _username; }
            set { _username = value; }
        }

    }
}
