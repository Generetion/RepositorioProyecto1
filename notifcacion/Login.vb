Imports System.Data.SqlClient

Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Login()
    End Sub

    Sub Login()
        Dim connection As New SqlClient.SqlConnection
        Dim command As New SqlClient.SqlCommand
        Dim adaptor As New SqlClient.SqlDataAdapter
        Dim dataSet As New DataSet

        connection.ConnectionString = ("Data Source=FERNANDO-PC\SQQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True")
        command.CommandText = "SELECT * FROM [Users] WHERE (Username='" + TbxUsername.Text + "')AND (Password='" + TbxPassword.Text + "');"

        connection.Open()
        command.Connection = connection
        adaptor.SelectCommand = command

        adaptor.Fill(dataSet, "0")
        Dim count = dataSet.Tables(0).Rows.Count

        If count > 0 Then
            Administrator.Show()
        Else
            MsgBox("Error usted no esta logeado en la base de datos")
        End If

    End Sub
End Class