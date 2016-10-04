<%@ Page language="c#" Codebehind="WriteXMLFile.aspx.cs" AutoEventWireup="false" Inherits="ASPNET.WriteXMLFile" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
  <HEAD>
    <title>WriteXMLFile</title>
    <meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
    <meta name="CODE_LANGUAGE" Content="C#">
    <meta name=vs_defaultClientScript content="JavaScript">
    <meta name=vs_targetSchema content="http://schemas.microsoft.com/intellisense/ie5">
  </HEAD>
  <body MS_POSITIONING="GridLayout">
	
    <form id="WriteXMLFile" method="post" runat="server">
<asp:Button id=WriteXMLButton style="Z-INDEX: 100; LEFT: 69px; POSITION: absolute; TOP: 54px" runat="server" Text="Write To File"></asp:Button>
<asp:datagrid id=ResultGrid style="Z-INDEX: 103; LEFT: 72px; POSITION: absolute; TOP: 96px" runat="server">
<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="Blue">
</HeaderStyle>
</asp:datagrid>
<asp:Button id=LoadFromFileButton style="Z-INDEX: 101; LEFT: 184px; POSITION: absolute; TOP: 54px" runat="server" Text="Load From File"></asp:Button>&nbsp;

     </form>
	
  </body>
</HTML>
