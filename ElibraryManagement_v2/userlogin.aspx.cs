using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussneisLogic;
using BussneisObject;
using DataAccess;
using System.Data;
namespace ElibraryManagement_v2
{
    public partial class userlogin : System.Web.UI.Page
    {
        public member_master_tbl defMember()
        {
            member_master_tbl member = new member_master_tbl()
            {
                member_id = txtmemberid.Text,
                password = txtpassword.Text
            };
            return member;
        }
        BL b = new BL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //login
        protected void Button1_Click(object sender, EventArgs e)
        {
             member_master_tbl mb = defMember();
             DataTable dt= b.MemberData(mb);
            if(b.checkexists(mb))
            {
                Session["username"] = dt.Rows[0]["member_id"].ToString();
                Session["fullname"] = dt.Rows[0]["full_name"].ToString();
                Session["role"] = "user";
                Session["status"] = dt.Rows[0]["acount_status"].ToString();
                if(Session["status"].ToString().Equals("active"))
                {
                    Response.Redirect("HomePage.aspx");
                }
                else if (Session["status"].ToString().Equals("panding"))
                {
                    Response.Write("<script>alert('Member panding');</script>");
                }
                else if(Session["status"].ToString().Equals("deactive"))
                {
                    Response.Write("<script>alert('Member deactive');</script>");
                }
               

            }
            else
            {
                Response.Write("<script>alert('Member not Exist please sign up');</script>");
            }
        }
    }
}