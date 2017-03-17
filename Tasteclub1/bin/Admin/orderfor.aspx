<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage2.master" AutoEventWireup="true" CodeFile="orderfor.aspx.cs" Inherits="Admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">





    <asp:GridView ID="GridView1" Width="10px"  Font-Size="16px"
        AlternatingRowStyle-BackColor="AliceBlue" runat="server" HeaderStyle-HorizontalAlign="Center"
        AutoGenerateColumns="False" BackColor="White" 
        BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" 
        style="margin-right: 0px" >
    <Columns>
    <asp:BoundField DataField="id" HeaderText="ID" />
    <asp:BoundField DataField="fstname" HeaderText="NAME" />
    <asp:BoundField DataField="email" HeaderText="E-MAIL" />
    <asp:BoundField DataField="totalitems" HeaderText="TOTAL ITEMS" />
    <asp:BoundField DataField="itemname" HeaderText="ITEM NAME" />
    <asp:BoundField DataField="price" HeaderText="PRICE" />
    <asp:BoundField DataField="totalrupee" HeaderText="TOTAL RUPEES" />
    <asp:BoundField DataField="payment" HeaderText="PAYMENT" />
    <asp:BoundField DataField="subtotal" HeaderText="SUBTOTAL" />
    <asp:BoundField DataField="date" HeaderText="DATE" />
      <asp:BoundField DataField="orderplaced" HeaderText="ORDER PLACED" />
    <asp:BoundField DataField="orderfor" HeaderText="ORDER FOR" />
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


    <table>
  
    </table>



</asp:Content>

