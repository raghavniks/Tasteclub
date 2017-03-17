<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage2.master" AutoEventWireup="true" CodeFile="change_password.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

 <div class="cantant_right_text">
<%--<form id="form1" runat="server">--%>

<h1>Change Password</h1><br />
<table style="height: 243px; width: 575px">
<tr>
<td style="width: 128px">
    <asp:Label ID="lblnam" runat="server" Text="User Name:"></asp:Label></td>
<td>
    <asp:TextBox ID="Textnam" runat="server" Width="315px" Height="23px"></asp:TextBox>
</td>

 <td> 
        <asp:RequiredFieldValidator ID="rfvnam" runat="server" ErrorMessage="Required Field" ControlToValidate="Textnam" ForeColor="red"></asp:RequiredFieldValidator>
 </td>

</tr>
<tr>
<td style="width: 128px">
    <asp:Label ID="lboldpass" runat="server" Text="Old Password:"></asp:Label></td>
<td>
    <asp:TextBox ID="Textoldpass" runat="server" Width="315px" Height="27px" 
        Font-Size="25px" TextMode="Password"></asp:TextBox>
</td>

 <td> 
        <asp:RequiredFieldValidator ID="rfvoldpass" runat="server" ErrorMessage="Required Field" ControlToValidate="Textoldpass" ForeColor="red"></asp:RequiredFieldValidator>
 </td>

</tr>
<tr>
<td style="width: 128px">
    <asp:Label ID="lblnewpass" runat="server" Text="New Password:"></asp:Label></td>
<td>
    <asp:TextBox ID="Textnewpass" runat="server" Width="315px" Height="27px" 
        Font-Bold="False" Font-Size="25px" TextMode="Password"></asp:TextBox>
</td>

 <td> 
        <asp:RequiredFieldValidator ID="rfvnewpass" runat="server" ErrorMessage="Required Field" ControlToValidate="Textnewpass" ForeColor="red"></asp:RequiredFieldValidator>
 </td>

</tr>
<tr>
<td style="width: 128px">
    <asp:Label ID="lbconpass" runat="server" Text="Confirm Password:"></asp:Label></td>
<td>
    <asp:TextBox ID="Textconpass" runat="server" Width="315px" Height="27px" 
        Font-Bold="False" Font-Size="25px" TextMode="Password"></asp:TextBox>
</td>

 <td> 
        <asp:RequiredFieldValidator ID="rfvconpass" runat="server" ErrorMessage="Required Field" ControlToValidate="Textconpass" ForeColor="red"></asp:RequiredFieldValidator>
 </td>

</tr>
  <tr><td style="width: 128px"></td></tr> 
     
  <tr><td colspan="2" > &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; 
      <asp:Button runat="server" ID="btnadd" Text="Change Password" onclick="btnadd_Click" 
          Width="120px" Height="34px" />&nbsp;&nbsp;&nbsp; <asp:Button runat="server" 
          ID="btnadd0" Text="Reset" onclick="btnreset_Click" Width="102px" 
          Height="35px" CausesValidation="False" /></td></tr>
        <tr><td style="width: 128px" colspan="2">
            <asp:Label ID="lbmsg" runat="server" Text=""></asp:Label></td></tr>   
</table>

 <br />
          <br/>
</div>
</asp:Content>

