using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussneisLogic;
using BussneisObject;
using System.Data.SqlClient;
using System.Data;
namespace ElibraryManagement_v2
{
    public partial class userprofile : System.Web.UI.Page
    {
        public member_master_tbl defMember()
        {
            member_master_tbl member = new member_master_tbl()
            {

            };
            return member;
        }
        BL log = new BL();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["username"].ToString().Equals("") || Session["username"] == null)
                {
                    Response.Write("<script>alert('Session Expired Login Again');</script>");
                    Response.Redirect("userlogin.aspx");
                }
                else
                {
                    DataTable dt = log.getUserBookData(Session["username"].ToString());
                    GridView1.DataSource = dt;
                    GridView1.DataBind();

                    if (!IsPostBack)
                    {
                        dt = log.getUserData(Session["username"].ToString());
                        if (dt.Rows.Count > 0)
                        {

                            TextBox3.Text = dt.Rows[0]["full_name"].ToString();
                            TextBox4.Text = dt.Rows[0]["dob"].ToString();
                            TextBox5.Text = dt.Rows[0]["contact_no"].ToString();
                            TextBox6.Text = dt.Rows[0]["email"].ToString();
                            TextBox8.Text = dt.Rows[0]["city"].ToString();
                            TextBox9.Text = dt.Rows[0]["pincode"].ToString();
                            TextBox7.Text = dt.Rows[0]["full_address"].ToString();
                            TextBox10.Text = dt.Rows[0]["member_id"].ToString();
                            TextBox11.Text = dt.Rows[0]["password"].ToString();
                            DropDownList1.SelectedValue = dt.Rows[0]["state"].ToString();
                            Label1.Text = dt.Rows[0]["acount_status"].ToString();
                            if (dt.Rows[0]["acount_status"].ToString().Trim().ToLower() == "active")
                            {
                                Label1.Attributes.Add("class", "badge badge-pill badge-success");
                            }
                            else if (dt.Rows[0]["acount_status"].ToString().Trim().ToLower() == "panding")
                            {
                                Label1.Attributes.Add("class", "badge badge-pill badge-warning");

                            }
                            else if (dt.Rows[0]["acount_status"].ToString().ToLower() == "deactive")
                            {
                                Label1.Attributes.Add("class", "badge badge-pill badge-danger");

                            }
                            else
                            {
                                Label1.Attributes.Add("class", "badge badge-pill badge-secondary");

                            }

                        }
                    }
                }
            }

            catch (Exception ex)
            {
                Response.Write("<script>alert('Session Expired Login Again');</script>");
                Response.Redirect("userlogin.aspx");
            }



        }
    
            


        

        
        //update

        protected void Button1_Click(object sender, EventArgs e)
        {
            member_master_tbl member = defMember();
            string password = "";
            if (TextBox1.Text.Trim() == "")
            {
                password = TextBox11.Text.Trim();
            }
            else
            {
                password = TextBox1.Text.Trim();
            }
            if (Session["username"].ToString() == "" || Session["username"] == null)
            {
                Response.Write("<script>alert('Session Expired Login Again');</script>");
                Response.Redirect("userlogin.aspx");
            }
            else
            {
                int result = log.updateDataPersonalUser(member, Session["username"].ToString(), password);

                if (result > 0)
                {
                    Response.Write("<script>alert('your details update successfully');</script>");
                    GridView1.DataSource = log.getUserBookData(Session["username"].ToString());
                    GridView1.DataBind();
                    DataTable dt = log.getUserData(Session["username"].ToString());
                    if (dt.Rows.Count > 0)
                    {

                        TextBox3.Text = dt.Rows[0]["full_name"].ToString();
                        TextBox4.Text = dt.Rows[0]["dob"].ToString();
                        TextBox5.Text = dt.Rows[0]["contact_no"].ToString();
                        TextBox6.Text = dt.Rows[0]["email"].ToString();
                        TextBox8.Text = dt.Rows[0]["city"].ToString();
                        TextBox9.Text = dt.Rows[0]["pincode"].ToString();
                        TextBox7.Text = dt.Rows[0]["full_address"].ToString();
                        TextBox10.Text = dt.Rows[0]["member_id"].ToString();
                        TextBox11.Text = dt.Rows[0]["password"].ToString();
                        DropDownList1.SelectedValue = dt.Rows[0]["state"].ToString();
                        Label1.Text = dt.Rows[0]["acount_status"].ToString();
                        if (dt.Rows[0]["acount_status"].ToString().Trim().ToLower() == "active")
                        {
                            Label1.Attributes.Add("class", "badge badge-pill badge-success");
                        }
                        else if (dt.Rows[0]["acount_status"].ToString().Trim().ToLower() == "panding")
                        {
                            Label1.Attributes.Add("class", "badge badge-pill badge-warning");

                        }
                        else if (dt.Rows[0]["acount_status"].ToString().ToLower() == "deactive")
                        {
                            Label1.Attributes.Add("class", "badge badge-pill badge-danger");

                        }
                        else
                        {
                            Label1.Attributes.Add("class", "badge badge-pill badge-secondary");

                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('Invalid entry');</script>");
                    }
                }
            }
        }
        

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            try
            {
                if (e.Row.RowType == DataControlRowType.DataRow)
                {
                    DateTime dt = Convert.ToDateTime(e.Row.Cells[5].Text);
                    DateTime toDay = DateTime.Today;
                    if (toDay > dt)
                    {
                        e.Row.BackColor = System.Drawing.Color.PaleVioletRed;
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}