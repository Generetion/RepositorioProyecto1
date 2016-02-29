<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Multas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbxTicket = New System.Windows.Forms.ComboBox()
        Me.TbxPrice = New System.Windows.Forms.TextBox()
        Me.BtnPay = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo de multa:"
        '
        'CbxTicket
        '
        Me.CbxTicket.FormattingEnabled = True
        Me.CbxTicket.Location = New System.Drawing.Point(148, 39)
        Me.CbxTicket.Name = "CbxTicket"
        Me.CbxTicket.Size = New System.Drawing.Size(121, 21)
        Me.CbxTicket.TabIndex = 1
        '
        'TbxPrice
        '
        Me.TbxPrice.Location = New System.Drawing.Point(148, 112)
        Me.TbxPrice.Name = "TbxPrice"
        Me.TbxPrice.Size = New System.Drawing.Size(100, 20)
        Me.TbxPrice.TabIndex = 2
        '
        'BtnPay
        '
        Me.BtnPay.Location = New System.Drawing.Point(34, 178)
        Me.BtnPay.Name = "BtnPay"
        Me.BtnPay.Size = New System.Drawing.Size(75, 23)
        Me.BtnPay.TabIndex = 3
        Me.BtnPay.Text = "Pagar Multa"
        Me.BtnPay.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(173, 178)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 4
        Me.BtnExit.Text = "Salir"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'Multas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnPay)
        Me.Controls.Add(Me.TbxPrice)
        Me.Controls.Add(Me.CbxTicket)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Multas"
        Me.Text = "Multas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CbxTicket As ComboBox
    Friend WithEvents TbxPrice As TextBox
    Friend WithEvents BtnPay As Button
    Friend WithEvents BtnExit As Button
End Class
