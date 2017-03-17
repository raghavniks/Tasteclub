<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    
    
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<link rel='icon' type='image/png' href="img/titl-logo.png" />
<title>Taste Club</title>
<link href="css/stylesheet.css" rel="stylesheet" type="text/css" />
   <link rel="stylesheet" href="jcobb-basic-jquery-slider-8ffe118/jcobb-basic-jquery-slider-8ffe118/demo.css">
   <link rel="stylesheet" href="jcobb-basic-jquery-slider-8ffe118/jcobb-basic-jquery-slider-8ffe118/bjqs.css">
   <script src="SpryAssets/SpryMenuBar.js" type="text/javascript"></script>
   <link href="SpryAssets/SpryMenuBarHorizontal.css" rel="stylesheet" type="text/css" />




<style type="text/css">
@font-face{ font-family:"SCRIPTBL"; src:url(SCRIPTBL.TTF) format("truetype");
}
p.SCRIPTBL{font-family:"SCRIPTBL"; }    
h1.SCRIPTBL{font-family:"SCRIPTBL"; } 
a.SCRIPTBL{font-family:"SCRIPTBL"; }    


</style>

 


</head>
<body style="background-color:#DAD7D7;">
    <div id="header_rihgt_bottom_main" style="height:125px; margin-bottom:6px; position:fixed; top:0px;">
<div id="header_main2">
<div id="header_left2" style="width:280px;">
<a href="index.aspx"><img src="img/logo.png" width="150px" height="200px"  style="margin-left:90px;"/></a>
</div>
<div id="header_rihgt" style="width:860px;">
<div id="header_rihgt_top" style="width:850px;">

<ul id="MenuBar1" class="MenuBarHorizontal">
  <li><a class="MenuBarItemSubmenu" href="#" style="text-decoration:none; font-weight:bold;">Hi <asp:Label ID="lbname" runat="server" Text=""></asp:Label></a>
      
      <%--<img src="img/rs.png" height="13px"/>&nbsp;<asp:Label ID="lbcredit" runat="server" Text="0.00"></asp:Label> &nbsp;Credit</a>--%>
    <ul>
      <li><a href="invite.aspx">Invite</a></li>
    <%--  <li><a href="#">Gift Cards</a></li>--%>
      <li><a href="accounts.aspx">Account</a></li>
      <%-- <li><a href="index.aspx">Logout</a></li>--%>
    </ul>
  </li>

 

</ul>




<div id="header_rihgt_bottom" style="width:500px;">
  <ul>
    <li><a  href="order.aspx" >My Order</a></li>
    <li><a href="new_meting.aspx" >Back to Menu</a></li>
    
   </ul>
   
 </div>
 <p>
 <%--<a href="new_meting.aspx">← To Groups Menu</a>--%>
 </p>
</div>
</div>




</div>
</div>


<form id="form1" runat="server" method="post">
    <div style="width:1120px; overflow:hidden; margin:136px auto 6px; height:auto; background-color:White; padding-bottom:20px;">
     <div style="height:72px; width:1120px; background-color: #fffbb9; margin-top:65px;">
     <div style="width: 290px; float: left; padding: 24px;"> 
     <div><%--<a href="" style="color: #45c3d3; text-decoration: none; float: left; font-size: 21px; margin-right:20px;">Edit</a>--%></div>
        <div style="font-size: 18px;">Pay Using Your Credit Card</div></div>
       
        <div style="float: right; padding: 15px;">
           <%-- <asp:Button ID="Button1" runat="server" Text="PLACE ORDER" />--%>
            <asp:Button ID="submit" Text="PLACE ORDER" Width="100px"  runat="server" OnClick="Button1_Click"  style="color:White; font-size: 20px; height: 42px; width: 291px; border: none; border-radius: 5px; background-color: #F05033;"/>
        </div>
     </div>
     <div class="text">
        <asp:Panel ID="Panel1" runat="server">
<div style="margin-top:7px; padding:10px; font-size:17px;">
    Thank you, the credit in your account will be applied to this group order. We still need a credit card authorization in case your final order exceeds your credit balance at the time of delivery, but you will see no charge if your credit balance suffices.
</div>
<div>
    <span><b style="font-size:20px; padding-left:10px; padding-bottom:10px;  ">Payment Info</b> </span>
</div>
    <div id ="frmError" runat="server">
      <span style="color:red">Please fill all mandatory fields.</span>
      <br/>
      <br/>
      </div>
      
    
   <input type="hidden" runat="server" id="key" name="key" />
      <input type="hidden" runat="server" id="hash" name="hash"  />
            <input type="hidden" runat="server" id="txnid" name="txnid" />
             <input type="hidden" runat="server" id="enforce_paymethod" name="enforce_paymethod" />
      <table style="float:left;">
        <tr>
          <td><b>Mandatory Parameters</b></td>
        </tr>
        <tr>
          <td>Amount: </td>
          <td>
          <asp:TextBox ID="amount" runat="server" Visible="true"  /></td>
          <td>First Name: </td>
          <td>
           <asp:TextBox ID="firstname" runat="server" /></td>
        </tr>
        <tr>
          <td>Email: </td>
          <td>
           <asp:TextBox ID="email" runat="server" /></td>
          <td>Phone: </td>
          <td>
          <asp:TextBox ID="phone" runat="server" /></td>
        </tr>
        <tr>
          <td>Product Info: </td>
          <td colspan="3">
          <asp:TextBox ID="productinfo" runat="server" placeholder="orders" /></td>
        </tr>
        <tr>
          <td>Success URI: </td>
          <td colspan="3">
          <asp:TextBox ID="surl" runat="server" >http://tasteclub.in/new_meting.aspx</asp:TextBox>
            </td>
        </tr>
        <tr>
          <td>Failure URI: </td>
          <td colspan="3">
          <asp:TextBox ID="furl" runat="server" >http://tasteclub.in/new_meting.aspx</asp:TextBox>
            </td>
        </tr>
        <tr>
          <td><b>Optional Parameters</b></td>
        </tr>
        <tr>
          <td>Last Name: </td>
          <td>
          <asp:TextBox ID="lastname" runat="server" Enabled="False" /></td>
          <td>Cancel URI: </td>
          <td>
           <asp:TextBox ID="curl" runat="server" Enabled="False" /></td>
         
        </tr>
        <tr>
          <td>Address1: </td>
          <td>
            <asp:TextBox ID="address1" runat="server" Enabled="False" /></td>
          <td>Address2: </td>
          <td>
          <asp:TextBox ID="address2" runat="server" Enabled="False" /></td>
        </tr>
        <tr>
          <td>City: </td>
          <td>
          <asp:TextBox ID="city" runat="server" Enabled="False" /></td>
          <td>State: </td>
          <td>
          <asp:TextBox ID="state" runat="server" Enabled="False" /></td>
        </tr>
        <tr>
          <td>Country: </td>
          <td>
          <asp:TextBox ID="country" runat="server" Enabled="False" /></td>
          <td>Zipcode: </td>
          <td>
            <asp:TextBox ID="zipcode" runat="server" Enabled="False" /></td>
        </tr>
        <tr>
          <td>UDF1: </td>
          <td>
           <asp:TextBox ID="udf1" runat="server" Enabled="False" /></td>
          <td>UDF2: </td>
          <td>
           <asp:TextBox ID="udf2" runat="server" Enabled="False" /></td>
        </tr>
        <tr>
          <td>UDF3: </td>
          <td>
           <asp:TextBox ID="udf3" runat="server" Enabled="False" /></td>
          <td>UDF4: </td>
          <td>
           <asp:TextBox ID="udf4" runat="server" Enabled="False" /></td>
        </tr>
        <tr>
          <td>UDF5: </td>
          <td>
           <asp:TextBox ID="udf5" runat="server" Enabled="False" /></td>
          <td>PG: </td>
          <td>
           <asp:TextBox ID="pg" runat="server" Enabled="False" /></td>
        </tr>
		<tr>
		<td>Service Provider: </td>
          <td>
           <asp:TextBox ID="service_provider" runat="server" Text="payu_paisa"/></td>
		</tr>
        <tr>
        
            <td colspan="4"></td>
            
        </tr>
      </table>
     <div style="float:right; height:200px; width:415px;">
     <div style="font-size:22px;">Order Summery</div>
         <asp:PlaceHolder ID="PlaceHolder1" runat="server">
        
                            </asp:PlaceHolder>
                 <div style="width:395px; height:2px; border-bottom:2px solid #ccc; float:left; margin-bottom:10px;"></div>
                   <asp:PlaceHolder ID="PlaceHolder2" runat="server">
        
                            </asp:PlaceHolder>


                                 <table>
        <tr>
        <td>
              <asp:Label ID="Label1" runat="server" Text="Grand Total" 
                  style="margin-left:32px; margin-right:240px;"></asp:Label>
        </td>
        <td> 
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label></td>
        </tr>
        
       
        </table>

       
        
     </div>
      
       </asp:Panel>
     </div>
    


    
</div>

    </form>


    <div id="header_bot">
<div id="header_bot_main_met" style="height:58px;">
<p><b>Questions?</b>  <b>Email Us</b>  Call Us <b>+91-123-456-7890</b> (M-F 9AM - 6PM)  <a href="#"><img src="img/1406225452_facebook.png" /></a></p>

<div id="header_bot_main_botf">
<p><a href="about_us.aspx">About Us</a> <a href="#"> Careers </a> <a href="#"> Contact Us </a> <a href="#"> Eat Club for Restaurants</a>  <a href="#"> Group & Lunch Meetings</a> <a href="#"> FAQ</a> <a href="#"> Terms </a> <a href="#">Suggestion Box </a></p>
</div>

</div> 
</div>
<div id="fotter_bottom_main" style="height:120px;">
<div id="fotter_bottom">
<p>ALL RIGHTS RESERVED  | COPYRIGHTS &copy; 2014 | <a href="#">TasteClub</a></p>
<p style="float:right; font-size:14px;">Design by: <a href="#">Shri Satya Technologies</a></p>
</div>
</div>
<script type="text/javascript">
    var MenuBar1 = new Spry.Widget.MenuBar("MenuBar1", { imgDown: "SpryAssets/SpryMenuBarDownHover.gif", imgRight: "SpryAssets/SpryMenuBarRightHover.gif" });
</script>

<script type="text/javascript">
    $(document).ready(function () {
        $(document).scroll(function () {
            var scroll = $(this).scrollTop();
            var topDist = $("#container").position();
            if (scroll > topDist.top) {
                $('#header_rihgt_bottom_main').css({ "position": "fixed", "top": "0" });
            } else {
                $('#header_rihgt_bottom_main').css({ "position": "static", "top": "auto" });
            }
        });
    });
</script>

</body>
</html>
