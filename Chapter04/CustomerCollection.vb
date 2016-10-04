Public Class CustomerCollection
    Inherits CollectionBase
    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal Reader As IDataReader)
        Me.Fill(Reader)
    End Sub

    Public Sub Fill(ByVal Reader As IDataReader)
        While (Reader.Read() = True)
            Dim aCustomer As New Customer(Reader)
            Me.Add(aCustomer)
        End While
    End Sub

#Region "Creating strongly typed collection"

    Public Sub Insert(ByVal index As Integer, ByVal NewCustomer As Customer)
        ' Check to see if input data is valid
        CheckValidity(NewCustomer)

        ' If the customer doesn't already exist, add it.
        If IsCustomerExist(NewCustomer) = False Then
            InnerList.Insert(index, NewCustomer)
        Else
            Throw New CustomerExistException()
        End If
    End Sub

    Public Sub Remove(ByVal aCustomer As Customer)
        InnerList.Remove(aCustomer)
    End Sub

    Public Function Contains(ByVal aCustomer As Customer) As Integer
        Return InnerList.Contains(aCustomer)
    End Function

    Public Function IndexOf(ByVal aCustomer As Customer) As Integer
        Return InnerList.IndexOf(aCustomer)
    End Function

    Public Function Add(ByVal NewCustomer As Customer) As Integer
        ' Check to see if input data is valid
        CheckValidity(NewCustomer)

        ' If the customer doesn't already exist, add it.
        If IsCustomerExist(NewCustomer) = False Then
            Return InnerList.Add(NewCustomer)
        Else
            Throw New CustomerExistException()
        End If
    End Function

#End Region

#Region "Business Rules"

    Private Function IsCustomerExist(ByVal newCustomer As Customer) As Boolean
        Dim aCustomer As Customer

        For Each aCustomer In Me
            If aCustomer.CompanyName = newCustomer.CompanyName And _
                aCustomer.ContactName = newCustomer.ContactName Then

                Return True
            End If
        Next

        Return False
    End Function

    Private Sub CheckValidity(ByVal aCustomer As Customer)
        ' Checking to see if customer name is provided
        If IsEmpty(aCustomer.CompanyName) = True Then
            Throw New CustomerNameRequiredException()
        End If

        ' Checking to see if contact name is provided
        If IsEmpty(aCustomer.ContactName) = True Then
            Throw New ContactNameRequiredException()
        End If
    End Sub

    Private Function IsEmpty(ByVal Field As String) As Boolean

        If Field Is Nothing Then
            Return True
        ElseIf Field Is System.DBNull.Value Then
            Return True
        ElseIf Field = "" Then
            Return True
        ElseIf Field.ToUpper() = "N/A" Then
            Return True
        ElseIf Field.ToUpper() = "NA" Then
            Return True
        Else
            Return False
        End If
    End Function


#End Region

#Region "Providing filtering capabilities"

    Public Function FilterByCompany(ByVal aCompanyName As String) As CustomerCollection

        Dim aCustomer As Customer
        Dim NewCollection As CustomerCollection

        For Each aCustomer In Me
            If aCustomer.CompanyName = aCompanyName Then
                NewCollection.Add(aCustomer)
            End If
        Next

        Return NewCollection

    End Function

    Public Function FilterByContact(ByVal aContactName As String) As CustomerCollection

        Dim aCustomer As Customer
        Dim NewCollection As CustomerCollection

        For Each aCustomer In Me
            If aCustomer.ContactName = aContactName Then
                NewCollection.Add(aCustomer)
            End If
        Next

        Return NewCollection

    End Function

    Public Function GetChangedRecords() As CustomerCollection

        Dim aCustomer As Customer
        Dim NewCollection As CustomerCollection

        For Each aCustomer In Me
            If aCustomer.RowState = "U" Then
                NewCollection.Add(aCustomer)
            End If
        Next

        Return NewCollection

    End Function

#End Region

#Region "Sorting the collection"

    Public Sub Sort(ByVal propertyName As String)

        If propertyName.ToUpper() = "COMPANYNAME" Then
            ' Using company name comparer to sort by CompanyName 
            Dim Comparer As New CompanyNameComparer()
            InnerList.Sort(Comparer)
        ElseIf propertyName.ToUpper() = "CONTACTNAME" Then
            ' Using contact name comparer to sort by ContactName 
            Dim Comparer As New ContactNameComparer()
            InnerList.Sort(Comparer)
        ElseIf propertyName.ToUpper() = "CONTACTTITLE" Then
            ' Using contact title comparer to sort by ContactTitle 
            Dim Comparer As New ContactTitleComparer()
            InnerList.Sort(Comparer)
        End If

    End Sub

#End Region


End Class
