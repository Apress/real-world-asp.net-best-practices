<%@ Page language="c#" Codebehind="ConfigItemEncrypter.aspx.cs" AutoEventWireup="false" Inherits="WebConfiguration.ConfigItemEncrypter" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>ConfigItemEncrypter</title>
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="FlowLayout">
		<form id="ConfigItemEncrypter" method="post" runat="server">
			<P>Enter a string to be encrypted:
				<asp:TextBox id="plainTextValue" runat="server" Columns="50"></asp:TextBox></P>
			<P>
				<asp:Button id="Button1" runat="server" Text="Encrypt"></asp:Button></P>
			<P>
				<asp:TextBox id="encryptedResult" runat="server" Columns="75"></asp:TextBox></P>
			<P>
				<asp:Label id="ErrorMessage" runat="server" Visible="False" ForeColor="Red">Error</asp:Label></P>
		</form>
	</body>
</HTML>
