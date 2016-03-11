Imports System.Data.SqlClient

Public Class Login
    Dim connectionString As String = "Data Source=FERNANDO-PC\SQQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True"


    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Login()
        ' If TbxPassword.Text.Equals("") Then
        'MsgBox("El campo de nombre de Username no puede quedar vacio", vbCritical)
        ' End If
        ' If TbxPassword.Text.Equals("") Then
        'MsgBox("El campo de Password no puede quedar vacio", vbCritical)
        'End If
    End Sub

    Sub Login()
        Dim connection As New SqlConnection(connectionString)
        Dim dataSet As New DataSet

        Dim command As SqlCommand = New SqlCommand("SELECT U.Name, R.Type FROM ApplicationUser U, ApplicationRole R, User_Role UR WHERE U.Id=UR.Id_User AND R.Id=UR.Id_Role  AND U.Username='" & TbxUsername.Text & "' AND U.Password='" & TbxPassword.Text & "'", connection)
        connection.Open()

        Dim reader As SqlDataReader = command.ExecuteReader()

        'Si la consulta genera datos desde SQL
        If reader.HasRows Then

            reader.Read() 'lee el resultado de la consulta
            Dim roleName As String
            roleName = reader.GetString(1)

            If roleName.Equals("Admin") Then

                Dim adminForm As AdminForm
                adminForm = New AdminForm()
                adminForm.Show()
                Me.Close()

            End If
        Else

            MsgBox("Error en los datos") 'especifique bien esto

        End If

    End Sub

    Private Sub TbxUsername_TextChanged(sender As Object, e As EventArgs) Handles TbxUsername.TextChanged



    End Sub

    '  Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    'Dim registrerFrom As Registro
    '    registrerFrom = New Registro()
    '   registrerFrom.Show()
    '    Me.Close()
    '   End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim registrerForm As Registrer
        registrerForm = New Registrer()
        registrerForm.Show()
        Me.Close()

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)

    End Sub
End Class