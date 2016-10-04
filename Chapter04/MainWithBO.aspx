<%@ Page Language="vb" AutoEventWireup="false" Codebehind="MainWithBO.aspx.vb" Inherits="ADONET.MainWithBO"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
  <HEAD>
    <title>Main</title>
    <meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
    <meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
    <meta name=vs_defaultClientScript content="JavaScript">
    <meta name=vs_targetSchema content="http://schemas.microsoft.com/intellisense/ie5">
  </HEAD>
  <body MS_POSITIONING="GridLayout">

    <form id="Form1" method="post" runat="server">
<asp:DataGrid id=CustomersDataGrid style="Z-INDEX: 107; LEFT: 16px; POSITION: absolute; TOP: 114px" runat="server" Font-Size="XX-Small" Font-Names="Verdana">
<AlternatingItemStyle BackColor="#E0E0E0">
</AlternatingItemStyle>

<HeaderStyle ForeColor="White" BackColor="Blue">
</HeaderStyle>
</asp:DataGrid>
<asp:Label id=ErrorLabel style="Z-INDEX: 109; LEFT: 34px; POSITION: absolute; TOP: 14px" runat="server" Font-Bold="True" ForeColor="Red" EnableViewState="False"></asp:Label>
<asp:Button id=AddButton style="Z-INDEX: 108; LEFT: 298px; POSITION: absolute; TOP: 83px" runat="server" Text="Add"></asp:Button>
<asp:TextBox id=CompanyNameTextBox style="Z-INDEX: 100; LEFT: 140px; POSITION: absolute; TOP: 38px" runat="server"></asp:TextBox>
<asp:TextBox id=ContactNameTextBox style="Z-INDEX: 101; LEFT: 140px; POSITION: absolute; TOP: 59px" runat="server"></asp:TextBox>
<asp:TextBox id=ContactTitleTextBox style="Z-INDEX: 102; LEFT: 140px; POSITION: absolute; TOP: 83px" runat="server"></asp:TextBox>
<asp:Label id=Label1 style="Z-INDEX: 104; LEFT: 16px; POSITION: absolute; TOP: 38px" runat="server" Font-Bold="True">Company Name :</asp:Label>
<asp:Label id=Label2 style="Z-INDEX: 105; LEFT: 16px; POSITION: absolute; TOP: 59px" runat="server" Font-Bold="True">Contact Name :</asp:Label>
<asp:Label id=Label3 style="Z-INDEX: 106; LEFT: 16px; POSITION: absolute; TOP: 83px" runat="server" Font-Bold="True">Contact Title :</asp:Label>

    </form>

  </body>
</HTML>
