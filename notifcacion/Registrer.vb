Imports System.Data.SqlClient

Public Class Registrer

    Dim databaseConectionString As String = "Data Source=FERNANDO-PC\SQQLEXPRESS;Initial Catalog=Project;Integrated Security=True"
    Dim connection As New SqlConnection(databaseConectionString)
    Private Sub Registrer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub Registro(ByVal applicationUser As ApplicationUser)

        'Command to communicate with database
        Dim commandInsert As SqlCommand

        commandInsert = New SqlCommand("INSERT INTO ApplicationUser(Id, Username, Password, Name, LastNames, Email, Phone)  VALUES (@IdApplicationUser, @UsernameApplicationUser, @PasswordApplicationUser, @NameApplicationUser, @LastNamesApplicationUser, @EmailApplicationUser, @PhoneApplicationUser)", connection)

        With commandInsert
            .Parameters.AddWithValue("@IdApplicationUser", applicationUser.IdApplicationUser)
            .Parameters.AddWithValue("@UsernameApplicationUser", applicationUser.userNameApplicationUser)
            .Parameters.AddWithValue("@NameApplicationUser", applicationUser.nameApplicationUser)
            .Parameters.AddWithValue("@PasswordApplicationUser", applicationUser.passwordApplicationUser)
            .Parameters.AddWithValue("@LastNamesApplicationUser", applicationUser.lastNamesApplicationUser)
            .Parameters.AddWithValue("@EmailApplicationUser", applicationUser.emailApplicationUser)
            .Parameters.AddWithValue("@PhoneApplicationUser", applicationUser.phoneApplicationUser)


        End With

        connection.Open() 'Open database connection
        commandInsert.ExecuteNonQuery()
        connection.Close()
        MsgBox("Registro exitoso")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnRegistrer.Click
        Dim applicationUser As ApplicationUser
        applicationUser = New ApplicationUser
        applicationUser.nameApplicationUser = TbxName.Text
        applicationUser.passwordApplicationUser = TbxUsername.Text
        applicationUser.lastNamesApplicationUser = TbxLastName.Text
        applicationUser.phoneApplicationUser = TbxPhone.Text
        applicationUser.emailApplicationUser = TbxEmail.Text
        applicationUser.userNameApplicationUser = TbxUsername.Text
        applicationUser.IdApplicationUser = TbxId.Text

            Registro(applicationUser)

    End Sub
End Class