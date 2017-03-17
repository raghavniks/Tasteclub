<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage3.master" AutoEventWireup="true" CodeFile="food-show.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<div id="wrapper_main" style="margin-top:140px;">
<asp:Label ID="lbbookid" runat="server" Text="" Visible="false"></asp:Label>
<div id="wrapper" style="padding:20px; ">
<div id="order_maindiv" style="background-color:#FDFCF8; padding-left:20px; width:972px; padding-top:12px; -webkit-box-shadow: 0px 1px 2px #D3CFCC;  margin-bottom:10px;
box-shadow: 0px 1px 2px #D3CFCC;">
<div style="font-size:24px; margin-bottom: 10px;">
    <asp:Label ID="lblitemname" runat="server" Text=""></asp:Label>
</div>
<div style="float:left;">
    <asp:Panel ID="Panel1" runat="server">
        <asp:Image ID="Image1" runat="server" Height="240px" Width="300px"/>
    </asp:Panel>
</div>
<div style="float:left; margin-left:30px; width:590px; font-size:17px;">
 <b>Restaurant:</b> <asp:Label ID="lbrestro" runat="server" Text="" 
        style="color: #339933"></asp:Label><br /><br />
  <b>Description:</b> <asp:Label ID="lbdes" runat="server" Text=""></asp:Label><br /><br />
    <b>Allergens:</b> <asp:Label ID="lballer" runat="server" Text=""></asp:Label><br />
</div>
</div>
<%--<div style="width:974px; height:30px; font-size:18px; background-color:#f0f0f0; padding:10px;"><b>
    <asp:Label ID="lbuser" runat="server" Text=""></asp:Label>&nbsp;reviews for
    <asp:Label ID="lbitem" runat="server" Text=""></asp:Label>&nbsp;from
    <asp:Label ID="lbresto" runat="server" Text=""></asp:Label>
        </b>
</div>--%>


</div>
</div>

</asp:Content>

