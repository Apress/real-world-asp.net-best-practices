Imports System.IO
Imports System.Text

Public Class RegisterStartupScript
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

            Dim ImageArray As StringBuilder

            ImageArray = GetImageArray("Images")

            Page.RegisterArrayDeclaration("Pictures", ImageArray.ToString())

            BackButton.Attributes.Add("onClick", "processPrevious();return false;")
            NextButton.Attributes.Add("onClick", "processNext();return false;")

            myPicture.Attributes.Add("onMouseOver", "processNext()")

            Page.RegisterStartupScript("StartUp", _
                    "<script language='JavaScript'>alert('Hi');processNext()</script>")

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
