<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage3.master" AutoEventWireup="true" CodeFile="change-password.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <div style="width:1000px; margin:136px auto 6px; height:600px; background-color:White; padding-bottom:20px;">
 <div id="editprofilepageredheaderdiv">
 <h1>
 Change Password
 </h1>
  <div id="editprofilepagewhitepagediv">

  <table>
  <tr>
  <td style="color:Black; font-size:20px;">Old Password</td>
  <td>
      <asp:TextBox ID="TextBox1" runat="server"  Height="20px" Width="250px"></asp:TextBox></td>
  </tr>

  <tr>
  <td style="color:Black; font-size:20px;">New Password</td>
  <td>

      <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 0px" Height="20px" Width="250px"></asp:TextBox></td>
  </tr>


  <tr>
  <td style="color:Black; font-size:20px;">Confirm Password</td>
  <td>
      <asp:TextBox ID="TextBox3" runat="server" Height="20px" Width="250px"></asp:TextBox></td>
  </tr>

  <tr>
  <td colspan="2" align="center">
      <asp:Label ID="lblmsg" runat="server" ForeColor="Red" Font-Size="17px"></asp:Label>
      <asp:Label ID="lbname" runat="server" Text="" Visible="false"></asp:Label></td>
  
  </tr>



  <tr>
  <td></td>
  <td > <asp:Button ID="Button1" runat="server" Text="Save" style="margin-top:15px; color: white; width=:253px; background-color: red; border: none; border-radius: 3px; font-size: 20px; height: 37px;" onclick="Button1_Click" /></td>
  
  </tr>
  </table>
  </div>
  </div>   
     
  </div>
</div>


</asp:Content>

