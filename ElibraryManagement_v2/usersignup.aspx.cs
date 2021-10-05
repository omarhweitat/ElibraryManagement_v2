using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussneisLogic;
using BussneisObject;

namespace ElibraryManagement_v2
{
    public partial class usersignup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        

        protected void Button1_Click(object sender, EventArgs e)
        {
            member_master_tbl member = new member_master_tbl()
            {
                full_Name = txtfullname.Text,
                dob = txtdataofbirth.Text,
                contact_no = txtcontactnumber.Text,
                email = txtemailid.Text,
                state=DropDownList1.SelectedValue,
                city=txtcity.Text,
                pincode=txtpincode.Text,
                full_address=txtfulladdress.Text,
                member_id = txtuserid.Text,
                password = txtpassword.Text
            };
            BL b = new BL();
            if(b.checkexists(member))
            {
                Response.Write("<script>alert('Member Already Exist with this Member ID,try other ID');</script>");
            }
            else
            {
                if (b.signmember(member) > 0)
                {
                    Response.Write("<script>alert('Add Successfully');</script>");
                }
            }
            
        }
    }
}