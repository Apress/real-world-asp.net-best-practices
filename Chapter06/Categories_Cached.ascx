<%@ Control Language="c#" AutoEventWireup="false" Codebehind="Categories_Cached.ascx.cs" Inherits="BP_Controls.Categories_Cached" TargetSchema="http://schemas.microsoft.com/intellisense/ie5"%>
<%@ Import namespace="System.Data.Common" %>
<%@ OutputCache duration="3600" varybyparam="none" %>

<asp:Repeater id="Repeater1" runat="server">
<HeaderTemplate>
	<table>
		<caption>Categories</caption>
	
</HeaderTemplate>
<ItemTemplate>
	<tr>
		<td>
		<a href="productlisting.aspx?Category=<%# ((DbDataRecord)Container.DataItem)["ID"] %>"><%# ((DbDataRecord)Container.DataItem)["Name"] %></a>
		</td>
	</tr>
</ItemTemplate>

<FooterTemplate>
	</table>
</FooterTemplate>
</asp:Repeater>
