using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussneisLogic;
using BussneisObject;
using System.Data;
namespace ElibraryManagement_v2
{
    public partial class adminauthormanagement : System.Web.UI.Page
    {
        public author_master_tbl defAuthor()
        {
            author_master_tbl author = new author_master_tbl()
            {
                author_id = TextBox1.Text,
                author_name = TextBox2.Text
            };
            return author;
        }
        BL bl = new BL();
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                if (!Session["role"].ToString().Equals("admin") && Session["role"] == null)
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
        //add
        protected void Button2_Click(object sender, EventArgs e)
        {
            author_master_tbl author= defAuthor();
            
            if(bl.checkauthor(author, "select * from  author_master_tbl where author_id= @author_id", "@author_id"))
            {
                Response.Write("<script>alert('author with this Id already exist ');</script>");
            }
            else
            {
                bl.editauthor(author, "insert into author_master_tbl (author_id ,author_name) values(@author_id,@author_name)", "@author_id", "@author_name");
                GridView1.DataBind();
            }
        }
        //update
        protected void Button3_Click(object sender, EventArgs e)
        {
            author_master_tbl author = defAuthor();
            if (bl.checkauthor(author, "select * from  author_master_tbl where author_id= @author_id", "@author_id"))
            {
                bl.editauthor(author, "update author_master_tbl set author_name= @author_name where author_id=@author_id", "@author_id", "@author_name");
                GridView1.DataBind();
               
            }
            else
            {
                Response.Write("<script>alert('author with this Id not exist ');</script>");
            }
        }
        //delete
        protected void Button4_Click(object sender, EventArgs e)
        {
            author_master_tbl author = defAuthor();
            if (bl.checkauthor(author ,"select * from  author_master_tbl where author_id= @author_id", "@author_id"))
            {
                bl.editauthor(author, "delete from author_master_tbl where author_id=@author_id", "@author_id", "@author_name");
                GridView1.DataBind();
                
            }
            else
            {
                Response.Write("<script>alert('author with this Id no exist ');</script>");
            }
        }
        //go
        protected void Button1_Click(object sender, EventArgs e)
        {
            author_master_tbl author = defAuthor();
            if (bl.checkauthor(author, "select * from  author_master_tbl where author_id= @author_id", "@author_id"))
            {
                DataTable dt= bl.editauthor(author, "select * from  author_master_tbl where author_id= @author_id", "@author_id", "@author_name");
                TextBox2.Text = dt.Rows[0]["author_name"].ToString();
                GridView1.DataBind();

            }
            else
            {
                Response.Write("<script>alert('author with this Id no exist ');</script>");
            }

        }
    }
}