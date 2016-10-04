<%@ Page language="c#" Codebehind="Examples.aspx.cs" AutoEventWireup="false" Inherits="WebConfiguration.Example1" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>WebForm1</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<b>Configured Mail Servers</b>
			<table border="1" runat="server" id="configTable">
			</table>
			<br>
			<asp:Label ID="ErrorMessage" Runat="server" ForeColor="Red" Visible="False">Configuration was not found.</asp:Label>
			<br>
			<asp:Label ID="appDomainID" Runat="server"></asp:Label>
		</form>
	</body>
</HTML>
