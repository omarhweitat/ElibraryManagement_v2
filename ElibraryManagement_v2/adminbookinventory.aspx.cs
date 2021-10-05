using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussneisLogic;
using BussneisObject;
using System.Data;
using System.IO;
namespace ElibraryManagement_v2
{
    public partial class adminbookinventory : System.Web.UI.Page
    {
        static string global_filepath;
        static int global_actual_stock, global_current_stock, global_issud_books;
        public book_master_tbl defBook()
        {
            book_master_tbl book = new book_master_tbl()
            {
                book_id = TextBox1.Text,
                book_name = TextBox2.Text,
                language = DropDownList1.SelectedValue,
                publisher_name = DropDownList2.SelectedValue,
                auhor_name = DropDownList3.SelectedValue,
                genre = ListBox1.SelectedValue,
                edition = TextBox6.Text,
                actual_stock = TextBox7.Text,
                book_cost = TextBox4.Text,
                current_stock = TextBox5.Text,
                no_of_page = TextBox15.Text,
                book_description = TextBox3.Text

            };
            return book;
        }
        BL log = new BL();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Session["role"].ToString().Equals("admin") && Session["role"]==null)
                {
                    Response.Write("<script>alert('Session Expired Login Again');</script>");
                    Response.Redirect("adminlogin.aspx");
                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Session Expired Login Again');</script>");
                Response.Redirect("adminlogin.aspx");
            }
        }
        //delete
        protected void Button4_Click(object sender, EventArgs e)
        {
            book_master_tbl book = defBook();
            if (log.checkbookexists(book, "select * from  book_master_tbl where book_id= @book_id or book_name=@book_name ", "@book_id", "@book_name"))
            {
                log.deleteBook(book);
                Response.Write("<script>alert('delete succesfully')</script>");
                GridView1.DataBind();

            }
            else
            {
                Response.Write("<script>alert('the book is exists')</script>");
            }
        }
        //go
        protected void Button3_Click(object sender, EventArgs e)
        {
            book_master_tbl book = defBook();
            DataTable dt=log.getDataById(book);
            if (dt.Rows.Count > 0)
            {
                TextBox2.Text = dt.Rows[0]["book_name"].ToString();
                DropDownList1.SelectedValue = dt.Rows[0]["languge"].ToString().Trim();
                DropDownList2.SelectedValue = dt.Rows[0]["publisher_name"].ToString().Trim();
                DropDownList3.SelectedValue = dt.Rows[0]["author_name"].ToString().Trim();
                ListBox1.ClearSelection();
                string[] genre = dt.Rows[0]["genre"].ToString().Trim().Split(',');
                for (int i = 0; i < genre.Length; i++)
                {
                    for (int j = 0; j < ListBox1.Items.Count; j++)
                    {
                        if (ListBox1.Items[j].ToString() == genre[i])
                        {
                            ListBox1.Items[j].Selected = true;
                        }
                    }
                }
                global_actual_stock = Convert.ToInt32(dt.Rows[0]["actual_stock"].ToString().Trim());
                global_current_stock = Convert.ToInt32(dt.Rows[0]["current_stock"].ToString().Trim());
                global_issud_books = global_actual_stock - global_current_stock;
                global_filepath = dt.Rows[0]["book_img_link"].ToString();

                TextBox6.Text = dt.Rows[0]["edition"].ToString();
                TextBox7.Text = dt.Rows[0]["actual_stock"].ToString();
                TextBox14.Text = dt.Rows[0]["book_cost"].ToString();
                TextBox3.Text = dt.Rows[0]["book_description"].ToString();
                TextBox15.Text = dt.Rows[0]["no_of_pages"].ToString();
                TextBox5.Text = dt.Rows[0]["current_stock"].ToString();
                TextBox4.Text = dt.Rows[0]["publisher_date"].ToString();

                TextBox7.Text = dt.Rows[0]["actual_stock"].ToString();
                TextBox16.Text = "" + (Convert.ToInt32(dt.Rows[0]["actual_stock"].ToString()) - Convert.ToInt32(dt.Rows[0]["current_stock"].ToString()));

            }
            else
            {
                Response.Write("<script>alert('Invalid Book Id')</script>");
            }


        }

        //add
        protected void Button1_Click(object sender, EventArgs e)
        {
            string genres = "";
            foreach (int i in ListBox1.GetSelectedIndices())
            {
                genres = genres + ListBox1.Items[i] + ",";
            }
            genres = genres.Remove(genres.Length - 1);

            string filepath = "~/book_inventory/books1.png";
            string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
            FileUpload1.SaveAs(Server.MapPath("book_inventory/" + filename));
            filepath = "~/book_inventory/" + filename;
            book_master_tbl book = defBook();
            if(log.checkbookexists(book, "select * from  book_master_tbl where book_id= @book_id or book_name=@book_name ", "@book_id", "@book_name"))
            {
                Response.Write("<script>alert('the book is exists')</script>");
            }
            else
            {
                string query = "insert into book_master_tbl (book_id,book_name,genre ,author_name , publisher_name , publisher_date, languge, edition , book_cost, no_of_pages, book_description, actual_stock, current_stock,book_img_link)" +
                    " values ( @book_id,@book_name,@genre , @author_name , @publisher_name , @publisher_date,@languge, @edition , @book_cost, @no_of_pages, @book_description, @actual_stock, @current_stock,@book_img_link)";
                log.addBook(book,query, genres, filepath);
                Response.Write("<script>alert('added succesfully')</script>");
                GridView1.DataBind();
            }
        }
        //update
        protected void Button2_Click(object sender, EventArgs e)
        {
            int actual_stock = Convert.ToInt32(TextBox7.Text.Trim());
            int current_stock = Convert.ToInt32(TextBox5.Text.Trim());
            if (global_actual_stock == actual_stock)
            {

            }
            else
            {
                if (actual_stock < global_issud_books)
                {
                    Response.Write("<script>('Actual stock value cannot be less than the Issued books')</script>");
                    TextBox5.Text = "" + current_stock;
                }
            }
            string genres = "";
            foreach (int i in ListBox1.GetSelectedIndices())
            {
                genres = genres + ListBox1.Items[i] + ",";
            }
            genres = genres.Remove(genres.Length - 1);

            string filepath = "~/book_inventory/books1.png";
            string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
            if (filename == "" || filename == null)
            {
                filepath = global_filepath;
            }
            else
            {
                FileUpload1.SaveAs(Server.MapPath("book_inventory/" + filename));
                filepath = "~/book_inventory/" + filename;
            }
            book_master_tbl book = defBook();
            if (log.checkbookexists(book, "select * from  book_master_tbl where book_id= @book_id or book_name=@book_name ", "@book_id", "@book_name"))
            {
                string query = "update book_master_tbl set book_name=@book_name,genre=@genre ,author_name=@author_name , publisher_name=@publisher_name , publisher_date=@publisher_date, languge=@languge, edition=@edition , book_cost=@book_cost, no_of_pages=@no_of_pages, book_description=@book_description, actual_stock=@actual_stock, current_stock=@current_stock,book_img_link=@book_img_link where book_id=@book_id ";
                log.addBook(book, query, genres, filepath);
                Response.Write("<script>alert('added succesfully')</script>");
                GridView1.DataBind();
                
            }
            else
            {
                Response.Write("<script>alert('the book is exists')</script>");
            }
        }
    }
    }

