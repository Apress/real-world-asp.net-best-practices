Public Class Customer

    Private _CompanyName As String
    Private _ContactName As String
    Private _ContactTitle As String

    ' Adding a flag to contain row state
    Private _RowState As Char

    ' Providing read only property for retreiving row state
    Public ReadOnly Property RowState()
        Get
            Return _RowState
        End Get
    End Property

    ' All public properties mark the object with updated "U" flag
    ' in their Set clauses
    Public Property CompanyName() As String
        Get
            Return _CompanyName
        End Get
        Set(ByVal Value As String)
            _CompanyName = Value

            ' Marking the object as updated
            _RowState = "U"
        End Set
    End Property

    Public Property ContactName() As String
        Get
            Return _ContactName
        End Get
        Set(ByVal Value As String)
            _ContactName = Value

            ' Marking the object as updated
            _RowState = "U"
        End Set
    End Property

    Public Property ContactTitle() As String
        Get
            Return _ContactTitle
        End Get
        Set(ByVal Value As String)
            _ContactTitle = Value

            ' Marking the object as updated
            _RowState = "U"
        End Set
    End Property

    Public Sub New()
        _CompanyName = ""
        _ContactName = ""
        _ContactTitle = ""

        ' Marking the object as newly created
        _RowState = "N"
    End Sub

    Public Sub New(ByVal Reader As IDataReader)
        Me.New(Reader("CompanyName"), _
                    Reader("ContactName"), _
                    Reader("ContactTitle"))

    End Sub

    Public Sub New(ByVal CompanyName As String, _
                    ByVal ContactName As String, _
                    ByVal ContactTitle As String)
        _CompanyName = CompanyName
        _ContactName = ContactName
        _ContactTitle = ContactTitle

        ' Marking the object as newly created
        _RowState = "N"

    End Sub

    ' Adding the Delete method to provide the ability to mark this
    ' object as deleted
    Public Sub Delete()
        _RowState = "D"
    End Sub

End Class

' This class provides mechanism for comparing CompanyName property
Public Class CompanyNameComparer
    Implements IComparer

    Function Compare(ByVal x As Object, ByVal y As Object) As Integer _
                        Implements IComparer.Compare

        Dim CustomerX As Customer
        Dim CustomerY As Customer

        ' Converting generic input objects to the objects of Customer class
        CustomerX = CType(x, Customer)
        CustomerY = CType(y, Customer)

        ' Comparing CompanyName property and returing comparison result
        Return CustomerX.CompanyName = CustomerY.CompanyName

    End Function
End Class

' This class provides mechanism for comparing ContactName property
Public Class ContactNameComparer
    Implements IComparer

    Function Compare(ByVal x As Object, ByVal y As Object) As Integer _
                        Implements IComparer.Compare

        Dim CustomerX As Customer
        Dim CustomerY As Customer

        ' Converting generic input objects to the objects of Customer class
        CustomerX = CType(x, Customer)
        CustomerY = CType(y, Customer)

        ' Comparing ContactName property and returing comparison result
        Return CustomerX.ContactName = CustomerY.ContactName

    End Function
End Class

' This class provides mechanism for comparing ContactTitle property
Public Class ContactTitleComparer
    Implements IComparer

    Function Compare(ByVal x As Object, ByVal y As Object) As Integer _
                        Implements IComparer.Compare

        Dim CustomerX As Customer
        Dim CustomerY As Customer

        ' Converting generic input objects to the objects of Customer class
        CustomerX = CType(x, Customer)
        CustomerY = CType(y, Customer)

        ' Comparing ContactTitle property and returing comparison result
        Return CustomerX.ContactTitle = CustomerY.ContactTitle

    End Function
End Class

