<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage4.master" AutoEventWireup="true" CodeFile="forgot.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<div style="height:400px; width:1000px; background-color:White; margin:0px auto;">
          <div style="padding:20px 0px 0px 20px; font-size:18px;">
                <asp:Label ID="Label3" runat="server" Text="" 
                    style="color: #CC3300; font-weight: 700"></asp:Label>
        </div>
        <div style="padding:10px 0px 20px 20px; font-size:18px;">
                <asp:Label ID="Label1" runat="server" Text="Please enter your email and we'll send you a link to reset your password."></asp:Label>
        </div>
         <div style="padding:0px 0px 20px 20px;">
             <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Height="24px" Width="151px" 
                 style="border-radius:5px;" BorderColor="Gray" BorderStyle="Solid" 
                 BorderWidth="1px"></asp:TextBox>
        </div>
        <div style="padding-left:20px; ">
            <asp:Button ID="Button1" runat="server" Text="Send" Height="30px" 
                Width="75px" BackColor="Red" ForeColor="White" BorderColor="Red" 
                BorderStyle="Solid" BorderWidth="1px" style="border-radius:5px;" 
                onclick="Button1_Click"/>
        </div>
        </div>
</asp:Content>

