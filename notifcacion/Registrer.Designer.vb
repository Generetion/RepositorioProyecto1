<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrer
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbxUsername = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbxPhone = New System.Windows.Forms.TextBox()
        Me.TbxEmail = New System.Windows.Forms.TextBox()
        Me.TbxLastName = New System.Windows.Forms.TextBox()
        Me.TbxName = New System.Windows.Forms.TextBox()
        Me.BtnRegistrer = New System.Windows.Forms.Button()
        Me.TbxContraseña = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(48, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Nombre de Usuario"
        '
        'TbxUsername
        '
        Me.TbxUsername.Location = New System.Drawing.Point(163, 103)
        Me.TbxUsername.Name = "TbxUsername"
        Me.TbxUsername.Size = New System.Drawing.Size(100, 20)
        Me.TbxUsername.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(48, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Telefono"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "E-mail"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Apellidos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Nombre"
        '
        'TbxPhone
        '
        Me.TbxPhone.Location = New System.Drawing.Point(163, 209)
        Me.TbxPhone.Name = "TbxPhone"
        Me.TbxPhone.Size = New System.Drawing.Size(100, 20)
        Me.TbxPhone.TabIndex = 20
        '
        'TbxEmail
        '
        Me.TbxEmail.Location = New System.Drawing.Point(163, 159)
        Me.TbxEmail.Name = "TbxEmail"
        Me.TbxEmail.Size = New System.Drawing.Size(100, 20)
        Me.TbxEmail.TabIndex = 19
        '
        'TbxLastName
        '
        Me.TbxLastName.Location = New System.Drawing.Point(163, 59)
        Me.TbxLastName.Name = "TbxLastName"
        Me.TbxLastName.Size = New System.Drawing.Size(100, 20)
        Me.TbxLastName.TabIndex = 18
        '
        'TbxName
        '
        Me.TbxName.Location = New System.Drawing.Point(163, 6)
        Me.TbxName.Name = "TbxName"
        Me.TbxName.Size = New System.Drawing.Size(100, 20)
        Me.TbxName.TabIndex = 17
        '
        'BtnRegistrer
        '
        Me.BtnRegistrer.Location = New System.Drawing.Point(340, 425)
        Me.BtnRegistrer.Name = "BtnRegistrer"
        Me.BtnRegistrer.Size = New System.Drawing.Size(75, 23)
        Me.BtnRegistrer.TabIndex = 29
        Me.BtnRegistrer.Text = "Registrar"
        Me.BtnRegistrer.UseVisualStyleBackColor = True
        '
        'TbxContraseña
        '
        Me.TbxContraseña.Location = New System.Drawing.Point(163, 263)
        Me.TbxContraseña.Name = "TbxContraseña"
        Me.TbxContraseña.Size = New System.Drawing.Size(100, 20)
        Me.TbxContraseña.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(48, 263)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Contraseña"
        '
        'Registrer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 496)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TbxContraseña)
        Me.Controls.Add(Me.BtnRegistrer)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TbxUsername)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TbxPhone)
        Me.Controls.Add(Me.TbxEmail)
        Me.Controls.Add(Me.TbxLastName)
        Me.Controls.Add(Me.TbxName)
        Me.Name = "Registrer"
        Me.Text = "Registrer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TbxUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TbxPhone As System.Windows.Forms.TextBox
    Friend WithEvents TbxEmail As System.Windows.Forms.TextBox
    Friend WithEvents TbxLastName As System.Windows.Forms.TextBox
    Friend WithEvents TbxName As System.Windows.Forms.TextBox
    Friend WithEvents BtnRegistrer As System.Windows.Forms.Button
    Friend WithEvents TbxContraseña As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
