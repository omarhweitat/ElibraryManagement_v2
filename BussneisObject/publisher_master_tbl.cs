using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussneisObject
{
    public class publisher_master_tbl
    {
        private string _publisher_id;
        private string _publisher_name;

        public string publisher_name
        {
            get { return _publisher_name; }
            set { _publisher_name = value; }
        }

        public string publisher_id
        {
            get { return _publisher_id; }
            set { _publisher_id = value; }
        }

    }
}
