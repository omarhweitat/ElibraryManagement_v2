<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminbookinventory.aspx.cs" Inherits="ElibraryManagement_v2.adminbookinventory" %>
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
                                <h4>Book Details</h4>
                            </center>
                            </div>
                        </div>
                        <div class="row">

                            <div class="col">
                                <center>
                               <img id="imgview" src="book_inventory/books.png" width="150px" />
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
                                   <asp:FileUpload ID="FileUpload1" runat="server" onchange="readURL(this);" Class="form-control"/>
                               </div>
                           </div>





                        <div class="row">
                            <div class="col-md-3">
                                <label>Book ID</label>
                                <div class="form-group">
                                    <div class="input-group">
                                <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" ></asp:TextBox></asp:TextBox><asp:LinkButton ID="Button3" runat="server" Text="Go" class="btn  btn-primary mr-1" OnClick="Button3_Click"  ><i  class="fas fa-check-circle"></i></asp:LinkButton>
                            </div>
                                     </div>
                            </div>


                            <div class="col-md-9">
                                <label>Book Name</label>
                                  <div class="form-group">
                                        <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" ></asp:TextBox>
                                    </div>
                                </div>
                            
                               
                        </div>
                        <div class="row">
                            <div class="col-md-4">
                              <label>Language</label>
                                <asp:DropDownList ID="DropDownList1" runat="server" Class="form-control">
                                    <asp:ListItem>English</asp:ListItem>
                                    <asp:ListItem>arabic</asp:ListItem>
                                    <asp:ListItem>france</asp:ListItem>
                                    <asp:ListItem></asp:ListItem>
                                </asp:DropDownList>
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DBCS %>" SelectCommand="SELECT * FROM [book_master_tbl]"></asp:SqlDataSource>
                                <label>publisher Name</label>
                                 <asp:DropDownList ID="DropDownList2" runat="server" Class="form-control" DataSourceID="SqlDataSource3" DataTextField="publisher_name" DataValueField="publisher_name"></asp:DropDownList>
                            </div>

                            <div class="col-md-4">
                                <label>Author Name</label>
                                <asp:DropDownList ID="DropDownList3" runat="server" Class="form-control" DataSourceID="SqlDataSource2" DataTextField="author_name" DataValueField="author_name"></asp:DropDownList>
                                <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:DBCS %>" SelectCommand="SELECT * FROM [publisher_master_tbl]"></asp:SqlDataSource>
                                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:DBCS %>" SelectCommand="SELECT * FROM [author_master_tbl]"></asp:SqlDataSource>
                                <label>Publisher Date</label>
                                <asp:TextBox ID="TextBox4" runat="server" Class="form-control" Textmode="Date"></asp:TextBox>
 
                            </div>
                            <div class="col-md-4">
                             <label>Genre</label>
                                <div class="form-group">
                                    <asp:ListBox ID="ListBox1" runat="server" SelectionMode="Multiple">
                                        <asp:ListItem>Self Help</asp:ListItem>
                                        <asp:ListItem>Movtivaion</asp:ListItem>
                                        <asp:ListItem>Personal Developent</asp:ListItem>
                                    </asp:ListBox>
          
                                </div>
                            </div>

                        </div>


                               <div class="row">
                            <div class="col-md-4">
                              <label>Edition</label>
                                 <asp:TextBox ID="TextBox6" runat="server" Class="form-control" ></asp:TextBox>
 
                                <label>Actual Stock</label>
                                 <asp:TextBox ID="TextBox7" runat="server" Class="form-control" ></asp:TextBox>
 
                            </div>

                            <div class="col-md-4">
                                <label>Book Cost(per unit)</label>
                                   <asp:TextBox ID="TextBox14" runat="server" Class="form-control"></asp:TextBox>
                                <label>Current Stock</label>
                                  <asp:TextBox ID="TextBox5" runat="server" Class="form-control" ReadOnly="true" ></asp:TextBox>
 
                            </div>
                            <div class="col-md-4">
                             <label>Pages</label>
                                   <asp:TextBox ID="TextBox15" runat="server" Class="form-control" ></asp:TextBox>
                                <label>Issued Books</label>
                                  <asp:TextBox ID="TextBox16" runat="server" Class="form-control" ReadOnly="true"></asp:TextBox>
 
                            </div>

                        </div>
                         
                        <div class="row">
                            <div class="col">
                                <label>Book Description</label>
                                <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine" Rows="2" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <br />
                        <div class="row">
                            <div class="col-md-4">
                                <asp:Button ID="Button1" runat="server" Text="Add"  class="btn  btn-info btn-block" OnClick="Button1_Click"/>
                            </div>
                            <div class="col-md-4">
                                <asp:Button ID="Button2" runat="server" Text="Update"  class="btn  btn-primary btn-block" OnClick="Button2_Click"/>
                            </div>
                            <div class="col-md-4">
                                <asp:Button ID="Button4" runat="server" Text="Delete"  class="btn  btn-warning btn-block" OnClick="Button4_Click"/>
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
                                <h4>Book Inventory List</h4>
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
                                    <asp:GridView  class="table table-striped table-bordered" ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="book_id" DataSourceID="SqlDataSource1">
                                        <Columns>
                                            <asp:BoundField DataField="book_id" HeaderText="ID" ReadOnly="True" SortExpression="book_id" />
                                            <asp:TemplateField>
                                                <ItemTemplate>
                                                    <div class="container-fluid">
                                                        <div class="row">
                                                            <div class="col-lg-10">
                                                                <div class="row">
                                                                    <div class="col">
                                                                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("book_name") %>' Font-Bold="True" Font-Size="X-Large"></asp:Label>

                                                                    </div>
                                                                </div>
                                                                <div class="row">
                                                                    <div class="col">

                                                                        Author -<asp:Label ID="Label2" runat="server" Font-Bold="True" Text='<%# Eval("author_name") %>'></asp:Label>
                                                                        &nbsp;| Genre-<asp:Label ID="Label3" runat="server" Font-Bold="True" Text='<%# Eval("genre") %>'></asp:Label>
                                                                        &nbsp; | Language-<asp:Label ID="Label4" runat="server" Font-Bold="True" Text='<%# Eval("languge") %>'></asp:Label>

                                                                    </div>
                                                                </div>
                                                                <div class="row">
                                                                    <div class="col">

                                                                        Publisher -
                                                                        <asp:Label ID="Label5" runat="server" Font-Bold="True" Text='<%# Eval("publisher_name") %>'></asp:Label>
                                                                        &nbsp;| Publisher Date -
                                                                        <asp:Label ID="Label6" runat="server" Font-Bold="True" Text='<%# Eval("publisher_date") %>'></asp:Label>
                                                                        &nbsp;| Pages -
                                                                        <asp:Label ID="Label7" runat="server" Font-Bold="True" Text='<%# Eval("no_of_pages") %>'></asp:Label>
                                                                        &nbsp;| Edition -
                                                                        <asp:Label ID="Label8" runat="server" Font-Bold="True" Text='<%# Eval("edition") %>'></asp:Label>

                                                                    </div>
                                                                </div>
                                                                <div class="row">
                                                                    <div class="col">

                                                                        Cost -
                                                                        <asp:Label ID="Label9" runat="server" Font-Bold="True" Text='<%# Eval("book_cost") %>'></asp:Label>
                                                                        &nbsp;| Actual Stock -
                                                                        <asp:Label ID="Label10" runat="server" Font-Bold="True" Text='<%# Eval("actual_stock") %>'></asp:Label>
                                                                        &nbsp;| Available -
                                                                        <asp:Label ID="Label11" runat="server" Font-Bold="True" Text='<%# Eval("current_stock") %>'></asp:Label>

                                                                    </div>
                                                                </div>
                                                                 <div class="row">
                                                                    <div class="col">

                                                                        Description -
                                                                        <asp:Label ID="Label12" runat="server" Font-Bold="True" Text='<%# Eval("book_description") %>'></asp:Label>

                                                                    </div>
                                                                </div>
                                                            </div>
                                                            <div class="col-lg-2">
                                                                <asp:Image ID="Image1" CssClass="img-fluid " runat="server" ImageUrl='<%# Eval("book_img_link") %>' />
                                                            </div>
                                                        </div>
                                                    </div>
                                                </ItemTemplate>
                                            </asp:TemplateField>
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
