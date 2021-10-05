<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="userlogin.aspx.cs" Inherits="ElibraryManagement_v2.userlogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="container">
    <div class="row">
        <div class="col-md-6 mx-auto">
            <div class="card">
                <div class="card-body">
                    <div class="col">
                        <center>
                            <img src="img/generaluser.png" width="150px"/>
                        </center>
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                        <center>
                            <h3>Member Login</h3>
                        </center>
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                           <hr>
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                        <label>Member ID</label>
                        <div class="form-group">
                            <asp:TextBox ID="txtmemberid" CssClass="form-control" runat="server" placeholder="Member ID"></asp:TextBox>
                        </div>
                        <label>Password</label>
  
                        <div class="form-group">
                            <asp:TextBox ID="txtpassword" CssClass="form-control" runat="server" placeholder="Password" textmode="Password"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Button ID="Button1" class="btn btn-primary btn-block btn-lg" runat="server" Text="Login" OnClick="Button1_Click" />
                        </div>
                        <div class="form-group">
                            <a href="usersignup.aspx"><input id="Button2" class="btn btn-info btn-block btn-lg" type="button" value="Sign Up" />   </a>
                         </div>
                    </div>
                </div>
            </div>
             <a href="HomePage.aspx"><< Back to Home
        </div>
       
    </div>
</div>
</asp:Content>

