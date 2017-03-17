<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <div style="height:830px; width:450px; padding-top:50px; padding-left:150px;float:left;">
        <div style="font-size:50px;">
            <p style="margin-left: 40px">
                Welcome Back</p>
        </div>  
        <div style="height: 20px"></div> 
        <div>
            <span style="font-size:20px;">Don't have an account?</span><span class="style1">
                <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" 
                PostBackUrl="~/signup.aspx" >Sign Up Now</asp:LinkButton>
            </span>
        </div>
        <div style="height: 24px"><asp:Label ID="Label3" runat="server" Text=""></asp:Label></div>
           <div>
               <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
           </div>   
           <div>
               <asp:TextBox ID="TextBox1" runat="server" Height="24px" Width="325px" 
                   BorderColor="gray" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
                   &nbsp;
           </div>
           <div style="height: 24px">
        </div>
             <div>
               <asp:Label ID="Label2" runat="server" Text="Password" ></asp:Label>
           </div>
           <div>
               <asp:TextBox ID="TextBox2" runat="server" Height="24px" Width="325px" 
                   BorderColor="gray" BorderStyle="Solid" BorderWidth="1px" 
                       TextMode="Password"></asp:TextBox>
                    &nbsp;
           </div>
           <div style="height: 10px"></div>
           <div class="style1" >
            <a href="forgot.aspx" style="color:Black;">Forgot Password?</a>
           </div>
           <div style="height: 22px"></div>
           <div>
               <asp:Button ID="Button1" runat="server" Text="Login" Height="40px" Font-Size="20px"
                   Width="328px" style="color: #FFFFFF; background-color: #f00; border-radius:5px;" 
                   onclick="Button1_Click" />
            </div>
            <%--<div style="margin-top:25px;"><a href="" style="text-decoration:none; color:Black;">or login with facebook</a></div>--%>
        </div>
      
</asp:Content>

