<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="userprofile.aspx.cs" Inherits="ElibraryManagement_v2.userprofile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">

      $(document).ready(function () {
          $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
        });
        </script>
 <div class="container-fluid">
    <div class="row">
        <div class="col-md-5 ">
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
                            <h3>Your Profile</h3>
                            <span>Account Status - </span>
                            <asp:Label class="badge badge-pill badge-info" ID="Label1" runat="server" Text="your status"></asp:Label>
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
                            <asp:TextBox ID="TextBox3" CssClass="form-control" runat="server" placeholder="Full Name" ></asp:TextBox>
                        </div>
                    </div>
                
                
                    <div class="col-md-6">
                           <label>Data of Birth</label>
                        <div class="form-group">
                            <asp:TextBox ID="TextBox4" CssClass="form-control" runat="server" placeholder="Member ID" TextMode="Date"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-6">
                           <label>Contact Number</label>
                        <div class="form-group">
                            <asp:TextBox ID="TextBox5" CssClass="form-control" runat="server" placeholder="Contact Number" textmode="Number"></asp:TextBox>
                        </div>
                    </div>
                
                
                    <div class="col-md-6">
                           <label>Email ID</label>
                        <div class="form-group"> 
                            <asp:TextBox ID="TextBox6" CssClass="form-control" runat="server" placeholder="Email ID" textmode="Email"></asp:TextBox>
                        </div>
                    </div>
                </div>
                 <div class="row">
                    <div class="col-md-4">
                           <label>State</label>
                        <div class="form-group">
                            <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server">
                                <asp:ListItem>active</asp:ListItem>
                                <asp:ListItem>panding</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                
                
                    <div class="col-md-4">
                           <label>City</label>
                        <div class="form-group"> 
                            <asp:TextBox ID="TextBox8" CssClass="form-control" runat="server" placeholder="City" ></asp:TextBox>
                        </div>
                    </div>
                     <div class="col-md-4">
                           <label>Pin Code</label>
                        <div class="form-group"> 
                            <asp:TextBox ID="TextBox9" CssClass="form-control" runat="server" placeholder="Pin Code" textmode="Number"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                           <label>Full Address</label>
  
                        <div class="form-group">
                            <asp:TextBox ID="TextBox7" CssClass="form-control" runat="server" placeholder="Full Address" textmode="MultiLine" Rows="2"></asp:TextBox>
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
                    <div class="col-md-4">
                           <label>User ID</label>
                        <div class="form-group">
                            <asp:TextBox ID="TextBox10" CssClass="form-control" runat="server" placeholder="User ID" ReadOnly="true"></asp:TextBox>
                        </div>
                    </div>
                
                
                    <div class="col-md-4">
                           <label>Old Password</label>
                        <div class="form-group"> 
                            <asp:TextBox ID="TextBox11" CssClass="form-control" runat="server" placeholder="Old Password"  ReadOnly="true"></asp:TextBox>
                        </div>
                    </div>
                     <div class="col-md-4">
                           <label>New Password</label>
                        <div class="form-group"> 
                            <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server" placeholder="New Password" ></asp:TextBox>
                        </div>
                    </div>
                </div>   
                <div class="row">
                    <div class="col-md-6 mx-auto">
                       <center>
                            <div class="form-group">
                            <asp:Button ID="Button1" class="btn btn-primary btn-block  btn-lg" runat="server" Text="Update" OnClick="Button1_Click" />
                        </div>
                       </center> 
                       
                        
                    </div>
                </div>
            </div>
             <a href="HomePage.aspx"><< Back to Home</a>
        </div>
       <div class="col-md-7">
             <div class="card">
                <div class="card-body">
                    <div class="col">
                        <center>
                            <img src="img/books1.png" width="150px"/>
                        </center>
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                        <center>
                            <h3>Your Issued Books</h3>
                            
                            <asp:Label CssClass="badge badge-pill badge-info" ID="Label2" runat="server" Text="your books info"></asp:Label>
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
                        <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" OnRowDataBound="GridView1_RowDataBound"></asp:GridView>
                    </div>
                </div>
               
                    
  
    </div>
   </div>
  </div>
</div>
</asp:Content>

