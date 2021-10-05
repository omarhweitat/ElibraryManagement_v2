using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussneisObject
{
    public class book_issue_tbl
    {
        private string _member_id;
        private string _member_name;
        private string _book_id;
        private string _book_name;

        public string book_name
        {
            get { return _book_name; }
            set { _book_name = value; }
        }

        private string _issue_date;
        private string _due_date;

        public string due_date
        {
            get { return _due_date; }
            set { _due_date = value; }
        }

        public string issue_date
        {
            get { return _issue_date; }
            set { _issue_date = value; }
        }

        public string book_id
        {
            get { return _book_id; }
            set { _book_id = value; }
        }

        public string member_name
        {
            get { return _member_name; }
            set { _member_name = value; }
        }

        public string member_id
        {
            get { return _member_id; }
            set { _member_id = value; }
        }

    }
}
