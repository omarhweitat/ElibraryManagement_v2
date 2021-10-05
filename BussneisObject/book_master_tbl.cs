using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussneisObject
{
    public class book_master_tbl
    {
        private string  _book_id;
        private string _book_name;
        private string _genre;
        private string _author_name;
        private string _publisher_name;
        private string _language;
        private string  _edition;
        private string _book_cost;
        private string _no_of_page;
        private string _book_description;
        private string _actual_stock;
        private string _current_stock;
        private string _book_img_link;

        public string book_img_link
        {
            get { return _book_img_link; }
            set { _book_img_link = value; }
        }

        public string current_stock
        {
            get { return _current_stock; }
            set { _current_stock = value; }
        }

        public string actual_stock
        {
            get { return _actual_stock; }
            set { _actual_stock = value; }
        }

        public string book_description
        {
            get { return _book_description; }
            set { _book_description = value; }
        }

        public string no_of_page
        {
            get { return _no_of_page; }
            set { _no_of_page = value; }
        }

        public string book_cost
        {
            get { return _book_cost; }
            set { _book_cost = value; }
        }

        public string  edition
        {
            get { return _edition; }
            set { _edition = value; }
        }

        public string language
        {
            get { return _language; }
            set { _language = value; }
        }

        public string publisher_name
        {
            get { return _publisher_name; }
            set { _publisher_name = value; }
        }

        public string auhor_name
        {
            get { return _author_name; }
            set { _author_name = value; }
        }

        public string genre
        {
            get { return _genre; }
            set { _genre = value; }
        }


        public string book_name
        {
            get { return _book_name; }
            set { _book_name = value; }
        }

        public string book_id
        {
            get { return _book_id; }
            set { _book_id = value; }
        }

    }
}
