<%@ Page language="c#" Codebehind="FastDataSetPerformanceTest.aspx.cs" AutoEventWireup="false" Inherits="ASPNET.FastDataSetPerformanceTest" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
  <HEAD>
    <title>FastDataSetPerformanceTest</title>
    <meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
    <meta name="CODE_LANGUAGE" Content="C#">
    <meta name=vs_defaultClientScript content="JavaScript">
    <meta name=vs_targetSchema content="http://schemas.microsoft.com/intellisense/ie5">
  </HEAD>
  <body MS_POSITIONING="GridLayout">
<FORM id=DataSetPerformanceTest method=post runat="server">
<asp:button id=DirectoryFromDBButton style="Z-INDEX: 107; LEFT: 204px; POSITION: absolute; TOP: 55px" runat="server" Width="195px" Text="Directory From Database"></asp:button>
<asp:textbox id=DirectoryTextBox style="Z-INDEX: 109; LEFT: 24px; POSITION: absolute; TOP: 46px" runat="server" Width="169px"></asp:textbox>
<asp:button id=DirectoryFromCacheButton style="Z-INDEX: 102; LEFT: 204px; POSITION: absolute; TOP: 31px" runat="server" Width="195px" Text="Directory From Cache"></asp:button>
<asp:datagrid id=ResultGrid style="Z-INDEX: 103; LEFT: 27px; POSITION: absolute; TOP: 170px" runat="server">
<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="Blue">
</HeaderStyle>
</asp:datagrid>
<asp:label id=CacheLabel style="Z-INDEX: 105; LEFT: 24px; POSITION: absolute; TOP: 120px" runat="server" Font-Bold="True"></asp:label>
<asp:label id=DurationLabel style="Z-INDEX: 106; LEFT: 25px; POSITION: absolute; TOP: 143px" runat="server" EnableViewState="False"></asp:label>
<asp:label id=Label2 style="Z-INDEX: 108; LEFT: 24px; POSITION: absolute; TOP: 27px" runat="server" Font-Bold="True">Directory Name :</asp:label></FORM>
	
  </body>
</HTML>
