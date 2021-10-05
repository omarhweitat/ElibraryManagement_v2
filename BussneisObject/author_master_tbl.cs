using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussneisObject
{
    public class author_master_tbl
    {
        private string _author_id;
        private string _author_name;

        public string author_name
        {
            get { return _author_name; }
            set { _author_name = value; }
        }

        public string author_id
        {
            get { return _author_id; }
            set { _author_id = value; }
        }

    }
}
