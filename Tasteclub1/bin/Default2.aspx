<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

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
    function sum() {
        var a = document.getElementById('TextBox1').value;
        var b = document.getElementById('TextBox2').value;
        var c = document.getElementById('TextBox3').value;
        var d = document.getElementById('TextBox4').value;
        var e = document.getElementById('TextBox5').value;
        var f = document.getElementById('TextBox6').value;
        var g = document.getElementById('TextBox7').value;
        var h = document.getElementById('TextBox8').value;
        var i = document.getElementById('TextBox9').value;
        var j = document.getElementById('TextBox10').value;
        var k = document.getElementById('TextBox11').value;
        var l = document.getElementById('TextBox12').value;
        var m = document.getElementById('TextBox13').value;
        var n = document.getElementById('TextBox14').value;
        var o = document.getElementById('TextBox15').value;
        var p = document.getElementById('TextBox16').value;
        var q = document.getElementById('TextBox17').value;
        var r = document.getElementById('TextBox18').value;
        var s = document.getElementById('TextBox19').value;
        var t = document.getElementById('TextBox20').value;
        var u = document.getElementById('TextBox21').value;
        var v = document.getElementById('TextBox22').value;

        if (a == "")
            a = 0;
        if (b == "")
            b = 0;
        if (c == "")
            c = 0;
        if (d == "")
            d = 0;
        if (e == "")
            e = 0;
        if (f == "")
            f = 0;
        if (g == "")
            g = 0;
        if (h == "")
            h = 0;
        if (i == "")
            i = 0;
        if (j == "")
            j = 0;
        if (k == "")
            k = 0;
        if (l == "")
            l = 0;
        if (m == "")
            m = 0;
        if (n == "")
            n = 0;
        if (o == "")
            o = 0;
        if (p == "")
            p = 0;
        if (q == "")
            q = 0;
        if (r == "")
            r = 0;
        if (s == "")
            s = 0;
        if (t == "")
            t = 0;
        if (u == "")
            u = 0;
        if (v == "")
            v = 0;

        var result = parseInt(a) + parseInt(b) + parseInt(c) + parseInt(d) + parseInt(e) + parseInt(f) + parseInt(g) + parseInt(h) + parseInt(i) + parseInt(j) + parseInt(k) + parseInt(l) + parseInt(m) + parseInt(n) + parseInt(o) + parseInt(p) + parseInt(q) + parseInt(r) + parseInt(s) + parseInt(t) + parseInt(u) + parseInt(v);
        if (!isNaN(result)) {
            document.getElementById('TextBox23').value = result;
        }
    }
</script>

</head>

<body >
<form runat="server" id="F1">
<header>
 
    


<div id="header_rihgt_bottom_main">
<div id="header_main2">
<div id="header_left2">
<a href="index.aspx"><img src="img/logo.png" width="100px" height="130px"  /></a>
</div>
<div id="header_rihgt">
<div id="header_rihgt_top" style="width:850px;">

<ul id="MenuBar1" class="MenuBarHorizontal">
  <li><a class="MenuBarItemSubmenu" href="#">Hi <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
   &nbsp;<img src="img/rs.png" height="13px"/>&nbsp;<asp:Label ID="Label2" runat="server" Text="0.00 "></asp:Label> Credit</a>
    <ul>
      <li><a href="#">Invite</a></li>
      <li><a href="#">Gift Cards</a></li>
      <li><a href="#">Account</a></li>
       <li><a href="#">Logout</a></li>
    </ul>
  </li>
  
 

</ul>




<div id="header_rihgt_bottom" style="width:500px;">
  <ul>
    <li><a  href="order.aspx" >My Order</a></li>
    <li><a href="home.aspx" >Menu</a></li>
    <li><a href="home.aspx" >Reward</a></li>
   </ul>
   
 </div>
</div>
</div>

<div id="newdiv">
<h1> Create Your Group Order </h1>
<b> The easiest way to order for groups of 5 or 500.</b>
<p>For your next group lunch, order something to satisfy everyone's tastebuds. We accept group orders (minimum 5 meals) until 4:30pm the day before.</p>

</div>


</div>
</div>

<div id="slider_main" style="margin:0px;;">

<div id="header_left3">
<p>START HERE</p>
<img src="img/subbot.png" style="height:30px;" />
</div>

<div id="lunch_pro">

<ul>

<li><a href="#"><asp:Panel ID="Panel1" runat="server" style="height:40px; padding:10px 0px;">
                <asp:Label ID="lbmndy" runat="server" Text="Label">Monday</asp:Label><br />
                <asp:Label ID="lbmndydate" runat="server" Text=""></asp:Label>
                </asp:Panel>
               
    </a>
</li>
<li><a href="#"><asp:Panel ID="Panel2" runat="server" style="height:40px; padding:10px 0px;">
                <asp:Label ID="lbtsdy" runat="server" Text="Label">Tuesday</asp:Label><br />
                <asp:Label ID="lbtsdydate" runat="server" Text=""></asp:Label>
                </asp:Panel>
    </a>
</li>
<li><a href="#"><asp:Panel ID="Panel3" runat="server" style="height:40px; padding:10px 0px;">
                <asp:Label ID="lbwndy" runat="server" Text="Label">Wednesday</asp:Label><br />
                <asp:Label ID="lbwndydate" runat="server" Text=""></asp:Label>
                </asp:Panel>
     </a>
</li>
<li><a href="#"><asp:Panel ID="Panel4" runat="server" style="height:40px; padding:10px 0px;">
                <asp:Label ID="lbthdy" runat="server" Text="Label">Thursday</asp:Label><br />
                <asp:Label ID="lbthdydate" runat="server" Text=""></asp:Label>
                </asp:Panel>
    </a>
</li>
<li>
<a href="#"><asp:Panel ID="Panel5" runat="server" style="height:40px; padding:10px 0px;">
                <asp:Label ID="lbfdy" runat="server" Text="Label">Friday</asp:Label><br />
                <asp:Label ID="lbfdydate" runat="server" Text=""></asp:Label>
                </asp:Panel>
    </a>

</li>
<li><a href="#"><asp:Panel ID="Panel6" runat="server" style="height:40px; padding:10px 0px;">
                <asp:Label ID="lbstdy" runat="server" Text="Label">Saturday</asp:Label><br />
                <asp:Label ID="lbstdydate" runat="server" Text=""></asp:Label>
                </asp:Panel>
    </a>
</li>

</ul>




<table>
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


</table>

</div>

</div>

</header>


<div id="container">

<nav>
 
 <div id="nav_warp">
 <div id="nav_warp_cart">
 <h1 style="margin-left:43px;"><span style="color:Red;">
 <%--<asp:TextBox ID="TextBox23" runat="server"></asp:TextBox>--%>
 <asp:Label ID="lblcount" runat="server" Text="0"></asp:Label></span></h1>
 </div>
 
 <div id="nav_warp_span">
 <img src="img/cart.png" />
 </div>
 <div id="nav_warp_h2">
 <h2><asp:Label ID="lblmenu" runat="server" Text=""></asp:Label>'s Menu</h2>
 </div>
 
 <div id="nav_warp_right">
 <a href="#"> See Printable Menu </a>
 <a href="#"> Review Order </a>
 
 </div>
 
 
 </div>   	
        
        
        
</nav>





<div id="wrapper_main">
<div id="wrapper">
<div id="cantant">



<div id="main_gallery_div">

<div id="main_gallery_div_sub">

<%--<div id="main_gallery_div_sub1">
   
</div>--%>



<asp:Panel ID="Panel7" runat="server">
 <div class="con">
     
        <div class="con_txt">
        <asp:TextBox ID="TextBox1" runat="server" ontextchanged="TextBox1_TextChanged" AutoPostBack="false" onkeyup="sum();"></asp:TextBox>
                  

        </div>
        <div class="con_place">
            <asp:HyperLink ID="hll1" runat="server" Target="_blank"><asp:Image ID="Image1" runat="server"/></asp:HyperLink>
        </div>
        <div class="con_label">
            <asp:Label ID="lbitemname1" runat="server" Text="" 
                style="font-size: x-large; font-family: Arial, Helvetica, sans-serif"></asp:Label><br />
            <asp:Label ID="lbcompany1" runat="server" Text=""></asp:Label><br /><br /><br />
           <span style="color:#51ae8c; font-weight: 500; font-size: 1.125em; margin-top:1px;"><img src="img/rs.png" /></span>  
           <asp:Label ID="lbprice1" runat="server" Text="" style="color:#51ae8c; font-weight: 500; font-size: 1.125em;"></asp:Label><br />
        </div>
    
  </div>
   </asp:Panel>
    <asp:Panel ID="Panel8" runat="server">
  <div class="con_even">
    
        <div class="con_txt">
            <asp:TextBox ID="TextBox2" runat="server" ontextchanged="TextBox2_TextChanged" onkeyup="sum();"></asp:TextBox>

        </div>
        <div class="con_place">
            <asp:HyperLink ID="hll2" runat="server" Target="_blank"><asp:Image ID="Image2" runat="server" /></asp:HyperLink>
        </div>
        <div class="con_label">
            <asp:Label ID="lbitemname2" runat="server" Text="" 
                style="font-size: x-large; font-family: Arial, Helvetica, sans-serif"></asp:Label><br />
            <asp:Label ID="lbcompany2" runat="server" Text=""></asp:Label><br /><br /><br />
           <span style="color:#51ae8c; font-weight: 500; font-size: 1.125em;"><img src="img/rs.png" /></span>  <asp:Label ID="lbprice2" runat="server" Text="" style="color:#51ae8c; font-weight: 500; font-size: 1.125em;"></asp:Label><br />
        </div>
    
  </div>
   </asp:Panel>
     <asp:Panel ID="Panel9" runat="server">
  <div class="con">
   
        <div class="con_txt">
            <asp:TextBox ID="TextBox3" runat="server" ontextchanged="TextBox3_TextChanged" onkeyup="sum();"></asp:TextBox>

        </div>
        <div class="con_place">
            <asp:HyperLink ID="hll3" runat="server" Target="_blank"> <asp:Image ID="Image3" runat="server" /></asp:HyperLink>
        </div>
        <div class="con_label">
            <asp:Label ID="lbitemname3" runat="server" Text="" 
                style="font-size: x-large; font-family: Arial, Helvetica, sans-serif"></asp:Label><br />
            <asp:Label ID="lbcompany3" runat="server" Text=""></asp:Label><br /><br /><br />
           <span style="color:#51ae8c; font-weight: 500; font-size: 1.125em;"><img src="img/rs.png" /></span>  <asp:Label ID="lbprice3" runat="server" Text="" style="color:#51ae8c; font-weight: 500; font-size: 1.125em;"></asp:Label><br />
        </div>
     
  </div>
  </asp:Panel>
  <asp:Panel ID="Panel10" runat="server">
  <div class="con_even">
     
        <div class="con_txt">
            <asp:TextBox ID="TextBox4" runat="server" ontextchanged="TextBox4_TextChanged" onkeyup="sum();"></asp:TextBox>

        </div>
        <div class="con_place">
            <asp:HyperLink ID="hll4" runat="server" Target="_blank"><asp:Image ID="Image4" runat="server" /></asp:HyperLink>
        </div>
        <div class="con_label">
            <asp:Label ID="lbitemname4" runat="server" Text="" 
                style="font-size: x-large; font-family: Arial, Helvetica, sans-serif"></asp:Label><br />
            <asp:Label ID="lbcompany4" runat="server" Text=""></asp:Label><br /><br /><br />
           <span style="color:#51ae8c; font-weight: 500; font-size: 1.125em;"><img src="img/rs.png" /></span>  <asp:Label ID="lbprice4" runat="server" Text="" style="color:#51ae8c; font-weight: 500; font-size: 1.125em;"></asp:Label><br />
        </div>
     
  </div>
  </asp:Panel>
  <asp:Panel ID="Panel11" runat="server">
  <div class="con">
     
        <div class="con_txt">
            <asp:TextBox ID="TextBox5" runat="server" ontextchanged="TextBox5_TextChanged" onkeyup="sum();"></asp:TextBox>

        </div>
        <div class="con_place">
            <asp:HyperLink ID="hll5" runat="server" Target="_blank"><asp:Image ID="Image5" runat="server" /></asp:HyperLink>
        </div>
        <div class="con_label">
            <asp:Label ID="lbitemname5" runat="server" Text="" 
                style="font-size: x-large; font-family: Arial, Helvetica, sans-serif"></asp:Label><br />
            <asp:Label ID="lbcompany5" runat="server" Text=""></asp:Label><br /><br /><br />
           <span style="color:#51ae8c; font-weight: 500; font-size: 1.125em;"><img src="img/rs.png" /></span>  <asp:Label ID="lbprice5" runat="server" Text="" style="color:#51ae8c; font-weight: 500; font-size: 1.125em;"></asp:Label><br />
        </div>
     
  </div>
  </asp:Panel>
  <asp:Panel ID="Panel12" runat="server">
  <div class="con_even">
     
        <div class="con_txt">
            <asp:TextBox ID="TextBox6" runat="server" ontextchanged="TextBox6_TextChanged" onkeyup="sum();"></asp:TextBox>

        </div>
        <div class="con_place">
            <asp:HyperLink ID="hll6" runat="server" Target="_blank"><asp:Image ID="Image6" runat="server" /></asp:HyperLink>
        </div>
        <div class="con_label">
            <asp:Label ID="lbitemname6" runat="server" Text="" 
                style="font-size: x-large; font-family: Arial, Helvetica, sans-serif"></asp:Label><br />
            <asp:Label ID="lbcompany6" runat="server" Text=""></asp:Label><br /><br /><br />
           <span style="color:#51ae8c; font-weight: 500; font-size: 1.125em;"><img src="img/rs.png" /></span>  <asp:Label ID="lbprice6" runat="server" Text="" style="color:#51ae8c; font-weight: 500; font-size: 1.125em;"></asp:Label><br />
        </div>
     
  </div>
  </asp:Panel>
  <asp:Panel ID="Panel13" runat="server">
  <div class="con">
     
        <div class="con_txt">
            <asp:TextBox ID="TextBox7" runat="server" ontextchanged="TextBox7_TextChanged" onkeyup="sum();"></asp:TextBox>

        </div>
        <div class="con_place">
            <asp:HyperLink ID="hll7" runat="server" Target="_blank"><asp:Image ID="Image7" runat="server" /></asp:HyperLink>
        </div>
        <div class="con_label">
            <asp:Label ID="lbitemname7" runat="server" Text="" 
                style="font-size: x-large; font-family: Arial, Helvetica, sans-serif"></asp:Label><br />
            <asp:Label ID="lbcompany7" runat="server" Text=""></asp:Label><br /><br /><br />
           <span style="color:#51ae8c; font-weight: 500; font-size: 1.125em;"><img src="img/rs.png" /></span> 
            <asp:Label ID="lbprice7" runat="server" Text="" style="color:#51ae8c; font-weight: 500; font-size: 1.125em;"></asp:Label><br />
        </div>
     
  </div>
  </asp:Panel>
  <asp:Panel ID="Panel14" runat="server">
  <div class="con_even">
     
        <div class="con_txt">
            <asp:TextBox ID="TextBox8" runat="server" ontextchanged="TextBox8_TextChanged" onkeyup="sum();"></asp:TextBox>

        </div>
        <div class="con_place">
            <asp:HyperLink ID="hll8" runat="server" Target="_blank"><asp:Image ID="Image8" runat="server" /></asp:HyperLink>
        </div>
        <div class="con_label">
            <asp:Label ID="lbitemname8" runat="server" Text="" 
                style="font-size: x-large; font-family: Arial, Helvetica, sans-serif"></asp:Label><br />
            <asp:Label ID="lbcompany8" runat="server" Text=""></asp:Label><br /><br /><br />
           <span style="color:#51ae8c; font-weight: 500; font-size: 1.125em;"><img src="img/rs.png" /></span>  <asp:Label ID="lbprice8" runat="server" Text="" style="color:#51ae8c; font-weight: 500; font-size: 1.125em;"></asp:Label><br />
        </div>
     
  </div>
  </asp:Panel>
  <asp:Panel ID="Panel15" runat="server">
  <div class="con">
     
        <div class="con_txt">
            <asp:TextBox ID="TextBox9" runat="server" ontextchanged="TextBox9_TextChanged" onkeyup="sum();"></asp:TextBox>

        </div>
        <div class="con_place">
            <asp:HyperLink ID="hll9" runat="server" Target="_blank"><asp:Image ID="Image9" runat="server" /></asp:HyperLink>
        </div>
        <div class="con_label">
            <asp:Label ID="lbitemname9" runat="server" Text="" 
                style="font-size: x-large; font-family: Arial, Helvetica, sans-serif"></asp:Label><br />
            <asp:Label ID="lbcompany9" runat="server" Text=""></asp:Label><br /><br /><br />
           <span style="color:#51ae8c; font-weight: 500; font-size: 1.125em;"><img src="img/rs.png" /></span>  <asp:Label ID="lbprice9" runat="server" Text="" style="color:#51ae8c; font-weight: 500; font-size: 1.125em;"></asp:Label><br />
        </div>
     
  </div>
  </asp:Panel>
  <asp:Panel ID="Panel16" runat="server">
  <div class="con_even">
     
        <div class="con_txt">
            <asp:TextBox ID="TextBox10" runat="server" 
                ontextchanged="TextBox10_TextChanged" onkeyup="sum();"></asp:TextBox>

        </div>
        <div class="con_place">
            <asp:HyperLink ID="hll10" runat="server" Target="_blank"><asp:Image ID="Image10" runat="server" /></asp:HyperLink>
        </div>
        <div class="con_label">
            <asp:Label ID="lbitemname10" runat="server" Text="" 
                style="font-size: x-large; font-family: Arial, Helvetica, sans-serif"></asp:Label><br />
            <asp:Label ID="lbcompany10" runat="server" Text=""></asp:Label><br /><br /><br />
           <span style="color:#51ae8c; font-weight: 500; font-size: 1.125em;"><img src="img/rs.png" /></span>  <asp:Label ID="lbprice10" runat="server" Text="" style="color:#51ae8c; font-weight: 500; font-size: 1.125em;"></asp:Label><br />
        </div>
     
  </div>
  </asp:Panel>
  <asp:Panel ID="Panel17" runat="server">
  <div class="con">
     
        <div class="con_txt">
            <asp:TextBox ID="TextBox11" runat="server" 
                ontextchanged="TextBox11_TextChanged" onkeyup="sum();"></asp:TextBox>

        </div>
        <div class="con_place">
            <asp:HyperLink ID="hll11" runat="server" Target="_blank"><asp:Image ID="Image11" runat="server" /></asp:HyperLink>
        </div>
        <div class="con_label">
            <asp:Label ID="lbitemname11" runat="server" Text="" 
                style="font-size: x-large; font-family: Arial, Helvetica, sans-serif"></asp:Label><br />
            <asp:Label ID="lbcompany11" runat="server" Text=""></asp:Label><br /><br /><br />
           <span style="color:#51ae8c; font-weight: 500; font-size: 1.125em;"><img src="img/rs.png" /></span>  <asp:Label ID="lbprice11" runat="server" Text="" style="color:#51ae8c; font-weight: 500; font-size: 1.125em;"></asp:Label><br />
        </div>
     
  </div>
  </asp:Panel>
  <asp:Panel ID="Panel18" runat="server">
  <div class="con_even">
     
        <div class="con_txt">
            <asp:TextBox ID="TextBox12" runat="server" 
                ontextchanged="TextBox12_TextChanged" onkeyup="sum();"></asp:TextBox>

        </div>
        <div class="con_place">
            <asp:HyperLink ID="hll12" runat="server" Target="_blank"><asp:Image ID="Image12" runat="server" /></asp:HyperLink>
        </div>
        <div class="con_label">
            <asp:Label ID="lbitemname12" runat="server" Text="" 
                style="font-size: x-large; font-family: Arial, Helvetica, sans-serif"></asp:Label><br />
            <asp:Label ID="lbcompany12" runat="server" Text=""></asp:Label><br /><br /><br />
           <span style="color:#51ae8c; font-weight: 500; font-size: 1.125em;"><img src="img/rs.png" /></span>  <asp:Label ID="lbprice12" runat="server" Text="" style="color:#51ae8c; font-weight: 500; font-size: 1.125em;"></asp:Label><br />
        </div>
     
  </div>
  </asp:Panel>
  <asp:Panel ID="Panel19" runat="server">
  <div class="con">
     
        <div class="con_txt">
            <asp:TextBox ID="TextBox13" runat="server" onkeyup="sum();"
                ontextchanged="TextBox13_TextChanged"></asp:TextBox>

        </div>
        <div class="con_place">
            <asp:HyperLink ID="hll13" runat="server" Target="_blank"><asp:Image ID="Image13" runat="server" /></asp:HyperLink>
        </div>
        <div class="con_label">
            <asp:Label ID="lbitemname13" runat="server" Text="" 
                style="font-size: x-large; font-family: Arial, Helvetica, sans-serif"></asp:Label><br />
            <asp:Label ID="lbcompany13" runat="server" Text=""></asp:Label><br /><br /><br />
           <span style="color:#51ae8c; font-weight: 500; font-size: 1.125em;"><img src="img/rs.png" /></span>  <asp:Label ID="lbprice13" runat="server" Text="" style="color:#51ae8c; font-weight: 500; font-size: 1.125em;"></asp:Label><br />
        </div>
    
  </div>
   </asp:Panel>
    <asp:Panel ID="Panel20" runat="server">
  <div class="con_even">
    
        <div class="con_txt">
            <asp:TextBox ID="TextBox14" runat="server" onkeyup="sum();"
                ontextchanged="TextBox14_TextChanged"></asp:TextBox>

        </div>
        <div class="con_place">
            <asp:HyperLink ID="hll14" runat="server" Target="_blank"><asp:Image ID="Image14" runat="server" /></asp:HyperLink>
        </div>
        <div class="con_label">
            <asp:Label ID="lbitemname14" runat="server" Text="" 
                style="font-size: x-large; font-family: Arial, Helvetica, sans-serif"></asp:Label><br />
            <asp:Label ID="lbcompany14" runat="server" Text=""></asp:Label><br /><br /><br />
           <span style="color:#51ae8c; font-weight: 500; font-size: 1.125em;"><img src="img/rs.png" /></span>  <asp:Label ID="lbprice14" runat="server" Text="" style="color:#51ae8c; font-weight: 500; font-size: 1.125em;"></asp:Label><br />
        </div>
     
  </div>
  </asp:Panel>
  <asp:Panel ID="Panel21" runat="server">
  <div class="con">
     
        <div class="con_txt">
            <asp:TextBox ID="TextBox15" runat="server" onkeyup="sum();"
                ontextchanged="TextBox15_TextChanged"></asp:TextBox>

        </div>
        <div class="con_place">
            <asp:HyperLink ID="hll15" runat="server" Target="_blank"><asp:Image ID="Image15" runat="server" /></asp:HyperLink>
        </div>
        <div class="con_label">
            <asp:Label ID="lbitemname15" runat="server" Text="" 
                style="font-size: x-large; font-family: Arial, Helvetica, sans-serif"></asp:Label><br />
            <asp:Label ID="lbcompany15" runat="server" Text=""></asp:Label><br /><br /><br />
           <span style="color:#51ae8c; font-weight: 500; font-size: 1.125em;"><img src="img/rs.png" /></span>  <asp:Label ID="lbprice15" runat="server" Text="" style="color:#51ae8c; font-weight: 500; font-size: 1.125em;"></asp:Label><br />
        </div>
     
  </div>
  </asp:Panel>
  <asp:Panel ID="Panel22" runat="server">
  <div class="con_even">
     
        <div class="con_txt">
            <asp:TextBox ID="TextBox16" runat="server" onkeyup="sum();"
                ontextchanged="TextBox16_TextChanged"></asp:TextBox>

        </div>
        <div class="con_place">
            <asp:HyperLink ID="hll16" runat="server" Target="_blank"><asp:Image ID="Image16" runat="server" /></asp:HyperLink>
        </div>
        <div class="con_label">
            <asp:Label ID="lbitemname16" runat="server" Text="" 
                style="font-size: x-large; font-family: Arial, Helvetica, sans-serif"></asp:Label><br />
            <asp:Label ID="lbcompany16" runat="server" Text=""></asp:Label><br /><br /><br />
           <span style="color:#51ae8c; font-weight: 500; font-size: 1.125em;"><img src="img/rs.png" /></span>  <asp:Label ID="lbprice16" runat="server" Text="" style="color:#51ae8c; font-weight: 500; font-size: 1.125em;"></asp:Label><br />
        </div>
     
  </div>
  </asp:Panel>
  <asp:Panel ID="Panel23" runat="server">
  <div class="con">
     
        <div class="con_txt">
            <asp:TextBox ID="TextBox17" runat="server" onkeyup="sum();"
                ontextchanged="TextBox17_TextChanged"></asp:TextBox>

        </div>
        <div class="con_place">
            <asp:HyperLink ID="hll17" runat="server" Target="_blank"> <asp:Image ID="Image17" runat="server" /></asp:HyperLink>
        </div>
        <div class="con_label">
            <asp:Label ID="lbitemname17" runat="server" Text="" 
                style="font-size: x-large; font-family: Arial, Helvetica, sans-serif"></asp:Label><br />
            <asp:Label ID="lbcompany17" runat="server" Text=""></asp:Label><br /><br /><br />
           <span style="color:#51ae8c; font-weight: 500; font-size: 1.125em;"><img src="img/rs.png" /></span>  <asp:Label ID="lbprice17" runat="server" Text="" style="color:#51ae8c; font-weight: 500; font-size: 1.125em;"></asp:Label><br />
        </div>
     
  </div>
  </asp:Panel>
  <asp:Panel ID="Panel24" runat="server">
  <div class="con_even">
     
        <div class="con_txt">
            <asp:TextBox ID="TextBox18" runat="server" onkeyup="sum();"
                ontextchanged="TextBox18_TextChanged"></asp:TextBox>

        </div>
        <div class="con_place">
            <asp:HyperLink ID="hll18" runat="server" Target="_blank"><asp:Image ID="Image18" runat="server" /></asp:HyperLink>
        </div>
        <div class="con_label">
            <asp:Label ID="lbitemname18" runat="server" Text="" 
                style="font-size: x-large; font-family: Arial, Helvetica, sans-serif"></asp:Label><br />
            <asp:Label ID="lbcompany18" runat="server" Text=""></asp:Label><br /><br /><br />
           <span style="color:#51ae8c; font-weight: 500; font-size: 1.125em;"><img src="img/rs.png" /></span>  <asp:Label ID="lbprice18" runat="server" Text="" style="color:#51ae8c; font-weight: 500; font-size: 1.125em;"></asp:Label><br />
        </div>
     
  </div>
  </asp:Panel>
  <asp:Panel ID="Panel25" runat="server">
  <div class="con">
     
        <div class="con_txt">
            <asp:TextBox ID="TextBox19" runat="server" onkeyup="sum();"
                ontextchanged="TextBox19_TextChanged"></asp:TextBox>

        </div>
        <div class="con_place">
            <asp:HyperLink ID="hll19" runat="server" Target="_blank"><asp:Image ID="Image19" runat="server" /></asp:HyperLink>
        </div>
        <div class="con_label">
            <asp:Label ID="lbitemname19" runat="server" Text="" 
                style="font-size: x-large; font-family: Arial, Helvetica, sans-serif"></asp:Label><br />
            <asp:Label ID="lbcompany19" runat="server" Text=""></asp:Label><br /><br /><br />
           <span style="color:#51ae8c; font-weight: 500; font-size: 1.125em;"><img src="img/rs.png" /></span>  <asp:Label ID="lbprice19" runat="server" Text="" style="color:#51ae8c; font-weight: 500; font-size: 1.125em;"></asp:Label><br />
        </div>
     
  </div>
  </asp:Panel>
  <asp:Panel ID="Panel26" runat="server">
  <div class="con_even">
     
        <div class="con_txt">
            <asp:TextBox ID="TextBox20" runat="server" onkeyup="sum();"
                ontextchanged="TextBox20_TextChanged"></asp:TextBox>

        </div>
        <div class="con_place">
            <asp:HyperLink ID="hll20" runat="server" Target="_blank"><asp:Image ID="Image20" runat="server" /></asp:HyperLink>
        </div>
        <div class="con_label">
            <asp:Label ID="lbitemname20" runat="server" Text="" 
                style="font-size: x-large; font-family: Arial, Helvetica, sans-serif"></asp:Label><br />
            <asp:Label ID="lbcompany20" runat="server" Text=""></asp:Label><br /><br /><br />
           <span style="color:#51ae8c; font-weight: 500; font-size: 1.125em;"><img src="img/rs.png" /></span>  <asp:Label ID="lbprice20" runat="server" Text="" style="color:#51ae8c; font-weight: 500; font-size: 1.125em;"></asp:Label><br />
        </div>
     
  </div>
  </asp:Panel>
  <asp:Panel ID="Panel27" runat="server">
  <div class="con">
     
        <div class="con_txt">
            <asp:TextBox ID="TextBox21" runat="server" onkeyup="sum();"
                ontextchanged="TextBox21_TextChanged"></asp:TextBox>

        </div>
        <div class="con_place">
            <asp:HyperLink ID="hll21" runat="server" Target="_blank"><asp:Image ID="Image21" runat="server" /></asp:HyperLink>
        </div>
        <div class="con_label">
            <asp:Label ID="lbitemname21" runat="server" Text="" 
                style="font-size: x-large; font-family: Arial, Helvetica, sans-serif"></asp:Label><br />
            <asp:Label ID="lbcompany21" runat="server" Text=""></asp:Label><br /><br /><br />
           <span style="color:#51ae8c; font-weight: 500; font-size: 1.125em;"><img src="img/rs.png" /></span>  <asp:Label ID="lbprice21" runat="server" Text="" style="color:#51ae8c; font-weight: 500; font-size: 1.125em;"></asp:Label><br />
        </div>
     
  </div>
  </asp:Panel>
  <asp:Panel ID="Panel28" runat="server">
  <div class="con_even">
     
        <div class="con_txt">
            <asp:TextBox ID="TextBox22" runat="server" onkeyup="sum();"
                ontextchanged="TextBox22_TextChanged"></asp:TextBox>

        </div>
        <div class="con_place">
            <asp:HyperLink ID="hll22" runat="server" Target="_blank"><asp:Image ID="Image22" runat="server" /></asp:HyperLink>
        </div>
        <div class="con_label">
            <asp:Label ID="lbitemname22" runat="server" Text="" 
                style="font-size: x-large; font-family: Arial, Helvetica, sans-serif"></asp:Label><br />
            <asp:Label ID="lbcompany22" runat="server" Text=""></asp:Label><br /><br /><br />
           <span style="color:#51ae8c; font-weight: 500; font-size: 1.125em;"><img src="img/rs.png" /></span>  <asp:Label ID="lbprice22" runat="server" Text="" style="color:#51ae8c; font-weight: 500; font-size: 1.125em;"></asp:Label><br />
        </div>
     
  </div>
  </asp:Panel>
</div>



<%--<div id="main_gallery_div2_sub">

<div id="main_gallery_div_sub1">
<input type="text" value="0" id="main_gallery_div_sub1_input" />
</div>

<div id="main_gallery_div_sub2">
<a href="#" rel="popover" target="_blank"  ><img src="img/m5.jpg" /></a>

<h1>White Truffled Chicken Salad</h1>
<p>The Urban Rabbit</p>
<b><img src="img/rs.png" />150.00</b>
</div>


<div id="main_gallery_div_sub3">
<img src="img/logomenu1.png" />
</div>

</div>



<div id="main_gallery_div_sub">

<div id="main_gallery_div_sub1">
<input type="text" value="0" id="main_gallery_div_sub1_input" />
</div>

<div id="main_gallery_div_sub2">
<a href="#" rel="popover" target="_blank"  ><img src="img/m7.jpg" /></a>

<h1>White Truffled Chicken Salad</h1>
<p>The Urban Rabbit</p>
<b><img src="img/rs.png" />110.00</b>
</div>


<div id="main_gallery_div_sub3">
<img src="img/logomenu1.png" />
</div>

</div>




<div id="main_gallery_div2_sub">

<div id="main_gallery_div_sub1">
<input type="text" value="0" id="main_gallery_div_sub1_input" />
</div>

<div id="main_gallery_div_sub2">
<a href="#" rel="popover" target="_blank"  ><img src="img/m5.jpg" /></a>

<h1>White Truffled Chicken Salad</h1>
<p>The Urban Rabbit</p>
<b><img src="img/rs.png" />10.00</b>
</div>


<div id="main_gallery_div_sub3">
<img src="img/logomenu1.png" />
</div>

</div>




<div id="main_gallery_div_sub">

<div id="main_gallery_div_sub1">
<input type="text" value="0" id="main_gallery_div_sub1_input" />
</div>

<div id="main_gallery_div_sub2">
<a href="#" rel="popover" target="_blank"  ><img src="img/m6.jpg" /></a>

<h1>White Truffled Chicken Salad</h1>
<p>The Urban Rabbit</p>
<b><img src="img/rs.png" />50.00</b>
</div>


<div id="main_gallery_div_sub3">
<img src="img/logomenu1.png" />
</div>

</div>




<div id="main_gallery_div2_sub">

<div id="main_gallery_div_sub1">
<input type="text" value="0" id="main_gallery_div_sub1_input" />
</div>

<div id="main_gallery_div_sub2">
<a href="#" rel="popover" target="_blank"  ><img src="img/m9.jpg" /></a>

<h1>White Truffled Chicken Salad</h1>
<p>The Urban Rabbit</p>
<b><img src="img/rs.png" />170.00</b>
</div>


<div id="main_gallery_div_sub3">
<img src="img/logomenu1.png" />
</div>

</div>



<div id="main_gallery_div_sub">

<div id="main_gallery_div_sub1">
<input type="text" value="0" id="main_gallery_div_sub1_input" />
</div>

<div id="main_gallery_div_sub2">
<a href="#" rel="popover" target="_blank"  ><img src="img/m10.jpg" /></a>

<h1>White Truffled Chicken Salad</h1>
<p>The Urban Rabbit</p>
<b><img src="img/rs.png" />210.00</b>
</div>


<div id="main_gallery_div_sub3">
<img src="img/logomenu1.png" />
</div>

</div>--%>


</div>













</div>
</div>
</div>



<div id="header_bot">
<div id="header_bot_main">
<div id="header_bot_main_left">
<h1 id="black_color">Review Order</h1>
<div style="float:left; width:674px; height:auto; color:Black;">
    <asp:Panel ID="Panel29" runat="server">
    
<div>
      <div style="float:left; margin-right:30px;"><asp:Label ID="lbquantity1" runat="server" Text=""></asp:Label>
          <asp:Label ID="lblx1" runat="server" Text="x"></asp:Label></div>
    <div style="float:left;  margin-right:60px;"><asp:Label ID="lbitem1" runat="server" Text=""></asp:Label></div>
    <div style="float:left;  margin-right:90px;">
        <asp:Label ID="lblat1" runat="server" Text="@"></asp:Label><img src="img/rs.png" />
        <asp:Label ID="lbrate1" runat="server" Text="">
        </asp:Label><asp:Label  ID="lbleach1" runat="server" Text="/each"></asp:Label></div>
           
    <div style="float:left;  margin-right:30px;"><asp:Label ID="lbinrr1" runat="server" 
            Text="INR"></asp:Label><asp:Label  ID="lbrateonly1" runat="server" Text=""></asp:Label></div>
        
</div></asp:Panel><br />
<asp:Panel ID="Panel30" runat="server">
<div>
      <div style="float:left; margin-right:30px;"><asp:Label ID="lbquantity2" runat="server" Text="">
      </asp:Label><asp:Label ID="lblx2" runat="server" Text="x"></asp:Label></div>
    <div style="float:left;  margin-right:60px;"><asp:Label ID="lbitem2" runat="server" Text=""></asp:Label></div>
    <div style="float:left;  margin-right:90px;"><asp:Label ID="lblat2" runat="server" Text="@"></asp:Label>
        <asp:Label ID="lbinr2" runat="server" Text="INR"></asp:Label><asp:Label ID="lbrate2" runat="server" Text=""></asp:Label>
    <asp:Label  ID="lbleach2" runat="server" Text="/each"></asp:Label></div>
    <div style="float:left;  margin-right:30px;"><asp:Label ID="lbinrr2" runat="server" 
            Text="INR"></asp:Label><asp:Label  ID="lbrateonly2" runat="server" Text=""></asp:Label></div>
</div></asp:Panel><br />
<asp:Panel ID="Panel31" runat="server"> 
<div>
      <div style="float:left; margin-right:30px;"><asp:Label ID="lbquantity3" runat="server" Text=""></asp:Label>
      <asp:Label ID="lblx3" runat="server" Text="x"></asp:Label></div>
    <div style="float:left;  margin-right:60px;"><asp:Label ID="lbitem3" runat="server" Text=""></asp:Label></div>
    <div style="float:left;  margin-right:90px;"><asp:Label ID="lblat3" runat="server" Text="@"></asp:Label>
        <asp:Label ID="lbinr3" runat="server" Text="INR"></asp:Label><asp:Label ID="lbrate3" runat="server" Text=""></asp:Label>
    <asp:Label  ID="lbleach3" runat="server" Text="/each"></asp:Label></div>
    <div style="float:left;  margin-right:30px;"><asp:Label ID="lbinrr3" runat="server" 
            Text="INR"></asp:Label><asp:Label  ID="lbrateonly3" runat="server" Text=""></asp:Label></div>
</div></asp:Panel><br />
<asp:Panel ID="Panel32" runat="server">
<div>
      <div style="float:left; margin-right:30px;"><asp:Label ID="lbquantity4" runat="server" Text=""></asp:Label>
      <asp:Label ID="lblx4" runat="server" Text="x"></asp:Label></div>
    <div style="float:left;  margin-right:60px;"><asp:Label ID="lbitem4" runat="server" Text=""></asp:Label></div>
    <div style="float:left;  margin-right:90px;"><asp:Label ID="lblat4" runat="server" Text="@"></asp:Label>
        <asp:Label ID="lbinr4" runat="server" Text="INR"></asp:Label><asp:Label ID="lbrate4" runat="server" Text=""></asp:Label>
    <asp:Label  ID="lbleach4" runat="server" Text="/each"></asp:Label></div>
    <div style="float:left;  margin-right:30px;"><asp:Label ID="lbinrr4" runat="server" 
            Text="INR"></asp:Label><asp:Label  ID="lbrateonly4" runat="server" Text=""></asp:Label></div>
</div></asp:Panel><br />
<asp:Panel ID="Panel33" runat="server">
<div>
      <div style="float:left; margin-right:30px;"><asp:Label ID="lbquantity5" runat="server" Text=""></asp:Label>
      <asp:Label ID="lblx5" runat="server" Text="x"></asp:Label></div>
    <div style="float:left;  margin-right:60px;"><asp:Label ID="lbitem5" runat="server" Text=""></asp:Label></div>
    <div style="float:left;  margin-right:90px;"><asp:Label ID="lblat5" runat="server" Text="@"></asp:Label>
        <asp:Label ID="lbinr5" runat="server" Text="INR"></asp:Label><asp:Label ID="lbrate5" runat="server" Text=""></asp:Label>
    <asp:Label  ID="lbleach5" runat="server" Text="/each"></asp:Label></div>
    <div style="float:left;  margin-right:30px;"><asp:Label ID="lbinrr5" runat="server" 
            Text="INR"></asp:Label><asp:Label  ID="lbrateonly5" runat="server" Text=""></asp:Label></div>
</div></asp:Panel><br />
<asp:Panel ID="Panel34" runat="server">
<div>
      <div style="float:left; margin-right:30px;"><asp:Label ID="lbquantity6" runat="server" Text=""></asp:Label>
      <asp:Label ID="lblx6" runat="server" Text="x"></asp:Label></div>
    <div style="float:left;  margin-right:60px;"><asp:Label ID="lbitem6" runat="server" Text=""></asp:Label></div>
    <div style="float:left;  margin-right:90px;"><asp:Label ID="lblat6" runat="server" Text="@"></asp:Label>
        <asp:Label ID="lbinr6" runat="server" Text="INR"></asp:Label><asp:Label ID="lbrate6" runat="server" Text=""></asp:Label>
    <asp:Label  ID="lbleach6" runat="server" Text="/each"></asp:Label></div>
    <div style="float:left;  margin-right:30px;"><asp:Label ID="lbinrr6" runat="server" 
            Text="INR"></asp:Label><asp:Label  ID="lbrateonly6" runat="server" Text=""></asp:Label></div>
</div></asp:Panel><br />
<asp:Panel ID="Panel35" runat="server">
<div>
      <div style="float:left; margin-right:30px;"><asp:Label ID="lbquantity7" runat="server" Text=""></asp:Label>
      <asp:Label ID="lblx7" runat="server" Text="x"></asp:Label></div>
    <div style="float:left;  margin-right:60px;"><asp:Label ID="lbitem7" runat="server" Text=""></asp:Label></div>
    <div style="float:left;  margin-right:90px;"><asp:Label ID="lblat7" runat="server" Text="@"></asp:Label>
        <asp:Label ID="lbinr7" runat="server" Text="INR"></asp:Label><asp:Label ID="lbrate7" runat="server" Text=""></asp:Label>
    <asp:Label  ID="lbleach7" runat="server" Text="/each"></asp:Label></div>
    <div style="float:left;  margin-right:30px;"><asp:Label ID="lbinrr7" runat="server" 
            Text="INR"></asp:Label><asp:Label  ID="lbrateonly7" runat="server" Text=""></asp:Label></div>
</div></asp:Panel><br />
<asp:Panel ID="Panel36" runat="server">
<div>
      <div style="float:left; margin-right:30px;"><asp:Label ID="lbquantity8" runat="server" Text=""></asp:Label>
      <asp:Label ID="lblx8" runat="server" Text="x"></asp:Label></div>
    <div style="float:left;  margin-right:60px;"><asp:Label ID="lbitem8" runat="server" Text=""></asp:Label></div>
    <div style="float:left;  margin-right:90px;"><asp:Label ID="lblat8" runat="server" Text="@"></asp:Label>
        <asp:Label ID="lbinr8" runat="server" Text="INR"></asp:Label><asp:Label ID="lbrate8" runat="server" Text=""></asp:Label>
    <asp:Label  ID="lbleach8" runat="server" Text="/each"></asp:Label></div>
    <div style="float:left;  margin-right:30px;"><asp:Label ID="lbinrr8" runat="server" 
            Text="INR"></asp:Label><asp:Label  ID="lbrateonly8" runat="server" Text=""></asp:Label></div>
</div></asp:Panel><br />
<asp:Panel ID="Panel37" runat="server">
<div>
      <div style="float:left; margin-right:30px;"><asp:Label ID="lbquantity9" runat="server" Text=""></asp:Label>
      <asp:Label ID="lblx9" runat="server" Text="x"></asp:Label></div>
    <div style="float:left;  margin-right:60px;"><asp:Label ID="lbitem9" runat="server" Text=""></asp:Label></div>
    <div style="float:left;  margin-right:90px;"><asp:Label ID="lblat9" runat="server" Text="@"></asp:Label>
        <asp:Label ID="lbinr9" runat="server" Text="INR"></asp:Label><asp:Label ID="lbrate9" runat="server" Text=""></asp:Label>
    <asp:Label  ID="lbleach9" runat="server" Text="/each"></asp:Label></div>
    <div style="float:left;  margin-right:30px;"><asp:Label ID="lbinrr9" runat="server" 
            Text="INR"></asp:Label><asp:Label  ID="lbrateonly9" runat="server" Text=""></asp:Label></div>
</div></asp:Panel><br />
<asp:Panel ID="Panel38" runat="server">
<div>
      <div style="float:left; margin-right:30px;"><asp:Label ID="lbquantity10" runat="server" Text=""></asp:Label>
      <asp:Label ID="lblx10" runat="server" Text="x"></asp:Label></div>
    <div style="float:left;  margin-right:60px;"><asp:Label ID="lbitem10" runat="server" Text=""></asp:Label></div>
    <div style="float:left;  margin-right:90px;"><asp:Label ID="lblat10" runat="server" Text="@"></asp:Label>
        <asp:Label ID="lbinr10" runat="server" Text="INR"></asp:Label><asp:Label ID="lbrate10" runat="server" Text=""></asp:Label>
    <asp:Label  ID="lbleach10" runat="server" Text="/each"></asp:Label></div>
    <div style="float:left;  margin-right:30px;"><asp:Label ID="lbinrr10" 
            runat="server" Text="INR"></asp:Label><asp:Label  ID="lbrateonly10" runat="server" Text=""></asp:Label></div>
</div></asp:Panel><br />
<asp:Panel ID="Panel39" runat="server">
<div>
      <div style="float:left; margin-right:30px;"><asp:Label ID="lbquantity11" runat="server" Text=""></asp:Label>
      <asp:Label ID="lblx11" runat="server" Text="x"></asp:Label></div>
    <div style="float:left;  margin-right:60px;"><asp:Label ID="lbitem11" runat="server" Text=""></asp:Label></div>
    <div style="float:left;  margin-right:90px;"><asp:Label ID="lblat11" runat="server" Text="@"></asp:Label>
        <asp:Label ID="lbinr11" runat="server" Text="INR"></asp:Label><asp:Label ID="lbrate11" runat="server" Text=""></asp:Label>
    <asp:Label  ID="lbleach11" runat="server" Text="/each"></asp:Label></div>
    <div style="float:left;  margin-right:30px;"><asp:Label ID="lbinrr11" 
            runat="server" Text="INR"></asp:Label><asp:Label  ID="lbrateonly11" runat="server" Text=""></asp:Label></div>
</div></asp:Panel><br />
<asp:Panel ID="Panel40" runat="server">
<div>
      <div style="float:left; margin-right:30px;"><asp:Label ID="lbquantity12" runat="server" Text=""></asp:Label>
      <asp:Label ID="lblx12" runat="server" Text="x"></asp:Label></div>
    <div style="float:left;  margin-right:60px;"><asp:Label ID="lbitem12" runat="server" Text=""></asp:Label></div>
    <div style="float:left;  margin-right:90px;"><asp:Label ID="lblat12" runat="server" Text="@"></asp:Label>
        <asp:Label ID="lbinr12" runat="server" Text="INR"></asp:Label><asp:Label ID="lbrate12" runat="server" Text=""></asp:Label>
    <asp:Label  ID="lbleach12" runat="server" Text="/each"></asp:Label></div>
    <div style="float:left;  margin-right:30px;"><asp:Label ID="lbinrr12" 
            runat="server" Text="INR"></asp:Label><asp:Label  ID="lbrateonly12" runat="server" Text=""></asp:Label></div>
</div></asp:Panel><br />
<asp:Panel ID="Panel41" runat="server">
<div>
      <div style="float:left; margin-right:30px;"><asp:Label ID="lbquantity13" runat="server" Text=""></asp:Label>
      <asp:Label ID="lblx13" runat="server" Text="x"></asp:Label></div>
    <div style="float:left;  margin-right:60px;"><asp:Label ID="lbitem13" runat="server" Text=""></asp:Label></div>
    <div style="float:left;  margin-right:90px;"><asp:Label ID="lblat13" runat="server" Text="@"></asp:Label>
        <asp:Label ID="lbinr13" runat="server" Text="INR"></asp:Label><asp:Label ID="lbrate13" runat="server" Text=""></asp:Label>
    <asp:Label  ID="lbleach13" runat="server" Text="/each"></asp:Label></div>
    <div style="float:left;  margin-right:30px;"><asp:Label ID="lbinrr13" 
            runat="server" Text="INR"></asp:Label><asp:Label  ID="lbrateonly13" runat="server" Text=""></asp:Label></div>
</div></asp:Panel><br />
<asp:Panel ID="Panel42" runat="server">
<div>
      <div style="float:left; margin-right:30px;"><asp:Label ID="lbquantity14" runat="server" Text=""></asp:Label>
      <asp:Label ID="lblx14" runat="server" Text="x"></asp:Label></div>
    <div style="float:left;  margin-right:60px;"><asp:Label ID="lbitem14" runat="server" Text=""></asp:Label></div>
    <div style="float:left;  margin-right:90px;"><asp:Label ID="lblat14" runat="server" Text="@"></asp:Label>
        <asp:Label ID="lbinr14" runat="server" Text="INR"></asp:Label><asp:Label ID="lbrate14" runat="server" Text=""></asp:Label>
    <asp:Label  ID="lbleach14" runat="server" Text="/each"></asp:Label></div>
    <div style="float:left;  margin-right:30px;"><asp:Label ID="lbinrr14" 
            runat="server" Text="INR"></asp:Label><asp:Label  ID="lbrateonly14" runat="server" Text=""></asp:Label></div>
</div></asp:Panel><br />
<asp:Panel ID="Panel43" runat="server">
<div>
      <div style="float:left; margin-right:30px;"><asp:Label ID="lbquantity15" runat="server" Text=""></asp:Label>
      <asp:Label ID="lblx15" runat="server" Text="x"></asp:Label></div>
    <div style="float:left;  margin-right:60px;"><asp:Label ID="lbitem15" runat="server" Text=""></asp:Label></div>
    <div style="float:left;  margin-right:90px;"><asp:Label ID="lblat15" runat="server" Text="@"></asp:Label>
        <asp:Label ID="lbinr15" runat="server" Text="INR"></asp:Label><asp:Label ID="lbrate15" runat="server" Text=""></asp:Label>
    <asp:Label  ID="lbleach15" runat="server" Text="/each"></asp:Label></div>
    <div style="float:left;  margin-right:30px;"><asp:Label ID="lbinrr15" 
            runat="server" Text="INR"></asp:Label><asp:Label  ID="lbrateonly15" runat="server" Text=""></asp:Label></div>
</div></asp:Panel><br />
<asp:Panel ID="Panel44" runat="server">
<div>
      <div style="float:left; margin-right:30px;"><asp:Label ID="lbquantity16" runat="server" Text=""></asp:Label>
      <asp:Label ID="lblx16" runat="server" Text="x"></asp:Label></div>
    <div style="float:left;  margin-right:60px;"><asp:Label ID="lbitem16" runat="server" Text=""></asp:Label></div>
    <div style="float:left;  margin-right:90px;"><asp:Label ID="lblat16" runat="server" Text="@"></asp:Label>
        <asp:Label ID="lbinr16" runat="server" Text="INR"></asp:Label><asp:Label ID="lbrate16" runat="server" Text=""></asp:Label>
    <asp:Label  ID="lbleach16" runat="server" Text="/each"></asp:Label></div>
    <div style="float:left;  margin-right:30px;"><asp:Label ID="lbinrr16" 
            runat="server" Text="INR"></asp:Label><asp:Label  ID="lbrateonly16" runat="server" Text=""></asp:Label></div>
</div></asp:Panel><br />
<asp:Panel ID="Panel45" runat="server">
<div>
      <div style="float:left; margin-right:30px;"><asp:Label ID="lbquantity17" runat="server" Text=""></asp:Label>
      <asp:Label ID="lblx17" runat="server" Text="x"></asp:Label></div>
    <div style="float:left;  margin-right:60px;"><asp:Label ID="lbitem17" runat="server" Text=""></asp:Label></div>
    <div style="float:left;  margin-right:90px;"><asp:Label ID="lblat17" runat="server" Text="@"></asp:Label>
        <asp:Label ID="lbinr17" runat="server" Text="INR"></asp:Label><asp:Label ID="lbrate17" runat="server" Text=""></asp:Label>
    <asp:Label  ID="lbleach17" runat="server" Text="/each"></asp:Label></div>
    <div style="float:left;  margin-right:30px;"><asp:Label ID="lbinrr17" 
            runat="server" Text="INR"></asp:Label><asp:Label  ID="lbrateonly17" runat="server" Text=""></asp:Label></div>
</div></asp:Panel><br />
<asp:Panel ID="Panel46" runat="server">
<div>
      <div style="float:left; margin-right:30px;"><asp:Label ID="lbquantity18" runat="server" Text=""></asp:Label>
      <asp:Label ID="lblx18" runat="server" Text="x"></asp:Label></div>
    <div style="float:left;  margin-right:60px;"><asp:Label ID="lbitem18" runat="server" Text=""></asp:Label></div>
    <div style="float:left;  margin-right:90px;"><asp:Label ID="lblat18" runat="server" Text="@"></asp:Label>
        <asp:Label ID="lbinr18" runat="server" Text="INR"></asp:Label><asp:Label ID="lbrate18" runat="server" Text=""></asp:Label>
    <asp:Label  ID="lbleach18" runat="server" Text="/each"></asp:Label></div>
    <div style="float:left;  margin-right:30px;"><asp:Label ID="lbinrr18" 
            runat="server" Text="INR"></asp:Label><asp:Label  ID="lbrateonly18" runat="server" Text=""></asp:Label></div>
</div></asp:Panel><br />
<asp:Panel ID="Panel47" runat="server">
<div>
      <div style="float:left; margin-right:30px;"><asp:Label ID="lbquantity19" runat="server" Text=""></asp:Label>
      <asp:Label ID="lblx19" runat="server" Text="x"></asp:Label></div>
    <div style="float:left;  margin-right:60px;"><asp:Label ID="lbitem19" runat="server" Text=""></asp:Label></div>
    <div style="float:left;  margin-right:90px;"><asp:Label ID="lblat19" runat="server" Text="@"></asp:Label>
        <asp:Label ID="lbinr19" runat="server" Text="INR"></asp:Label><asp:Label ID="lbrate19" runat="server" Text=""></asp:Label>
    <asp:Label  ID="lbleach19" runat="server" Text="/each"></asp:Label></div>
    <div style="float:left;  margin-right:30px;"><asp:Label ID="lbinrr19" 
            runat="server" Text="INR"></asp:Label><asp:Label  ID="lbrateonly19" runat="server" Text=""></asp:Label></div>
</div></asp:Panel><br />
<asp:Panel ID="Panel48" runat="server">
<div>
      <div style="float:left; margin-right:30px;"><asp:Label ID="lbquantity20" runat="server" Text=""></asp:Label>
      <asp:Label ID="lblx20" runat="server" Text="x"></asp:Label></div>
    <div style="float:left;  margin-right:60px;"><asp:Label ID="lbitem20" runat="server" Text=""></asp:Label></div>
    <div style="float:left;  margin-right:90px;"><asp:Label ID="lblat20" runat="server" Text="@"></asp:Label>
        <asp:Label ID="lbinr20" runat="server" Text="INR"></asp:Label><asp:Label ID="lbrate20" runat="server" Text=""></asp:Label>
    <asp:Label  ID="lbleach20" runat="server" Text="/each"></asp:Label></div>
    <div style="float:left;  margin-right:30px;"><asp:Label ID="lbinrr20" 
            runat="server" Text="INR"></asp:Label><asp:Label  ID="lbrateonly20" runat="server" Text=""></asp:Label></div>
</div></asp:Panel><br />
<asp:Panel ID="Panel49" runat="server">
<div>
      <div style="float:left; margin-right:30px;"><asp:Label ID="lbquantity21" runat="server" Text=""></asp:Label>
      <asp:Label ID="lblx21" runat="server" Text="x"></asp:Label></div>
    <div style="float:left;  margin-right:60px;"><asp:Label ID="lbitem21" runat="server" Text=""></asp:Label></div>
    <div style="float:left;  margin-right:90px;"><asp:Label ID="lblat21" runat="server" Text="@"></asp:Label>
        <asp:Label ID="lbinr21" runat="server" Text="INR"></asp:Label><asp:Label ID="lbrate21" runat="server" Text=""></asp:Label>
    <asp:Label  ID="lbleach21" runat="server" Text="/each"></asp:Label></div>
    <div style="float:left;  margin-right:30px;"><asp:Label ID="lbinrr21" 
            runat="server" Text="INR"></asp:Label><asp:Label  ID="lbrateonly21" runat="server" Text=""></asp:Label></div>
</div></asp:Panel><br />
<asp:Panel ID="Panel50" runat="server">
<div>
      <div style="float:left; margin-right:30px;"><asp:Label ID="lbquantity22" runat="server" Text=""></asp:Label>
      <asp:Label ID="lblx22" runat="server" Text="x"></asp:Label></div>
    <div style="float:left;  margin-right:60px;"><asp:Label ID="lbitem22" runat="server" Text=""></asp:Label></div>
    <div style="float:left;  margin-right:90px;"><asp:Label ID="lblat22" runat="server" Text="@"></asp:Label>
        <asp:Label ID="lbinr22" runat="server" Text="INR"></asp:Label><asp:Label ID="lbrate22" runat="server" Text=""></asp:Label>
    <asp:Label  ID="lbleach22" runat="server" Text="/each"></asp:Label></div>
    <div style="float:left;  margin-right:30px;"><asp:Label ID="lbinrr22" 
            runat="server" Text="INR"></asp:Label><asp:Label  ID="lbrateonly22" runat="server" Text=""></asp:Label></div>
</div></asp:Panel><br />
       
</div>
<%--<div style="width:500px; height:auto;" ></div>--%>
<div id="subfottoriv">
<p><b>Subtotal : </b><span ><img src="img/rs.png" /><asp:Label ID="lbsubtotal" runat="server" Text="0.00"></asp:Label></span></p>
<div id="fotter_butn">
    <asp:Button ID="Button1" runat="server" Text="Continue" 
        onclick="Button1_Click" /></div>
    <div style="color:Black;">
        <asp:Label ID="lberror" runat="server" Text=""></asp:Label></div>
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
