<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrincipal
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        Me.tabMenu = New System.Windows.Forms.TabControl
        Me.tbGeral = New System.Windows.Forms.TabPage
        Me.tbAdministracao = New System.Windows.Forms.TabPage
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnMedicos = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.tbFinanceiro = New System.Windows.Forms.TabPage
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton10 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.tbConfiguracao = New System.Windows.Forms.TabPage
        Me.tabMenu.SuspendLayout()
        Me.tbGeral.SuspendLayout()
        Me.tbAdministracao.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabMenu
        '
        Me.tabMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMenu.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabMenu.Controls.Add(Me.tbGeral)
        Me.tabMenu.Controls.Add(Me.tbAdministracao)
        Me.tabMenu.Controls.Add(Me.tbFinanceiro)
        Me.tabMenu.Controls.Add(Me.tbConfiguracao)
        Me.tabMenu.Font = New System.Drawing.Font("Calibri", 9.25!)
        Me.tabMenu.ImageList = Me.ImageList1
        Me.tabMenu.Location = New System.Drawing.Point(0, 0)
        Me.tabMenu.Name = "tabMenu"
        Me.tabMenu.SelectedIndex = 0
        Me.tabMenu.Size = New System.Drawing.Size(591, 106)
        Me.tabMenu.TabIndex = 3
        '
        'tbGeral
        '
        Me.tbGeral.BackgroundImage = CType(resources.GetObject("tbGeral.BackgroundImage"), System.Drawing.Image)
        Me.tbGeral.Controls.Add(Me.ToolStrip1)
        Me.tbGeral.ImageIndex = 1
        Me.tbGeral.Location = New System.Drawing.Point(4, 26)
        Me.tbGeral.Name = "tbGeral"
        Me.tbGeral.Padding = New System.Windows.Forms.Padding(3)
        Me.tbGeral.Size = New System.Drawing.Size(583, 76)
        Me.tbGeral.TabIndex = 0
        Me.tbGeral.Text = "Geral"
        Me.tbGeral.UseVisualStyleBackColor = True
        '
        'tbAdministracao
        '
        Me.tbAdministracao.BackgroundImage = CType(resources.GetObject("tbAdministracao.BackgroundImage"), System.Drawing.Image)
        Me.tbAdministracao.Controls.Add(Me.ToolStrip2)
        Me.tbAdministracao.ImageIndex = 0
        Me.tbAdministracao.Location = New System.Drawing.Point(4, 26)
        Me.tbAdministracao.Name = "tbAdministracao"
        Me.tbAdministracao.Padding = New System.Windows.Forms.Padding(3)
        Me.tbAdministracao.Size = New System.Drawing.Size(583, 76)
        Me.tbAdministracao.TabIndex = 1
        Me.tbAdministracao.Text = "Administração"
        Me.tbAdministracao.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Font = New System.Drawing.Font("Calibri", 9.25!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnMedicos, Me.ToolStripButton5, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(577, 70)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnMedicos
        '
        Me.btnMedicos.Font = New System.Drawing.Font("Calibri", 9.25!, System.Drawing.FontStyle.Bold)
        Me.btnMedicos.Image = CType(resources.GetObject("btnMedicos.Image"), System.Drawing.Image)
        Me.btnMedicos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnMedicos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMedicos.Name = "btnMedicos"
        Me.btnMedicos.Size = New System.Drawing.Size(56, 67)
        Me.btnMedicos.Text = "Médicos"
        Me.btnMedicos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.Font = New System.Drawing.Font("Calibri", 9.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(63, 67)
        Me.ToolStripButton5.Text = "Pacientes"
        Me.ToolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Calibri", 9.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(52, 67)
        Me.ToolStripButton1.Text = "Agenda"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tbFinanceiro
        '
        Me.tbFinanceiro.ImageIndex = 3
        Me.tbFinanceiro.Location = New System.Drawing.Point(4, 26)
        Me.tbFinanceiro.Name = "tbFinanceiro"
        Me.tbFinanceiro.Padding = New System.Windows.Forms.Padding(3)
        Me.tbFinanceiro.Size = New System.Drawing.Size(583, 76)
        Me.tbFinanceiro.TabIndex = 2
        Me.tbFinanceiro.Text = "Financeiro"
        Me.tbFinanceiro.UseVisualStyleBackColor = True
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip2.Font = New System.Drawing.Font("Calibri", 9.25!)
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton7, Me.ToolStripButton10, Me.ToolStripButton4})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(577, 70)
        Me.ToolStrip2.TabIndex = 4
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.Font = New System.Drawing.Font("Calibri", 9.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(67, 67)
        Me.ToolStripButton7.Text = "Convênios"
        Me.ToolStripButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton10
        '
        Me.ToolStripButton10.Font = New System.Drawing.Font("Calibri", 9.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton10.Image = CType(resources.GetObject("ToolStripButton10.Image"), System.Drawing.Image)
        Me.ToolStripButton10.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton10.Name = "ToolStripButton10"
        Me.ToolStripButton10.Size = New System.Drawing.Size(52, 67)
        Me.ToolStripButton10.Text = "Leitos"
        Me.ToolStripButton10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Font = New System.Drawing.Font("Calibri", 9.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(58, 67)
        Me.ToolStripButton4.Text = "Cirurgias"
        Me.ToolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "acoes16x16.png")
        Me.ImageList1.Images.SetKeyName(1, "bairros16x16.png")
        Me.ImageList1.Images.SetKeyName(2, "manutencao16x16.png")
        Me.ImageList1.Images.SetKeyName(3, "orcamento16x16.png")
        '
        'tbConfiguracao
        '
        Me.tbConfiguracao.ImageIndex = 2
        Me.tbConfiguracao.Location = New System.Drawing.Point(4, 26)
        Me.tbConfiguracao.Name = "tbConfiguracao"
        Me.tbConfiguracao.Padding = New System.Windows.Forms.Padding(3)
        Me.tbConfiguracao.Size = New System.Drawing.Size(583, 76)
        Me.tbConfiguracao.TabIndex = 3
        Me.tbConfiguracao.Text = "Configurações"
        Me.tbConfiguracao.UseVisualStyleBackColor = True
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 446)
        Me.Controls.Add(Me.tabMenu)
        Me.IsMdiContainer = True
        Me.Name = "FormPrincipal"
        Me.Text = "SGCM - SISTEMA DE GESTÃO DE CLÍNICA MÉDICA"
        Me.tabMenu.ResumeLayout(False)
        Me.tbGeral.ResumeLayout(False)
        Me.tbGeral.PerformLayout()
        Me.tbAdministracao.ResumeLayout(False)
        Me.tbAdministracao.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabMenu As System.Windows.Forms.TabControl
    Friend WithEvents tbGeral As System.Windows.Forms.TabPage
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnMedicos As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbAdministracao As System.Windows.Forms.TabPage
    Friend WithEvents tbFinanceiro As System.Windows.Forms.TabPage
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton10 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents tbConfiguracao As System.Windows.Forms.TabPage
End Class
