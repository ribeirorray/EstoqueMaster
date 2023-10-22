<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaEstoque
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
        Me.dtDataInicio = New System.Windows.Forms.DateTimePicker()
        Me.rbData = New System.Windows.Forms.RadioButton()
        Me.cbEntrada = New System.Windows.Forms.ComboBox()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbEntrada = New System.Windows.Forms.RadioButton()
        Me.lblDataInicio = New System.Windows.Forms.Label()
        Me.lblDataFinal = New System.Windows.Forms.Label()
        Me.dtDataFinal = New System.Windows.Forms.DateTimePicker()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtDataInicio
        '
        Me.dtDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDataInicio.Location = New System.Drawing.Point(454, 11)
        Me.dtDataInicio.Name = "dtDataInicio"
        Me.dtDataInicio.Size = New System.Drawing.Size(131, 20)
        Me.dtDataInicio.TabIndex = 113
        '
        'rbData
        '
        Me.rbData.AutoSize = True
        Me.rbData.Location = New System.Drawing.Point(329, 10)
        Me.rbData.Name = "rbData"
        Me.rbData.Size = New System.Drawing.Size(48, 17)
        Me.rbData.TabIndex = 111
        Me.rbData.TabStop = True
        Me.rbData.Text = "Data"
        Me.rbData.UseVisualStyleBackColor = True
        '
        'cbEntrada
        '
        Me.cbEntrada.FormattingEnabled = True
        Me.cbEntrada.Items.AddRange(New Object() {"Entrada", "Saída"})
        Me.cbEntrada.Location = New System.Drawing.Point(456, 10)
        Me.cbEntrada.Name = "cbEntrada"
        Me.cbEntrada.Size = New System.Drawing.Size(129, 21)
        Me.cbEntrada.TabIndex = 107
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(21, 77)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(564, 180)
        Me.dg.TabIndex = 106
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(151, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "Buscar:"
        '
        'rbEntrada
        '
        Me.rbEntrada.AutoSize = True
        Me.rbEntrada.Location = New System.Drawing.Point(212, 11)
        Me.rbEntrada.Name = "rbEntrada"
        Me.rbEntrada.Size = New System.Drawing.Size(102, 17)
        Me.rbEntrada.TabIndex = 109
        Me.rbEntrada.TabStop = True
        Me.rbEntrada.Text = "Entrada / Saída"
        Me.rbEntrada.UseVisualStyleBackColor = True
        '
        'lblDataInicio
        '
        Me.lblDataInicio.AutoSize = True
        Me.lblDataInicio.Location = New System.Drawing.Point(407, 14)
        Me.lblDataInicio.Name = "lblDataInicio"
        Me.lblDataInicio.Size = New System.Drawing.Size(35, 13)
        Me.lblDataInicio.TabIndex = 114
        Me.lblDataInicio.Text = "Inicio:"
        '
        'lblDataFinal
        '
        Me.lblDataFinal.AutoSize = True
        Me.lblDataFinal.Location = New System.Drawing.Point(407, 43)
        Me.lblDataFinal.Name = "lblDataFinal"
        Me.lblDataFinal.Size = New System.Drawing.Size(32, 13)
        Me.lblDataFinal.TabIndex = 115
        Me.lblDataFinal.Text = "Final:"
        '
        'dtDataFinal
        '
        Me.dtDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDataFinal.Location = New System.Drawing.Point(454, 37)
        Me.dtDataFinal.Name = "dtDataFinal"
        Me.dtDataFinal.Size = New System.Drawing.Size(131, 20)
        Me.dtDataFinal.TabIndex = 116
        '
        'ConsultaEstoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(613, 278)
        Me.Controls.Add(Me.dtDataFinal)
        Me.Controls.Add(Me.lblDataFinal)
        Me.Controls.Add(Me.lblDataInicio)
        Me.Controls.Add(Me.dtDataInicio)
        Me.Controls.Add(Me.rbData)
        Me.Controls.Add(Me.rbEntrada)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbEntrada)
        Me.Controls.Add(Me.dg)
        Me.Name = "ConsultaEstoque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultas no Estoque"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtDataInicio As DateTimePicker
    Friend WithEvents rbData As RadioButton
    Friend WithEvents cbEntrada As ComboBox
    Friend WithEvents dg As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents rbEntrada As RadioButton
    Friend WithEvents lblDataInicio As Label
    Friend WithEvents lblDataFinal As Label
    Friend WithEvents dtDataFinal As DateTimePicker
End Class
