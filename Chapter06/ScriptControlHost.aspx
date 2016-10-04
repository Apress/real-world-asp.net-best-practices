<%@ Register TagPrefix="Apress" Assembly="BP_Controls" Namespace="BP_Controls"%>
<%@ Page language="c#" Codebehind="ScriptControlHost.aspx.cs" AutoEventWireup="false" Inherits="BP_Controls.ScriptControlHost" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>ScriptControlHost</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="FlowLayout">
		<form id="ScriptControlHost" method="post" runat="server">
			<Apress:SuperTextBox id="box1" runat="server" Text="Custom Control"></Apress:SuperTextBox>
			<br>
			<asp:Button id="button1" Runat="server" />
		</form>
	</body>
</HTML>
