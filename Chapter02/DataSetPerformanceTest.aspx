<%@ Page language="c#" Codebehind="DataSetPerformanceTest.aspx.cs" AutoEventWireup="false" Inherits="ASPNET.DataSetPerformanceTest" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
  <HEAD>
    <title>DataSetPerformanceTest</title>
<meta content="Microsoft Visual Studio 7.0" name=GENERATOR>
<meta content=C# name=CODE_LANGUAGE>
<meta content=JavaScript name=vs_defaultClientScript>
<meta content=http://schemas.microsoft.com/intellisense/ie5 name=vs_targetSchema>
  </HEAD>
<body MS_POSITIONING="GridLayout">
<form id=DataSetPerformanceTest method=post runat="server"><asp:textbox id=DirectoryTextBox style="Z-INDEX: 100; LEFT: 26px; POSITION: absolute; TOP: 47px" runat="server" Width="169px"></asp:textbox><asp:button id=DirectoryFromDBButton style="Z-INDEX: 107; LEFT: 204px; POSITION: absolute; TOP: 55px" runat="server" Width="195px" Text="Directory from Database"></asp:button><asp:button id=DirectoryFromCacheButton style="Z-INDEX: 102; LEFT: 204px; POSITION: absolute; TOP: 31px" runat="server" Width="195px" Text="Directory from Cache"></asp:button><asp:datagrid id=ResultGrid style="Z-INDEX: 103; LEFT: 27px; POSITION: absolute; TOP: 170px" runat="server">
<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="Blue">
</HeaderStyle>
</asp:datagrid><asp:label id=CacheLabel style="Z-INDEX: 105; LEFT: 24px; POSITION: absolute; TOP: 120px" runat="server" Font-Bold="True"></asp:label><asp:label id=DurationLabel style="Z-INDEX: 106; LEFT: 25px; POSITION: absolute; TOP: 143px" runat="server" EnableViewState="False"></asp:label><asp:label id=Label2 style="Z-INDEX: 108; LEFT: 24px; POSITION: absolute; TOP: 27px" runat="server" Font-Bold="True">Directory Name :</asp:label></form>
	
  </body>
</HTML>
