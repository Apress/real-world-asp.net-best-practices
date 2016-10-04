Public Class MainWithCollectionBase
    Inherits System.Web.UI.Page
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents ContactTitleTextBox As System.Web.UI.WebControls.TextBox
    Protected WithEvents ContactNameTextBox As System.Web.UI.WebControls.TextBox
    Protected WithEvents CompanyNameTextBox As System.Web.UI.WebControls.TextBox
    Protected WithEvents AddButton As System.Web.UI.WebControls.Button
    Protected WithEvents CustomersDataGrid As System.Web.UI.WebControls.DataGrid
    Protected WithEvents ErrorLabel As System.Web.UI.WebControls.Label

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
        Dim MyCustomers As CustomerCollection
        MyCustomers = GetCustomers()

        CustomersDataGrid.DataSource = MyCustomers
        CustomersDataGrid.DataBind()
    End Sub

    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click

        Dim MyCustomers As CustomerCollection
        MyCustomers = GetCustomers()

        Try
            Dim NewCustomer As New Customer()
            NewCustomer.CompanyName = CompanyNameTextBox.Text
            NewCustomer.ContactName = ContactNameTextBox.Text
            NewCustomer.ContactTitle = ContactTitleTextBox.Text

            MyCustomers.Add(NewCustomer)

            CustomersDataGrid.DataSource = MyCustomers
            CustomersDataGrid.DataBind()

        Catch expAlreadyExist As CustomerExistException
            ' Show additional information from the exception object
            ErrorLabel.Text = expAlreadyExist.Message
        Catch expNameRequired As CustomerNameRequiredException
            ' Show additional information from the exception object
            ErrorLabel.Text = expNameRequired.Message
        Catch expContactRequired As ContactNameRequiredException
            ' Show additional information from the exception object
            ErrorLabel.Text = expContactRequired.Message
        End Try
    End Sub

    Private Function GetCustomers() As CustomerCollection
        Dim MyCustomers As CustomerCollection

        If Cache("Customers") Is Nothing Then
            MyCustomers = DAL.GetCustomersCollection()
            Cache.Insert("Customers", MyCustomers)
        Else
            MyCustomers = CType(Cache("Customers"), CustomerCollection)
        End If

        Return MyCustomers
    End Function


End Class
