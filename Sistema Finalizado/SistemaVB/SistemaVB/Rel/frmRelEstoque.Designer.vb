<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRelEstoque
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.dtDataFinal = New System.Windows.Forms.DateTimePicker()
        Me.lblDataFinal = New System.Windows.Forms.Label()
        Me.lblDataInicio = New System.Windows.Forms.Label()
        Me.dtDataInicio = New System.Windows.Forms.DateTimePicker()
        Me.rbData = New System.Windows.Forms.RadioButton()
        Me.rbEntrada = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbEntrada = New System.Windows.Forms.ComboBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.EstoquePorDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.estoquesDataSet = New SistemaVB.estoquesDataSet()
        Me.BuscarEntradasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuscarSaidasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstoquePorDataTableAdapter = New SistemaVB.estoquesDataSetTableAdapters.EstoquePorDataTableAdapter()
        Me.BuscarEntradasTableAdapter = New SistemaVB.estoquesDataSetTableAdapters.BuscarEntradasTableAdapter()
        Me.BuscarSaidasTableAdapter = New SistemaVB.estoquesDataSetTableAdapters.BuscarSaidasTableAdapter()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BuscarEntradasSaidasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuscarEntradasSaidasTableAdapter = New SistemaVB.estoquesDataSetTableAdapters.BuscarEntradasSaidasTableAdapter()
        CType(Me.EstoquePorDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.estoquesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuscarEntradasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuscarSaidasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuscarEntradasSaidasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtDataFinal
        '
        Me.dtDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDataFinal.Location = New System.Drawing.Point(555, 48)
        Me.dtDataFinal.Name = "dtDataFinal"
        Me.dtDataFinal.Size = New System.Drawing.Size(131, 20)
        Me.dtDataFinal.TabIndex = 124
        '
        'lblDataFinal
        '
        Me.lblDataFinal.AutoSize = True
        Me.lblDataFinal.Location = New System.Drawing.Point(508, 54)
        Me.lblDataFinal.Name = "lblDataFinal"
        Me.lblDataFinal.Size = New System.Drawing.Size(32, 13)
        Me.lblDataFinal.TabIndex = 123
        Me.lblDataFinal.Text = "Final:"
        '
        'lblDataInicio
        '
        Me.lblDataInicio.AutoSize = True
        Me.lblDataInicio.Location = New System.Drawing.Point(508, 25)
        Me.lblDataInicio.Name = "lblDataInicio"
        Me.lblDataInicio.Size = New System.Drawing.Size(35, 13)
        Me.lblDataInicio.TabIndex = 122
        Me.lblDataInicio.Text = "Inicio:"
        '
        'dtDataInicio
        '
        Me.dtDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDataInicio.Location = New System.Drawing.Point(555, 21)
        Me.dtDataInicio.Name = "dtDataInicio"
        Me.dtDataInicio.Size = New System.Drawing.Size(131, 20)
        Me.dtDataInicio.TabIndex = 121
        '
        'rbData
        '
        Me.rbData.AutoSize = True
        Me.rbData.Location = New System.Drawing.Point(430, 21)
        Me.rbData.Name = "rbData"
        Me.rbData.Size = New System.Drawing.Size(48, 17)
        Me.rbData.TabIndex = 120
        Me.rbData.TabStop = True
        Me.rbData.Text = "Data"
        Me.rbData.UseVisualStyleBackColor = True
        '
        'rbEntrada
        '
        Me.rbEntrada.AutoSize = True
        Me.rbEntrada.Location = New System.Drawing.Point(313, 22)
        Me.rbEntrada.Name = "rbEntrada"
        Me.rbEntrada.Size = New System.Drawing.Size(102, 17)
        Me.rbEntrada.TabIndex = 119
        Me.rbEntrada.TabStop = True
        Me.rbEntrada.Text = "Entrada / Saída"
        Me.rbEntrada.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(252, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 118
        Me.Label1.Text = "Buscar:"
        '
        'cbEntrada
        '
        Me.cbEntrada.FormattingEnabled = True
        Me.cbEntrada.Items.AddRange(New Object() {"Entrada", "Saída"})
        Me.cbEntrada.Location = New System.Drawing.Point(313, 47)
        Me.cbEntrada.Name = "cbEntrada"
        Me.cbEntrada.Size = New System.Drawing.Size(129, 21)
        Me.cbEntrada.TabIndex = 117
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.EstoquePorDataBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.BuscarEntradasBindingSource
        ReportDataSource3.Name = "DataSet3"
        ReportDataSource3.Value = Me.BuscarSaidasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SistemaVB.RelEstoqueData.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 96)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(674, 431)
        Me.ReportViewer1.TabIndex = 125
        '
        'EstoquePorDataBindingSource
        '
        Me.EstoquePorDataBindingSource.DataMember = "EstoquePorData"
        Me.EstoquePorDataBindingSource.DataSource = Me.estoquesDataSet
        '
        'estoquesDataSet
        '
        Me.estoquesDataSet.DataSetName = "estoquesDataSet"
        Me.estoquesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BuscarEntradasBindingSource
        '
        Me.BuscarEntradasBindingSource.DataMember = "BuscarEntradas"
        Me.BuscarEntradasBindingSource.DataSource = Me.estoquesDataSet
        '
        'BuscarSaidasBindingSource
        '
        Me.BuscarSaidasBindingSource.DataMember = "BuscarSaidas"
        Me.BuscarSaidasBindingSource.DataSource = Me.estoquesDataSet
        '
        'EstoquePorDataTableAdapter
        '
        Me.EstoquePorDataTableAdapter.ClearBeforeFill = True
        '
        'BuscarEntradasTableAdapter
        '
        Me.BuscarEntradasTableAdapter.ClearBeforeFill = True
        '
        'BuscarSaidasTableAdapter
        '
        Me.BuscarSaidasTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer2
        '
        ReportDataSource4.Name = "DataSet1"
        ReportDataSource4.Value = Me.BuscarEntradasSaidasBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "SistemaVB.RelEntradaSaida.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(13, 96)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.ServerReport.BearerToken = Nothing
        Me.ReportViewer2.Size = New System.Drawing.Size(673, 431)
        Me.ReportViewer2.TabIndex = 126
        '
        'BuscarEntradasSaidasBindingSource
        '
        Me.BuscarEntradasSaidasBindingSource.DataMember = "BuscarEntradasSaidas"
        Me.BuscarEntradasSaidasBindingSource.DataSource = Me.estoquesDataSet
        '
        'BuscarEntradasSaidasTableAdapter
        '
        Me.BuscarEntradasSaidasTableAdapter.ClearBeforeFill = True
        '
        'frmRelEstoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(702, 539)
        Me.Controls.Add(Me.ReportViewer2)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.dtDataFinal)
        Me.Controls.Add(Me.lblDataFinal)
        Me.Controls.Add(Me.lblDataInicio)
        Me.Controls.Add(Me.dtDataInicio)
        Me.Controls.Add(Me.rbData)
        Me.Controls.Add(Me.rbEntrada)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbEntrada)
        Me.Name = "frmRelEstoque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Entradas e Saídas"
        CType(Me.EstoquePorDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.estoquesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuscarEntradasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuscarSaidasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuscarEntradasSaidasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtDataFinal As DateTimePicker
    Friend WithEvents lblDataFinal As Label
    Friend WithEvents lblDataInicio As Label
    Friend WithEvents dtDataInicio As DateTimePicker
    Friend WithEvents rbData As RadioButton
    Friend WithEvents rbEntrada As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents cbEntrada As ComboBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents EstoquePorDataBindingSource As BindingSource
    Friend WithEvents estoquesDataSet As estoquesDataSet
    Friend WithEvents BuscarEntradasBindingSource As BindingSource
    Friend WithEvents BuscarSaidasBindingSource As BindingSource
    Friend WithEvents EstoquePorDataTableAdapter As estoquesDataSetTableAdapters.EstoquePorDataTableAdapter
    Friend WithEvents BuscarEntradasTableAdapter As estoquesDataSetTableAdapters.BuscarEntradasTableAdapter
    Friend WithEvents BuscarSaidasTableAdapter As estoquesDataSetTableAdapters.BuscarSaidasTableAdapter
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BuscarEntradasSaidasBindingSource As BindingSource
    Friend WithEvents BuscarEntradasSaidasTableAdapter As estoquesDataSetTableAdapters.BuscarEntradasSaidasTableAdapter
End Class
