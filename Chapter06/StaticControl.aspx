<%@ Register TagPrefix="uc1" TagName="ContentControl" Src="ContentControl.ascx" %>
<%@ Page language="c#" Codebehind="StaticControl.aspx.cs" AutoEventWireup="false" Inherits="BP_Controls.StaticControl" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>StaticControl</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="FlowLayout">
		<form id="StaticControl" method="post" runat="server">
			<uc1:ContentControl id="ContentControl1" runat="server"></uc1:ContentControl>
		</form>
	</body>
</HTML>
