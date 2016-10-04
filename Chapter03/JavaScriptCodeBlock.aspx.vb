Imports System.IO
Imports System.Text

Public Class JavaScriptCodeBlock
    Inherits System.Web.UI.Page
    Protected WithEvents myPicture As System.Web.UI.WebControls.Image
    Protected WithEvents BackButton As System.Web.UI.WebControls.Button
    Protected WithEvents NextButton As System.Web.UI.WebControls.Button

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Not Page.IsPostBack Then

            Dim CurPic As String
            Dim ProcessPrevious, ProcessNext As String
            Dim ImageArray As StringBuilder

            ImageArray = GetImageArray("Images")
            Page.RegisterArrayDeclaration("Pictures", ImageArray.ToString())

            CurPic = "var curPic = 0;"

            ProcessPrevious = "function processPrevious() " + _
                        " { " + _
                        "  if (curPic==0) " + _
                        "  { " + _
                        "    curPic=Pictures.length - 1; " + _
                        "  } " + _
                        "  else " + _
                        "  { " + _
                        "    curPic--; " + _
                        "  } " + _
                        "  document.myPicture.src=Pictures[curPic]; " + _
                        " } "

            ProcessNext = "function processNext() " + _
                            " { " + _
                            "    if (curPic==Pictures.length -1) " + _
                            "    { " + _
                            "      curPic=0; " + _
                            "    } " + _
                            "    else " + _
                            "    { " + _
                            "      curPic++; " + _
                            "    } " + _
                            "    document.myPicture.src=Pictures[curPic];    " + _
                            " }"

            Page.RegisterClientScriptBlock("SlideShow", _
                            "<script language='JavaScript'>" + _
                            CurPic + ProcessPrevious + ProcessNext + _
                            "</script>")

            BackButton.Attributes.Add("onClick", _
                        "processPrevious();return false;")
            NextButton.Attributes.Add("onClick", _
                        "processNext();return false;")

            myPicture.Attributes.Add("onMouseOver", "processNext()")

        End If

    End Sub

    Private Function GetImageArray(ByVal folderName As String) As StringBuilder

        Dim Path As String
        Dim Folder As DirectoryInfo
        Dim Image As FileInfo
        Dim Images As FileInfo()
        Dim ImageArray As New StringBuilder()

        Path = Request.PhysicalApplicationPath + folderName
        Folder = New DirectoryInfo(Path)
        Images = Folder.GetFiles()

        For Each Image In Images
            ImageArray.AppendFormat("'{0}/{1}',", _
                            folderName, Image.Name)
        Next
        ImageArray.Remove(ImageArray.Length - 1, 1)

        Return ImageArray
    End Function

End Class
