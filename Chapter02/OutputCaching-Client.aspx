<%@ OutputCache Duration="10" VaryByParam="None" Location="Client" %>
<%@ Page language="c#" Codebehind="OutputCaching-Client.aspx.cs" AutoEventWireup="false" Inherits="ASPNET.OutputCaching" %>
<HTML>
  <HEAD><title>OutputCaching</title></HEAD>
  <body MS_POSITIONING="GridLayout">
    <form id="OutputCaching" method="post" runat="server">
<asp:datagrid id=ResultGrid style="Z-INDEX: 103; LEFT: 16px; POSITION: absolute; TOP: 30px" runat="server">
<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="Blue">
</HeaderStyle>
</asp:datagrid></form></body>
</HTML>
