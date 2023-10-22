<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vendas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vendas))
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.cbProduto = New System.Windows.Forms.ComboBox()
        Me.cbCliente = New System.Windows.Forms.ComboBox()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.txtEstoque = New System.Windows.Forms.TextBox()
        Me.txtQuantVendida = New System.Windows.Forms.TextBox()
        Me.txtCodBarras = New System.Windows.Forms.TextBox()
        Me.btnRel = New System.Windows.Forms.Button()
        Me.imagem = New System.Windows.Forms.PictureBox()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblTotalUnit = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblTotalFinal = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblTroco = New System.Windows.Forms.Label()
        Me.txtDesconto = New System.Windows.Forms.TextBox()
        Me.txtValorReceb = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(82, 5)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(41, 20)
        Me.txtCodigo.TabIndex = 104
        Me.txtCodigo.Visible = False
        '
        'txtValor
        '
        Me.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtValor.Enabled = False
        Me.txtValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 23.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.Location = New System.Drawing.Point(448, 414)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(183, 35)
        Me.txtValor.TabIndex = 90
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(981, 157)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(28, 39)
        Me.lblTotal.TabIndex = 101
        Me.lblTotal.Text = "-"
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(12, 68)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(416, 462)
        Me.dg.TabIndex = 96
        '
        'txtQuantidade
        '
        Me.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtQuantidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 23.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantidade.Location = New System.Drawing.Point(448, 340)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(183, 35)
        Me.txtQuantidade.TabIndex = 3
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(777, 5)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(129, 20)
        Me.txtBuscar.TabIndex = 92
        Me.txtBuscar.Visible = False
        '
        'cbProduto
        '
        Me.cbProduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProduto.FormattingEnabled = True
        Me.cbProduto.Location = New System.Drawing.Point(445, 170)
        Me.cbProduto.Name = "cbProduto"
        Me.cbProduto.Size = New System.Drawing.Size(465, 37)
        Me.cbProduto.TabIndex = 1
        '
        'cbCliente
        '
        Me.cbCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCliente.FormattingEnabled = True
        Me.cbCliente.Location = New System.Drawing.Point(445, 248)
        Me.cbCliente.Name = "cbCliente"
        Me.cbCliente.Size = New System.Drawing.Size(465, 37)
        Me.cbCliente.TabIndex = 2
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(221, 5)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(61, 20)
        Me.txtNum.TabIndex = 105
        Me.txtNum.Visible = False
        '
        'txtEstoque
        '
        Me.txtEstoque.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEstoque.Enabled = False
        Me.txtEstoque.Font = New System.Drawing.Font("Microsoft Sans Serif", 23.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstoque.Location = New System.Drawing.Point(448, 497)
        Me.txtEstoque.Name = "txtEstoque"
        Me.txtEstoque.Size = New System.Drawing.Size(183, 35)
        Me.txtEstoque.TabIndex = 107
        '
        'txtQuantVendida
        '
        Me.txtQuantVendida.Enabled = False
        Me.txtQuantVendida.Location = New System.Drawing.Point(139, 5)
        Me.txtQuantVendida.Name = "txtQuantVendida"
        Me.txtQuantVendida.Size = New System.Drawing.Size(60, 20)
        Me.txtQuantVendida.TabIndex = 111
        Me.txtQuantVendida.Visible = False
        '
        'txtCodBarras
        '
        Me.txtCodBarras.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodBarras.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodBarras.Location = New System.Drawing.Point(448, 76)
        Me.txtCodBarras.Name = "txtCodBarras"
        Me.txtCodBarras.Size = New System.Drawing.Size(458, 31)
        Me.txtCodBarras.TabIndex = 112
        '
        'btnRel
        '
        Me.btnRel.BackColor = System.Drawing.Color.Transparent
        Me.btnRel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRel.FlatAppearance.BorderSize = 0
        Me.btnRel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btnRel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRel.Image = CType(resources.GetObject("btnRel.Image"), System.Drawing.Image)
        Me.btnRel.Location = New System.Drawing.Point(328, 536)
        Me.btnRel.Name = "btnRel"
        Me.btnRel.Size = New System.Drawing.Size(65, 65)
        Me.btnRel.TabIndex = 110
        Me.btnRel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRel.UseVisualStyleBackColor = False
        '
        'imagem
        '
        Me.imagem.Location = New System.Drawing.Point(679, 340)
        Me.imagem.Name = "imagem"
        Me.imagem.Size = New System.Drawing.Size(190, 190)
        Me.imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imagem.TabIndex = 109
        Me.imagem.TabStop = False
        '
        'btnExcluir
        '
        Me.btnExcluir.BackColor = System.Drawing.Color.Transparent
        Me.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluir.FlatAppearance.BorderSize = 0
        Me.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.Location = New System.Drawing.Point(232, 536)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(65, 65)
        Me.btnExcluir.TabIndex = 100
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'btnSalvar
        '
        Me.btnSalvar.BackColor = System.Drawing.Color.Transparent
        Me.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalvar.FlatAppearance.BorderSize = 0
        Me.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.Location = New System.Drawing.Point(148, 536)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(60, 60)
        Me.btnSalvar.TabIndex = 98
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'btnNovo
        '
        Me.btnNovo.BackColor = System.Drawing.Color.Transparent
        Me.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNovo.FlatAppearance.BorderSize = 0
        Me.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovo.Image = CType(resources.GetObject("btnNovo.Image"), System.Drawing.Image)
        Me.btnNovo.Location = New System.Drawing.Point(66, 536)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(60, 60)
        Me.btnNovo.TabIndex = 97
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNovo.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(918, 159)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 39)
        Me.Label8.TabIndex = 113
        Me.Label8.Text = "R$"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(914, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 39)
        Me.Label9.TabIndex = 115
        Me.Label9.Text = "R$"
        '
        'lblTotalUnit
        '
        Me.lblTotalUnit.AutoSize = True
        Me.lblTotalUnit.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalUnit.Location = New System.Drawing.Point(977, 66)
        Me.lblTotalUnit.Name = "lblTotalUnit"
        Me.lblTotalUnit.Size = New System.Drawing.Size(28, 39)
        Me.lblTotalUnit.TabIndex = 114
        Me.lblTotalUnit.Text = "-"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(918, 340)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 39)
        Me.Label10.TabIndex = 117
        Me.Label10.Text = "R$"
        '
        'lblTotalFinal
        '
        Me.lblTotalFinal.AutoSize = True
        Me.lblTotalFinal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalFinal.ForeColor = System.Drawing.Color.Green
        Me.lblTotalFinal.Location = New System.Drawing.Point(981, 338)
        Me.lblTotalFinal.Name = "lblTotalFinal"
        Me.lblTotalFinal.Size = New System.Drawing.Size(28, 39)
        Me.lblTotalFinal.TabIndex = 116
        Me.lblTotalFinal.Text = "-"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(918, 539)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 39)
        Me.Label13.TabIndex = 119
        Me.Label13.Text = "R$"
        '
        'lblTroco
        '
        Me.lblTroco.AutoSize = True
        Me.lblTroco.BackColor = System.Drawing.Color.Transparent
        Me.lblTroco.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTroco.ForeColor = System.Drawing.Color.Red
        Me.lblTroco.Location = New System.Drawing.Point(981, 537)
        Me.lblTroco.Name = "lblTroco"
        Me.lblTroco.Size = New System.Drawing.Size(28, 39)
        Me.lblTroco.TabIndex = 118
        Me.lblTroco.Text = "-"
        '
        'txtDesconto
        '
        Me.txtDesconto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDesconto.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesconto.Location = New System.Drawing.Point(977, 245)
        Me.txtDesconto.Name = "txtDesconto"
        Me.txtDesconto.Size = New System.Drawing.Size(198, 38)
        Me.txtDesconto.TabIndex = 120
        '
        'txtValorReceb
        '
        Me.txtValorReceb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtValorReceb.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorReceb.Location = New System.Drawing.Point(977, 427)
        Me.txtValorReceb.Name = "txtValorReceb"
        Me.txtValorReceb.Size = New System.Drawing.Size(195, 38)
        Me.txtValorReceb.TabIndex = 121
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(923, 427)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(51, 38)
        Me.TextBox1.TabIndex = 122
        Me.TextBox1.Text = "R$"
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(925, 248)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(51, 38)
        Me.TextBox2.TabIndex = 123
        Me.TextBox2.Text = "R$"
        '
        'Vendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1200, 618)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtValorReceb)
        Me.Controls.Add(Me.txtDesconto)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblTroco)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblTotalFinal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblTotalUnit)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCodBarras)
        Me.Controls.Add(Me.txtQuantVendida)
        Me.Controls.Add(Me.btnRel)
        Me.Controls.Add(Me.imagem)
        Me.Controls.Add(Me.txtEstoque)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.cbCliente)
        Me.Controls.Add(Me.cbProduto)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.txtQuantidade)
        Me.Controls.Add(Me.txtBuscar)
        Me.Name = "Vendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vendas"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtValor As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents dg As DataGridView
    Friend WithEvents txtQuantidade As TextBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents cbProduto As ComboBox
    Friend WithEvents cbCliente As ComboBox
    Friend WithEvents txtNum As TextBox
    Friend WithEvents txtEstoque As TextBox
    Friend WithEvents imagem As PictureBox
    Friend WithEvents btnRel As Button
    Friend WithEvents txtQuantVendida As TextBox
    Friend WithEvents txtCodBarras As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblTotalUnit As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblTotalFinal As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblTroco As Label
    Friend WithEvents txtDesconto As TextBox
    Friend WithEvents txtValorReceb As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
