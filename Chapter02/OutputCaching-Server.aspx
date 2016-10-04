<%@ Page language="c#" Codebehind="OutputCaching-Server.aspx.cs" AutoEventWireup="false" Inherits="ASPNET.OutputCaching___Server" %>
<%@ OutputCache Duration="10" VaryByParam="None" Location="Server" %>
<HTML>
  <HEAD>
    <title>OutputCaching - Server</title>
  </HEAD>
  <body MS_POSITIONING="GridLayout">
    <form id="OutputCaching_Server" method="post" runat="server">
<asp:datagrid id=ResultGrid style="Z-INDEX: 103; LEFT: 8px; POSITION: absolute; TOP: 8px" runat="server">
<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="Blue">
</HeaderStyle></asp:datagrid></form></body>
</HTML>
