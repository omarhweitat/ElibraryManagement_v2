using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussneisLogic;
using BussneisObject;
using System.Data;
using System.Data.SqlClient;
namespace ElibraryManagement_v2
{
    public partial class adminmember : System.Web.UI.Page
    {
        BL log = new BL();
        public member_master_tbl defMember()
        {
            member_master_tbl member = new member_master_tbl()
            {
                member_id = TextBox1.Text.Trim()
            };
            return member;
        }
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
                //}
            }
        }
        //go
        protected void Button3_Click(object sender, EventArgs e)
        {
            member_master_tbl member = defMember();
            if (log.checkiMemberExistsissue(member, "select * from  member_master_tbl where member_id= @member_id ", "@member_id"))
            {
               DataTable dr= log.getDataFromDBMember(member);
                
                if (dr.Rows.Count>0)
                {

                    TextBox2.Text = dr.Rows[0]["full_name"].ToString();
                    TextBox7.Text = dr.Rows[0]["acount_status"].ToString();
                    TextBox8.Text = dr.Rows[0]["dob"].ToString();
                    TextBox9.Text = dr.Rows[0]["contact_no"].ToString();
                    TextBox10.Text = dr.Rows[0]["email"].ToString();
                    TextBox11.Text = dr.Rows[0]["state"].ToString();
                    TextBox12.Text = dr.Rows[0]["city"].ToString();
                    TextBox13.Text = dr.Rows[0]["pincode"].ToString();
                    TextBox3.Text = dr.Rows[0]["full_address"].ToString();


                }
                GridView1.DataBind();
               
            }
            else
            {
                Response.Write("<script>alert('Member not Exist please check Id to deleted');</script>");
            }
        }
        //green
        protected void Button2_Click(object sender, EventArgs e)
        {
            member_master_tbl member = defMember();
            log.updateMemberStatusById(member,"active");
            GridView1.DataBind();
            DataTable dr = log.getDataFromDBMember(member);

            if (dr.Rows.Count > 0)
            {

                TextBox2.Text = dr.Rows[0]["full_name"].ToString();
                TextBox7.Text = dr.Rows[0]["acount_status"].ToString();
                TextBox8.Text = dr.Rows[0]["dob"].ToString();
                TextBox9.Text = dr.Rows[0]["contact_no"].ToString();
                TextBox10.Text = dr.Rows[0]["email"].ToString();
                TextBox11.Text = dr.Rows[0]["state"].ToString();
                TextBox12.Text = dr.Rows[0]["city"].ToString();
                TextBox13.Text = dr.Rows[0]["pincode"].ToString();
                TextBox3.Text = dr.Rows[0]["full_address"].ToString();


            }
        }
        //yellow
        protected void Button4_Click(object sender, EventArgs e)
        {
            member_master_tbl member = defMember();
            log.updateMemberStatusById(member, "panding");
            GridView1.DataBind();
            DataTable dr = log.getDataFromDBMember(member);

            if (dr.Rows.Count > 0)
            {

                TextBox2.Text = dr.Rows[0]["full_name"].ToString();
                TextBox7.Text = dr.Rows[0]["acount_status"].ToString();
                TextBox8.Text = dr.Rows[0]["dob"].ToString();
                TextBox9.Text = dr.Rows[0]["contact_no"].ToString();
                TextBox10.Text = dr.Rows[0]["email"].ToString();
                TextBox11.Text = dr.Rows[0]["state"].ToString();
                TextBox12.Text = dr.Rows[0]["city"].ToString();
                TextBox13.Text = dr.Rows[0]["pincode"].ToString();
                TextBox3.Text = dr.Rows[0]["full_address"].ToString();


            }
        }
        //red
        protected void Button5_Click(object sender, EventArgs e)
        {
            member_master_tbl member = defMember();

            log.updateMemberStatusById(member, "deactive");
            GridView1.DataBind();
            DataTable dr = log.getDataFromDBMember(member);

            if (dr.Rows.Count > 0)
            {

                TextBox2.Text = dr.Rows[0]["full_name"].ToString();
                TextBox7.Text = dr.Rows[0]["acount_status"].ToString();
                TextBox8.Text = dr.Rows[0]["dob"].ToString();
                TextBox9.Text = dr.Rows[0]["contact_no"].ToString();
                TextBox10.Text = dr.Rows[0]["email"].ToString();
                TextBox11.Text = dr.Rows[0]["state"].ToString();
                TextBox12.Text = dr.Rows[0]["city"].ToString();
                TextBox13.Text = dr.Rows[0]["pincode"].ToString();
                TextBox3.Text = dr.Rows[0]["full_address"].ToString();


            }
        }
        //delete
        protected void Button1_Click(object sender, EventArgs e)
        {
            member_master_tbl member = defMember();

            if (log.checkiMemberExistsissue(member, "select * from  member_master_tbl where member_id= @member_id ", "@member_id"))
            {
                log.deleteMemberFromDB(member);
                GridView1.DataBind();
                clear();
            }
            else
            {
                Response.Write("<script>alert('Member not Exist please check Id to deleted');</script>");
            }
        }
        void clear()
        {
            TextBox2.Text = string.Empty;
            TextBox7.Text = string.Empty;
            TextBox8.Text = string.Empty;
            TextBox9.Text = string.Empty;
            TextBox10.Text = string.Empty;
            TextBox11.Text = string.Empty;
            TextBox12.Text = string.Empty;
            TextBox13.Text = string.Empty;
            TextBox3.Text = string.Empty;
            TextBox1.Text = string.Empty;
        }
    }
}