<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage3.master" AutoEventWireup="true" CodeFile="edit-profile.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
















    <div style="width:1000px; margin:136px auto 6px; height:auto; background-color:White; padding-bottom:20px;">
     <div id="editprofilepageredheaderdiv">
     <h1>

     Change Profile
     </h1>
    <div id="editprofilepagewhitepagediv">
   


    <div style="height:250px; width:300px; margin:50px 0 0 120px;">



    <div style="font-size:20px; color:Red; margin-bottom:10px;">Change Profile</div>

    <table>
    <tr>
    <td style="color:Black; font-size:20px;"> First Name</td>
    <td><asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox></td>
    </tr>

    <tr>
    <td style="color:Black; font-size:20px;"> Last Name</td>
    <td> <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
    </tr>

    <tr>
    <td style="color:Black; font-size:20px;">  Email</td>
    <td>
      <asp:TextBox ID="TextBox3" runat="server" Enabled="False"></asp:TextBox></td>
    </tr>

    <tr>
    <td style="color:Black; font-size:20px;">Phone</td>
    <td><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
    </tr>



    <tr>
    <td></td>
    <td style="color:Black; font-size:20px;">
        <asp:Label ID="Label16" runat="server"></asp:Label>
        </td>
    </tr>



    <tr>
    <td></td>
    <td></td>
    </tr>


     <tr>
    <td></td>
    <td> <asp:Button ID="Button1" runat="server" Text="Save" style=" color: white; background-color: red; border: none; border-radius: 3px; font-size: 20px; height: 37px; Width:173px;"  onclick="Button1_Click"/></td>
    </tr>
    
    </table>




     <asp:Label ID="Label5" runat="server" Visible="False" style="margin-right:58px;" ></asp:Label>
      
  
     
   
     
          <asp:Label ID="lbname" runat="server" Text="" Visible="false"></asp:Label>
  </div>
  </div>
</div>
</div>
</asp:Content>

