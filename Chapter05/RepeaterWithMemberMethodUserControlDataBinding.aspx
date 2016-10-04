<%@ Register TagPrefix="uc1" TagName="Order" Src="OrderWithLabel.ascx" %>
<%@ Page language="c#" Codebehind="RepeaterWithMemberMethodUserControlDataBinding.aspx.cs" AutoEventWireup="false" Inherits="ASPControls.RepeaterWithMemberMethodUserControlDataBinding" %>
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
     <uc1:Order DataSource='<%#Container.DataItem%>' id=MyOrderControl runat="server"></uc1:Order>
	</tr>		
</ItemTemplate>

<FooterTemplate>
</table>
</FooterTemplate>
</asp:Repeater>

</form>
	
</body>
</HTML>
