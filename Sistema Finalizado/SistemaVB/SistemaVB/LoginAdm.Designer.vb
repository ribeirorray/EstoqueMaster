<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginAdm
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtSenha = New System.Windows.Forms.MaskedTextBox()
        Me.btnEntrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtSenha
        '
        Me.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSenha.Location = New System.Drawing.Point(22, 36)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(120, 13)
        Me.txtSenha.TabIndex = 2
        '
        'btnEntrar
        '
        Me.btnEntrar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnEntrar.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnEntrar.FlatAppearance.BorderSize = 0
        Me.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEntrar.Location = New System.Drawing.Point(157, 31)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(75, 23)
        Me.btnEntrar.TabIndex = 3
        Me.btnEntrar.Text = "Entrar"
        Me.btnEntrar.UseVisualStyleBackColor = False
        '
        'LoginAdm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(276, 86)
        Me.Controls.Add(Me.btnEntrar)
        Me.Controls.Add(Me.txtSenha)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "LoginAdm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login do Administrador"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSenha As MaskedTextBox
    Friend WithEvents btnEntrar As Button
End Class
