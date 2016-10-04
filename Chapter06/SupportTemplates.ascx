<%@ Control Language="c#" AutoEventWireup="false" Codebehind="SupportTemplates.ascx.cs" Inherits="BP_Controls.SupportTemplates" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<table>
	<tr>
		<td><asp:PlaceHolder id="headerContainer" runat="server"></asp:PlaceHolder></td>
	</tr>
	<tr>
		<td>This is the static content that always&nbsp;appears on the control</td>
	</tr>
	<tr>
		<td><asp:PlaceHolder id="footerContainer" runat="server"></asp:PlaceHolder></td>
	</tr>
</table>
