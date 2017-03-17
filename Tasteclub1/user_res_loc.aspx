<%@ Page Language="C#" AutoEventWireup="true" CodeFile="user_res_loc.aspx.cs" Inherits="user_res_loc" %>



<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="css_extender/jquery.autocomplete.css" rel="stylesheet" type="text/css" />
<script src="scripts_extender/jquery-1.4.1.min.js" type="text/javascript"></script>
<script src="scripts_extender/jquery.autocomplete.js" type="text/javascript"></script>
    <style type="text/css">
        .login{ width:225px; height:25px; float:right; margin-top:15px;}
        .login a{color:Black; text-decoration:none; margin-right:10px; margin-left:5px; font-weight:bold; font-size:17px;}
        .login a:hover{color:Red;}
        .style1 a{color:Maroon; text-decoration:none;}
        
        .style2
        {
            font-family: "Times New Roman", Times, serif;
            font-size: large;
        }
        .style3
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: 45px;
        }
        </style>
    <link href="css/stylesheet.css" rel="stylesheet" type="text/css" />

  <%-- <script type="text/javascript">
       $(document).ready(function () {
           $("#<%=txtSearch.ClientID%>").autocomplete('Search_CS.ashx');
       });       
</script> --%>

</head>
<body>
    <form id="form1" runat="server">
    <asp:Label ID="Labelname" runat="server" Text="" Visible="false"></asp:Label>
    <asp:Label ID="Labelemail" runat="server" Text="" Visible="false"></asp:Label>
    <asp:Label ID="Labelphone" runat="server" Text="" Visible="false"></asp:Label>
    <div style="width:1351px; height:900px;">
    <div style="height:70px;">
    <div style="float:left; width:351px; height:70px;">
    <a href="index.aspx">
        <img src="img/logo.png"  height="200px" width="150px" style="margin-left:5px;" />
        </a>
    </div>
    <div class="login">
        <a href="login.aspx">Login</a>|
         <a href="signup.aspx">Register</a>
    </div>
    </div>
    <div style="height:900px; background-color:#f0f0f0;">
        <div style="height:830px; width:450px; padding-top:50px; padding-left:150px;float:left;">
        <div class="style3">
            <asp:Label ID="lbnam" runat="server" Text=""></asp:Label>,
            tell us where you work</div>
            <br />
        <div>
            <span class="style2" style="color:Red;">TASTE CLUB delivers to offices in Gurgaon Only. </span>           
        </div>
        <br />
           <div>
           <table>
           <tr>
           <td>Select Region
               </td>
           <td>
               <asp:DropDownList ID="DropDownList1" runat="server" Height="31px" Width="150px" 
                   AutoPostBack="True" onselectedindexchanged="DropDownList1_SelectedIndexChanged"
         
                   >
                   <asp:ListItem>-----Choose a Region-----</asp:ListItem>
                   <asp:ListItem>Gurgaon</asp:ListItem>
                   
               </asp:DropDownList>

               </td>
           <td></td>
           <td></td>
           </tr>


           <tr>
           <td></td>
           <td>
               <asp:Label ID="Label1" runat="server" Text="Not In List ?"></asp:Label>
&nbsp;<asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click" 
                   ForeColor="Red">Click Here</asp:LinkButton>
          
                  
               </td>
           <td></td>
           <td></td>
           </tr>

             <tr>
           <td>
               <asp:Label ID="lblcity" runat="server" Text="City"></asp:Label>
                 </td>
           <td>
               <asp:TextBox ID="txtcity" Height="26px" runat="server" Width="230px" 
                   placeholder="Enter City"></asp:TextBox>
                 </td>
           <td></td>
           <td></td>
           </tr>

             <tr>
           <td>
               <asp:Label ID="lbladdress" runat="server" Text="Address"></asp:Label>
                 </td>
           <td>
<asp:TextBox ID="txtaddress" runat="server" Height="100px" Width="226px" placeholder="Enter Address" TextMode="MultiLine"></asp:TextBox>
                             </td>
           <td></td>
           <td></td>
           </tr>


             <tr>
           <td>
               <asp:Label ID="lblcompany" runat="server" Text="Company"></asp:Label>
                 </td>
           <td>

                             <asp:DropDownList ID="ddcompany" runat="server" Height="31px" 
                   Width="150px" onselectedindexchanged="ddloption_SelectedIndexChanged" AutoPostBack="True">
              </asp:DropDownList>
          
                  
                 </td>
           <td></td>
           <td></td>
           </tr>


           <tr>
           <td>
               <asp:Label ID="lblcompanyaddress" runat="server" Text="Address"></asp:Label>
               </td>
           <td>
               <asp:DropDownList ID="ddaddress"  Height="31px" 
                   Width="150px" runat="server"
                   onselectedindexchanged="ddaddress_SelectedIndexChanged"  >
               </asp:DropDownList>
          
                  
               </td>
           <td></td>
           <td></td> 
           </tr>


           <tr>
           <td colspan="4" align="center"><asp:Label ID="lblmsg" runat="server" ForeColor="Red"></asp:Label></td>
           </tr>



           <tr>
           <td></td>
           <td>
              
             
                       <asp:Button ID="Button1" runat="server" Height="33px" 
                           
                           style="color: #FFFFFF; background-color: Red; border:none; border-radius:6px;" 
                           Text="Continue" Width="120px" onclick="Button1_Click" />
              
             
                       </td>
           <td></td>
           <td></td>
           </tr>
           </table>

           </div>
           <div>

               <br />
               <br />
               <br />
                             <br />
               <br />
               <br />

                  
               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               
          
                  
               <br />
               <br />
          
                  
           </div>
            
      <%--     <div>
          

             <asp:TextBox ID="txtSearch" runat="server" Height="26px" Width="325px" 
                   BorderColor="gray" BorderStyle="Solid" BorderWidth="1px" 
                   ontextchanged="txtSearch_TextChanged" 
                   AutoPostBack="True" Visible="False"></asp:TextBox>
            <asp:RequiredFieldValidator ControlToValidate="txtSearch" ForeColor="Red" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Mandatory Field" ></asp:RequiredFieldValidator>
                <asp:Label ID="Label2" runat="server" Style="left: 208px; position: relative; top: 32px"

            Text="Label"></asp:Label>

              
                   
           </div>--%>           
         <%--  <div>
               <asp:TextBox ID="TextBox1" runat="server" Height="26px" Width="325px" 
                   BorderColor="gray" BorderStyle="Solid" BorderWidth="1px" Enabled="false"></asp:TextBox>
                 
             </div>--%>
          <div class="rep">
              
             
                       </div>
          
          <div>
              
          </div>
           
        </div>
        
        <div style="float:left; margin-top:50px; width:600px;"><iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d224564.16410469668!2d76.98978175!3d28.42483664999996!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x390d19d582e38859%3A0x2cf5fe8e5c64b1e!2sGurgaon%2C+Haryana!5e0!3m2!1sen!2sin!4v1410422812600" width="600" height="800" frameborder="0" style="border:0"></iframe></div>
        <div>
        
        </div>
    </div>
    </div>
    </form>
</body>
</html>
