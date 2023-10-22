<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelVendas
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ListaDeVendasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VendasDataSet = New SistemaVB.VendasDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dtData = New System.Windows.Forms.DateTimePicker()
        Me.cbFuncionario = New System.Windows.Forms.ComboBox()
        Me.ListaDeVendasTableAdapter = New SistemaVB.VendasDataSetTableAdapters.ListaDeVendasTableAdapter()
        CType(Me.ListaDeVendasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaDeVendasBindingSource
        '
        Me.ListaDeVendasBindingSource.DataMember = "ListaDeVendas"
        Me.ListaDeVendasBindingSource.DataSource = Me.VendasDataSet
        '
        'VendasDataSet
        '
        Me.VendasDataSet.DataSetName = "VendasDataSet"
        Me.VendasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ListaDeVendasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SistemaVB.RelVenda.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(27, 56)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(732, 369)
        Me.ReportViewer1.TabIndex = 0
        '
        'dtData
        '
        Me.dtData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtData.Location = New System.Drawing.Point(670, 12)
        Me.dtData.Name = "dtData"
        Me.dtData.Size = New System.Drawing.Size(89, 20)
        Me.dtData.TabIndex = 1
        '
        'cbFuncionario
        '
        Me.cbFuncionario.FormattingEnabled = True
        Me.cbFuncionario.Location = New System.Drawing.Point(530, 11)
        Me.cbFuncionario.Name = "cbFuncionario"
        Me.cbFuncionario.Size = New System.Drawing.Size(121, 21)
        Me.cbFuncionario.TabIndex = 2
        '
        'ListaDeVendasTableAdapter
        '
        Me.ListaDeVendasTableAdapter.ClearBeforeFill = True
        '
        'frmRelVendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cbFuncionario)
        Me.Controls.Add(Me.dtData)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmRelVendas"
        Me.Text = "frmRelVendas"
        CType(Me.ListaDeVendasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ListaDeVendasBindingSource As BindingSource
    Friend WithEvents VendasDataSet As VendasDataSet
    Friend WithEvents ListaDeVendasTableAdapter As VendasDataSetTableAdapters.ListaDeVendasTableAdapter
    Friend WithEvents dtData As DateTimePicker
    Friend WithEvents cbFuncionario As ComboBox
End Class
