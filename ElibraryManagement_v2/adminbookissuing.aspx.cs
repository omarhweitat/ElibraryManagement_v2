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
    public partial class adminbookissuing : System.Web.UI.Page
    {
        public book_master_tbl defBook()
        {
            book_master_tbl book = new book_master_tbl()
            {
                book_id = TextBox2.Text.Trim()
            };
            return book;
        }
        public member_master_tbl defMember()
        {
            member_master_tbl member = new member_master_tbl()
            {
                member_id = TextBox1.Text.Trim()
            };
            return member;
        }
        public book_issue_tbl defBookIssue()
        {
            book_issue_tbl book_Issue = new book_issue_tbl()
            {
                member_id = TextBox1.Text.Trim(),
                book_id = TextBox2.Text.Trim(),
                member_name = TextBox3.Text.Trim(),
                book_name = TextBox4.Text.Trim(),
                issue_date = TextBox5.Text.Trim(),
                due_date = TextBox6.Text.Trim()
            };
            return book_Issue;
        }
        BL log = new BL();
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
        void getNames()
        {
            book_master_tbl book = defBook();
            member_master_tbl member = defMember();
            
            DataTable dt = log.getNameBookfromDB(book);


            if (dt.Rows.Count >= 1)
            {
                TextBox4.Text = dt.Rows[0]["book_name"].ToString();
            }
            else
            {
                Response.Write("<script>alert('wrong book ID')</script>");
            }
            //////
           
            dt = log.getNameMemberFromDB(member);

                if (dt.Rows.Count >= 1)
                {
                    TextBox3.Text = dt.Rows[0]["full_name"].ToString();
                }
                else
                {
                    Response.Write("<script>alert('wrong book ID')</script>");
                }
            }
        //go
        protected void Button3_Click(object sender, EventArgs e)
        {
            getNames();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            book_master_tbl book = defBook();
            member_master_tbl member = defMember();
            book_issue_tbl book_Issue = defBookIssue();
            if (log.checkifBookExistsissue(book, "select * from  book_master_tbl where book_id= @book_id and current_stock > 0 ", "@book_id") && log.checkiMemberExistsissue(member, "select full_name from  member_master_tbl where member_id= @member_id ","@member_id"))
            {
                if (log.checkIfIssueEntryExist(book_Issue))
                {
                    Response.Write("<script>alert('this member already has this book')</script>");
                }
                else
                {
                    log.issueBook(book_Issue);
                    GridView1.DataBind();
                }

            }
            else
            {
                Response.Write("<script>alert('wrong book ID or member Id')</script>");

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            book_master_tbl book = defBook();
            member_master_tbl member = defMember();
            book_issue_tbl book_Issue = defBookIssue();
            if (log.checkifBookExistsissue(book, "select * from  book_master_tbl where book_id= @book_id and current_stock > 0 ", "@book_id") && log.checkiMemberExistsissue(member, "select full_name from  member_master_tbl where member_id= @member_id ", "@member_id"))
            {
                if (log.checkIfIssueEntryExist(book_Issue))
                {
                    log.returnBook(book_Issue);
                    Response.Write("<script>alert('Book Returned Successfully')</script>");
                    GridView1.DataBind();
                }
                else
                {
                    Response.Write("<script>alert('this entry does not exist')</script>");
                }

            }
            else
            {
                Response.Write("<script>alert('wrong book ID or member Id')</script>");

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
