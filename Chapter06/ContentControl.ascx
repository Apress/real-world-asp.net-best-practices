<%@ Import namespace="System.Data.Common" %>
<%@ Control Language="c#" AutoEventWireup="false" Codebehind="ContentControl.ascx.cs" Inherits="BP_Controls.ContentControl" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<asp:Repeater id="Repeater1" runat="server">
	<HeaderTemplate>
		<table>
			<caption>
				Categories</caption>
	</HeaderTemplate>
	<ItemTemplate>
		<tr>
			<td>
				<a href='productlisting.aspx?Category=<%# ((DbDataRecord)Container.DataItem)["ID"] %>'>
					<%# ((DbDataRecord)Container.DataItem)["Name"] %>
				</a>
			</td>
		</tr>
	</ItemTemplate>
	<FooterTemplate>
		</table>
	</FooterTemplate>
</asp:Repeater>
