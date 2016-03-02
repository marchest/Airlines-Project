<%@ Page Title="" Language="C#" MasterPageFile="~/master_page.Master" AutoEventWireup="true" CodeBehind="MemberSign.aspx.cs" Inherits="isos_airlines19._11.MemberSign" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/Membersign_css.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="wrapper">
  
        
          <div class="left">
            <br>
             <div class="ust1">
             <asp:TextBox ID="TextBox1" runat="server" BorderColor="Black" BackColor="#d5d5d5" Width="200px" Height="35px" Text="    Ad Soyad"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please Enter UserName" ControlToValidate="TextBox1" ForeColor="Red"></asp:RequiredFieldValidator>
                 
             </div>
             

              <div class="ust2">
             <asp:TextBox ID="TextBox2" runat="server" BorderColor="Black" BackColor="#d5d5d5" Width="200px" Height="35px"  Text="    EMail"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Please Enter Email" ForeColor="Red"></asp:RequiredFieldValidator>
           </div>
                 <div class="ust3">
             <asp:TextBox ID="TextBox3" runat="server"  BorderColor="Black" TextMode="Password" BackColor ="#d5d5d5" Width="200px" Height="35px"  Text="    Password" MaxLength="8" Columns="0" ValidateRequestMode="Inherit" CausesValidation="False"></asp:TextBox>
           </div>
             <div class="ust4">
             <asp:Button ID="Button1" runat="server" Text="KAYDOL" ForeColor="DarkBlue" Font-Italic="False" OnClick="Button1_Click" Width="60px" Height="30px"/>
                 </div>
</div>
        
    <div class="right">

          <div class="ust1">
               <asp:TextBox ID="TextBox4" runat="server"   BorderColor="Black" BackColor="#d5d5d5" Width="200px" Height="35px" Text="    Mail"></asp:TextBox>
               <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="Please Enter Mail" ForeColor="Red"></asp:RequiredFieldValidator>
             </div>

        <div class="ust2">
             <asp:TextBox ID="TextBox5" runat="server"  BackColor="#d5d5d5" TextMode="Password" Width="200px" Height="35px" Text="  Password"></asp:TextBox>
           </div>
          <div class="ust4">
              <asp:Button ID="Button2" runat="server"  Text="GİRİŞ YAP" ForeColor="DarkBlue" Width="70px" Height="30px" OnClick="button2_Click"/>
                 </div>
      


        </div>
      
          </div>

</asp:Content>
