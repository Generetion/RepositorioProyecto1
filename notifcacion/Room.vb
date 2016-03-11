Public Class Room
    Private id As Integer
    Private number As Integer
    Private edifice As String
    Private type As String

    Public Property idRoom() As Integer
        Get
            Return id
        End Get
        Set(ByVal value As Integer)
            id = value
        End Set
    End Property

    Public Property numberRoom() As Integer
        Get
            Return number
        End Get
        Set(ByVal value As Integer)
            number = value
        End Set
    End Property
    Public Property edificeRoom() As String
        Get
            Return edifice
        End Get
        Set(ByVal value As String)
            edifice = value
        End Set
    End Property
    Public Property typeRoom() As String
        Get
            Return type
        End Get
        Set(ByVal value As String)
            type = value
        End Set
    End Property
End Class
