Public Class Article
    Private id As Integer
    Private name As String
    Private idNumber As Integer
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
    Public Property idNumberArticle() As Integer
        Get
            Return idNumber
        End Get
        Set(ByVal value As Integer)
            idNumber = value
        End Set
    End Property


End Class
