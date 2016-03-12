Public Class AdminForm

    Private Sub ArticulosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ArticulosToolStripMenuItem1.Click
        Dim articlesCRUD As ArticlesCRUD
        articlesCRUD = New ArticlesCRUD
        articlesCRUD.Show()
        Me.Close()
    End Sub
End Class