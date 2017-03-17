<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage2.master" AutoEventWireup="true" CodeFile="add_ad.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">


    <div class="cantant_right_text">
<%--<form id="form1" runat="server">--%>

<h1>Add New User</h1><br />

<table style="height: 312px; width: 803px;">
            
            <tr>
                    <td style="height: 38px">
                            <asp:Label ID="lblname" runat="server" Text=" User Name:"></asp:Label>
                    </td>

                    <td style="height: 38px">
                            <asp:TextBox ID="txtname" runat="server" Height="25px" Width="270px"
                               BackColor="White" ontextchanged="txtname_TextChanged"   
                               ></asp:TextBox>
                    </td>

                    <td style="height: 38px">
                            <asp:RequiredFieldValidator Display="Dynamic" ControlToValidate="txtname" runat="server" ForeColor="red" ID="rfvname" ErrorMessage="Required Field" ></asp:RequiredFieldValidator>
                    </td>
                    <td colspan="2" style="width: 107px; height: 38px;">
                        <asp:Label ID="Label2" runat="server" Text=""></asp:Label></td>
                  

            </tr>

            <%--<tr>
                    <td>
                            <asp:Label ID="lblemail" runat="server" Text="E_Mail:"></asp:Label>
                    </td>

                    <td>
                            <asp:TextBox ID="txtemail" runat="server" Height="25px" Width="270px"
                               BackColor="White"
                                ></asp:TextBox>
                    </td>

                    <td>
                            <asp:RequiredFieldValidator Display="Dynamic" ControlToValidate="txtemail" runat="server" ID="rfvcemail" ForeColor="red" ErrorMessage="Required Field"></asp:RequiredFieldValidator>
                    </td>
                    <td style="width: 107px">
                        <asp:RegularExpressionValidator ID="rfvcemail2" runat="server" ErrorMessage="Fill Correct Email" ControlToValidate="txtemail" ValidationExpression="^[\w-\.]{1,}\@([\da-zA-Z-]{1,}\.){1,}[\da-zA-Z-]{2,6}$" ForeColor="red"></asp:RegularExpressionValidator>
                    </td>

            </tr>--%>

            <%--<tr>
                    <td>
                            <asp:Label ID="lblcontact" runat="server" Text="Contact:"></asp:Label>
                    </td>

                    <td>
                            <asp:TextBox ID="txtcontact" runat="server" Height="25px" Width="270px"
                               BackColor="White" 
                                TextMode="SingleLine"></asp:TextBox>
                    </td>

                    <td>
                            <asp:RequiredFieldValidator Display="Dynamic" ControlToValidate="txtcontact" runat="server" ID="rfvcontact" ForeColor="red" ErrorMessage="Required Field"></asp:RequiredFieldValidator>
                    </td>
                    <td style="width: 107px">
                        <asp:RegularExpressionValidator ID="rfvcontact1" runat="server" ForeColor="Red" ControlToValidate="txtcontact" ValidationExpression="\d{10}" ErrorMessage="Max.10 Digits" ></asp:RegularExpressionValidator>
                    </td>
                    <td>
                        <asp:RegularExpressionValidator ID="rfvcontact2" runat="server" ForeColor="Red" ControlToValidate="txtcontact" ValidationExpression="[7-9][0-9]{9}$" ErrorMessage="Enter Valid Number" ></asp:RegularExpressionValidator>
                    </td>

            </tr>--%>

            <tr>
                    <td style="height: 37px">
                            <asp:Label ID="lblpassword" runat="server" Text="Password:"></asp:Label>
                    </td>

                    <td style="height: 37px">
                            <asp:TextBox ID="txtpassword" runat="server" Height="28px" Width="270px"
                               BackColor="White" TextMode="Password" Font-Size="25px" ontextchanged="txtpassword_TextChanged" 
                                ></asp:TextBox>
                    </td>
                   
                    <td style="height: 37px">
                            <asp:RequiredFieldValidator Display="Dynamic" ControlToValidate="txtpassword" runat="server" ID="rfvprice" ForeColor="red" ErrorMessage="Required Field"></asp:RequiredFieldValidator>
                    </td>
                     


            </tr>
             <tr>
                    <td style="height: 38px">
                            <asp:Label ID="lblconfpass" runat="server" Text=" Confirm Password:"></asp:Label>
                    </td>

                    <td style="height: 38px">
                            <asp:TextBox ID="txtconfpass" runat="server" Height="28px" Width="270px"
                               BackColor="White" TextMode="Password" 
                                Font-Size="25px"></asp:TextBox>
                    </td>

                    <td style="height: 38px">
                            <asp:RequiredFieldValidator Display="Dynamic" ControlToValidate="txtconfpass" runat="server" ForeColor="Red"  ID="RequiredFieldValidator1" ErrorMessage="Required Field"></asp:RequiredFieldValidator>
                    </td>
                    
                    

            </tr>

            <tr>
                    <td style="height: 38px">
                            <asp:Label ID="lbldesig" runat="server" Text="Designation:"></asp:Label>
                    </td>

                    <td style="height: 38px">
                            <asp:TextBox ID="txtdesig" runat="server" Height="25px" Width="270px"
                               BackColor="White"
                                ></asp:TextBox>
                    </td>

                    <td style="height: 38px">
                            <asp:RequiredFieldValidator Display="Dynamic" ControlToValidate="txtdesig" runat="server" ForeColor="Red" ID="rfvpack" ErrorMessage="Required Field"></asp:RequiredFieldValidator>
                    </td>

            </tr>


                    <tr>
                            <td style="height: 57px">
                                
                                
                                </td>
                            
                            <td style="height: 57px">
                                        <asp:Button runat="server" ID="btnSubmit" Text="Submit" 
                                            onclick="btnSubmit_Click" Height="34px" Width="85px" style="color: #FFFFFF; background-color: #04579F; border-radius: 7px; border: none;"
                                             />
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        <asp:Button runat="server" ID="btnReset" Text="Reset" CausesValidation="False" 
                                            Height="34px" onclick="btnReset_Click" Width="85px" style="color: #FFFFFF; background-color: #04579F; border-radius: 7px; border: none;"
                                             />

                            </td>
                    </tr>

                    <tr>
                    
                            <td style="height: 35px">
                            </td>

                            <td style="height: 35px">
                                    <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
                            </td>

                            <td style="height: 35px">
                            </td>
                    </tr>
                     <tr>
                    
                            <td>
                            </td>

                            <td>
                                    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                            </td>

                            <td>
                            </td>
                    </tr>

</table>
        
        <br />

<%--</form>--%>
</div>
</asp:Content>

