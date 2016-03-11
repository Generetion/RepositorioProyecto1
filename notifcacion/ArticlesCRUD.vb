Imports System.Data.SqlClient

Public Class ArticlesCRUD

    Dim databaseConectionString As String = "Data Source=FERNANDO-PC\SQQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True"
    Dim connection As New SqlConnection(databaseConectionString)
    Dim articleTable As New DataTable
    Dim roomTables As New DataTable

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles LblNumberRoom.Click

    End Sub

    Private Sub LblElectric_Click(sender As Object, e As EventArgs) Handles LblArticleName.Click

    End Sub

    Private Sub CbxType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxType.SelectedIndexChanged
        Dim day As String
        day = CbxType.SelectedItem
        Select Case day
            Case "Electronico"


                LblArticleName.Visible = True
                TbxNameArticle.Visible = True

                LblNumberArticle.Visible = True
                TbxArticleNumber.Visible = True

                LblNumberRoom.Visible = False
                TbxNumberRoom.Visible = False

                LblEdificeNumberRoom.Visible = False
                TbxEdificeRoom.Visible = False

                LblTypeRoom.Visible = False
                TbxTypeRoom.Visible = False


                BtnInsert.Text = "Insertar Articulo Electronico"

            Case "Clase"

        
                LblNumberRoom.Visible = True
                TbxNumberRoom.Visible = True

                LblEdificeNumberRoom.Visible = True
                TbxEdificeRoom.Visible = True

                LblTypeRoom.Visible = True
                TbxTypeRoom.Visible = True

                LblArticleName.Visible = False
                TbxNameArticle.Visible = False

                LblNumberArticle.Visible = False
                TbxArticleNumber.Visible = False
                BtnInsert.Text = "Insertar Clase"

        End Select

    End Sub

    Private Sub ArticlesCRUD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CbxType.Items.Add("Electronico")
        CbxType.Items.Add("Clase")
    End Sub
   Public Function CreateDataTable() As DataTable
        articleTable = New DataTable
        articleTable.Columns.Add("Nombre")
        articleTable.Columns.Add("Numero")

        Return articleTable
    End Function
    Public Sub InsertArticle(ByVal article As Article)
        Dim commandInsert As New SqlCommand

        commandInsert = New SqlCommand("INSERT INTO Article(name, idNumber) VALUES(@nameArticle, @idNumberArticle)", connection)

        With commandInsert
            .Parameters.AddWithValue("@nameArticle", article.nameArticle)
            .Parameters.AddWithValue("@idNumberArticle", article.idNumberArticle)
        End With
        connection.Open()
        commandInsert.ExecuteNonQuery()
        connection.Close()
        MsgBox("Profesor insertado con éxito")
    End Sub


    Sub InsertRoom(ByVal room As Room)
        Dim commandInsert As SqlCommand

        commandInsert = New SqlCommand("INSERT INTO Room(number, edifice, type) VALUES (@NumberRoom, @EdificeRoom, @TypeRoom)", connection)

        With commandInsert
            .Parameters.AddWithValue("@NumberRoom", room.numberRoom)
            .Parameters.AddWithValue("@EdificeRoom", room.edificeRoom)
            .Parameters.AddWithValue("@TypeRoom", room.typeRoom)

        End With

        connection.Open() 'Open database connection
        commandInsert.ExecuteNonQuery()
        connection.Close()
        MsgBox("Insercion exitosa")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnInsert.Click
  

        Dim casoOfInsert As String
        casoOfInsert = BtnInsert.Text
        Select Case casoOfInsert
            Case "Insertar Articulo Electronico"
                Dim article As Article
                article = New Article
                article.nameArticle = TbxNameArticle.Text
                article.idNumberArticle = TbxArticleNumber.Text
                InsertArticle(article)

            Case "Insertar Clase"
                Dim room As Room
                room = New Room
                room.numberRoom = TbxNumberRoom.Text
                room.edificeRoom = TbxEdificeRoom.Text
                room.typeRoom = TbxTypeRoom.Text
                InsertRoom(room)

        End Select

    End Sub
End Class