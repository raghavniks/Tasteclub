<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage2.master" AutoEventWireup="true" CodeFile="add-food-image.aspx.cs" Inherits="Admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<div class="cantant_right_text">
<h1>Add Food Images</h1><br />

 
        <table class="add_foodimg">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Select Image"></asp:Label>
                </td>
                <td>
                    <asp:FileUpload ID="FileUpload1" runat="server" height=" 25px" width= "216px"/>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Item Name"></asp:Label>
                </td>
                <td>
                     <asp:TextBox ID="TextBox1" runat="server" placeholder="item name" height=" 17px" width= "216px"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Company Name"></asp:Label>
                </td>
                <td>
                     <asp:TextBox ID="TextBox2" runat="server" placeholder="company name" height=" 17px" width= "216px"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Price"></asp:Label>
                </td>
                <td>
                     <asp:TextBox ID="TextBox3" runat="server" placeholder="rupees" height=" 17px" width= "216px"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text=" Select Vegetarian/Non Vegetarian"></asp:Label>
                </td>
                <td>
                     <asp:DropDownList ID="DropDownList1" runat="server" Height="30px" Width="228px">
            <asp:ListItem>Yes</asp:ListItem>
            <asp:ListItem>No</asp:ListItem>
        </asp:DropDownList>
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Select Day"></asp:Label>
                </td>
                <td>
                      <asp:DropDownList ID="DropDownList2" runat="server" Height="30px" Width="228px">
            <asp:ListItem>Monday</asp:ListItem>
            <asp:ListItem>Tuesday</asp:ListItem>
            <asp:ListItem>Wednesday</asp:ListItem>
            <asp:ListItem>Thursday</asp:ListItem>
            <asp:ListItem>Friday</asp:ListItem>
        </asp:DropDownList>
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Label ID="Label7" runat="server" Text="Description"></asp:Label>
                </td>
                <td>
                     <asp:TextBox ID="TextBox4" runat="server" placeholder="Description" height=" 17px" width= "216px"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Label ID="Label8" runat="server" Text="Allergance"></asp:Label>
                </td>
                <td>
                     <asp:TextBox ID="TextBox5" runat="server" placeholder="Allergance" height=" 17px" width= "216px" ></asp:TextBox>
                </td>
            </tr>
            <tr>
            <td></td>
                <td  style="height: 26px">
                    <asp:Button ID="Button1" runat="server" Text="Submit" style="width:75px; color: #FFFFFF; background-color: #04579F; border-radius: 7px; border: none; height:35px;" onclick="Button1_Click" />
                </td>
                
            </tr>
            <tr>
                <td colspan="2">
                     <asp:Label ID="lbmsg" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            </table>
        
        
       
       
    
           
   
    
    </div>
</asp:Content>

