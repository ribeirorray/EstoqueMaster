Imports Bunifu.Framework.UI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NovoLogin
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
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NovoLogin))
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtusuario = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtsenha = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.btnlogin = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.IconButton4 = New FontAwesome.Sharp.IconButton()
        Me.labelmenor = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IconButton2
        '
        Me.IconButton2.BackColor = System.Drawing.Color.Transparent
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.IconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.Key
        Me.IconButton2.IconColor = System.Drawing.Color.Silver
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 27
        Me.IconButton2.Location = New System.Drawing.Point(564, 285)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(33, 29)
        Me.IconButton2.TabIndex = 39
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.Transparent
        Me.IconButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.IconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.UserAlt
        Me.IconButton1.IconColor = System.Drawing.Color.Silver
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 27
        Me.IconButton1.Location = New System.Drawing.Point(564, 217)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(33, 37)
        Me.IconButton1.TabIndex = 38
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(411, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 40)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Olá, novamente."
        '
        'txtusuario
        '
        Me.txtusuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtusuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txtusuario.BackColor = System.Drawing.Color.White
        Me.txtusuario.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtusuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtusuario.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtusuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtusuario.HintForeColor = System.Drawing.Color.Empty
        Me.txtusuario.HintText = "usuario"
        Me.txtusuario.isPassword = False
        Me.txtusuario.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtusuario.LineIdleColor = System.Drawing.Color.Gray
        Me.txtusuario.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtusuario.LineThickness = 1
        Me.txtusuario.Location = New System.Drawing.Point(419, 226)
        Me.txtusuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtusuario.MaxLength = 32767
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(189, 33)
        Me.txtusuario.TabIndex = 42
        Me.txtusuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtsenha
        '
        Me.txtsenha.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtsenha.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txtsenha.BackColor = System.Drawing.Color.White
        Me.txtsenha.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtsenha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsenha.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtsenha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtsenha.HintForeColor = System.Drawing.Color.Empty
        Me.txtsenha.HintText = "********"
        Me.txtsenha.isPassword = True
        Me.txtsenha.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtsenha.LineIdleColor = System.Drawing.Color.Gray
        Me.txtsenha.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtsenha.LineThickness = 1
        Me.txtsenha.Location = New System.Drawing.Point(419, 285)
        Me.txtsenha.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsenha.MaxLength = 32767
        Me.txtsenha.Name = "txtsenha"
        Me.txtsenha.Size = New System.Drawing.Size(189, 33)
        Me.txtsenha.TabIndex = 43
        Me.txtsenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me
        Me.BunifuDragControl1.Vertical = True
        '
        'btnlogin
        '
        Me.btnlogin.AllowToggling = False
        Me.btnlogin.AnimationSpeed = 200
        Me.btnlogin.AutoGenerateColors = False
        Me.btnlogin.BackColor = System.Drawing.Color.Transparent
        Me.btnlogin.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btnlogin.BackgroundImage = CType(resources.GetObject("btnlogin.BackgroundImage"), System.Drawing.Image)
        Me.btnlogin.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnlogin.ButtonText = "Login"
        Me.btnlogin.ButtonTextMarginLeft = 0
        Me.btnlogin.ColorContrastOnClick = 45
        Me.btnlogin.ColorContrastOnHover = 45
        Me.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.btnlogin.CustomizableEdges = BorderEdges1
        Me.btnlogin.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnlogin.DisabledBorderColor = System.Drawing.Color.Empty
        Me.btnlogin.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnlogin.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnlogin.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btnlogin.Font = New System.Drawing.Font("Ebrima", 9.75!)
        Me.btnlogin.ForeColor = System.Drawing.Color.White
        Me.btnlogin.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.btnlogin.IconMarginLeft = 11
        Me.btnlogin.IconPadding = 10
        Me.btnlogin.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.btnlogin.IdleBorderColor = System.Drawing.Color.White
        Me.btnlogin.IdleBorderRadius = 3
        Me.btnlogin.IdleBorderThickness = 1
        Me.btnlogin.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btnlogin.IdleIconLeftImage = Nothing
        Me.btnlogin.IdleIconRightImage = Nothing
        Me.btnlogin.IndicateFocus = False
        Me.btnlogin.Location = New System.Drawing.Point(430, 352)
        Me.btnlogin.Name = "btnlogin"
        StateProperties1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(244, Byte), Integer))
        StateProperties1.BorderRadius = 3
        StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties1.BorderThickness = 1
        StateProperties1.FillColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(114, Byte), Integer))
        StateProperties1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(244, Byte), Integer))
        StateProperties1.IconLeftImage = Nothing
        StateProperties1.IconRightImage = Nothing
        Me.btnlogin.onHoverState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(244, Byte), Integer))
        StateProperties2.BorderRadius = 3
        StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties2.BorderThickness = 1
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(114, Byte), Integer))
        StateProperties2.ForeColor = System.Drawing.Color.White
        StateProperties2.IconLeftImage = Nothing
        StateProperties2.IconRightImage = Nothing
        Me.btnlogin.OnPressedState = StateProperties2
        Me.btnlogin.Size = New System.Drawing.Size(167, 45)
        Me.btnlogin.TabIndex = 40
        Me.btnlogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnlogin.TextMarginLeft = 0
        Me.btnlogin.UseDefaultRadiusAndThickness = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = Global.SistemaVB.My.Resources.Resources.logologin
        Me.PictureBox1.Location = New System.Drawing.Point(463, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(101, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'IconButton4
        '
        Me.IconButton4.BackColor = System.Drawing.Color.White
        Me.IconButton4.FlatAppearance.BorderSize = 0
        Me.IconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton4.IconChar = FontAwesome.Sharp.IconChar.TimesCircle
        Me.IconButton4.IconColor = System.Drawing.Color.Black
        Me.IconButton4.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton4.IconSize = 35
        Me.IconButton4.Location = New System.Drawing.Point(593, 1)
        Me.IconButton4.Name = "IconButton4"
        Me.IconButton4.Size = New System.Drawing.Size(42, 39)
        Me.IconButton4.TabIndex = 220
        Me.IconButton4.UseVisualStyleBackColor = False
        '
        'labelmenor
        '
        Me.labelmenor.AutoSize = True
        Me.labelmenor.BackColor = System.Drawing.Color.Transparent
        Me.labelmenor.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelmenor.ForeColor = System.Drawing.Color.Gray
        Me.labelmenor.Location = New System.Drawing.Point(460, 140)
        Me.labelmenor.Name = "labelmenor"
        Me.labelmenor.Size = New System.Drawing.Size(137, 26)
        Me.labelmenor.TabIndex = 221
        Me.labelmenor.Text = "Faça login para ter acesso " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "novamente ao sistema."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(12, 424)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(346, 17)
        Me.Label1.TabIndex = 222
        Me.Label1.Text = "Todos os direitos reservados ©2023 Rayane Nascimento."
        '
        'NovoLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(637, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.labelmenor)
        Me.Controls.Add(Me.IconButton4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.IconButton2)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.txtsenha)
        Me.Controls.Add(Me.txtusuario)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "NovoLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NovoLogin"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Label2 As Label
    Friend WithEvents txtusuario As BunifuMaterialTextbox
    Friend WithEvents txtsenha As BunifuMaterialTextbox
    Friend WithEvents BunifuElipse1 As BunifuElipse
    Friend WithEvents btnlogin As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuDragControl1 As BunifuDragControl
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents labelmenor As Label
    Friend WithEvents Label1 As Label
End Class
