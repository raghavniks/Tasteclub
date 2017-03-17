<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage5.master" AutoEventWireup="true" CodeFile="dessert.aspx.cs" Inherits="dessert" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


<div id="slider_main" style="margin-top:-88px;">


</div>

<div id="lunch_pro">








</div>

</div>

</header>


<div id="container">

<nav>
 
 <div id="nav_warp">
     <%--<div id="nav_warp_cart">
 <h1 style="margin-left:43px;"><span style="color:Red;">

 <asp:Label ID="lblcount" runat="server" Text="0"></asp:Label></span></h1>
 </div>--%>
 
 <div id="nav_warp_span">
 <img src="img/cart.png" />
 </div>
 <div id="nav_warp_h2">

 <h2 style="width: 560px;
font-size: 18px;">Would You Like Some Beverages Or Dessert (Click For Continue)</h2>
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
  
  
    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
  
  
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

<tr style="width:266px; float:left;">
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

<p><b>Subtotal</b> <span><img src="img/rs.png" /><asp:Label ID="lbsubtotal1" 
        runat="server" Text="00"></asp:Label>
       
     
       
      
    </span></p>  
<div id="fotter_butn">
    <asp:Button ID="Button1" runat="server" Text="Continue" 
         /></div>
    <div style="color:Black;">
        <asp:Label ID="lberror" runat="server" Text=""></asp:Label></div>
</div>

  <div id="backtomenu" >
    <asp:Button ID="Button2" runat="server" BorderStyle="None" Font-Size="20px" Text="Back To Menu" height="50px" width="230px" ForeColor="White" BackColor="Red"/>
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






</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>