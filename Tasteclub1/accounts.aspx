<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage3.master" AutoEventWireup="true" CodeFile="accounts.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<div style="width:1000px; margin:136px auto 6px; height:auto; background-color:White; padding-bottom:20px;">
    <div style="padding:15px; ">
        <span style="color:Red; font-size: 22px; margin-right:10px;"><b>Profile</b></span><a href="edit-profile.aspx" style="color:#45c3d3; font-size:18px; text-decoration:none;">Edit</a>
        <asp:Label ID="lbname" runat="server" Text="" Visible="false"></asp:Label>
    </div>
    <div style="margin-left:15px; font-size:18px; margin-bottom:20px;">


    <table>
    <tr>
    <td><b><asp:Label ID="Label1" runat="server" Text="Name:"></asp:Label></b></td>
    <td><asp:Label ID="Label2" runat="server" Text=""></asp:Label></td>
    </tr>


    <tr>
    <td><b><asp:Label ID="Label3" runat="server" Text="Email address:"></asp:Label></b></td>
    <td>
        <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
        </td>
    </tr>


    <tr>
    <td>
        <b><asp:Label ID="Label5" runat="server" Text="Phone Number:"></asp:Label></b>
        </td>
    <td>
        <asp:Label ID="Label6" runat="server" Text=""></asp:Label></td>
    </tr>


    <tr>
    <td>
        <b><asp:Label ID="Label7" runat="server" Text="Deliver To:"></asp:Label></b>
        </td>
    <td>
       <asp:Label ID="Label15" runat="server" Text=""></asp:Label></td>
    </tr>



    <tr>
    <td></td>
    <td></td>
    </tr>

    
    
    </table>
       <b style="margin-right:185px;">
       
       
       
       
       
       
       
       
       
       
       </b> 
        <br />
        <b style="margin-right:123px;"></b>
        <br />
        <b style="margin-right:112px;"></b>
        <br />
        <br />
    </div>
    <hr style="margin:0px 20px 20px;"/>
    <div style="margin-top:20px; margin-left:15px;">
       <span style="color:Red; font-size: 22px; margin-right:10px;"><b>Paasword</b></span><br />
        <a href="change-password.aspx" style="color:#45c3d3; font-size:18px; text-decoration:none;">Change Your Password</a>
    </div>
    <hr style="margin:20px 20px;"/>
    <div style="margin-top:20px; margin-left:15px; font-size:18px;">
         <span style="color:Red; font-size: 22px; margin-right:10px;"><b>Account Balance</b></span><br /><br />
          <b style="margin-right:185px;"><asp:Label ID="Label8" runat="server" Text="Type of Credit"></asp:Label></b> 
        <b><asp:Label ID="Label9" runat="server" Text="Amount"></asp:Label></b><br />
        <b style="margin-right:142px;"><asp:Label ID="Label10" runat="server" Text="Promotional Credit:"></asp:Label></b>
        <%--<asp:Label ID="Label11" runat="server" Text="$0.00"></asp:Label>--%><br />
        <b style="margin-right:161px;"><asp:Label ID="Label12" runat="server" Text="Purchased Credit:"></asp:Label></b>
        <%--<asp:Label ID="Label13" runat="server" Text="$0.00"></asp:Label>--%><br />
    </div>
    <hr style="margin:20px 20px;"/>
    <%--<div style="margin:20px 15px; font-size:18px; ">
        <span style="color:Red; font-size: 22px; margin-right:10px;"><b>Communication Preferences</b></span><br /><br />
         <b style="margin-right:185px;"><asp:Label ID="Label14" runat="server" Text="Receive Menu Emails:"></asp:Label></b> 
        <asp:DropDownList ID="DropDownList2" runat="server">
        </asp:DropDownList>
        <br />
        <b style="margin-right:115px;"><asp:Label ID="Label16" runat="server" Text="Opt out of special offers/events"></asp:Label></b>
        <asp:CheckBox ID="CheckBox1" runat="server" /><br />
        <b style="margin-right:151px;"><asp:Label ID="Label18" runat="server" Text="Opt out of Favorites alerts"></asp:Label></b>
        <asp:CheckBox ID="CheckBox2" runat="server" />
    </div>--%>
</div>


</asp:Content>

