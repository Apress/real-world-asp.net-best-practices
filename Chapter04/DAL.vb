Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration.ConfigurationSettings

Public Class DAL

    Public Shared Function GetCustomersCollection() As CustomerCollection

        Dim MyConnection As New SqlConnection()
        Dim MyCommand As New SqlCommand()
        Dim MyCustomers As New CustomerCollection()
        Dim MyReader

        MyConnection.ConnectionString = AppSettings.Get("DSN")
        MyCommand.CommandText = "Select CustomerID, CompanyName," + _
                                " ContactName, ContactTitle " + _
                                " from Customers"
        MyCommand.Connection = MyConnection
        MyCommand.Connection.Open()
        MyReader = MyCommand.ExecuteReader()

        MyCustomers.Fill(MyReader)

        Return MyCustomers
    End Function

    Public Shared Function GetCustomers() As Customers
        Dim CustomerInfo As New Customers()

        Dim MyConnection As New SqlConnection()
        Dim MyCommand As New SqlCommand()
        Dim MyAdapter As New SqlDataAdapter()

        MyConnection.ConnectionString = AppSettings.Get("DSN")
        MyCommand.CommandText = "Select CustomerID, CompanyName," + _
                                " ContactName, ContactTitle " + _
                                " from Customers"
        MyCommand.Connection = MyConnection

        MyAdapter.SelectCommand = MyCommand
        CustomerInfo.Fill(MyAdapter)

        Return CustomerInfo
    End Function

    Public Shared Sub SaveCustomers(ByVal CustomerInfo As Customers)
        Dim MyAdapter As New SqlDataAdapter()

        'Write code to setup the adapter with 
        ' appropriate Insert/Update/Delete commands

        ' Asking Customers object to save its data using the 
        ' data adapter object provided to it.
        CustomerInfo.Update(MyAdapter)

    End Sub

    Public Shared Function GetCustomersDS() As DataSet
        Dim CustomerDS As New DataSet()

        Dim MyConnection As New SqlConnection()
        Dim MyCommand As New SqlCommand()
        Dim MyAdapter As New SqlDataAdapter()

        MyConnection.ConnectionString = AppSettings.Get("DSN")
        MyCommand.CommandText = "Select CustomerID, CompanyName," + _
                                " ContactName, ContactTitle " + _
                                " from Customers"
        MyCommand.Connection = MyConnection

        MyAdapter.SelectCommand = MyCommand
        MyAdapter.Fill(CustomerDS)

        Return CustomerDS
    End Function

End Class
