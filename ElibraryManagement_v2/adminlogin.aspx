<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminlogin.aspx.cs" Inherits="ElibraryManagement_v2.adminlogin" %>
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
                          <img src="img/adminuser.png" width="150px"/>
                        </center>
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                        <center>
                            <h3>Admin Login</h3>
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
                       
                        <div class="form-group">
                            <asp:TextBox ID="txtmemberid" CssClass="form-control" runat="server" placeholder="admin ID"></asp:TextBox>
                        </div>
                        
                        <div class="form-group">
                            <asp:TextBox ID="txtpassword" CssClass="form-control" runat="server" placeholder="Password" textmode="Password"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Button ID="Button" class="btn btn-primary btn-block btn-lg" runat="server" Text="Login" OnClick="Button_Click"  />
                        </div>
                        
                    </div>
                </div>
            </div>
             <a href="HomePage.aspx"><< Back to Home
        </div>
       
    </div>
</div>
</a>
</asp:Content>
