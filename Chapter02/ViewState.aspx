<%@ Page language="c#" Codebehind="ViewState.aspx.cs" AutoEventWireup="false" Inherits="ASPNET.ViewState" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
  <HEAD>
    <title>ViewState</title>
    <meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
    <meta name="CODE_LANGUAGE" Content="C#">
    <meta name=vs_defaultClientScript content="JavaScript">
    <meta name=vs_targetSchema content="http://schemas.microsoft.com/intellisense/ie5">
  </HEAD>
  <body MS_POSITIONING="GridLayout">
	
    <form id="ViewState" method="post" runat="server">
<asp:DropDownList id=CategoriesDropDown style="Z-INDEX: 101; LEFT: 24px; POSITION: absolute; TOP: 73px" runat="server" Width="151px" DataTextField="CategoryName" DataValueField="CategoryID" EnableViewState="False"></asp:DropDownList>
<asp:datagrid id=ResultGrid style="Z-INDEX: 113; LEFT: 24px; POSITION: absolute; TOP: 161px" runat="server" EnableViewState="False">
<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="Blue">
</HeaderStyle>
</asp:datagrid>
<asp:Label id=Label6 style="Z-INDEX: 112; LEFT: 335px; POSITION: absolute; TOP: 100px" runat="server" Font-Bold="True">Region:</asp:Label>
<asp:DropDownList id=RegionDropDown style="Z-INDEX: 103; LEFT: 335px; POSITION: absolute; TOP: 122px" runat="server" Width="151px" DataTextField="RegionDescription" DataValueField="RegionID" EnableViewState="False"></asp:DropDownList>
<asp:Label id=Label5 style="Z-INDEX: 111; LEFT: 181px; POSITION: absolute; TOP: 100px" runat="server" Font-Bold="True">Products:</asp:Label>
<asp:DropDownList id=ProductsDropDown style="Z-INDEX: 104; LEFT: 181px; POSITION: absolute; TOP: 122px" runat="server" Width="151px" DataTextField="ProductName" DataValueField="ProductID" EnableViewState="False"></asp:DropDownList>
<asp:Label id=Label4 style="Z-INDEX: 110; LEFT: 24px; POSITION: absolute; TOP: 100px" runat="server" Font-Bold="True">Orders:</asp:Label>
<asp:DropDownList id=OrdersDropDown style="Z-INDEX: 105; LEFT: 24px; POSITION: absolute; TOP: 122px" runat="server" Width="151px" DataTextField="OrderDate" DataValueField="OrderID" EnableViewState="False"></asp:DropDownList>
<asp:Label id=Label3 style="Z-INDEX: 109; LEFT: 335px; POSITION: absolute; TOP: 53px" runat="server" Font-Bold="True">Employees:</asp:Label>
<asp:DropDownList id=EmployeesDropDown style="Z-INDEX: 106; LEFT: 335px; POSITION: absolute; TOP: 73px" runat="server" Width="151px" DataTextField="LastName" DataValueField="EmployeeId" EnableViewState="False"></asp:DropDownList>
<asp:Label id=Label2 style="Z-INDEX: 108; LEFT: 181px; POSITION: absolute; TOP: 53px" runat="server" Font-Bold="True">Customers:</asp:Label>
<asp:DropDownList id=CustomersDropDown style="Z-INDEX: 102; LEFT: 181px; POSITION: absolute; TOP: 73px" runat="server" Width="151px" DataTextField="CompanyName" DataValueField="CustomerID" EnableViewState="False"></asp:DropDownList>&nbsp;
<asp:Label id=Label1 style="Z-INDEX: 107; LEFT: 24px; POSITION: absolute; TOP: 53px" runat="server" Font-Bold="True">Categories:</asp:Label>
<asp:Button id=PostBackButton style="Z-INDEX: 114; LEFT: 24px; POSITION: absolute; TOP: 23px" runat="server" Text="Post Back"></asp:Button>

     </form>
	
  </body>
</HTML>
