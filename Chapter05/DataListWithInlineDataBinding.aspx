<%@ Page language="c#" Codebehind="DataListWithInlineDataBinding.aspx.cs" AutoEventWireup="false" Inherits="ASPControls.DataListWithInlineDataBinding" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
  <HEAD>
    <title>DataListWithInlineDataBinding</title>
<meta content="Microsoft Visual Studio 7.0" name=GENERATOR>
<meta content=C# name=CODE_LANGUAGE>
<meta content=JavaScript name=vs_defaultClientScript>
<meta content=http://schemas.microsoft.com/intellisense/ie5 name=vs_targetSchema>
  </HEAD>
<body MS_POSITIONING="GridLayout">
<form id=DataListWithInlineDataBinding method=post 
runat="server"><asp:datalist id=CustomerDataList OnEditCommand="CustomerDataList_EditCommand" style="Z-INDEX: 101; LEFT: 11px; POSITION: absolute; TOP: 21px" runat="server" EditItemIndex="-1" RepeatColumns="1">
<HeaderTemplate>
			<tr bgcolor=lightgrey valign=top>
			<th>&nbsp;</th>
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
<TR valign="top" align="left"><TD>
<asp:LinkButton id=EditButton Runat="server" CommandName="edit" Text="Edit"></asp:LinkButton></TD>
<TD><%#DataBinder.Eval(Container.DataItem, "OrderID")%></TD>
<TD><%#DataBinder.Eval(Container.DataItem, "CompanyName")%></TD>
<TD><%#DataBinder.Eval(Container.DataItem, "LastName")%></TD>
<TD><%#DataBinder.Eval(Container.DataItem, "FirstName")%></TD>
<TD><%#DataBinder.Eval(Container.DataItem, "OrderDate")%></TD>
<TD><%#DataBinder.Eval(Container.DataItem, "RequiredDate")%></TD>
<TD><%#DataBinder.Eval(Container.DataItem, "ShippedDate")%></TD></TR>
</ItemTemplate>

<EditItemTemplate>
<TR valign="top" align="left"><TD>&nbsp;</TD> <TD colspan="6">
<TABLE>
<TR>
<TD><B>Order ID:</B></TD>
<TD>
<INPUT id=OrderIDTextBox type=text value='<%#DataBinder.Eval(Container.DataItem, "OrderID")%>'> </TD></TR>
<TR>
<TD><B>Company Name:</B></TD>
<TD>
<INPUT id=CompayNameTextBox type=text value='<%#DataBinder.Eval(Container.DataItem, "CompanyName")%>'> </TD></TR>
<TR>
<TD><B>Last Name:</B></TD>
<TD>
<INPUT id=LastNameTextBox type=text value='<%#DataBinder.Eval(Container.DataItem, "LastName")%>'> </TD></TR>
<TR>
<TD><B>First Name:</B></TD>
<TD>
<INPUT id=FirstNameTextBox type=text value='<%#DataBinder.Eval(Container.DataItem, "FirstName")%>'> </TD></TR>
<TR>
<TD><B>Order Date:</B></TD>
<TD>
<INPUT id=OrderDateTextBox type=text value='<%#DataBinder.Eval(Container.DataItem, "OrderDate")%>'> </TD></TR>
<TR>
<TD><B>Required Date:</B></TD>
<TD>
<INPUT id=RequiredDateTextBox type=text value='<%#DataBinder.Eval(Container.DataItem, "RequiredDate")%>'> </TD></TR>
<TR>
<TD><B>Shipped Date:</B></TD>
<TD>
<INPUT id=ShippedDateTextBox type=text value='<%#DataBinder.Eval(Container.DataItem, "ShippedDate")%>'> </TD></TR></TABLE></TD></TR>
</EditItemTemplate>

</asp:datalist></form>
	
  </body>
</HTML>
