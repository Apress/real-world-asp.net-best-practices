<%@ Page language="c#" Codebehind="SessionLoss.aspx.cs" AutoEventWireup="false" Inherits="WebConfiguration.SessionLoss" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>SessionLoss</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="SessionLoss" method="post" runat="server">
			<asp:TextBox id="TextBox1" runat="server"></asp:TextBox><br>
			<asp:Button id="Button1" runat="server" Text="Set Session Value"></asp:Button>
			<asp:Button id="Button2" runat="server" Text="Get Session Value"></asp:Button><br>
			<asp:Label id="Label1" runat="server" EnableViewState="False"></asp:Label>
		</form>
	</body>
</HTML>
