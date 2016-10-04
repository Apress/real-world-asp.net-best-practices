Imports System.Data

Public Class MainWithDS
    Inherits System.Web.UI.Page
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents AddButton As System.Web.UI.WebControls.Button
    Protected WithEvents CompanyNameTextBox As System.Web.UI.WebControls.TextBox
    Protected WithEvents ContactNameTextBox As System.Web.UI.WebControls.TextBox
    Protected WithEvents ContactTitleTextBox As System.Web.UI.WebControls.TextBox
    Protected WithEvents ErrorLabel As System.Web.UI.WebControls.Label
    Protected WithEvents CustomersDataGrid As System.Web.UI.WebControls.DataGrid

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

        If Not IsPostBack Then
            Dim CustomerDS As DataSet

            CustomerDS = GetCustomers()

            CustomersDataGrid.DataSource = CustomerDS.Tables(0).DefaultView
            CustomersDataGrid.DataBind()
        End If
    End Sub

    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click

        Dim CustomersDS As DataSet
        Dim NewRow As DataRow

        CustomersDS = GetCustomers()

        NewRow = CustomersDS.Tables(0).NewRow()

        NewRow("CompanyName") = CompanyNameTextBox.Text
        NewRow("ContactName") = ContactNameTextBox.Text
        NewRow("ContactTitle") = ContactTitleTextBox.Text

        ' Check to see if input data is acceptable
        If CheckValidity(NewRow) = False Then
            Return
        End If

        ' If the customer doesn't already exist, add it.
        If IsCustomerExist(CustomersDS, NewRow) = False Then
            CustomersDS.Tables(0).Rows.Add(NewRow)
            CustomersDataGrid.DataSource = CustomersDS.Tables(0).DefaultView
            CustomersDataGrid.DataBind()
        Else
            ErrorLabel.Text = "This customer already exist."
        End If
    End Sub

    Private Function GetCustomers() As DataSet
        Dim CustomerInfo As DataSet

        If Cache("CustomersDS") Is Nothing Then
            CustomerInfo = DAL.GetCustomersDS()
            Cache.Insert("CustomersDS", CustomerInfo)
        Else
            CustomerInfo = CType(Cache("CustomersDS"), DataSet)
        End If

        Return CustomerInfo
    End Function

    Private Function CheckValidity(ByVal aRow As DataRow) As Boolean
        ' Checking to see if customer name is provided
        If IsEmpty(aRow, "CompanyName") = True Then
            ErrorLabel.Text = "Company Name is not acceptable."
            Return False
        End If

        ' Checking to see if contact name is provided
        If IsEmpty(aRow, "ContactName") = True Then
            ErrorLabel.Text = "Contact Name is not acceptable."
            Return False
        End If

        Return True
    End Function

    Private Function IsEmpty(ByVal aRow As DataRow, ByVal fieldName As String) As Boolean

        If aRow(fieldName) Is Nothing Then
            Return True
        End If

        If aRow(fieldName) Is System.DBNull.Value Then
            Return True
        End If

        Dim FieldValue As String
        FieldValue = Convert.ToString(aRow(fieldName))

        If FieldValue = "" Then
            Return True
        End If

        ' NA or N/A is not an acceptable value.
        If FieldValue.ToUpper() = "NA" Or _
                FieldValue.ToUpper() = "N/A" Then
            Return True
        End If

        Return False
    End Function

    Private Function IsCustomerExist(ByVal CustomersDS As DataSet, ByVal NewRow As DataRow) As Boolean
        Dim Row As DataRow

        For Each Row In CustomersDS.Tables(0).Rows
            If Row("CompanyName").ToString() = NewRow("CompanyName").ToString() And _
                Row("ContactName").ToString() = NewRow("ContactName").ToString() Then

                Return True
            End If
        Next

        Return False
    End Function

End Class

