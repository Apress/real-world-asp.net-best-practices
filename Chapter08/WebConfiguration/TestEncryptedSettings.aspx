<%@ Page language="c#" Codebehind="TestEncryptedSettings.aspx.cs" AutoEventWireup="false" Inherits="WebConfiguration.TestEncryptedSettings" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>TestEncryptedSettings</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="FlowLayout">
		<form id="TestEncryptedSettings" method="post" runat="server">
			The decrypted value for the database connection string is:
			<asp:Label id="cnnstring" runat="server"></asp:Label>
		</form>
	</body>
</HTML>
