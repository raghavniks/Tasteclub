<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage5.master" AutoEventWireup="true" CodeFile="foodpage.aspx.cs" Inherits="foodpage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">











<div id="slider_main" style=" margin-top:-125px;">

<div id="header_left3">
<p>START HERE</p>
    <%--<img src="img/subbot.png" style="height:30px;" />--%>
</div>

<div id="lunch_pro">

<ul>

<li><asp:LinkButton runat="server" ID="lk"> 
<asp:Panel ID="Panel1" runat="server" style="height:40px; padding:10px 0px;">
                <asp:Label ID="lbmndy" runat="server" Text=""></asp:Label><br />
                <asp:Label ID="lbmndydate" runat="server" Text=""></asp:Label>
                </asp:Panel>
               
   </asp:LinkButton>
</li>
<li>
<asp:LinkButton runat="server" ID="lk1">
<asp:Panel ID="Panel2" runat="server" style="height:40px; padding:10px 0px;">
                <asp:Label ID="lbtsdy" runat="server" Text=""></asp:Label><br />
                <asp:Label ID="lbtsdydate" runat="server" Text=""></asp:Label>
                </asp:Panel>
   </asp:LinkButton>
</li>
<li>
<asp:LinkButton runat="server" ID="lk2"><asp:Panel ID="Panel3" runat="server" style="height:40px; padding:10px 0px;">
                <asp:Label ID="lbwndy" runat="server" Text=""></asp:Label><br />
                <asp:Label ID="lbwndydate" runat="server" Text=""></asp:Label>
                </asp:Panel>
     </asp:LinkButton>
</li>
<li>
<asp:LinkButton runat="server" ID="lk3">
<asp:Panel ID="Panel4" runat="server" style="height:40px; padding:10px 0px;">
                <asp:Label ID="lbthdy" runat="server" Text=""></asp:Label><br />
                <asp:Label ID="lbthdydate" runat="server" Text=""></asp:Label>
                </asp:Panel>
    </asp:LinkButton>
</li>
<li>
<asp:LinkButton runat="server" ID="lk4">
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


    
</div>
</div>



<div id="header_bot">
<div id="header_bot_main">
<div id="header_bot_main_left">
<h1 id="black_color"></h1>

<div id="subfottoriv">

<p><b>Subtotal</b> <span><img src="img/rs.png" /><asp:Label ID="lbsubtotal" runat="server" Text="0.00"></asp:Label></span></p>
<div id="fotter_butn">
    <asp:Button ID="Button1" runat="server" Text="Continue"
         /></div>
    <div style="color:Black;">
        <asp:Label ID="lberror" runat="server" Text=""></asp:Label>
        
    </div>
</div>


    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>


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











</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

    <div id="your_order_list">
<h1>Your Order List</h1>


<table>
<tr style="width:266px; float:left;">
<td style="width:266px; float:left;">

<asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder>
</td>
<td></td>
</tr >

<tr style="width:266px; float:left;">
<td style="width:200px; float:left;">Food Total</td><td style="float:right;"><asp:Label ID="Label4" runat="server"></asp:Label></td>
<td>
   
    </td>
</tr>

 
</table>


</div>
</asp:Content>
