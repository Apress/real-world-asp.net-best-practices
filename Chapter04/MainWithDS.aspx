<%@ Page Language="vb" AutoEventWireup="false" Codebehind="MainWithDS.aspx.vb" Inherits="ADONET.MainWithDS"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
  <HEAD>
    <title>MainWithDS</title>
    <meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0">
    <meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
    <meta name=vs_defaultClientScript content="JavaScript">
    <meta name=vs_targetSchema content="http://schemas.microsoft.com/intellisense/ie5">
  </HEAD>
  <body MS_POSITIONING="GridLayout">

    <form id="Form1" method="post" runat="server">
<asp:DataGrid id=CustomersDataGrid style="Z-INDEX: 101; LEFT: 15px; POSITION: absolute; TOP: 111px" runat="server" Font-Names="Verdana" Font-Size="XX-Small">
<AlternatingItemStyle BackColor="#E0E0E0">
</AlternatingItemStyle>

<HeaderStyle ForeColor="White" BackColor="Blue">
</HeaderStyle>
</asp:DataGrid>
<asp:Label id=ErrorLabel style="Z-INDEX: 109; LEFT: 25px; POSITION: absolute; TOP: 14px" runat="server" Font-Bold="True" ForeColor="Red" EnableViewState="False"></asp:Label>
<asp:TextBox id=CompanyNameTextBox style="Z-INDEX: 102; LEFT: 139px; POSITION: absolute; TOP: 34px" runat="server"></asp:TextBox>
<asp:TextBox id=ContactNameTextBox style="Z-INDEX: 103; LEFT: 139px; POSITION: absolute; TOP: 55px" runat="server"></asp:TextBox>
<asp:TextBox id=ContactTitleTextBox style="Z-INDEX: 104; LEFT: 139px; POSITION: absolute; TOP: 79px" runat="server"></asp:TextBox>
<asp:Label id=Label1 style="Z-INDEX: 105; LEFT: 15px; POSITION: absolute; TOP: 34px" runat="server" Font-Bold="True">Company Name :</asp:Label>
<asp:Label id=Label2 style="Z-INDEX: 106; LEFT: 15px; POSITION: absolute; TOP: 55px" runat="server" Font-Bold="True">Contact Name :</asp:Label>
<asp:Label id=Label3 style="Z-INDEX: 107; LEFT: 15px; POSITION: absolute; TOP: 79px" runat="server" Font-Bold="True">Contact Title :</asp:Label>
<asp:Button id=AddButton style="Z-INDEX: 108; LEFT: 297px; POSITION: absolute; TOP: 80px" runat="server" Text="Add"></asp:Button>

    </form>

  </body>
</HTML>
