using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using BussneisObject;
using System.Data;
using System.Data.SqlClient;
namespace BussneisLogic
{
    public class BL
    {
        DAL check = new DAL();
        public bool checkexists(member_master_tbl mb)
        {
            
            return check.checkMemberExists(mb);
        }
        public DataTable MemberData(member_master_tbl mb)
        {
           
            return check.Member1(mb);
        }
        public int signmember(member_master_tbl mb)
        {
           
            return check.signUpNewUser(mb);
        }
        //author
        public bool checkauthor(author_master_tbl mb,string query,string id)
        {
            
            return check.checkAutherExists(mb,query,id);
        }
        public DataTable editauthor(author_master_tbl mb,string query,string id,string name)
        {
           
           return check.addNewAuthor(mb,query,id,name);
        }
        //publisher
        public bool checkPublisher(publisher_master_tbl publisher, string query, string id)
        {
            
            return check.checkpublisherExists(publisher, query, id);
        }

        public DataTable editPublisher(publisher_master_tbl publisher, string query, string id, string name)
        {
            
            return check.addNewPublisher(publisher, query, id, name);
        }
        //book inventory
        public bool checkbookexists(book_master_tbl book, string query, string id, string name)
        {
            return check.checkifBookExists(book, query, id, name);
        }
        public void addBook(book_master_tbl book,string query, string genres, string filepath)

        {
            check.addBook(book,query, genres, filepath);
           
        }
        public void deleteBook(book_master_tbl book)
        {
            check.Delete(book);
        }
        public DataTable getDataById(book_master_tbl book)
        {
            return check.getDataByID(book);
        }
        //book issue
        public DataTable getNameBookfromDB(book_master_tbl book)
        {
            return check.getNameBookfromDB(book);
        }
        public DataTable getNameMemberFromDB(member_master_tbl member)
        {
            return check.getNameMemberFromDB(member);
        }
        public bool checkifBookExistsissue(book_master_tbl book, string query, string id)
        {
            return check.checkifBookExistsissue(book, query, id);
        }
        public bool checkiMemberExistsissue(member_master_tbl member, string query, string id)
        {
            return check.checkiMemberExistsissue(member, query, id);
        }
        public bool checkIfIssueEntryExist(book_issue_tbl issue_Tbl)
        {
            return check.checkIfIssueEntryExist(issue_Tbl);
        }
        public void issueBook(book_issue_tbl book_Issue)
        {
            check.issueBook(book_Issue);
        }
        public void returnBook(book_issue_tbl book_Issue)
        {
            check.returnBook(book_Issue);
        }
        public DataTable getDataFromDBMember(member_master_tbl member)
        {
            return check.getDataFromDBMember(member);
        }
        public void updateMemberStatusById(member_master_tbl member, string status)
        {
            check.updateMemberStatusById(member, status);
        }
        public void deleteMemberFromDB(member_master_tbl member)
        {
            check.deleteMemberFromDB(member);
        }
        public DataTable checkadmin(admin_login admin)
        {
            return check.checkadmin(admin);
        }
        public DataTable getUserBookData(string username)
        {
            return check.getUserBookData(username);
        }
        public DataTable getUserData(string username)
        {
            return check.getUserData(username);
        }
        public int updateDataPersonalUser(member_master_tbl member, string username, string password)
        {
            return check.updateDataPersonalUser(member, username, password);
        }
    }
}
