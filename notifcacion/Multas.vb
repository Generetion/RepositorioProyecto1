Public Class Multas
    Dim typeOfTicket As Double
    Dim ticket As String

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxTicket.SelectedIndexChanged


        'Get the selected product from the combo box
        ticket = CbxTicket.SelectedItem


        If ticket.Equals("Atrasarse en la entrega") Then
            typeOfTicket = 2000

        ElseIf ticket.Equals("Robar algun articulo") Then
            typeOfTicket = 5000

        ElseIf ticket.Equals("Destruir algun articulo") Then
            typeOfTicket = 10000

        ElseIf ticket.Equals("No entregar lo reservado") Then
            typeOfTicket = 7500

        End If




    End Sub

    Private Sub Multas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CbxTicket.Items.Add("Atrasarse en la entrega")
        CbxTicket.Items.Add("Robar algun articulo")
        CbxTicket.Items.Add("Destruir algun articulo")
        CbxTicket.Items.Add("No entregar lo reservado")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnPay.Click

        'Get the value from the textbox:
        TbxPrice.Text = ticket


        'Show total price
        TbxPrice.Text = typeOfTicket
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click

        Me.Close()
    End Sub
End Class