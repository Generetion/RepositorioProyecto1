Public Class AdminForm

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CrearToolStripMenuItem_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub ArticulosToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TsmAccount_Click(sender As Object, e As EventArgs) Handles TsmAccount.Click

    End Sub

    Private Sub SolicitudesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SolicitudesToolStripMenuItem.Click

    End Sub

    Private Sub ArticulosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ArticulosToolStripMenuItem1.Click
        Dim articlesCRUD As ArticlesCRUD
        articlesCRUD = New ArticlesCRUD
        articlesCRUD.Show()
        Me.Close()
    End Sub
End Class