<%@ Page Language="vb" AutoEventWireup="false" Codebehind="MainWithCollectionBase.aspx.vb" Inherits="ADONET.MainWithCollectionBase"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
  <HEAD>
    <title>MainWithCollectionBase</title>
    <meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
    <meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
    <meta name=vs_defaultClientScript content="JavaScript">
    <meta name=vs_targetSchema content="http://schemas.microsoft.com/intellisense/ie5">
  </HEAD>
  <body MS_POSITIONING="GridLayout">
<FORM id=Form1 method=post runat="server">
<asp:Label id=ErrorLabel style="Z-INDEX: 109; LEFT: 34px; POSITION: absolute; TOP: 14px" runat="server" Font-Bold="True" ForeColor="Red" EnableViewState="False"></asp:Label>
<asp:DataGrid id=CustomersDataGrid style="Z-INDEX: 110; LEFT: 18px; POSITION: absolute; TOP: 112px" runat="server" Font-Size="XX-Small" Font-Names="Verdana" AutoGenerateColumns="False">
<AlternatingItemStyle BackColor="#E0E0E0">
</AlternatingItemStyle>

<HeaderStyle ForeColor="White" BackColor="Blue">
</HeaderStyle>

<Columns>
<asp:BoundColumn DataField="CompanyName" HeaderText="Customer Name"></asp:BoundColumn>
<asp:BoundColumn DataField="ContactName" HeaderText="Contact Name"></asp:BoundColumn>
<asp:BoundColumn DataField="ContactTitle" HeaderText="Contact Title"></asp:BoundColumn>
</Columns>
</asp:DataGrid>
<asp:Button id=AddButton style="Z-INDEX: 108; LEFT: 298px; POSITION: absolute; TOP: 83px" runat="server" Text="Add"></asp:Button>
<asp:TextBox id=CompanyNameTextBox style="Z-INDEX: 100; LEFT: 140px; POSITION: absolute; TOP: 38px" runat="server"></asp:TextBox>
<asp:TextBox id=ContactNameTextBox style="Z-INDEX: 101; LEFT: 140px; POSITION: absolute; TOP: 59px" runat="server"></asp:TextBox>
<asp:TextBox id=ContactTitleTextBox style="Z-INDEX: 102; LEFT: 140px; POSITION: absolute; TOP: 83px" runat="server"></asp:TextBox>
<asp:Label id=Label1 style="Z-INDEX: 104; LEFT: 16px; POSITION: absolute; TOP: 38px" runat="server" Font-Bold="True">Company Name :</asp:Label>
<asp:Label id=Label2 style="Z-INDEX: 105; LEFT: 16px; POSITION: absolute; TOP: 59px" runat="server" Font-Bold="True">Contact Name :</asp:Label>
<asp:Label id=Label3 style="Z-INDEX: 106; LEFT: 16px; POSITION: absolute; TOP: 83px" runat="server" Font-Bold="True">Contact Title :</asp:Label></FORM>

  </body>
</HTML>
