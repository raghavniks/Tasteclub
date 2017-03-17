<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage3.master" AutoEventWireup="true" CodeFile="invite.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <div style="background-color:#f0f0f0; float: left; width: 100%; margin-top: 130px; height:auto; overflow:hidden;">
    <div style="text-align:center; font-size:50px; padding:20px 0px 10px 0px; height:50px; float:left; width: 100%; font-weight:100">Invite Others to Taste Club!</div>
    <%--<div style="margin-top:10px; font-size:20px; text-align:center; width: 100%; float:left;">You'll both get 50 Rs. when they make their first purchase</div>--%>
    <div style="float:left; width:100%; text-align:center; margin:40px 0px 50px 0px;">
        <asp:TextBox ID="TextBox1" runat="server" Enabled="False" Height="25px" style="border: 1px solid #ccc; -webkit-border-radius: 3px; -moz-border-radius: 3px; border-radius: 3px;"
            Width="356px" BackColor="White">http://www.tasteclub.in</asp:TextBox></div>
           <hr style="margin:0px 130px;"/>
    <div style="height:500px; width:45%; float:left;">
            <div style="float:left; height:20px; width:490px; margin:20px 0px 0px 130px; font-size:17px;">Type email addresses below </div>
             <div style="float:left; margin-left:130px; width:625px; font-size:17px;">
                (separate with commas):
            </div>
               <div style="float:left; width:100%; margin:5px 0px 20px 130px;">
        <asp:TextBox ID="txttomail" runat="server" Enabled="true" Height="88px" 
                       placeholder="Enter Email Address" style="border: 1px solid #ccc; -webkit-border-radius: 3px; -moz-border-radius: 3px; border-radius: 3px;"
            Width="356px" BackColor="White" TextMode="MultiLine"></asp:TextBox></div>
              <div style="float:left; margin-left:130px; width:625px; font-size:17px;">


                  <asp:TextBox ID="txtsub" TextMode="MultiLine" runat="server" Height="25px" placeholder="Enter Subject" Width="356px"></asp:TextBox>






                
            </div>
             <div style="float:left; width:100%; margin:5px 0px 20px 130px;">
        <asp:TextBox ID="txtmsg" runat="server" Enabled="true" Height="170px" placeholder="Enter Email Address" style="border: 1px solid #ccc; -webkit-border-radius: 3px; -moz-border-radius: 3px; border-radius: 3px;"
            Width="356px" BackColor="White" TextMode="MultiLine">Please accept this invitation to become a member of TASTE Club.

At TASTE Club, lunch is just a click away. As a member, you have access to a rotating menu of delicious food delivered to your office.  Membership is free!http://tasteclub.in/signup.aspx</asp:TextBox>
</div>
        <div style="float:left; width:100%; margin:5px 0px 20px 130px;">
            <asp:Button ID="Button1" runat="server" Text="Send" BorderStyle="None" 
                Height="30px" style="color: #FFFFFF; background-color: #CC3300" 
                Width="74px" onclick="Button1_Click" />
                 &nbsp;
            <asp:Button ID="Button2" runat="server" BorderStyle="None"  height="30px" Width="74px"   style="color: #FFFFFF; background-color: #CC3300" onclick="Button2_Click" Text="Reset" />
                 <asp:Label ID="Label3" runat="server" Visible="False"></asp:Label>
                  <asp:Label ID="lbname" runat="server" Visible="False"></asp:Label>
        </div>     
    </div>
        
        
      <%--<div style="width:55%; height:auto; float:left;"> 
           <div style="float:left; width:500px;  margin:20px 0px 0px 130px; font-size:30px;">Your Referral Activity</div>
            <div style="float:left; margin-top:13px; margin-bottom:15px; font-size:20px; width:249px;">
                Email address
            </div>

            <div style="float:left; margin-top:13px; margin-bottom:15px; font-size:20px; width:200px;">
                Last Invited
            </div>
            <div style="float:left; margin-top:13px; margin-bottom:15px; font-size:20px; width:226px;">
                Status
            </div>
            <div style="float:left; margin-top:13px; margin-bottom:15px; font-size:20px; width:249px;">
          <asp:Panel ID="Panel1" runat="server">
          </asp:Panel>
      </div>
         <div style="float:left; margin-top:13px; margin-bottom:15px; font-size:20px; width:200px;">
          <asp:Panel ID="Panel2" runat="server">
          </asp:Panel>
      </div>
      <div style="float:left; margin-top:13px; margin-bottom:15px; font-size:20px; width:226px;">
          <asp:Panel ID="Panel3" runat="server">
          </asp:Panel><asp:Panel ID="Panel4" runat="server">
          </asp:Panel> 
          
      </div>
      </div>--%>
      
        
           
            </div>

</asp:Content>

