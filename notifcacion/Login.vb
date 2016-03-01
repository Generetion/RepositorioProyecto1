Imports System.Data.SqlClient

Public Class Login

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim con As New SqlClient.SqlConnection("Data Source=FERNANDO-PC\SQQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True")
        con.Open()
        Dim dr As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand("select * from [Users] where username" + TbxUsername.Text + "and pasword" + TbxPassword.Text + "", con)
      

        dr = cmd.ExecuteReader
        If dr.Read Then
            Administrator.Show()
        Else
            MessageBox.Show("Acceso invalido")
        End If
    End Sub

End Class