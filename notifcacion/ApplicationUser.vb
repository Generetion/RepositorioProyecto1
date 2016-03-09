Public Class ApplicationUser
    Private id As Integer
    Private username As String
    Private password As String
    Private name As String
    Private lastNames As String
    Private email As String
    Private phone As Integer

    Public Property IdApplicationUser() As String
        Get
            Return id
        End Get
        Set(ByVal value As String)
            id = value
        End Set
    End Property

    Public Property userNameApplicationUser() As String
        Get
            Return username
        End Get
        Set(ByVal value As String)
            username = value
        End Set
    End Property
    Public Property passwordApplicationUser() As String
        Get
            Return password
        End Get
        Set(ByVal value As String)
            password = value
        End Set
    End Property
    Public Property nameApplicationUser() As String
        Get
            Return name
        End Get
        Set(ByVal value As String)
            name = value
        End Set
    End Property
    Public Property lastNamesApplicationUser() As String
        Get
            Return lastNames
        End Get
        Set(ByVal value As String)
            lastNames = value
        End Set
    End Property
    Public Property emailApplicationUser() As String
        Get
            Return email
        End Get
        Set(ByVal value As String)
            email = value
        End Set
    End Property
    Public Property phoneApplicationUser() As Integer
        Get
            Return phone
        End Get
        Set(ByVal value As Integer)
            phone = value
        End Set
    End Property

End Class
