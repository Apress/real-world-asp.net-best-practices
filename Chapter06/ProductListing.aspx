<%@ Page language="c#" Codebehind="ProductListing.aspx.cs" AutoEventWireup="false" Inherits="BP_Controls.WebForm1" %>
<%@ Register TagPrefix="uc1" TagName="Categories_Cached" Src="Categories_Cached.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Product Listing</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" cellSpacing="1" cellPadding="1" width="100%" border="1">
				<TR>
					<TD width="25%" valign="top">
						<uc1:Categories_Cached id="Categories_Cached1" runat="server"></uc1:Categories_Cached></TD>
					<TD width="75%">
						<asp:DataGrid id="DataGrid1" runat="server" AutoGenerateColumns="False">
						<Columns>
							<asp:HyperLinkColumn DataTextField="productname" DataNavigateUrlField="productid" DataNavigateUrlFormatString="productdetails.aspx?productid={0}" />
							<asp:BoundColumn DataField="unitprice" Headertext="Price" DataFormatString="{0:C}" />
						</Columns>
						
						</asp:DataGrid></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
