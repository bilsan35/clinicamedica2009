<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.GeralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AdministraçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FinanceiroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConfiguraçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UsuáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PacientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MédicosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SecretáriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FornecedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConvêniosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CirurgiasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LeitosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MateriaisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ContasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RelatóriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnPacientes = New System.Windows.Forms.ToolStripButton
        Me.btnMedicos = New System.Windows.Forms.ToolStripButton
        Me.btnSecretarias = New System.Windows.Forms.ToolStripButton
        Me.btnFornecedores = New System.Windows.Forms.ToolStripButton
        Me.btnConsultas = New System.Windows.Forms.ToolStripButton
        Me.btnCirurgias = New System.Windows.Forms.ToolStripButton
        Me.btnConvenios = New System.Windows.Forms.ToolStripButton
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PlanosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GeralToolStripMenuItem, Me.AdministraçãoToolStripMenuItem, Me.FinanceiroToolStripMenuItem, Me.ConfiguraçõesToolStripMenuItem, Me.AjudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(594, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GeralToolStripMenuItem
        '
        Me.GeralToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PacientesToolStripMenuItem, Me.MédicosToolStripMenuItem, Me.SecretáriasToolStripMenuItem, Me.FornecedoresToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.GeralToolStripMenuItem.Name = "GeralToolStripMenuItem"
        Me.GeralToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.GeralToolStripMenuItem.Text = "&Geral"
        '
        'AdministraçãoToolStripMenuItem
        '
        Me.AdministraçãoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConvêniosToolStripMenuItem, Me.ConsultasToolStripMenuItem, Me.CirurgiasToolStripMenuItem, Me.LeitosToolStripMenuItem, Me.MateriaisToolStripMenuItem, Me.PlanosToolStripMenuItem})
        Me.AdministraçãoToolStripMenuItem.Name = "AdministraçãoToolStripMenuItem"
        Me.AdministraçãoToolStripMenuItem.Size = New System.Drawing.Size(96, 20)
        Me.AdministraçãoToolStripMenuItem.Text = "A&dministração"
        '
        'FinanceiroToolStripMenuItem
        '
        Me.FinanceiroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContasToolStripMenuItem, Me.RelatóriosToolStripMenuItem})
        Me.FinanceiroToolStripMenuItem.Name = "FinanceiroToolStripMenuItem"
        Me.FinanceiroToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.FinanceiroToolStripMenuItem.Text = "&Financeiro"
        '
        'ConfiguraçõesToolStripMenuItem
        '
        Me.ConfiguraçõesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuáriosToolStripMenuItem})
        Me.ConfiguraçõesToolStripMenuItem.Name = "ConfiguraçõesToolStripMenuItem"
        Me.ConfiguraçõesToolStripMenuItem.Size = New System.Drawing.Size(96, 20)
        Me.ConfiguraçõesToolStripMenuItem.Text = "&Configurações"
        '
        'AjudaToolStripMenuItem
        '
        Me.AjudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem})
        Me.AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
        Me.AjudaToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.AjudaToolStripMenuItem.Text = "&Ajuda"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'UsuáriosToolStripMenuItem
        '
        Me.UsuáriosToolStripMenuItem.Name = "UsuáriosToolStripMenuItem"
        Me.UsuáriosToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.UsuáriosToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.UsuáriosToolStripMenuItem.Text = "Usuários"
        '
        'PacientesToolStripMenuItem
        '
        Me.PacientesToolStripMenuItem.Name = "PacientesToolStripMenuItem"
        Me.PacientesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PacientesToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.PacientesToolStripMenuItem.Text = "Pacientes"
        '
        'MédicosToolStripMenuItem
        '
        Me.MédicosToolStripMenuItem.Name = "MédicosToolStripMenuItem"
        Me.MédicosToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.MédicosToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.MédicosToolStripMenuItem.Text = "Médicos"
        '
        'SecretáriasToolStripMenuItem
        '
        Me.SecretáriasToolStripMenuItem.Name = "SecretáriasToolStripMenuItem"
        Me.SecretáriasToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SecretáriasToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.SecretáriasToolStripMenuItem.Text = "Secretárias"
        '
        'FornecedoresToolStripMenuItem
        '
        Me.FornecedoresToolStripMenuItem.Name = "FornecedoresToolStripMenuItem"
        Me.FornecedoresToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FornecedoresToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.FornecedoresToolStripMenuItem.Text = "Fornecedores"
        '
        'ConvêniosToolStripMenuItem
        '
        Me.ConvêniosToolStripMenuItem.Name = "ConvêniosToolStripMenuItem"
        Me.ConvêniosToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.ConvêniosToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ConvêniosToolStripMenuItem.Text = "Convênios"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'CirurgiasToolStripMenuItem
        '
        Me.CirurgiasToolStripMenuItem.Name = "CirurgiasToolStripMenuItem"
        Me.CirurgiasToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CirurgiasToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.CirurgiasToolStripMenuItem.Text = "Cirurgias"
        '
        'LeitosToolStripMenuItem
        '
        Me.LeitosToolStripMenuItem.Name = "LeitosToolStripMenuItem"
        Me.LeitosToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LeitosToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.LeitosToolStripMenuItem.Text = "Leitos"
        '
        'MateriaisToolStripMenuItem
        '
        Me.MateriaisToolStripMenuItem.Name = "MateriaisToolStripMenuItem"
        Me.MateriaisToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.MateriaisToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.MateriaisToolStripMenuItem.Text = "Materiais"
        '
        'ContasToolStripMenuItem
        '
        Me.ContasToolStripMenuItem.Name = "ContasToolStripMenuItem"
        Me.ContasToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.ContasToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ContasToolStripMenuItem.Text = "Contas"
        '
        'RelatóriosToolStripMenuItem
        '
        Me.RelatóriosToolStripMenuItem.Name = "RelatóriosToolStripMenuItem"
        Me.RelatóriosToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.RelatóriosToolStripMenuItem.Text = "Relatórios"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 427)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(594, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackgroundImage = CType(resources.GetObject("ToolStrip1.BackgroundImage"), System.Drawing.Image)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnMedicos, Me.btnPacientes, Me.btnSecretarias, Me.btnFornecedores, Me.btnConsultas, Me.btnCirurgias, Me.btnConvenios})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(594, 70)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnPacientes
        '
        Me.btnPacientes.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPacientes.Image = CType(resources.GetObject("btnPacientes.Image"), System.Drawing.Image)
        Me.btnPacientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnPacientes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPacientes.Name = "btnPacientes"
        Me.btnPacientes.Size = New System.Drawing.Size(64, 67)
        Me.btnPacientes.Text = "Pacientes"
        Me.btnPacientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnMedicos
        '
        Me.btnMedicos.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMedicos.Image = CType(resources.GetObject("btnMedicos.Image"), System.Drawing.Image)
        Me.btnMedicos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnMedicos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMedicos.Name = "btnMedicos"
        Me.btnMedicos.Size = New System.Drawing.Size(57, 67)
        Me.btnMedicos.Text = "Médicos"
        Me.btnMedicos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnSecretarias
        '
        Me.btnSecretarias.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSecretarias.Image = CType(resources.GetObject("btnSecretarias.Image"), System.Drawing.Image)
        Me.btnSecretarias.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSecretarias.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSecretarias.Name = "btnSecretarias"
        Me.btnSecretarias.Size = New System.Drawing.Size(73, 67)
        Me.btnSecretarias.Text = "Secretárias"
        Me.btnSecretarias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnFornecedores
        '
        Me.btnFornecedores.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFornecedores.Image = CType(resources.GetObject("btnFornecedores.Image"), System.Drawing.Image)
        Me.btnFornecedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnFornecedores.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFornecedores.Name = "btnFornecedores"
        Me.btnFornecedores.Size = New System.Drawing.Size(87, 67)
        Me.btnFornecedores.Text = "Fornecedores"
        Me.btnFornecedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnConsultas
        '
        Me.btnConsultas.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultas.Image = CType(resources.GetObject("btnConsultas.Image"), System.Drawing.Image)
        Me.btnConsultas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnConsultas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnConsultas.Name = "btnConsultas"
        Me.btnConsultas.Size = New System.Drawing.Size(63, 67)
        Me.btnConsultas.Text = "Consultas"
        Me.btnConsultas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnCirurgias
        '
        Me.btnCirurgias.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCirurgias.Image = CType(resources.GetObject("btnCirurgias.Image"), System.Drawing.Image)
        Me.btnCirurgias.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnCirurgias.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCirurgias.Name = "btnCirurgias"
        Me.btnCirurgias.Size = New System.Drawing.Size(59, 67)
        Me.btnCirurgias.Text = "Cirurgias"
        Me.btnCirurgias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnConvenios
        '
        Me.btnConvenios.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvenios.Image = CType(resources.GetObject("btnConvenios.Image"), System.Drawing.Image)
        Me.btnConvenios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnConvenios.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnConvenios.Name = "btnConvenios"
        Me.btnConvenios.Size = New System.Drawing.Size(68, 67)
        Me.btnConvenios.Text = "Convênios"
        Me.btnConvenios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'PlanosToolStripMenuItem
        '
        Me.PlanosToolStripMenuItem.Name = "PlanosToolStripMenuItem"
        Me.PlanosToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.PlanosToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.PlanosToolStripMenuItem.Text = "Planos"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 449)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "DOCTORCLIN - SISTEMA DE GESTÃO DE CLÍNICA MÉDICA"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GeralToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministraçãoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PacientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MédicosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SecretáriasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FinanceiroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguraçõesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuáriosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FornecedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConvêniosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CirurgiasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LeitosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MateriaisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RelatóriosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnPacientes As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMedicos As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSecretarias As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnFornecedores As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnConsultas As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCirurgias As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnConvenios As System.Windows.Forms.ToolStripButton
    Friend WithEvents SairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlanosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
