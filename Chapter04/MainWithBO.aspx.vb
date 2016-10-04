Public Class MainWithBO
    Inherits System.Web.UI.Page
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents AddButton As System.Web.UI.WebControls.Button
    Protected WithEvents ContactTitleTextBox As System.Web.UI.WebControls.TextBox
    Protected WithEvents ContactNameTextBox As System.Web.UI.WebControls.TextBox
    Protected WithEvents CompanyNameTextBox As System.Web.UI.WebControls.TextBox
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

        Dim CustomerInfo As Customers
        CustomerInfo = GetCustomers()

        CustomersDataGrid.DataSource = CustomerInfo.Data
        CustomersDataGrid.DataBind()
    End Sub

    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click

        Dim CustomerInfo As Customers
        CustomerInfo = GetCustomers()        

        Try
            CustomerInfo.AddCustomer(CompanyNameTextBox.Text, _
                                        ContactNameTextBox.Text, _
                                        ContactTitleTextBox.Text)

            CustomersDataGrid.DataSource = CustomerInfo.Data
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

    Private Function GetCustomers() As Customers
        Dim CustomerInfo As Customers

        If Cache("Customers") Is Nothing Then
            CustomerInfo = DAL.GetCustomers()
            Cache.Insert("Customers", CustomerInfo)
        Else
            CustomerInfo = CType(Cache("Customers"), Customers)
        End If

        Return CustomerInfo
    End Function
End Class
