using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussneisObject;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace DataAccess
{
    public class DAL
    {
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        public bool checkMemberExists(member_master_tbl member)
        {

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("select * from member_master_tbl where member_id= @username and password=@password", con);
                cmd.Parameters.AddWithValue("@username", member.member_id);
                cmd.Parameters.AddWithValue("@password", member.password);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {

                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
        public DataTable Member1(member_master_tbl member)
        {

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter cmd = new SqlDataAdapter("select * from member_master_tbl where member_id= @username and password=@password", con);
                cmd.SelectCommand.Parameters.AddWithValue("@username", member.member_id);
                cmd.SelectCommand.Parameters.AddWithValue("@password", member.password);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                return dt;
            }
        }
        public int signUpNewUser(member_master_tbl member)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("insert into member_master_tbl ( full_name,dob,contact_no,email,state,city,pincode,full_address,member_id,password,acount_status) " +
                    "values( @full_name,@dob,@contact_no,@email,@state,@city,@pincode,@full_address,@member_id,@password,@acount_status)", con);
                cmd.Parameters.AddWithValue("@full_name", member.full_Name);
                cmd.Parameters.AddWithValue("@dob", member.dob);
                cmd.Parameters.AddWithValue("@contact_no", member.contact_no);
                cmd.Parameters.AddWithValue("@email", member.email);
                cmd.Parameters.AddWithValue("@state", member.state);
                cmd.Parameters.AddWithValue("@city", member.city);
                cmd.Parameters.AddWithValue("@pincode", member.pincode);
                cmd.Parameters.AddWithValue("@full_address", member.full_Name);
                cmd.Parameters.AddWithValue("@member_id", member.member_id);
                cmd.Parameters.AddWithValue("@password", member.password);
                cmd.Parameters.AddWithValue("@acount_status", "panding");
                con.Open();
                int result = cmd.ExecuteNonQuery();
                return result;

            }
        }

        //author
        public bool checkAutherExists(author_master_tbl author, string query, string id)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue(id, author.author_id);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        public DataTable addNewAuthor(author_master_tbl author, string query, string id, string name)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter dr = new SqlDataAdapter(query, con);
                dr.SelectCommand.Parameters.AddWithValue(id, author.author_id);
                dr.SelectCommand.Parameters.AddWithValue(name, author.author_name);
                DataTable ds = new DataTable();
                dr.Fill(ds);
                return ds;

            }
        }
        //publisher
        public bool checkpublisherExists(publisher_master_tbl publisher, string query, string id)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue(id, publisher.publisher_id);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
        public DataTable addNewPublisher(publisher_master_tbl publisher, string query, string id, string name)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter dr = new SqlDataAdapter(query, con);
                dr.SelectCommand.Parameters.AddWithValue(id, publisher.publisher_id);
                dr.SelectCommand.Parameters.AddWithValue(name, publisher.publisher_name);
                DataTable ds = new DataTable();
                dr.Fill(ds);
                return ds;

            }
        }

        //bookinviroment
        public bool checkifBookExists(book_master_tbl book, string query, string id, string name)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                //"select * from  book_master_tbl where book_id= @book_id or book_name=@book_name "
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue(id, book.book_id);
                cmd.Parameters.AddWithValue(name, book.book_name);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public void addBook(book_master_tbl book, string query, string genres, string filepath)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter dr = new SqlDataAdapter(query, con);
                dr.SelectCommand.Parameters.AddWithValue("@book_id", book.book_id);
                dr.SelectCommand.Parameters.AddWithValue("@book_name", book.book_name);
                dr.SelectCommand.Parameters.AddWithValue("@genre", genres);

                dr.SelectCommand.Parameters.AddWithValue("@author_name", book.auhor_name);
                dr.SelectCommand.Parameters.AddWithValue("@publisher_name", book.publisher_name);
                dr.SelectCommand.Parameters.AddWithValue("@publisher_date", book.publisher_name);
                dr.SelectCommand.Parameters.AddWithValue("@languge", book.language);
                dr.SelectCommand.Parameters.AddWithValue("@edition", book.edition);
                dr.SelectCommand.Parameters.AddWithValue("@book_cost", book.book_cost);
                dr.SelectCommand.Parameters.AddWithValue("@no_of_pages", book.no_of_page);
                dr.SelectCommand.Parameters.AddWithValue("@book_description", book.book_description);
                dr.SelectCommand.Parameters.AddWithValue("@actual_stock", book.actual_stock);
                dr.SelectCommand.Parameters.AddWithValue("@current_stock", book.actual_stock);
                dr.SelectCommand.Parameters.AddWithValue("@book_img_link", filepath);

                DataSet ds = new DataSet();
                dr.Fill(ds);


            }
        }
        public void Delete(book_master_tbl book)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter dr = new SqlDataAdapter("delete from  book_master_tbl where book_id= @member_id", con);
                dr.SelectCommand.Parameters.AddWithValue("@member_id", book.book_id);
                DataSet ds = new DataSet();
                dr.Fill(ds);
                //GridView1.DataBind();
            }
        }
        public DataTable getDataByID(book_master_tbl book)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                //author
                SqlCommand cmd = new SqlCommand("select * from book_master_tbl where book_id=@book_id", con);
                cmd.Parameters.AddWithValue("@book_id", book.book_id);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                return table;
            }
        }
        //book issue
        public DataTable getNameBookfromDB(book_master_tbl book)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("select * from book_master_tbl where book_id=@book_id ", con);
                cmd.Parameters.AddWithValue("@book_id", book.book_id);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable getNameMemberFromDB(member_master_tbl member)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("select * from member_master_tbl where member_id =@member_id", con);
                cmd.Parameters.AddWithValue("@member_id", member.member_id);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public bool checkiMemberExistsissue(member_master_tbl member, string query, string id)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                //"select * from  book_master_tbl where book_id= @book_id or book_name=@book_name "
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue(id, member.member_id);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool checkifBookExistsissue(book_master_tbl book, string query, string id)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                //"select * from  book_master_tbl where book_id= @book_id or book_name=@book_name "
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue(id, book.book_id);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool checkIfIssueEntryExist(book_issue_tbl issue_Tbl)
        {

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("select* from  book_issue_tbl where member_id= @member_id and book_id=@book_id", con);
                cmd.Parameters.AddWithValue("@member_id", issue_Tbl.member_id);
                cmd.Parameters.AddWithValue("@book_id", issue_Tbl.book_id);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
        public void issueBook(book_issue_tbl book_Issue)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter dr = new SqlDataAdapter("insert into book_issue_tbl (member_id ,member_name,book_id,book_name,issue_date,due_date) values(@member_id,@member_name,@book_id ,@book_name,@issue_date,@due_date)", con);
                dr.SelectCommand.Parameters.AddWithValue("@member_id", book_Issue.member_id);
                dr.SelectCommand.Parameters.AddWithValue("@member_name", book_Issue.member_name);
                dr.SelectCommand.Parameters.AddWithValue("@book_id", book_Issue.book_id);
                dr.SelectCommand.Parameters.AddWithValue("@book_name", book_Issue.book_name);
                dr.SelectCommand.Parameters.AddWithValue("@issue_date", book_Issue.issue_date);
                dr.SelectCommand.Parameters.AddWithValue("@due_date", book_Issue.due_date);



                DataSet ds = new DataSet();
                dr.Fill(ds);
                dr = new SqlDataAdapter("update book_master_tbl set current_stock=current_stock-1 where book_id=@book_id", con);
                dr.SelectCommand.Parameters.AddWithValue("@book_id", book_Issue.book_id);
                ds = new DataSet();
                dr.Fill(ds);
                // GridView1.DataBind();
            }
        }
        public void returnBook(book_issue_tbl book_Issue)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("delete from book_issue_tbl where book_id=@book_id and member_id=@member_id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@book_id", book_Issue.book_id);
                cmd.Parameters.AddWithValue("@member_id", book_Issue.member_id);
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    cmd = new SqlCommand("update book_master_tbl set current_stock =current_stock+1 where book_id=@book_id", con);
                    cmd.Parameters.AddWithValue("@book_id", book_Issue.book_id);
                    cmd.ExecuteNonQuery();
                    con.Close();

                }
            }
        }

        /// //////////

        public DataTable getDataFromDBMember(member_master_tbl member)
        {

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter cmd = new SqlDataAdapter("select * from  member_master_tbl where member_id= @member_id", con);
                cmd.SelectCommand.Parameters.AddWithValue("@member_id", member.member_id);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                return dt;
            }
        }
        public void updateMemberStatusById(member_master_tbl member, string status)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("update member_master_tbl set acount_status= @acount_status where member_id= @member_id  ", con);
                cmd.Parameters.AddWithValue("@acount_status", status);
                cmd.Parameters.AddWithValue("@member_id", member.member_id);
                con.Open();
                cmd.ExecuteNonQuery();


            }
        }
        public void deleteMemberFromDB(member_master_tbl member)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter dr = new SqlDataAdapter("delete from  member_master_tbl where member_id= @member_id", con);
                dr.SelectCommand.Parameters.AddWithValue("@member_id", member.member_id);
                DataSet ds = new DataSet();
                dr.Fill(ds);

            }
        }
        ////admin
        ///
        public DataTable checkadmin(admin_login admin)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter cmd = new SqlDataAdapter("select * from admin_login_tbl where username= @username and password=@password", con);
                cmd.SelectCommand.Parameters.AddWithValue("@username", admin.username);
                cmd.SelectCommand.Parameters.AddWithValue("@password", admin.password);
                con.Open();
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                return dt;
            }
        }
        public DataTable getUserBookData(string username)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter cmd = new SqlDataAdapter("select * from  book_issue_tbl where member_id= @member_id ", con);
                cmd.SelectCommand.Parameters.AddWithValue("@member_id", username);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                return dt;
            }
        }
        public DataTable getUserData(string username)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter cmd = new SqlDataAdapter("select * from  member_master_tbl where member_id= @member_id ", con);
                cmd.SelectCommand.Parameters.AddWithValue("@member_id", username);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                return dt;
            }
        }
       public int updateDataPersonalUser(member_master_tbl member,string username,string password)
        {
            
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("update member_master_tbl set full_name=@full_name,dob=@dob,contact_no=@contact_no,email=@email,state=@state,city=@city,pincode=@pincode,full_address=@full_address," +
                    "password=@password,account_status=@account_status where member_id='" + username + "'", con);
                con.Open();
                cmd.Parameters.AddWithValue("@full_name", member.full_Name);
                cmd.Parameters.AddWithValue("@dob", member.dob);
                cmd.Parameters.AddWithValue("@contact_no", member.contact_no);
                cmd.Parameters.AddWithValue("@email", member.email);
                cmd.Parameters.AddWithValue("@state", member.state);
                cmd.Parameters.AddWithValue("@city", member.city);
                cmd.Parameters.AddWithValue("@pincode", member.pincode);
                cmd.Parameters.AddWithValue("@full_address", member.full_Name);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@account_status", "panding");
                int result = cmd.ExecuteNonQuery();
                return result;
            }
        }
    }
}
