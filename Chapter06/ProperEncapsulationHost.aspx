<%@ Page language="c#" Codebehind="ProperEncapsulationHost.aspx.cs" AutoEventWireup="false" Inherits="BP_Controls.ProperEncapsulationHost" %>
<%@ Register TagPrefix="uc1" TagName="ProperEncapsulation" Src="ProperEncapsulation.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>ProperEncapsulationHost</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="FlowLayout">
		<form id="ProperEncapsulationHost" method="post" runat="server">
			<uc1:ProperEncapsulation id="ProperEncapsulation1" runat="server"></uc1:ProperEncapsulation>
			
			<br>
			<br>
			Page scope total items in user control: <%= ProperEncapsulation1.ItemCount %>
		</form>
	</body>
</HTML>
