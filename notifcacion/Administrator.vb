Public Class Administrator

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked
  
    End Sub


    Private Sub TsmNotifications_Click(sender As Object, e As EventArgs) Handles TsmNotifications.Click
        Notifications.Show()
        Me.Close()
    End Sub
End Class