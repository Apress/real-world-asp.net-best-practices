<%@ Page language="c#" Codebehind="RepeaterWithMemberMethodDataBinding.aspx.cs" AutoEventWireup="false" Inherits="ASPControls.RepeaterWithMemberMethodDataBinding" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
  <HEAD>
    <title>RepeaterWithMemberMethodDataBinding</title>
    <meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
    <meta name="CODE_LANGUAGE" Content="C#">
    <meta name=vs_defaultClientScript content="JavaScript">
    <meta name=vs_targetSchema content="http://schemas.microsoft.com/intellisense/ie5">
  </HEAD>
  <body MS_POSITIONING="GridLayout">
	
    <form id="RepeaterWithMemberMethodDataBinding" method="post" runat="server">
<asp:Repeater id=CustomerRepeater runat="server">
<HeaderTemplate>
    <table>
			<tr bgcolor=lightgrey valign=top>
			<th>Order ID</th>
			<th>Company Name</th>
			<th>Last Name</th>
			<th>First Name</th>
			<th>Order Date</th>
			<th>Required Date</th>
			<th>Shipped Date</th>
			</tr>
</HeaderTemplate>

<ItemTemplate>
			<tr valign=top align=left>
			<td><%#ShowData(Container.DataItem, "OrderID")%></td>
			<td><%#ShowData(Container.DataItem, "CompanyName")%></td>
			<td><%#ShowData(Container.DataItem, "LastName")%></td>
			<td><%#ShowData(Container.DataItem, "FirstName")%></td>
			<td><%#ShowData(Container.DataItem, "OrderDate")%></td>
			<td><%#ShowData(Container.DataItem, "RequiredDate")%></td>
			<td><%#ShowData(Container.DataItem, "ShippedDate")%></td>
			</tr>		
</ItemTemplate>

<FooterTemplate>
</table>
</FooterTemplate>
	</asp:Repeater>

     </form>
	
  </body>
</HTML>
