<%@ Register TagPrefix="uc1" TagName="EventSubscriber" Src="EventSubscriber.ascx" %>
<%@ Register TagPrefix="uc1" TagName="EventPublisher" Src="EventPublisher.ascx" %>
<%@ Page language="c#" Codebehind="EventsInControls.aspx.cs" AutoEventWireup="false" Inherits="BP_Controls.EventsInControls" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>EventsInControls</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="FlowLayout">
		<form id="EventsInControls" method="post" runat="server">
			<P>
				<uc1:EventPublisher id="EventPublisher1" runat="server"></uc1:EventPublisher></P>
			<P>
				<uc1:EventSubscriber id="EventSubscriber1" runat="server"></uc1:EventSubscriber></P>
		</form>
	</body>
</HTML>
