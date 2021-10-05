using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussneisObject
{
    public class member_master_tbl
    {
        private string _full_name;
        private string _dob;
        private string _contact_no;
        private string _email;
        private string _state;
        private string _city;
        private string _pincode;
        private string _full_address;
        private string  _member_id;
        private string _password;
        private string _acount_status;

        public string acount_status
        {
            get { return _acount_status; }
            set { _acount_status = value; }
        }

        public string password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string  member_id
        {
            get { return _member_id; }
            set { _member_id = value; }
        }

        public string full_address
        {
            get { return _full_address; }
            set { _full_address = value; }
        }

        public string pincode
        {
            get { return _pincode; }
            set { _pincode = value; }
        }

        public string city
        {
            get { return _city; }
            set { _city = value; }
        }

        public string state
        {
            get { return _state; }
            set { _state = value; }
        }

        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string contact_no
        {
            get { return _contact_no; }
            set { _contact_no = value; }
        }

        public string dob
        {
            get { return _dob; }
            set { _dob = value; }
        }

        public string full_Name
        {
            get { return _full_name; }
            set { _full_name = value; }
        }

    }
}
