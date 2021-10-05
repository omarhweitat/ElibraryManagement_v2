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
    public partial class adminlogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["role"]!=null && !Session["role"].ToString().Equals("admin"))
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

        protected void Button_Click(object sender, EventArgs e)
        {
            admin_login admin = new admin_login()
            {
                username = txtmemberid.Text.Trim(),
                password = txtpassword.Text.Trim()
            };
            BL log = new BL();
            DataTable dr=log.checkadmin(admin);
            if (dr.Rows.Count>0)
            {
               
                    Session["username"] = dr.Rows[0]["username"].ToString();
                    Session["fullname"] = dr.Rows[0]["full_name"].ToString();
                    Session["role"] = "admin";
                    Response.Redirect("HomePage.aspx");
            }
            else
            {
                Response.Write("<script>alert('please check your password or username');</script>");
            }
        }
    }
}