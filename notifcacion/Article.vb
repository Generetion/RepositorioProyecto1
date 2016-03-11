Public Class Article
    Private id As Integer
    Private name As String
    Private number As Integer
    Public Property IdArticle() As Integer
        Get
            Return id
        End Get
        Set(ByVal value As Integer)
            id = value
        End Set
    End Property

    Public Property nameArticle() As String
        Get
            Return name
        End Get
        Set(ByVal value As String)
            name = value
        End Set
    End Property
    Public Property numberArticle() As Integer
        Get
            Return number
        End Get
        Set(ByVal value As Integer)
            number = value
        End Set
    End Property


End Class
