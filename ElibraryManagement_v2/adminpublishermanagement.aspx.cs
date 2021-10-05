using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussneisObject;
using BussneisLogic;
using System.Data;
namespace ElibraryManagement_v2
{
    public partial class adminpublishermanagement : System.Web.UI.Page
    {
        public publisher_master_tbl defPubkisher()
        {
            publisher_master_tbl publisher = new publisher_master_tbl()
            {
                publisher_id = TextBox1.Text,
                publisher_name = TextBox2.Text
            };
            return publisher;
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
            publisher_master_tbl publisher = defPubkisher();


            if (bl.checkPublisher(publisher, "select * from  publisher_master_tbl where publisher_id= @publisher_id ", "@publisher_id"))
            {
                Response.Write("<script>alert('publisher with this Id already exist ');</script>");
            }
            else
            {
                bl.editPublisher(publisher, "insert into publisher_master_tbl (publisher_id ,publisher_name) values(@publisher_id ,@publisher_name)", "@publisher_id", "@publisher_name");
                GridView1.DataBind();
            }
        }
        //update
        protected void Button3_Click(object sender, EventArgs e)
        {
            publisher_master_tbl publisher = defPubkisher();
            if (bl.checkPublisher(publisher, "select * from  publisher_master_tbl where publisher_id= @publisher_id ", "@publisher_id"))
            {
                bl.editPublisher(publisher, "update publisher_master_tbl set publisher_name= @publisher_name where publisher_id=@publisher_id", "@publisher_id", "@publisher_name");
                GridView1.DataBind();

            }
            else
            {
                Response.Write("<script>alert('publisher with this Id not exist ');</script>");
            }
        }
        //delete
        protected void Button4_Click(object sender, EventArgs e)
        {
            publisher_master_tbl publisher = defPubkisher();
            if (bl.checkPublisher(publisher, "select * from  publisher_master_tbl where publisher_id= @publisher_id ", "@publisher_id"))
            {
                bl.editPublisher(publisher, "delete from publisher_master_tbl where publisher_id=@publisher_id", "@publisher_id", "@publisher_name");
                GridView1.DataBind();

            }
            else
            {
                Response.Write("<script>alert('publisher with this Id no exist ');</script>");
            }
        }
        //go
        protected void Button1_Click(object sender, EventArgs e)
        {
            publisher_master_tbl publisher = defPubkisher();
            if (bl.checkPublisher(publisher, "select * from  publisher_master_tbl where publisher_id= @publisher_id ", "@publisher_id"))
            {
                DataTable dt = bl.editPublisher(publisher, "select * from  publisher_master_tbl where publisher_id= @publisher_id", "@publisher_id", "@publisher_name");
                TextBox2.Text = dt.Rows[0]["publisher_name"].ToString();
                GridView1.DataBind();

            }
            else
            {
                Response.Write("<script>alert('publisher with this Id no exist ');</script>");
            }
        }
    }
}