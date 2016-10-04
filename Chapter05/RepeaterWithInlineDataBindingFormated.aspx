<%@ Page language="c#" Codebehind="RepeaterWithInlineDataBindingFormated.aspx.cs" AutoEventWireup="false" Inherits="ASPControls.RepeaterWithInlineDataBindingFormated" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
  <HEAD>
    <title>Repeater</title>
    <meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
    <meta name="CODE_LANGUAGE" Content="C#">
    <meta name=vs_defaultClientScript content="JavaScript">
    <meta name=vs_targetSchema content="http://schemas.microsoft.com/intellisense/ie5">
  </HEAD>
  <body MS_POSITIONING="GridLayout">
	
    <form id="Repeater" method="post" runat="server">
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
			<td><%#DataBinder.Eval(Container.DataItem, "OrderID")%></td>
			<td><%#DataBinder.Eval(Container.DataItem, "CompanyName")%></td>
			<td><%#DataBinder.Eval(Container.DataItem, "LastName")%></td>
			<td><%#DataBinder.Eval(Container.DataItem, "FirstName")%></td>
			<td><%#DataBinder.Eval(Container.DataItem, "OrderDate")%></td>
			<td><%#DataBinder.Eval(Container.DataItem, "RequiredDate", "{0:d}")%></td>
			<td><%#DataBinder.Eval(Container.DataItem, "ShippedDate", "{0:d}")%></td>
			</tr>		
</ItemTemplate>
<FooterTemplate>
</table>
</FooterTemplate>
	</asp:Repeater>
</table>	
     </form>
	
  </body>
</HTML>
