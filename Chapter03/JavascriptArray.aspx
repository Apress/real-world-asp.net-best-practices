<%@ Page Language="vb" AutoEventWireup="false" Codebehind="JavascriptArray.aspx.vb" Inherits="ASPNETVB.JavascriptArray" enableViewState="False"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
  <HEAD>
    <title>JavascriptArray</title>
<meta content="Microsoft Visual Studio.NET 7.0" name=GENERATOR>
<meta content="Visual Basic 7.0" name=CODE_LANGUAGE>
<meta content=JavaScript name=vs_defaultClientScript>
<meta content=http://schemas.microsoft.com/intellisense/ie5 name=vs_targetSchema>
<SCRIPT language=Javascript>

var curPic = 0;  

function processPrevious() {
	
    if (curPic==0) 
    {
       curPic=Pictures.length - 1; 
    }
    else 
    {
      curPic--; 
    }
    document.myPicture.src=Pictures[curPic];    
}

function processNext() {

    if (curPic==Pictures.length -1) 
    {
        curPic=0;
        }
        else 
        {
	    curPic++; 
		}
    document.myPicture.src=Pictures[curPic];    
}


</SCRIPT>
</HEAD>
<body MS_POSITIONING="GridLayout">
<form id=Form1 method=post runat="server"><asp:image id=myPicture style="Z-INDEX: 101; LEFT: 41px; POSITION: absolute; TOP: 59px" runat="server" ImageUrl="images/ac1.jpg" name="myPicture" EnableViewState="False"></asp:image><asp:button id=BackButton style="Z-INDEX: 102; LEFT: 79px; POSITION: absolute; TOP: 182px" runat="server" Text="Back" EnableViewState="False"></asp:button><asp:button id=NextButton style="Z-INDEX: 103; LEFT: 124px; POSITION: absolute; TOP: 182px" runat="server" Text="Next" EnableViewState="False"></asp:button></form>

  </body>
</HTML>
