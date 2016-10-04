<%@ Page language="c#" Codebehind="LinearSearch.aspx.cs" AutoEventWireup="false" Inherits="ASPNET.LinearSearch" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
  <HEAD>
    <title>LinearSearch</title>
    <meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
    <meta name="CODE_LANGUAGE" Content="C#">
    <meta name=vs_defaultClientScript content="JavaScript">
    <meta name=vs_targetSchema content="http://schemas.microsoft.com/intellisense/ie5">
  </HEAD>
  <body MS_POSITIONING="GridLayout">
	
    <form id="LinearSearch" method="post" runat="server">
<asp:Button id=SelectButton style="Z-INDEX: 101; LEFT: 39px; POSITION: absolute; TOP: 43px" runat="server" Text="Use Select Method"></asp:Button>
<asp:Button id=DataViewButton style="Z-INDEX: 102; LEFT: 39px; POSITION: absolute; TOP: 69px" runat="server" Text="Use DataView Search" Width="166px"></asp:Button>
<asp:Label id=DurationLabel style="Z-INDEX: 103; LEFT: 39px; POSITION: absolute; TOP: 104px" runat="server" Width="194px"></asp:Label>
<asp:TextBox id=DirectoryTextBox style="Z-INDEX: 104; LEFT: 39px; POSITION: absolute; TOP: 17px" runat="server"></asp:TextBox>

     </form>
	
  </body>
</HTML>
