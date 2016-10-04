Imports System.Data
Imports System.Data.SqlClient

Public Class Customers
    Private _Data As DataTable

#Region "Data table encapsulation"
    Public ReadOnly Property Data() As IList
        Get
            Return _Data.DefaultView
        End Get
    End Property

    Sub New()
        _Data = New DataTable("Customers")

    End Sub

    Public Sub Fill(ByVal adapter As SqlDataAdapter)
        adapter.Fill(_Data)
    End Sub

    Public Sub Update(ByVal adapter As SqlDataAdapter)
        adapter.Update(_Data)
    End Sub

    Public Sub Remove(ByVal customer As DataRow)
        _Data.Rows.Remove(customer)
    End Sub

    Public Sub RemoveAt(ByVal index As Integer)
        _Data.Rows.RemoveAt(index)
    End Sub

    Public Function NewCustomer() As DataRow
        Return _Data.NewRow()
    End Function

    Public Function GetCustomer(ByVal index As Integer) As DataRow
        Return _Data.Rows(index)
    End Function

#End Region

#Region "Business Logic"
    Public Sub AddCustomer(ByVal CompanyName As String, _
                                ByVal ContactName As String, _
                                ByVal ContactTitle As String)
        Dim NewCustomer As DataRow
        NewCustomer = Me.NewCustomer()

        NewCustomer("CompanyName") = CompanyName
        NewCustomer("ContactName") = ContactName
        NewCustomer("ContactTitle") = ContactTitle

        Me.AddCustomer(NewCustomer)

    End Sub

    Public Sub AddCustomer(ByVal newCustomer As DataRow)
        ' Check to see if input data is valid
        CheckValidity(newCustomer)

        ' If the customer doesn't already exist, add it.
        If IsCustomerExist(newCustomer) = False Then
            _Data.Rows.Add(newCustomer)
        Else
            Throw New CustomerExistException()
        End If

    End Sub

    Public Sub UpdateCustomer(ByVal index As Integer, _
                                        ByVal customer As DataRow)
        ' Check to see if input data is valid
        CheckValidity(customer)

        ' Everything good, updating customer informaton
        _Data.Rows(index).ItemArray = customer.ItemArray
    End Sub

    Private Function IsCustomerExist(ByVal newCustomer As DataRow) As Boolean
        Dim Row As DataRow

        For Each Row In _Data.Rows
            If Row("CompanyName").ToString() = newCustomer("CompanyName").ToString() And _
                Row("ContactName").ToString() = newCustomer("ContactName").ToString() Then

                Return True
            End If
        Next

        Return False
    End Function

    Private Sub CheckValidity(ByVal customer As DataRow)
        ' Checking to see if customer name is provided
        If IsEmpty(customer, "CompanyName") = True Then
            Throw New CustomerNameRequiredException()
        End If

        ' Checking to see if contact name is provided
        If IsEmpty(customer, "ContactName") = True Then
            Throw New ContactNameRequiredException()
        End If
    End Sub

    Private Function IsEmpty(ByVal customer As DataRow, _
                                ByVal fieldName As String) As Boolean

        If customer(fieldName) Is Nothing Then
            Return True
        ElseIf customer(fieldName) Is System.DBNull.Value Then
            Return True
        ElseIf Convert.ToString(customer(fieldName)) = "" Then
            Return True
        ElseIf Convert.ToString(customer(fieldName)).ToUpper() = "N/A" Then
            Return True
        ElseIf Convert.ToString(customer(fieldName)).ToUpper() = "NA" Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region
End Class

Public Class CustomerExistException
    Inherits System.Exception
    ' You can add methods here to override 
    ' base constructors and to add your own 
    ' functionality.
    Public Sub New()
        MyBase.New("Customer already exist!")
    End Sub

End Class

Public Class CustomerNameRequiredException
    Inherits System.Exception
    ' You can add methods here to override 
    ' base constructors and to add your own 
    ' functionality.
    Public Sub New()
        MyBase.New("Customer name is required!")
    End Sub
End Class

Public Class ContactNameRequiredException
    Inherits System.Exception
    ' You can add methods here to override 
    ' base constructors and to add your own 
    ' functionality.
    Public Sub New()
        MyBase.New("Contact name is required!")
    End Sub
End Class