<%@ Page Language="C#" AutoEventWireup="true" CodeFile="user_res.aspx.cs" Inherits="user_res" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/aspx; charset=utf-8" />
<link rel='icon' type='image/png' href="img/titl-logo.png" />
<title>Taste Club</title>
<link href="css/stylesheet.css" rel="stylesheet" type="text/css" />
   <link rel="stylesheet" href="jcobb-basic-jquery-slider-8ffe118/jcobb-basic-jquery-slider-8ffe118/demo.css">
   <link rel="stylesheet" href="jcobb-basic-jquery-slider-8ffe118/jcobb-basic-jquery-slider-8ffe118/bjqs.css">


<link rel="stylesheet" href="FancySlidingForm/css/style.css" type="text/css" media="screen"/>
		<script type="text/javascript" src="FancySlidingForm/jquery1.4.2.min.js"></script>
        <script type="text/javascript" src="FancySlidingForm/sliding.form.js"></script>


<script src="skdslider/src/jquery.js"></script>
<script src="skdslider/src/skdslider.js"></script>
<link href="skdslider/src/skdslider.css" rel="stylesheet">
<script type="text/javascript">
    jQuery(document).ready(function () {
        jQuery('#demo1').skdslider({ delay: 5000, animationSpeed: 1000, showNextPrev: true, showPlayButton: true, autoSlide: true, animationType: 'sliding' });
        jQuery('#demo2').skdslider({ delay: 5000, animationSpeed: 1000, showNextPrev: true, showPlayButton: false, autoSlide: true, animationType: 'sliding' });
        jQuery('#demo3').skdslider({ delay: 5000, animationSpeed: 1000, showNextPrev: true, showPlayButton: true, autoSlide: true, animationType: 'sliding' });

        jQuery('#responsive').change(function () {
            $('#responsive_wrapper').width(jQuery(this).val());
        });

    });
</script>


<style type="text/css">
@font-face{ font-family:"SCRIPTBL"; src:url(SCRIPTBL.TTF) format("truetype");
}
p.SCRIPTBL{font-family:"SCRIPTBL"; }    
h1.SCRIPTBL{font-family:"SCRIPTBL"; } 
a.SCRIPTBL{font-family:"SCRIPTBL"; }    


</style>

 <style>
        span.reference{
            position:fixed;
            left:5px;
            top:5px;
            font-size:10px;
            text-shadow:1px 1px 1px #fff;
        }
        span.reference a{
            color:#555;
            text-decoration:none;
			text-transform:uppercase;
        }
        span.reference a:hover{
            color:#000;
            
        }
    
     
    </style>


</head>

<body >

<div id="header_rihgt_bottom_main">
<div id="header_main2">
<div id="header_left">
<a href="index.aspx"><img src="img/logo.png" width="100px" height="130px"  /></a>
</div>
<div id="header_rihgt">
<div id="header_rihgt_top">
<div id="header_rihgt_bottom">
   <ul>
    <li><a  href="menu.aspx" >Our Food</a></li>
    <li><a href="home.aspx" > How It Works</a></li>
   </ul>
   
  <%-- <div id="header_rihgt_sub">
   <table>
   <tr><td>User Name :</td><td><input type="text" style="width:110px;" /></td> <td>Password :</td><td><input type="password" style="width:110px;"/></td><td><input type="submit" value="login"  /></td></tr>
    <tr><td colspan="2"><a href="user_res.aspx">Fotget Password</a></td><td colspan="2"><a href="user_res.aspx">Singup for New User</a></td> </tr>
   </table>
   </div>--%>
</div>
</div>
</div>
</div>
</div>


<div id="slider_main">

<img src="skdslider/slides/1.jpg" />

</div>

<div id="wrapper_main">
<div id="wrapper">
<div id="cantant">
<br />

   
   

<div id="content_fed">
    
            <div id="wrapper_fed">
                <div id="steps">
                    <form id="formElem" runat="server">
                   <%-- <asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>--%>
                        <fieldset class="step">
                        
                            <legend>Personnal Detail</legend><br /><br /><br />
                           <span style="color:Maroon; float:left; margin-left:10px;">(* Indicates Required Field)</span>
                           <br /> 
                           <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Minimum 8 characters atleast 1 Alphabet, 1 Number and 1 Special Character" ValidationGroup="Validation"  ValidationExpression="^(?=.*[A-Za-z])(?=.*\d)(?=.*[$@$!%*#?&])[A-Za-z\d$@$!%*#?&]{8,}$" ForeColor="Red" ControlToValidate="TextBox3"></asp:RegularExpressionValidator><br />
                           <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Enter valid email. like this example@123.com" ValidationGroup="Validation"  ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"  ForeColor="Red" ControlToValidate="TextBox2"></asp:RegularExpressionValidator>
                            <p>
                                <label for="username">User name<span style="color:Red">*</span></label>
                                <asp:TextBox ID="TextBox1" runat="server" placeholder="info@tympanus.net"></asp:TextBox>
                            </p>
                            <p>
                                <label for="email">Email<span style="color:Red">*</span></label>
                                <asp:TextBox ID="TextBox2" runat="server" placeholder="Enter Email"></asp:TextBox>
                               
                            </p>
                            <p>
                                <label for="password">Password<span style="color:Red">*</span></label>
                                <asp:TextBox ID="TextBox3" runat="server" placeholder="Enter Password" 
                                    TextMode="Password"></asp:TextBox>
                               
                               
                            </p>
                       
                            <p>
                                <label for="cpassword">Confirm Password<span style="color:Red">*</span></label>
                                <asp:TextBox ID="TextBox12" runat="server" placeholder="Confirm Password" 
                                    TextMode="Password"></asp:TextBox> 
                                      <asp:CompareValidator id="comparePasswords" ValidationGroup="Validation"  runat="server" ControlToCompare="TextBox3" ControlToValidate="TextBox12" ErrorMessage="Your passwords do not match up!" ForeColor="Red" Display="Dynamic" />
                                                               </p>
                            <p>
                                <label for="country">Company Name<span style="color:Red">*</span></label>
                               <asp:TextBox ID="TextBox4" runat="server" placeholder="Enter Company Name" 
                                    AutoPostBack="True" ontextchanged="TextBox4_TextChanged"></asp:TextBox>
                            </p>
                            <p>
                                <label for="phone">Location<span style="color:Red">*</span></label>
                                <asp:TextBox ID="TextBox5" runat="server" placeholder="Enter Contact No."></asp:TextBox>
                            </p>
                           
                        </fieldset>
                        <fieldset class="step">
                            <legend>Payment</legend>
                            <p>
                            <label for="Card">Card<span style="color:Red">*</span></label>
                                                
                                 
                                 <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="true"
                                    onselectedindexchanged="DropDownList2_SelectedIndexChanged">
                                    <asp:ListItem>Credit Card</asp:ListItem>
                                    <asp:ListItem>Debit Card</asp:ListItem>
                                    <asp:ListItem>Networking</asp:ListItem>
                                </asp:DropDownList>
                                
                              
                            </p>
                            <asp:Panel ID="Panel1" runat="server">
                             <p>
                                <label for="cardnumber">Card number<span style="color:Red">*</span></label>
                                 <asp:TextBox ID="TextBox7" runat="server" placeholder="Card Number"></asp:TextBox>
                                 <asp:CompareValidator id="CompareValidator1" ValidationGroup="Validation"  runat="server" ControlToCompare="TextBox3" ControlToValidate="TextBox7" ErrorMessage="Enter Digit Value[0-9]" ForeColor="Red" Display="Dynamic" Type="Integer" />
                            </p>
                            <p>
                                <label for="secure">CVV<span style="color:Red">*</span></label>
                                <asp:TextBox ID="TextBox8" runat="server" placeholder="Enter Your Cvv Number"></asp:TextBox>
                                <asp:CompareValidator id="CompareValidator2" ValidationGroup="Validation"  runat="server" ControlToCompare="TextBox3" ControlToValidate="TextBox8" ErrorMessage="Enter Digit Value[0-9]" ForeColor="Red" Display="Dynamic" Type="Integer" />
                            </p>
                             <p>
                                <label for="date">Expiry Date<span style="color:Red">*</span></label>
                                <asp:TextBox ID="TextBox6" runat="server" placeholder="Expiry Date"></asp:TextBox>
                            </p>
                            <p>
                                <label for="namecard">Name on Card<span style="color:Red">*</span></label>
                                 <asp:TextBox ID="TextBox9" runat="server" placeholder="Card Holder Name"></asp:TextBox>
                            </p>
                            </asp:Panel>
                            <asp:Panel ID="Panel2" runat="server">
                              <p>
                                <label for="bankname">Bank Name<span style="color:Red">*</span></label>
                                 <asp:TextBox ID="TextBox10" runat="server" placeholder="Bank Name"></asp:TextBox>
                            </p>
                            <p>
                                <label for="branch">Branch<span style="color:Red">*</span></label>
                                <asp:TextBox ID="TextBox11" runat="server" placeholder="Branch"></asp:TextBox>
                            </p>
                            </asp:Panel>
                           
                        </fieldset>
                        
						<fieldset class="step">
                            <legend>Confirm</legend>
							<p>
								Everything in the form was correctly filled 
								if all the steps have a green checkmark icon.
								A red checkmark icon indicates that some field 
								is missing or filled out with invalid data. In this
								last step the user can confirm the submission of
								the form.
							</p>
                            <p class="submit">
                                <asp:Button ID="Button1" runat="server" Text="Button" 
                                    onclick="Button1_Click1" />
                            </p>
                        </fieldset>
                    </form>
                </div>
                <div id="navigation" style="display:none;">
                    <ul>
                       
                        <li>
                            <a href="#">Personal Details</a>
                        </li>
                        <li>
                            <a href="#">Payment</a>
                        </li>
                       
						<li>
                            <a href="#">Confirm</a>
                        </li>
                    </ul>
                </div>
            </div>
        </div>


<br />











</div>
</div>
</div>





<div id="fotter_bottom_main">
<div id="fotter_bottom">
<p>ALL RIGHTS RESERVED  | COPYRIGHTS &copy; 2014 | <a href="#">TasteClub</a></p>
<p style="float:right; font-size:14px;">Design by: <a href="#">Shri Satya Technologies</a></p>
</div>
</div>

</body>

</html>
