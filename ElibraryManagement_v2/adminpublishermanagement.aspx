<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminpublishermanagement.aspx.cs" Inherits="ElibraryManagement_v2.adminpublishermanagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">

      $(document).ready(function () {
          $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
        });
        </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div class="container">
        <div class="row">
            <div class="col-md-5">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                          <h1>
                              <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DBCS %>" SelectCommand="SELECT * FROM [publisher_master_tbl]"></asp:SqlDataSource>
                              Publisher Details</h1>
                            </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                          <img src="img/publisher.png"  width="100px"/>
                            </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <hr>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-4">
                                <label>Publisher ID</label>
                                <div class="form-group">
                                    <div class="input-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="ID"></asp:TextBox><asp:Button CssClass="btn btn-primary  " ID="Button1" runat="server" Text="Go" OnClick="Button1_Click" />
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-8">
                                <label>Publisher Name</label>
                                <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" placeholder="Publisher Name"></asp:TextBox>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-4">
                                <asp:Button ID="Button2" runat="server" Text="Add" class="btn btn-lg btn-success btn-block" OnClick="Button2_Click"/>
                            </div>
                             <div class="col-4">
                                <asp:Button ID="Button3" runat="server" Text="Update" class="btn btn-lg btn-warning btn-block" OnClick="Button3_Click"/>
                            </div>
                             <div class="col-4">
                                <asp:Button ID="Button4" runat="server" Text="Delete " class="btn btn-lg btn-danger btn-block" OnClick="Button4_Click"/>
                            </div>
                        </div>

                    </div>
                   
                </div>
            </div>
             <div class="col-md-7">
                 <div class="card">
                     <div class="card-body">
                         <div class="row">
                             <div class="col">
                                 <center>
                                     <h4>Publisher List</h4>
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
                                 <asp:GridView class="table table-stripes table-bordered" ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="publisher_id" DataSourceID="SqlDataSource1">
                                     <Columns>
                                         <asp:BoundField DataField="publisher_id" HeaderText="publisher_id" ReadOnly="True" SortExpression="publisher_id" />
                                         <asp:BoundField DataField="publisher_name" HeaderText="publisher_name" SortExpression="publisher_name" />
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

