<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="signup.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <div style="height:830px; width:450px; padding-top:50px; padding-left:150px;float:left;">
        <div class="register">Register to order today</div>
        <div style="height: 24px"></div>
        <div>
            <span class="register_in">Already a member? </span>
            <asp:Button ID="Button2" runat="server" Text="Login"  
                style="color: #FFFFFF; background-color: #f05033; height:35px; width:75px; border-color: #f05033; border-radius: 7px; font-size: 16px; cursor:pointer;" 
                CausesValidation="False" PostBackUrl="~/login.aspx"/>
           
        </div>
        <div style="height: 24px">
            <asp:ValidationSummary ID="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" HeaderText="You must enter a value in the following fields:" EnableClientScript="true" runat="server"/>
        </div>
           <div>
               <asp:Label ID="lbfstname" runat="server" Text="First Name"></asp:Label>
           </div>
           <div>
               <asp:TextBox ID="txtfstname" runat="server" Height="24px" Width="325px" 
                   BorderColor="gray" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
               &nbsp;<asp:RequiredFieldValidator ControlToValidate="txtfstname" ForeColor="Red" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter Your First Name" Text="*"></asp:RequiredFieldValidator>
           </div>

           <div style="height: 24px"></div>
             <div>
               <asp:Label ID="lblastname" runat="server" Text="Last Name" ></asp:Label>
           </div>
           <div>
               <asp:TextBox ID="txtlastname" runat="server" Height="24px" Width="325px" 
                   BorderColor="gray" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
                   &nbsp;<asp:RequiredFieldValidator ControlToValidate="txtlastname" ForeColor="Red" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter Your Last Name" Text="*"></asp:RequiredFieldValidator>
           </div>
           <div style="height: 24px"></div>
           <div>
               <asp:Label ID="lbemail" runat="server" Text="E-Mail"></asp:Label>
           </div>
           <div>
               <asp:TextBox ID="txtemail" runat="server" Height="24px" Width="325px" 
                   BorderColor="gray" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
                   &nbsp;<asp:RequiredFieldValidator ControlToValidate="txtemail" ForeColor="Red" ID="RequiredFieldValidator3" runat="server" ErrorMessage="Enter Your Email" Text="*"></asp:RequiredFieldValidator>
               &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Email is not valid" Text="**" ControlToValidate="txtemail" ForeColor="Red" ValidationExpression="^[\w-\.]{1,}\@([\da-zA-Z-]{1,}\.){1,}[\da-zA-Z-]{2,6}$"></asp:RegularExpressionValidator>
           </div>
           <div style="height: 24px"></div>
             <div>
               <asp:Label ID="Password" runat="server" Text="Password" ></asp:Label>
           </div>
           <div>
               <asp:TextBox ID="txtpass" runat="server" Height="24px" Width="325px" 
                   BorderColor="gray" BorderStyle="Solid" BorderWidth="1px" 
                   TextMode="Password"></asp:TextBox>
                   &nbsp;<asp:RequiredFieldValidator ControlToValidate="txtpass" ForeColor="Red" ID="RequiredFieldValidator4" runat="server" ErrorMessage="Enter Your Password" Text="*"></asp:RequiredFieldValidator>
           </div>
           <div style="height: 24px"></div>
           <div>
               <asp:Label ID="lbph" runat="server" Text="Phone Number"></asp:Label>
           </div>
          
           <div>
               <asp:TextBox ID="txtph" runat="server" Height="24px" Width="325px" 
                   BorderColor="gray" BorderStyle="Solid" BorderWidth="1px" MaxLength="10"></asp:TextBox>
                   &nbsp;<asp:RequiredFieldValidator ControlToValidate="txtph" ForeColor="Red" ID="RequiredFieldValidator5" runat="server" ErrorMessage="Enter Your Phone No." Text="*"></asp:RequiredFieldValidator>
           &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Phone No. Is not valid" Text="**" ControlToValidate="txtph" ForeColor="Red" ValidationExpression="^[7-9][0-9]{9}$"></asp:RegularExpressionValidator></div>
           <div style="height: 35px"></div>
          
           
           <div>
               <asp:Button ID="Button1" runat="server" Text="Continue" Height="40px" Font-Size="20px"
                   Width="328px" style="color: #FFFFFF; background-color: #CC3300" 
                   onclick="Button1_Click" />
            </div>
        
        </div>

</asp:Content>

