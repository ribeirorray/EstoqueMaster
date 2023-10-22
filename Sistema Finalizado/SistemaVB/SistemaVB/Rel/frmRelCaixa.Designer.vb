<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRelCaixa
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbFunc = New System.Windows.Forms.ComboBox()
        Me.dt = New System.Windows.Forms.DateTimePicker()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.CaixaaDataSet = New SistemaVB.CaixaaDataSet()
        Me.CaixaaDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CaixaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CaixaTableAdapter = New SistemaVB.CaixaaDataSetTableAdapters.caixaTableAdapter()
        CType(Me.CaixaaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CaixaaDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CaixaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(574, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(330, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Funcionário:"
        '
        'cbFunc
        '
        Me.cbFunc.FormattingEnabled = True
        Me.cbFunc.Location = New System.Drawing.Point(401, 12)
        Me.cbFunc.Name = "cbFunc"
        Me.cbFunc.Size = New System.Drawing.Size(121, 21)
        Me.cbFunc.TabIndex = 2
        '
        'dt
        '
        Me.dt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt.Location = New System.Drawing.Point(614, 12)
        Me.dt.Name = "dt"
        Me.dt.Size = New System.Drawing.Size(87, 20)
        Me.dt.TabIndex = 3
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.CaixaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SistemaVB.RelCaixa.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(13, 56)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(688, 382)
        Me.ReportViewer1.TabIndex = 4
        '
        'CaixaaDataSet
        '
        Me.CaixaaDataSet.DataSetName = "CaixaaDataSet"
        Me.CaixaaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CaixaaDataSetBindingSource
        '
        Me.CaixaaDataSetBindingSource.DataSource = Me.CaixaaDataSet
        Me.CaixaaDataSetBindingSource.Position = 0
        '
        'CaixaBindingSource
        '
        Me.CaixaBindingSource.DataMember = "caixa"
        Me.CaixaBindingSource.DataSource = Me.CaixaaDataSetBindingSource
        '
        'CaixaTableAdapter
        '
        Me.CaixaTableAdapter.ClearBeforeFill = True
        '
        'frmRelCaixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(719, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.dt)
        Me.Controls.Add(Me.cbFunc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRelCaixa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório Final de Caixa"
        CType(Me.CaixaaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CaixaaDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CaixaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbFunc As ComboBox
    Friend WithEvents dt As DateTimePicker
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CaixaaDataSetBindingSource As BindingSource
    Friend WithEvents CaixaaDataSet As CaixaaDataSet
    Friend WithEvents CaixaBindingSource As BindingSource
    Friend WithEvents CaixaTableAdapter As CaixaaDataSetTableAdapters.caixaTableAdapter
End Class
