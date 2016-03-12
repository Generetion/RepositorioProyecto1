Imports System.Data.SqlClient

Public Class ArticlesCRUD

    Dim databaseConectionString As String = "Data Source=FERNANDO-PC\SQQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True"
    Dim connection As New SqlConnection(databaseConectionString)
    Dim articlesTable As New DataTable
    Dim roomsTables As New DataTable
    Dim row As Integer
    Private Sub CbxType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxType.SelectedIndexChanged
        Dim type As String
        type = CbxType.SelectedItem
        Select Case type
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

        CbxChosseModify.Items.Add("Electronico")
        CbxChosseModify.Items.Add("Clase")
    End Sub
    Public Function articleTable() As DataTable
        articlesTable = New DataTable
        articlesTable.Columns.Add("Nombre")
        articlesTable.Columns.Add("Numero")

        Return articlesTable
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
        MsgBox("Inserción exitosa")

    End Sub

    Public Function roomData() As DataTable
        roomsTables = New DataTable
        roomsTables.Columns.Add("Number")
        roomsTables.Columns.Add("Edificio")
        roomsTables.Columns.Add("Tipo")

        Return roomsTables
    End Function
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
        RoomTableUpdate()

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
                UpdateTable()
            Case "Insertar Clase"
                Dim room As Room
                room = New Room
                room.numberRoom = TbxNumberRoom.Text
                room.edificeRoom = TbxEdificeRoom.Text
                room.typeRoom = TbxTypeRoom.Text
                InsertRoom(room)
                RoomTableUpdate()
        End Select

    End Sub
    Public Sub UpdateTable()
        articlesTable.Rows.Clear()
        Dim commandSelect As New SqlCommand("SELECT name, idNumber FROM Article", connection)
        Dim dataAdapter As New SqlDataAdapter(commandSelect)
        dataAdapter.Fill(articlesTable)
        Me.DgvArticles.DataSource = articlesTable

    End Sub
    Public Sub RoomTableUpdate()
        roomsTables.Rows.Clear()
        Dim commandSelect As New SqlCommand("SELECT number, edifice, type FROM Room", connection)
        Dim dataAdapter As New SqlDataAdapter(commandSelect)
        dataAdapter.Fill(roomsTables)
        Me.DgvRoomsView.DataSource = roomsTables
    End Sub

    Public Sub UpdateTableModify()
        articlesTable.Rows.Clear()
        Dim commandSelect As New SqlCommand("SELECT name, idNumber FROM Article", connection)
        Dim dataAdapter As New SqlDataAdapter(commandSelect)
        dataAdapter.Fill(articlesTable)
        Me.DgvModify.DataSource = articlesTable

    End Sub
    Public Sub RoomTableModify()
        roomsTables.Rows.Clear()
        Dim commandSelect As New SqlCommand("SELECT number, edifice, type FROM Room", connection)
        Dim dataAdapter As New SqlDataAdapter(commandSelect)
        dataAdapter.Fill(roomsTables)
        Me.DgvModify.DataSource = roomsTables
    End Sub

    Sub ModifyArticle(ByVal article As Article)
        Dim idArticles As String
        'get the Id of professor selected
        idArticles = DgvArticles.Item(1, row).Value.ToString

        Dim commandUpdate As New SqlCommand("UPDATE Article SET " & _
                                            "NAME= @name," & _
                                            "IdNumber= @idNumber" & _
                                            " WHERE Idnumber=" & "'" & idArticles & "'", connection)

        With commandUpdate
            .Parameters.AddWithValue("@name", article.nameArticle)
            .Parameters.AddWithValue("@idNumber", article.IdArticle)
        End With

        connection.Open()
        commandUpdate.ExecuteNonQuery()
        UpdateTable()
        connection.Close()
        MsgBox("Profesor modificado con éxito")
    End Sub
    Public Sub FillTextBoxesWithArticledData()
        TbxNameArticleModify.Text = DgvModify.Item(0, row).Value.ToString
        TbxClassNumberModify.Text = DgvModify.Item(1, row).Value.ToString

    End Sub
    Public Sub FillTextBoxesWithRoomData()


        TbxNumberRoomModify.Text = DgvModify.Item(0, row).Value.ToString
        TbxEdificeRoomModify.Text = DgvModify.Item(1, row).Value.ToString
        TbxTypeRoomModify.Text = DgvModify.Item(2, row).Value.ToString


    End Sub
    Private Sub BtnShowData_Click(sender As Object, e As EventArgs) Handles BtnShowData.Click
        UpdateTable()
        RoomTableUpdate()
    End Sub
  
    Private Sub CbxChosseModify_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxChosseModify.SelectedIndexChanged
     
        Dim type As String
        type = CbxChosseModify.SelectedItem
        Select Case type
            Case "Electronico"

                LblNameArticleUpdate.Visible = True
                TbxNameArticleModify.Visible = True

                LblNumberRoomUpdate.Visible = True
                TbxClassNumberModify.Visible = True

                LblNumberClassUpdate.Visible = False
                TbxNumberRoomModify.Visible = False

                LblEdificeNumberUpdate.Visible = False
                TbxEdificeRoomModify.Visible = False

                LblTypeRoomUpdate.Visible = False
                TbxTypeRoomModify.Visible = False

                DgvModify.Visible = True
                BtnSelect.Text = "Modificar Electronico"

                UpdateTableModify()

            Case "Clase"

                LblNumberClassUpdate.Visible = True
                TbxNumberRoomModify.Visible = True

                LblEdificeNumberUpdate.Visible = True
                TbxEdificeRoomModify.Visible = True

                LblTypeRoomUpdate.Visible = True
                TbxTypeRoomModify.Visible = True

                LblNameArticleUpdate.Visible = False
                TbxNameArticleModify.Visible = False

                LblNumberRoomUpdate.Visible = False
                TbxClassNumberModify.Visible = False

                DgvModify.Visible = True

                BtnSelect.Text = "Modificar Clase"

                RoomTableModify()
        End Select
    End Sub

    Private Sub BtnModify_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        FillTextBoxesWithRoomData()


    End Sub

    Private Sub BtnModify_Click_1(sender As Object, e As EventArgs) Handles BtnModify.Click

    End Sub
End Class