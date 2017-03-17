<%@ Page Language="C#" AutoEventWireup="true" CodeFile="admin Panel.aspx.cs" Inherits="Admin_Panel" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>taste club {Admin Login}</title>
<link href="css_ad/style_ad.css" type="text/css" rel="stylesheet" />

<script src="SpryAssets_ad/SpryMenuBar.js" type="text/javascript"></script>
<link href="SpryAssets_ad/SpryMenuBarHorizontal_ad.css" rel="stylesheet" type="text/css" />
 
</head>

<body >
<div class="header_top_wrapper">
<div class="header_top_wrapper2">
<div class="header_top_wrapper_sub">
<a href="../index.aspx">Back To Website</a>
</div>

</div>

</div>
    

<div id="Wapper">
<form id="form1" runat="server">
<div id="warpper_login">
<br /><img src="css_ad/img_ad/contant2.png" /> <br />
<img src="css_ad/img_ad/logo.png" />

<p>
Welcome You in Your</p>
<p>Admin Login Panel
</p>

<p>  
Enter Your User Name & Password
</p>

    
                <table style=" width:430px; height:auto; margin: 0px auto;" >
                        <tr style="width:430px;">
                                    <td style="width:115px;">
                                            <asp:Label ID="lblName" runat="server" Text="User Name :"></asp:Label>
                                    </td>

                                    <td style="width:200px;">
                                            <asp:TextBox ID="txtName" runat="server" Height="25px" Width="150px" 
                                                BackColor="White" BorderColor="#006600" BorderWidth="2px"></asp:TextBox>
                                    </td>

                                    <td style="width:115px;">
                                            <asp:RequiredFieldValidator Display="Dynamic" ControlToValidate="txtName" runat="server" ID="rfvName" ErrorMessage="Required Field"></asp:RequiredFieldValidator>
                                    </td>
                    
                            </tr>

                            <tr style="width:430px;">
                                    <td style="width:115px;">
                                                <asp:Label ID="lblPass" runat="server" Text="Password:"></asp:Label>
                                    </td>

                                    <td style="width:200px;">
                                                <asp:TextBox ID="txtPass" runat="server" Height="25px" Width="150px" 
                                                    BackColor="White" BorderColor="#006600" BorderWidth="2px" TextMode="Password"></asp:TextBox>
                                    </td>

                                    <td style="width:115px;">
                                                <asp:RequiredFieldValidator Display="Dynamic" ControlToValidate="txtPass" runat="server" ID="rfvEmail" ErrorMessage="Required Field"></asp:RequiredFieldValidator>
                                    </td>
                            </tr>

                            <tr style="width:430px;">
                                    <td style="width:115px;">
                                    
                                    </td>

                                    <td style="width:200px;">
                                                <p><asp:Label ID="lblmessage" runat="server"></asp:Label></p>
                                    </td>

                                    <td style="width:115px;">
                                    
                                    </td>
                            
                            </tr>
                            <tr style="width:430px;">
                                    <td style="width:115px;">
                                
                                        &nbsp;</td>
                            
                                    <td style="width:200px;">
                                                <asp:Button runat="server" ID="btnSubmit" Text="Submit" Font-Bold="True" 
                                                        ForeColor="#336600" onclick="btnSubmit_Click" 
                                                    />
                                                &nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:Button runat="server" ID="btnReset" Text="Reset" CausesValidation="False" 
                                                        Font-Bold="True" ForeColor="#336600" Width="61px" onclick="btnReset_Click"
                                                    />

                                    </td>
                                    <td style="width:115px;">
                                    &nbsp;</td>
                            </tr>
                
                </table>

    
    

</div>
</form>
</div><!--Wapper-->

<div class="footer_bottom_div" style="height:40px; border-top:26px solid #04579f;">

</div>

</body>
</html>
