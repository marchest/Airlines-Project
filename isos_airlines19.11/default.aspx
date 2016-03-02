<%@ Page Title="" Language="C#" MaintainScrollPositionOnPostback="true" MasterPageFile="~/master_page.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="isos_airlines19._11._default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/css2.css" rel="stylesheet" />

    
    <style type="text/css">
        .auto-style3 {
            margin-left: 0;
        }
        .auto-style4 {
            text-align: center;
        }
    </style>

    
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="wrapper">
           <div class="Bilet_Al">
                <div class="ust">
                    Bilet Al
                </div>

                <div class="alt" style="height: 600px">
                    <br>
                    <br>
                    &nbsp&nbsp Nereden?
                <div class="From">
                    &nbsp&nbsp<asp:DropDownList ID="DropDownList1" runat="server" Width="300px" Height="40px" DataSourceID="SqlDataSource1" DataTextField="AirportName" DataValueField="AirportName"></asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:IsosAirlinesConnectionString %>" SelectCommand="GetAirports" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
                </div>
                    <br>
                    <br>
                    &nbsp&nbsp Nereye?
                  <div class="To">
                      &nbsp&nbsp
                      <asp:DropDownList ID="DropDownList2" runat="server" Width="300px" Height="40px" DataSourceID="SqlDataSource2" DataTextField="AirportName" DataValueField="AirportName"></asp:DropDownList>
                      <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:IsosAirlinesConnectionString %>" SelectCommand="GetAirports" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
                  </div>
                    <br>
                    <div class="rota">
                        &nbsp&nbsp    
                        <asp:RadioButton ID="Gidiş_Dönüş_RadioBtn" runat="server" OnCheckedChanged="Gidiş_Dönüş_RadioBtn_CheckedChanged" />
                        &nbsp 
                        <asp:Label ID="Label3" runat="server" Text="Gidiş-Dönüş"></asp:Label>
                        &nbsp&nbsp    
                        <asp:RadioButton ID="TekYon_RadioBtn" runat="server" OnCheckedChanged="TekYon_RadioBtn_CheckedChanged" />
                        &nbsp 
                        <asp:Label ID="Label2" runat="server" Text="Tek Yön"></asp:Label>
                        <br>
                        <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Uçuş Ara</asp:LinkButton>
                        <br>
                    </div>

                    <div class="tarih">
                      <div class="sol">
      <asp:TextBox ID="TextBox1" BackColor="Silver" ForeColor="Black" Width="150px" Height="25px" runat="server"></asp:TextBox>
                         <asp:ImageButton ID="ImageButton1" runat="server" Height="28px" ImageUrl="~/images/calendar.png" Width="33px" OnClick="ImageButton1_Click" />
                        
                        <asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" Width="175px" OnSelectionChanged="Calendar1_SelectionChanged">
                            <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                            <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                            <OtherMonthDayStyle ForeColor="#CC9966" />
                            <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                            <SelectorStyle BackColor="#FFCC66" />
                            <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                            <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                        </asp:Calendar>
                     

  </div>
                        <div class="sag">

                            <asp:TextBox ID="TextBox2" BackColor="Silver" Width="150px" Height="25px" runat="server"></asp:TextBox>
                        <asp:ImageButton ID="ImageButton2" runat="server" Height="28px" ImageUrl="~/images/calendar.png" Width="33px" OnClick="ImageButton2_Click" />
                        <asp:Calendar ID="Calendar2" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" Width="175px" OnSelectionChanged="Calendar2_SelectionChanged">
                            <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                            <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                            <OtherMonthDayStyle ForeColor="#CC9966" />
                            <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                            <SelectorStyle BackColor="#FFCC66" />
                            <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                            <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                        </asp:Calendar>
                     
                        </div>
 
                    </div>
                
                </div>
            </div>


           <div class="Reklam">
               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
       
              
            
         
               <br />
&nbsp; Avantajlı fiyatlar :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               <asp:TextBox ID="TextBox3" runat="server" BackColor="Silver" CssClass="auto-style3" Height="21px"></asp:TextBox>
               <br />
               <br />
&nbsp;&nbsp;&nbsp;&nbsp;
               <div class="auto-style4">
               <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource4" Width="499px" AllowSorting="True">
                   <Columns>
                       <asp:BoundField DataField="Fare" HeaderText="Fare" SortExpression="Fare" />
                       <asp:BoundField DataField="FlightDate" HeaderText="FlightDate" SortExpression="FlightDate" />
                       <asp:BoundField DataField="Departure" HeaderText="Departure" SortExpression="Departure" />
                       <asp:BoundField DataField="Arrival" HeaderText="Arrival" SortExpression="Arrival" />
                       <asp:BoundField DataField="Airport" HeaderText="Airport" SortExpression="Airport" />
                       <asp:BoundField DataField="Destination" HeaderText="Destination" SortExpression="Destination" />
                   </Columns>
               </asp:GridView>
               </div>
               <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:IsosAirlinesConnectionString %>" SelectCommand="ParayaGöreSırala" SelectCommandType="StoredProcedure">
                   <SelectParameters>
                       <asp:ControlParameter ControlID="TextBox3" Name="money" PropertyName="Text" Type="Int32" />
                   </SelectParameters>
               </asp:SqlDataSource>
               <asp:SqlDataSource ID="SqlDataSource3" runat="server"></asp:SqlDataSource>
       
              
            
         
        </div>
          
        
    </div>


        
        
</asp:Content>

