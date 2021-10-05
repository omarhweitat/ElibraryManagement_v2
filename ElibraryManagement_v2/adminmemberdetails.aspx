<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminmemberdetails.aspx.cs" Inherits="ElibraryManagement_v2.adminmember" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">

      $(document).ready(function () {
          $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
        });
        </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="container-fluid">
        <div class="row">
            <div class="col-md-5">
                <div class="card">
                    <div class="card-body">
                        <div class="row">

                            <div class="col">
                                <center>
                                <h4>Member Details</h4>
                            </center>
                            </div>
                        </div>
                        <div class="row">

                            <div class="col">
                                <center>
                               <img src="img/generaluser.png" width="150px" />
                            </center>
                            </div>
                        </div>
                        
                        <div class="row">
                            <div class="col-md-3">
                                <label>Member ID</label>
                                <div class="form-group">
                                    <div class="input-group">
                                <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" ></asp:TextBox></asp:TextBox><asp:LinkButton ID="Button3" runat="server" Text="Go" class="btn  btn-primary mr-1" OnClick="Button3_Click" ><i  class="fas fa-check-circle"></i></asp:LinkButton>
                            </div>
                                     </div>
                            </div>


                            <div class="col-md-4">
                                <label>Full Name</label>
                                
                                        <asp:TextBox ID="TextBox2" runat="server" ReadOnly="true" CssClass="form-control"></asp:TextBox>
                                    </div>
                            <div class="col-md-5">

                                <label>Account Status</label>
                                <div class="form-group">
                                    <div class="input-group">
                                          <asp:TextBox ID="TextBox7" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                                <asp:LinkButton CssClass="btn btn-success mr-1" ID="Button2" runat="server" Text="A" OnClick="Button2_Click"  ><i  class="fas fa-check-circle"></i></asp:LinkButton>

                                <asp:LinkButton CssClass="btn btn-warning mr-1" ID="Button4" runat="server" Text="P" OnClick="Button4_Click"  ><i  class="fas fa-pause-circle"></i></asp:LinkButton>
                                <asp:LinkButton CssClass="btn btn-danger mr-1" ID="Button5" runat="server" Text="D" OnClick="Button5_Click"  ><i  class="fas fa-times-circle"></i></asp:LinkButton>
                         
                                    </div>
                                </div>
                                         </div>
                               
                        </div>
                         <div class="row">
                            <div class="col-md-4">
                                <label>DOB</label>
                                <asp:TextBox ID="TextBox8" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                            </div>
                                     

                            <div class="col-md-4">
                                <label>Contact No</label>
                                
                                        <asp:TextBox ID="TextBox9" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                                    </div>
                            <div class="col-md-4">
                                <label>Email ID</label>
                                
                                        <asp:TextBox ID="TextBox10" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                                    </div>
                               
                        </div>
                        <div class="row">
                            <div class="col-md-4">
                                <label>State</label>
                                <asp:TextBox ID="TextBox11" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                            </div>
                                     

                            <div class="col-md-4">
                                <label>City</label>
                                
                                        <asp:TextBox ID="TextBox12" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                                    </div>
                            <div class="col-md-4">
                                <label>Pin Code</label>
                                
                                        <asp:TextBox ID="TextBox13" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                                    </div>
                               
                        </div>
                        <div class="row">
                            <div class="col">
                                <label>Full Postal Address</label>
                                <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine" Rows="2" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                            </div>
                        </div>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:elibraryDBConnectionString %>" SelectCommand="SELECT * FROM [member_master_tbl]"></asp:SqlDataSource>
                        <br />
                        <div class="row">
                            <div class="col">
                                <asp:Button ID="Button1" runat="server" Text="Delete User Permanently"  class="btn  btn-success btn-block" OnClick="Button1_Click" />
                                 </div>
                        </div>
                        </div>
                    </div>
                <a href="HomePage.aspx"><< Back to Home</a>
                </div>



                        
                     
                        
            <div class="col-md-7">
                <div class="card">
                    <div class="card-body">
                        <div class="row">

                            <div class="col">
                                <center>
                                <h4>Member List</h4>
                            </center>
                            </div>
                            </div>
                           <div class="row">
                               <div class="col">
                                   <hr >
                               </div>
                           </div>
                            <div class="row">
                                <div class="col">
                                    <asp:GridView  class="table table-striped table-bordered" ID="GridView1" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False" DataKeyNames="member_id">
                                        <Columns>
                                            <asp:BoundField DataField="member_id" HeaderText="ID" ReadOnly="True" SortExpression="member_id" />
                                            <asp:BoundField DataField="full_name" HeaderText="Full Name" SortExpression="full_name" />
                                            <asp:BoundField DataField="dob" HeaderText="Date of Birth" SortExpression="dob" />
                                            <asp:BoundField DataField="contact_no" HeaderText="Phone" SortExpression="contact_no" />
                                            <asp:BoundField DataField="email" HeaderText="Email" SortExpression="email" />
                                            <asp:BoundField DataField="state" HeaderText="State" SortExpression="state" />
                                            <asp:BoundField DataField="city" HeaderText="City" SortExpression="city" />
                                            <asp:BoundField DataField="full_address" HeaderText="Full Address" SortExpression="full_address" />
                                            <asp:BoundField DataField="password" HeaderText="Password" SortExpression="password" />
                                            <asp:BoundField DataField="acount_status" HeaderText="Acount Status" SortExpression="acount_status" />
                                        </Columns>
                                    </asp:GridView>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            
        </div>
    </div>
</asp:Content>
