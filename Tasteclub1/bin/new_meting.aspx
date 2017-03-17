
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="new_meting.aspx.cs" Inherits="new_meting" %>



<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>

<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<link rel='icon' type='image/png' href="img/titl-logo.png" />
<title>Taste Club</title>
<link href="css/stylesheet.css" rel="stylesheet" type="text/css" />
  
<style type="text/css">
atfont-face{ font-family:"SCRIPTBL"; src:url(SCRIPTBL.TTF) format("truetype");
}
p.SCRIPTBL{font-family:"SCRIPTBL"; }    
h1.SCRIPTBL{font-family:"SCRIPTBL"; } 
a.SCRIPTBL{font-family:"SCRIPTBL"; }    
</style>
<script src="SpryAssets/SpryMenuBar.js" type="text/javascript"></script>
<link href="SpryAssets/SpryMenuBarHorizontal.css" rel="stylesheet" type="text/css" />
<script src="skdslider/jquery1.10.1.min.js" type="text/javascript"></script>


    <script language="javascript" type="text/javascript">
        function DisableBackButton() {
            window.history.forward();
        }
        setTimeout("DisableBackButton()", 0);
        window.onunload = function () { null }
    </script>

<script language="javascript" type="text/javascript">
    function CalculateExpense(obj)
     {
        var row = obj.parentNode.parentNode; var inputs = row.getElementsByTagName("input");

        sum = 0;
        for (i = 0; i < inputs.length; i++) 
        {
            if (inputs[i].type == "text")
             {

                if (inputs[i].id.indexOf("txtTotal") == -1) //Here give the id of the Total textbox
                {

                    //Calculate Total
                    if (inputs[i].value != null && inputs[i].value != "")

                        sum += parseInt(inputs[i].value);

                }

                else
                {

                    //Store the Total

                    inputs[i].value = sum;

                }

            }

        }

    }
</script>

</head>

<body>
<form runat="server" id="F1">
<header>
 
    


<div id="header_rihgt_bottom_main">
<div id="header_main2">
<div id="header_left2">
<div style="z-index: 1; position: relative; left: 125px;"><a href="index.aspx"><img src="img/logo.png" width="150px" height="200px"  style="margin-left:-90px;"  /></a></div> 
</div>
<div id="header_rihgt" style="float:right; width:250px;">
<div id="header_rihgt_top">

<ul id="MenuBar1" class="MenuBarHorizontal">
  <li>
  
  <a class="MenuBarItemSubmenu" href="#"  style="text-decoration:none; font-weight:bold;">Hi <asp:Label ID="Label1" runat="server" Text=""></asp:Label></a>
  
   <%-- <img src="img/rs.png" height="13px"/>&nbsp;--%>   <%--<asp:Label ID="Label2" runat="server" Text="0.00 "></asp:Label> Credit</a>--%>
    <ul>

      <li><a href="invite.aspx">Invite</a></li>   
      <li><a href="accounts.aspx">Account</a></li>

      <%-- <li><a href="index.aspx">Logout</a></li>--%>
    </ul>
  </li>
</ul>

<asp:Label ID="Label3" runat="server" Text="" Visible="false"></asp:Label>


<div id="header_rihgt_bottom">
  <ul>
    
    <li  style="width:150px;"><a href="#" >Menu</a></li>
    <li  style="width:150px;"> <a  href="order.aspx">Order History</a></li>
  
   </ul>




<%--
    <style type="text/css">
        .logout{ font-size: 22px;
font-weight: bold;
border-radius: 5px;
color: #fff;
height: 50px;
margin-right: 109px;
float: right;
width: 100px;
background-color: #f00;}
        .logout a{color:Black; text-decoration:none; margin-right:10px; margin-left:5px;}
        .logout a:hover{color:Blue;}
        .style1
        {
            color: #990000;
            font-family: "Times New Roman", Times, serif;
            font-size: large;
        }
        .style1 a{color:Maroon; text-decoration:none;}
        
        </style>--%>












   <div style="font-size: 22px;
font-weight: bold;
border-radius: 5px;
color: #fff;
margin-right: 109px;
float: right;
background-color: #f00;">




    <asp:Button ID="btnlogout" runat="server" onclick="btnlogout_Click" Text="Log Out" Font-Size="22px"
           BackColor="Red" ForeColor="White" style="color:White; background-color:Red; border-style:None; font-size:22px; border-radius: 5px; height:50px; width:100px;"/>
   </div>
 </div>
</div>
</div>

<div id="newdiv">
    <%--<h1> Create Your Group Order </h1>--%><%--<b> The easiest way to order for groups of 5 or 500.</b>--%><%--<p>For your next group lunch, order something to satisfy everyone's tastebuds. We accept group orders (minimum 5 meals) until 4:30pm the day before.</p>--%>

</div>


    


</div>
</div>

<div id="slider_main" style=" margin-top:-125px;">

<div id="header_left3" style="color:#f000;">
<p>START HERE</p>
    <%--<img src="img/subbot.png" style="height:30px;" />--%>
</div>

<div id="lunch_pro">

<ul>

<li><asp:LinkButton runat="server" ID="lk" onclick="lk_Click"> 
<asp:Panel ID="Panel1" runat="server" style="height:40px; padding:10px 0px;">
                <asp:Label ID="lbmndy" runat="server" Text=""></asp:Label><br />
                <asp:Label ID="lbmndydate" runat="server" Text=""></asp:Label>
                </asp:Panel>
               
   </asp:LinkButton>
</li>
<li>
<asp:LinkButton runat="server" ID="lk1" onclick="lk1_Click">
<asp:Panel ID="Panel2" runat="server" style="height:40px; padding:10px 0px;">
                <asp:Label ID="lbtsdy" runat="server" Text=""></asp:Label><br />
                <asp:Label ID="lbtsdydate" runat="server" Text=""></asp:Label>
                </asp:Panel>
   </asp:LinkButton>
</li>
<li>
<asp:LinkButton runat="server" ID="lk2" onclick="lk2_Click"><asp:Panel ID="Panel3" runat="server" style="height:40px; padding:10px 0px;">
                <asp:Label ID="lbwndy" runat="server" Text=""></asp:Label><br />
                <asp:Label ID="lbwndydate" runat="server" Text=""></asp:Label>
                </asp:Panel>
     </asp:LinkButton>
</li>
<li>
<asp:LinkButton runat="server" ID="lk3" onclick="lk3_Click">
<asp:Panel ID="Panel4" runat="server" style="height:40px; padding:10px 0px;">
                <asp:Label ID="lbthdy" runat="server" Text=""></asp:Label><br />
                <asp:Label ID="lbthdydate" runat="server" Text=""></asp:Label>
                </asp:Panel>
    </asp:LinkButton>
</li>
<li>
<asp:LinkButton runat="server" ID="lk4" onclick="lk4_Click">
<asp:Panel ID="Panel5" runat="server" style="height:40px; padding:10px 0px;">
                <asp:Label ID="lbfdy" runat="server" Text=""></asp:Label><br />
                <asp:Label ID="lbfdydate" runat="server" Text=""></asp:Label>
                </asp:Panel>
    </asp:LinkButton>

</li>


</ul>




<%--<table>
<tr>
<td>Meeting Name<br />
<asp:TextBox ID="txtmetname" runat="server" style="width:280px; float:left; padding:5px; color:#888A4f; "></asp:TextBox>
</td>
 <td>
 Loction<br />
<asp:TextBox ID="txtloc" runat="server" style="width:280px; float:left; padding:5px; color:#888A4f;"></asp:TextBox>
</td> 
<td rowspan="2" >Delivery Instructions for Driver<br />
<asp:TextBox ID="txtdelinst" runat="server" 
        style="width:280px; float:left; padding:5px " Height="95px" 
        TextMode="MultiLine" BorderColor="#D7D7D7" BorderStyle="Solid"
        BorderWidth="2px" ForeColor="#888A4F"></asp:TextBox></td></tr>
<tr><td>Contact<br /><asp:TextBox ID="txtcont" runat="server" style="width:280px; float:left; padding:5px; color:#888A4f;"></asp:TextBox></td>
 <td>Phone<br /><asp:TextBox ID="txtph" runat="server" style="width:280px; float:left; padding:5px; color:#888A4f; "></asp:TextBox></td></tr>


</table>--%>

</div>

</div>

</header>


<div id="container">

<nav>
 
 <div id="nav_warp">
 <div id="nav_warp_cart">
 <h1 style="margin-left:43px;"><span style="color:Red;">
     <%--
 <asp:Label ID="lblcount" runat="server" Text="0"></asp:Label>--%>
 </span></h1>
 </div>
 
 <div id="nav_warp_span">
 <a href="add_to_cart.aspx">
<img src="img/download.png"  style="height:50px; width:50px;"/>
</a>
     <%--<img src="img/cart.png" />--%>
 </div>
 <div id="nav_warp_h2">
 <h2><asp:Label ID="lblmenu" runat="server" Text=""></asp:Label>'s Menu</h2>
 </div>
 
 <div id="nav_warp_right">
 
 </div>
 
 
 </div>   	
        
        
        
</nav>





<div id="wrapper_main">
<div id="wrapper">
<div id="cantant" style="width:720px;">



<div id="main_gallery_div">

<div id="main_gallery_div_sub">





<div class="con">

     <asp:PlaceHolder ID="PlaceHolder1" runat="server">
        
                            </asp:PlaceHolder> 
                      
</div>
</div>






</div>







</div>
    <div id="your_order_list">
<h1>Your Order List</h1>


<table>
<tr style="width:266px; float:left;">
<td style="width:266px; float:left;">
    <asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder>
</td>
<td></td>
</tr >

<tr style="width: 312px; float:left; margin-left:10px;">
<br />
<br />
<td style="width:200px; float:left;">Food Total</td><td style="float:right;"><asp:Label ID="Label4" runat="server"></asp:Label></td>
<td>
   
    </td>
</tr>

 
</table>


</div>
</div>
</div>



<div id="header_bot">
<div id="header_bot_main">
<div id="header_bot_main_left">
<h1 id="black_color"></h1>

<div id="subfottoriv">

<p><b>Subtotal</b> <span><img src="img/rs.png" /><asp:Label ID="lbsubtotal" 
        runat="server" Text="0"></asp:Label></span></p>
<div id="fotter_butn">
    <asp:Button ID="Button1" runat="server" Text="Continue" onclick="Button1_Click" 
         /></div>
    <div style="color:Black;">
        <asp:Label ID="lberror" runat="server" Text=""></asp:Label>
        
    </div>
</div>


</div>
</div> 
</div>
<div id="fotter_bottom_main">

</div>




</div>


<script type="text/javascript">
    $(document).ready(function () {
        $(document).scroll(function () {
            var scroll = $(this).scrollTop();
            var topDist = $("#container").position();
            if (scroll > topDist.top) {
                $('nav').css({ "position": "fixed", "top": "0" });
            } else {
                $('nav').css({ "position": "static", "top": "auto" });
            }
        });
    });
</script>

<script type="text/javascript">
    var MenuBar1 = new Spry.Widget.MenuBar("MenuBar1", { imgDown: "SpryAssets/SpryMenuBarDownHover.gif", imgRight: "SpryAssets/SpryMenuBarRightHover.gif" });
</script>


</form>

</body>
</html>
