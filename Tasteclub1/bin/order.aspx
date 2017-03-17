<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage3.master" AutoEventWireup="true" CodeFile="order.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <div id="wrapper_main">
<div style="margin-top:140px;  overflow: hidden; background: #FFF;   width: 1260px; height: auto;">
<div id="order_maindiv" style="  width: 1245px;
  height: auto;
  min-height: 350px;
  margin: 70px 0px 0px 15px;
  padding: 0px 0px 10px 0px;">
<div style="margin:10px; font-size:17px;"><asp:Label ID="lbnorecord" runat="server" Text=""></asp:Label></div>
 <asp:Label ID="lbname" runat="server" Text="" Visible="false"></asp:Label> 
       <asp:Label ID="lbemail" runat="server" Text="" Visible="false"></asp:Label>




    <asp:GridView ID="GridView1" runat="server" Width="1230px" 
    AutoGenerateColumns="False" CellPadding="4" BackColor="White"
        BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" >
        <%--<Columns>
            <asp:BoundField DataField="order_id" HeaderText="Order_Id"  InsertVisible="False" ReadOnly="True" SortExpression="order_id" />
            <asp:BoundField DataField="fstname" HeaderText="First Name"   SortExpression="fstname" />
            <asp:BoundField DataField="email" HeaderText="Email" SortExpression="email" />
            <asp:BoundField DataField="itemname" HeaderText="Item Name" SortExpression="itemname" />
            <asp:BoundField DataField="companyname" HeaderText="Company Name"  SortExpression="companyname" />
            <asp:BoundField DataField="price" HeaderText="Price" SortExpression="price" />
            <asp:BoundField DataField="veg" HeaderText="Vegetarian" SortExpression="veg" />
            <asp:BoundField DataField="day" HeaderText="Day" SortExpression="day" />
        </Columns>--%>
        <Columns>
            <asp:BoundField DataField="id" HeaderText="Order_Id"  InsertVisible="False" ReadOnly="True" SortExpression="order_id" />
            <asp:BoundField DataField="fstname" HeaderText="First Name"   SortExpression="fstname" />
            <asp:BoundField DataField="email" HeaderText="Email" SortExpression="email" />
            <asp:BoundField DataField="itemname" HeaderText="Item Name" SortExpression="itemname" />
           
            <asp:BoundField DataField="price" HeaderText="Price" SortExpression="price" />
            <asp:BoundField DataField="totalitems" HeaderText="Quantity" SortExpression="Quantity" />
            <asp:BoundField DataField="totalrupee" HeaderText="Total Price" SortExpression="Total Price" />
            <asp:BoundField DataField="subtotal" HeaderText="Grand Total" SortExpression="Grand Total" />
            <asp:BoundField DataField="date" HeaderText="Order Placed on" SortExpression="Order Placed" />
            <asp:BoundField DataField="orderfordate" HeaderText="Order For(Date)" SortExpression="Order For" />
            <asp:BoundField DataField="orderfor" HeaderText="Order For(Day of week)" SortExpression="Date" />
        </Columns>
        <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
        <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
        <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
        <RowStyle BackColor="White" ForeColor="#003399" />
        <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
        <SortedAscendingCellStyle BackColor="#EDF6F6" />
        <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
        <SortedDescendingCellStyle BackColor="#D6DFDF" />
        <SortedDescendingHeaderStyle BackColor="#002876" />
    </asp:GridView>
</div>



</div>
</div>
</asp:Content>

