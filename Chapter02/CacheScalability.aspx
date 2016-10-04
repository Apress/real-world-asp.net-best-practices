<%@ Page language="c#"  Codebehind="CacheScalability.aspx.cs" AutoEventWireup="false" Inherits="ASPNET.CacheScalability" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
  <HEAD>
    <title>CacheScalability</title>
    <meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
    <meta name="CODE_LANGUAGE" Content="C#">
    <meta name=vs_defaultClientScript content="JavaScript">
    <meta name=vs_targetSchema content="http://schemas.microsoft.com/intellisense/ie5">
  </HEAD>
  <body MS_POSITIONING="GridLayout">
	
    <form id="CacheScalability" method="post" runat="server">
<asp:button id=AddToCacheButton OnClick="AddToCacheButton_Click" style="Z-INDEX: 101; LEFT: 73px; POSITION: absolute; TOP: 41px" runat="server" Text="Add To Cache"></asp:button>
<asp:button id=CheckCacheButton style="Z-INDEX: 102; LEFT: 73px; POSITION: absolute; TOP: 77px" runat="server" Text="Check Cache" Width="123px"></asp:button>&nbsp;
<asp:Label id=CacheStatusLabel style="Z-INDEX: 103; LEFT: 73px; POSITION: absolute; TOP: 109px" runat="server"></asp:Label>
<asp:Label id=DurationLabel style="Z-INDEX: 104; LEFT: 73px; POSITION: absolute; TOP: 135px" runat="server" EnableViewState="False"></asp:Label>

     </form>
	
  </body>
</HTML>
