<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaVendas
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
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.cbCliente = New System.Windows.Forms.ComboBox()
        Me.rbFuncionario = New System.Windows.Forms.RadioButton()
        Me.rbCliente = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbData = New System.Windows.Forms.RadioButton()
        Me.cbFuncionario = New System.Windows.Forms.ComboBox()
        Me.dtData = New System.Windows.Forms.DateTimePicker()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(29, 50)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(754, 209)
        Me.dg.TabIndex = 97
        '
        'cbCliente
        '
        Me.cbCliente.FormattingEnabled = True
        Me.cbCliente.Location = New System.Drawing.Point(652, 15)
        Me.cbCliente.Name = "cbCliente"
        Me.cbCliente.Size = New System.Drawing.Size(129, 21)
        Me.cbCliente.TabIndex = 98
        '
        'rbFuncionario
        '
        Me.rbFuncionario.AutoSize = True
        Me.rbFuncionario.Location = New System.Drawing.Point(491, 16)
        Me.rbFuncionario.Name = "rbFuncionario"
        Me.rbFuncionario.Size = New System.Drawing.Size(80, 17)
        Me.rbFuncionario.TabIndex = 102
        Me.rbFuncionario.TabStop = True
        Me.rbFuncionario.Text = "Funcionário"
        Me.rbFuncionario.UseVisualStyleBackColor = True
        '
        'rbCliente
        '
        Me.rbCliente.AutoSize = True
        Me.rbCliente.Location = New System.Drawing.Point(412, 16)
        Me.rbCliente.Name = "rbCliente"
        Me.rbCliente.Size = New System.Drawing.Size(57, 17)
        Me.rbCliente.TabIndex = 101
        Me.rbCliente.TabStop = True
        Me.rbCliente.Text = "Cliente"
        Me.rbCliente.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(357, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "Buscar:"
        '
        'rbData
        '
        Me.rbData.AutoSize = True
        Me.rbData.Location = New System.Drawing.Point(587, 16)
        Me.rbData.Name = "rbData"
        Me.rbData.Size = New System.Drawing.Size(48, 17)
        Me.rbData.TabIndex = 103
        Me.rbData.TabStop = True
        Me.rbData.Text = "Data"
        Me.rbData.UseVisualStyleBackColor = True
        '
        'cbFuncionario
        '
        Me.cbFuncionario.FormattingEnabled = True
        Me.cbFuncionario.Location = New System.Drawing.Point(652, 15)
        Me.cbFuncionario.Name = "cbFuncionario"
        Me.cbFuncionario.Size = New System.Drawing.Size(129, 21)
        Me.cbFuncionario.TabIndex = 104
        '
        'dtData
        '
        Me.dtData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtData.Location = New System.Drawing.Point(652, 15)
        Me.dtData.Name = "dtData"
        Me.dtData.Size = New System.Drawing.Size(131, 20)
        Me.dtData.TabIndex = 105
        '
        'ListaVendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(815, 309)
        Me.Controls.Add(Me.dtData)
        Me.Controls.Add(Me.cbFuncionario)
        Me.Controls.Add(Me.rbData)
        Me.Controls.Add(Me.rbFuncionario)
        Me.Controls.Add(Me.rbCliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbCliente)
        Me.Controls.Add(Me.dg)
        Me.Name = "ListaVendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ListaVendas"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dg As DataGridView
    Friend WithEvents cbCliente As ComboBox
    Friend WithEvents rbFuncionario As RadioButton
    Friend WithEvents rbCliente As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents rbData As RadioButton
    Friend WithEvents cbFuncionario As ComboBox
    Friend WithEvents dtData As DateTimePicker
End Class
