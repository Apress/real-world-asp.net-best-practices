<%@ Page language="c#" Codebehind="RepeaterWithProgrammaticDataBinding.aspx.cs" AutoEventWireup="false" Inherits="ASPControls.RepeaterWithProgrammaticDataBinding" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
  <HEAD>
    <title>RepeaterWithProgrammaticDataBinding</title>
    <meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
    <meta name="CODE_LANGUAGE" Content="C#">
    <meta name=vs_defaultClientScript content="JavaScript">
    <meta name=vs_targetSchema content="http://schemas.microsoft.com/intellisense/ie5">
  </HEAD>
  <body MS_POSITIONING="GridLayout">
	
    <form id="RepeaterWithProgrammaticDataBinding" method="post" runat="server">
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
			<td>
<asp:label id=OrderIDLabel runat=server></asp:label></td>
			<td>
<asp:label id="CompanyNameLabel" runat=server></asp:label></td>
			<td>
<asp:label id="LastNameLabel" runat=server></asp:label></td>
			<td>
<asp:label id="FirstNameLabel" runat=server></asp:label></td>
			<td>
<asp:label id="OrderDateLabel" runat=server></asp:label></td>
			<td>
<asp:label id="RequiredDateLabel" runat=server></asp:label></td>
			<td>
<asp:label id="ShippedDateLabel" runat=server></asp:label></td>
			</tr>		
</ItemTemplate>

<FooterTemplate>
</table>
</FooterTemplate>
	</asp:Repeater>&nbsp;

     </form>
	
  </body>
</HTML>
