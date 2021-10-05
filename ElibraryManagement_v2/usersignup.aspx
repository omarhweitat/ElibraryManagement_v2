<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="usersignup.aspx.cs" Inherits="ElibraryManagement_v2.usersignup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
    <div class="row">
        <div class="col-md-8 mx-auto">
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
                            <h3>User Registration</h3>
                        </center>
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                           <hr>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-6">
                           <label>Full Name</label>
                        <div class="form-group">
                            <asp:TextBox ID="txtfullname" CssClass="form-control" runat="server" placeholder="Full Name" ></asp:TextBox>
                        </div>
                    </div>
                
                
                    <div class="col-md-6">
                           <label>Data of Birth</label>
                        <div class="form-group">
                            <asp:TextBox ID="txtdataofbirth" CssClass="form-control" runat="server" placeholder="Member ID" TextMode="Date"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-6">
                           <label>Contact Number</label>
                        <div class="form-group">
                            <asp:TextBox ID="txtcontactnumber" CssClass="form-control" runat="server" placeholder="Contact Number" textmode="Number"></asp:TextBox>
                        </div>
                    </div>
                
                
                    <div class="col-md-6">
                           <label>Email ID</label>
                        <div class="form-group"> 
                            <asp:TextBox ID="txtemailid" CssClass="form-control" runat="server" placeholder="Email ID" textmode="Email"></asp:TextBox>
                        </div>
                    </div>
                </div>
                 <div class="row">
                    <div class="col-md-4">
                           <label>State</label>
                        <div class="form-group">
                            <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server">
                                <asp:ListItem>offline</asp:ListItem>
                                <asp:ListItem>active</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                
                
                    <div class="col-md-4">
                           <label>City</label>
                        <div class="form-group"> 
                            <asp:TextBox ID="txtcity" CssClass="form-control" runat="server" placeholder="City" ></asp:TextBox>
                        </div>
                    </div>
                     <div class="col-md-4">
                           <label>Pin Code</label>
                        <div class="form-group"> 
                            <asp:TextBox ID="txtpincode" CssClass="form-control" runat="server" placeholder="Pin Code" textmode="Number"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                           <label>Full Address</label>
  
                        <div class="form-group">
                            <asp:TextBox ID="txtfulladdress" CssClass="form-control" runat="server" placeholder="Full Address" textmode="MultiLine" Rows="2"></asp:TextBox>
                        </div>
                    </div>
                
                </div>
                <div class="row">
                    
                        <div class="col">
                            <center>
                        <span class="badge rounded-pill bg-primary ">Login Credentials</span>
                    </center>
                                </div>
                    
                   
                </div>
                
                 <div class="row">
                    <div class="col-md-6">
                           <label>User ID</label>
                        <div class="form-group">
                            <asp:TextBox ID="txtuserid" CssClass="form-control" runat="server" placeholder="User ID" ></asp:TextBox>
                        </div>
                    </div>
                
                
                    <div class="col-md-6">
                           <label>Password</label>
                        <div class="form-group"> 
                            <asp:TextBox ID="txtpassword" CssClass="form-control" runat="server" placeholder="Password" textmode="password"></asp:TextBox>
                        </div>
                    </div>
                </div>   
                <div class="row">
                    <div class="col">
                        
                        <div class="form-group">
                            <asp:Button ID="Button1" class="btn btn-primary btn-block btn-lg" runat="server" Text="Sign Up" OnClick="Button1_Click"  />
                        </div>
                        
                    </div>
                </div>
            </div>
             <a href="HomePage.aspx"><< Back to Home</a>
        </div>
       
    </div>
</div>
</asp:Content>
