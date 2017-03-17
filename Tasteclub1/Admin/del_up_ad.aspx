<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage2.master" AutoEventWireup="true" CodeFile="del_up_ad.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <div class="cantant_right_text">
<%--<form id="form1" runat="server">--%>

<h1>Update/Delete User</h1><br />

<table style="height: 238px">
<tr><td style="width: 125px" >
    <asp:Label ID="lblselest" runat="server" Text=" Select:"></asp:Label>
    </td><td>
        <asp:DropDownList ID="Ddlshow" runat="server" Height="29px" Width="320px" 
        DataTextField="Name" 
        onselectedindexchanged="Ddlshow_SelectedIndexChanged" AutoPostBack="True">
            <asp:ListItem></asp:ListItem>
    </asp:DropDownList></td></tr>
    <%--<tr><td style="height: 10px"></td></tr>--%>

    <tr style="visibility:hidden;">
                    <td>
                            <asp:Label ID="lbid" runat="server" Text="User ID:"></asp:Label>
                    </td>

                    <td colspan="3">
                            <asp:TextBox ID="txtid" runat="server" Height="16px" Width="320px"
                               BackColor="White" style="margin-bottom: 0px"  
                                ></asp:TextBox>
                    </td>

                   

                   

            </tr>
                 <tr>
                    <td>
                            <asp:Label ID="lblname" runat="server" Text=" User Name:"></asp:Label>
                    </td>

                    <td>
                            <asp:TextBox ID="txtname" runat="server" Height="25px" Width="320px"
                               BackColor="White" 
                               ></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rfvname" runat="server" ErrorMessage="Required Field" ControlToValidate="txtname" ForeColor="red"></asp:RequiredFieldValidator>
                    </td>

                    
                   

            </tr>

            

           <%--<tr>
                    <td>
                            <asp:Label ID="lblcontact" runat="server" Text="Contact:"></asp:Label>
                    </td>

                    <td>
                            <asp:TextBox ID="txtcontact" runat="server" Height="25px" Width="320px"
                               BackColor="White"
                                TextMode="SingleLine"></asp:TextBox>
                    </td>

                    <td>
                        <asp:RequiredFieldValidator ID="rfvcontact" runat="server" ErrorMessage="Required Field" ControlToValidate="txtcontact" ForeColor="red"></asp:RequiredFieldValidator>
                    </td>
                    <td>
                        <asp:RegularExpressionValidator ID="rfvcontact1" runat="server" ForeColor="Red" ControlToValidate="txtcontact" ValidationExpression="\d{10}" ErrorMessage="Maximum 10 Digits" ></asp:RegularExpressionValidator>
                    </td>

            </tr>--%>

            

            <tr>
                    <td>
                            <asp:Label ID="lbldesig" runat="server" Text="Designation:"></asp:Label>
                    </td>

                    <td>
                            <asp:TextBox ID="txtdesig" runat="server" Height="25px" Width="320px"
                               BackColor="White" 
                                ></asp:TextBox>
                    </td>

                    <td>
                        <asp:RequiredFieldValidator ID="rfvdesig" runat="server" ErrorMessage="Required Field" ControlToValidate="txtdesig" ForeColor="red"></asp:RequiredFieldValidator>
                    </td>
            </tr>


            <tr><td style="width: 125px"></td></tr>
            <tr>
                            <td style="width: 125px">
                                
                                
                                &nbsp;</td>
                            
                            <td>
                                        &nbsp;<asp:Button runat="server" ID="btnupd" Text="Update" 
                                            onclick="btnupd_Click"   
                                            onclientclick="return confirm('Are you sure you Want to Update the Records?');" style="height: 26px"
                                             />
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        <asp:Button runat="server" ID="btndel" Text="Delete" onclick="btndel_Click" onclientclick="return confirm('Are you sure you Want to Delete the Records?');" 
                                             />
                                             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        <asp:Button runat="server" ID="btncancl" Text="Cancel" CausesValidation="False" onclick="btncancl_Click"  
                                             />

                            </td>
                    </tr>
                   <tr><td colspan="2">
                       <asp:Label ID="lbmsg" runat="server" Text=""></asp:Label></td></tr>
                   <tr><td></td></tr>
                   <tr><td></td></tr>
                   <tr><td></td></tr>
                    

</table>



 <br />


        
<%--</form>--%>
</div>
    
</asp:Content>

