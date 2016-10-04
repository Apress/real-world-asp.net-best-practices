<%@ Page language="c#" Codebehind="TemplateControlHost.aspx.cs" AutoEventWireup="false" Inherits="BP_Controls.TemplateControlHost" %>
<%@ Register TagPrefix="uc1" TagName="SupportTemplates" Src="SupportTemplates.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>TemplateControlHost</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="FlowLayout">
		<form id="TemplateControlHost" method="post" runat="server">
			<uc1:SupportTemplates id="SupportTemplates1" runat="server">
				<HeaderTemplate>
					<b>Header Content</b>
				</HeaderTemplate>
				<FooterTemplate>
					<i>Footer Content</i>
				</FooterTemplate>
			</uc1:SupportTemplates>
		</form>
	</body>
</HTML>
