<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.tabMenu = New System.Windows.Forms.TabControl
        Me.tbGeral = New System.Windows.Forms.TabPage
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnMedicos = New System.Windows.Forms.ToolStripButton
        Me.btnPacientes = New System.Windows.Forms.ToolStripButton
        Me.btnEnfermeiras = New System.Windows.Forms.ToolStripButton
        Me.btnSecretarias = New System.Windows.Forms.ToolStripButton
        Me.btnFornecedores = New System.Windows.Forms.ToolStripButton
        Me.tbAdministracao = New System.Windows.Forms.TabPage
        Me.ToolStrip6 = New System.Windows.Forms.ToolStrip
        Me.btnConvenios = New System.Windows.Forms.ToolStripButton
        Me.btnConsultas = New System.Windows.Forms.ToolStripButton
        Me.btnCirurgias = New System.Windows.Forms.ToolStripButton
        Me.btnLeitos = New System.Windows.Forms.ToolStripButton
        Me.btnMateriais = New System.Windows.Forms.ToolStripButton
        Me.btnAgenda = New System.Windows.Forms.ToolStripButton
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton10 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.tbFinanceiro = New System.Windows.Forms.TabPage
        Me.ToolStrip7 = New System.Windows.Forms.ToolStrip
        Me.btnRelatorios = New System.Windows.Forms.ToolStripButton
        Me.ToolStrip5 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton11 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton12 = New System.Windows.Forms.ToolStripButton
        Me.tbConfiguracao = New System.Windows.Forms.TabPage
        Me.ToolStrip8 = New System.Windows.Forms.ToolStrip
        Me.btnUsuarios = New System.Windows.Forms.ToolStripButton
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.tbAjuda = New System.Windows.Forms.TabPage
        Me.ToolStrip9 = New System.Windows.Forms.ToolStrip
        Me.btnInformacoes = New System.Windows.Forms.ToolStripButton
        Me.ToolStrip4 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton13 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton14 = New System.Windows.Forms.ToolStripButton
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.tabMenu.SuspendLayout()
        Me.tbGeral.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.tbAdministracao.SuspendLayout()
        Me.ToolStrip6.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.tbFinanceiro.SuspendLayout()
        Me.ToolStrip7.SuspendLayout()
        Me.ToolStrip5.SuspendLayout()
        Me.tbConfiguracao.SuspendLayout()
        Me.ToolStrip8.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        Me.tbAjuda.SuspendLayout()
        Me.ToolStrip9.SuspendLayout()
        Me.ToolStrip4.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabMenu
        '
        Me.tabMenu.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabMenu.Controls.Add(Me.tbGeral)
        Me.tabMenu.Controls.Add(Me.tbAdministracao)
        Me.tabMenu.Controls.Add(Me.tbFinanceiro)
        Me.tabMenu.Controls.Add(Me.tbConfiguracao)
        Me.tabMenu.Controls.Add(Me.tbAjuda)
        Me.tabMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.tabMenu.Font = New System.Drawing.Font("Calibri", 9.25!)
        Me.tabMenu.ImageList = Me.ImageList1
        Me.tabMenu.Location = New System.Drawing.Point(0, 0)
        Me.tabMenu.Name = "tabMenu"
        Me.tabMenu.SelectedIndex = 0
        Me.tabMenu.Size = New System.Drawing.Size(591, 106)
        Me.tabMenu.TabIndex = 4
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
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Font = New System.Drawing.Font("Calibri", 9.25!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnMedicos, Me.btnPacientes, Me.btnEnfermeiras, Me.btnSecretarias, Me.btnFornecedores})
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
        'btnPacientes
        '
        Me.btnPacientes.Font = New System.Drawing.Font("Calibri", 9.25!, System.Drawing.FontStyle.Bold)
        Me.btnPacientes.Image = CType(resources.GetObject("btnPacientes.Image"), System.Drawing.Image)
        Me.btnPacientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnPacientes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPacientes.Name = "btnPacientes"
        Me.btnPacientes.Size = New System.Drawing.Size(63, 67)
        Me.btnPacientes.Text = "Pacientes"
        Me.btnPacientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnEnfermeiras
        '
        Me.btnEnfermeiras.Font = New System.Drawing.Font("Calibri", 9.25!, System.Drawing.FontStyle.Bold)
        Me.btnEnfermeiras.Image = CType(resources.GetObject("btnEnfermeiras.Image"), System.Drawing.Image)
        Me.btnEnfermeiras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnEnfermeiras.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEnfermeiras.Name = "btnEnfermeiras"
        Me.btnEnfermeiras.Size = New System.Drawing.Size(77, 67)
        Me.btnEnfermeiras.Text = "Enfermeiras"
        Me.btnEnfermeiras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnSecretarias
        '
        Me.btnSecretarias.Font = New System.Drawing.Font("Calibri", 9.25!, System.Drawing.FontStyle.Bold)
        Me.btnSecretarias.Image = CType(resources.GetObject("btnSecretarias.Image"), System.Drawing.Image)
        Me.btnSecretarias.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSecretarias.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSecretarias.Name = "btnSecretarias"
        Me.btnSecretarias.Size = New System.Drawing.Size(71, 67)
        Me.btnSecretarias.Text = "Secretárias"
        Me.btnSecretarias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnFornecedores
        '
        Me.btnFornecedores.Font = New System.Drawing.Font("Calibri", 9.25!, System.Drawing.FontStyle.Bold)
        Me.btnFornecedores.Image = CType(resources.GetObject("btnFornecedores.Image"), System.Drawing.Image)
        Me.btnFornecedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnFornecedores.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFornecedores.Name = "btnFornecedores"
        Me.btnFornecedores.Size = New System.Drawing.Size(86, 67)
        Me.btnFornecedores.Text = "Fornecedores"
        Me.btnFornecedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tbAdministracao
        '
        Me.tbAdministracao.BackgroundImage = CType(resources.GetObject("tbAdministracao.BackgroundImage"), System.Drawing.Image)
        Me.tbAdministracao.Controls.Add(Me.ToolStrip6)
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
        'ToolStrip6
        '
        Me.ToolStrip6.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip6.Font = New System.Drawing.Font("Calibri", 9.25!)
        Me.ToolStrip6.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip6.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnConvenios, Me.btnConsultas, Me.btnCirurgias, Me.btnLeitos, Me.btnMateriais, Me.btnAgenda})
        Me.ToolStrip6.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip6.Name = "ToolStrip6"
        Me.ToolStrip6.Size = New System.Drawing.Size(577, 70)
        Me.ToolStrip6.TabIndex = 5
        Me.ToolStrip6.Text = "ToolStrip6"
        '
        'btnConvenios
        '
        Me.btnConvenios.Font = New System.Drawing.Font("Calibri", 9.25!, System.Drawing.FontStyle.Bold)
        Me.btnConvenios.Image = CType(resources.GetObject("btnConvenios.Image"), System.Drawing.Image)
        Me.btnConvenios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnConvenios.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnConvenios.Name = "btnConvenios"
        Me.btnConvenios.Size = New System.Drawing.Size(67, 67)
        Me.btnConvenios.Text = "Convênios"
        Me.btnConvenios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnConsultas
        '
        Me.btnConsultas.Font = New System.Drawing.Font("Calibri", 9.25!, System.Drawing.FontStyle.Bold)
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
        Me.btnCirurgias.Font = New System.Drawing.Font("Calibri", 9.25!, System.Drawing.FontStyle.Bold)
        Me.btnCirurgias.Image = CType(resources.GetObject("btnCirurgias.Image"), System.Drawing.Image)
        Me.btnCirurgias.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnCirurgias.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCirurgias.Name = "btnCirurgias"
        Me.btnCirurgias.Size = New System.Drawing.Size(58, 67)
        Me.btnCirurgias.Text = "Cirurgias"
        Me.btnCirurgias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnLeitos
        '
        Me.btnLeitos.Font = New System.Drawing.Font("Calibri", 9.25!, System.Drawing.FontStyle.Bold)
        Me.btnLeitos.Image = CType(resources.GetObject("btnLeitos.Image"), System.Drawing.Image)
        Me.btnLeitos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnLeitos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLeitos.Name = "btnLeitos"
        Me.btnLeitos.Size = New System.Drawing.Size(52, 67)
        Me.btnLeitos.Text = "Leitos"
        Me.btnLeitos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnMateriais
        '
        Me.btnMateriais.Font = New System.Drawing.Font("Calibri", 9.25!, System.Drawing.FontStyle.Bold)
        Me.btnMateriais.Image = CType(resources.GetObject("btnMateriais.Image"), System.Drawing.Image)
        Me.btnMateriais.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnMateriais.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMateriais.Name = "btnMateriais"
        Me.btnMateriais.Size = New System.Drawing.Size(62, 67)
        Me.btnMateriais.Text = "Materiais"
        Me.btnMateriais.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnAgenda
        '
        Me.btnAgenda.Font = New System.Drawing.Font("Calibri", 9.25!, System.Drawing.FontStyle.Bold)
        Me.btnAgenda.Image = CType(resources.GetObject("btnAgenda.Image"), System.Drawing.Image)
        Me.btnAgenda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnAgenda.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAgenda.Name = "btnAgenda"
        Me.btnAgenda.Size = New System.Drawing.Size(52, 67)
        Me.btnAgenda.Text = "Agenda"
        Me.btnAgenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        Me.ToolStrip2.Visible = False
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
        'tbFinanceiro
        '
        Me.tbFinanceiro.BackgroundImage = CType(resources.GetObject("tbFinanceiro.BackgroundImage"), System.Drawing.Image)
        Me.tbFinanceiro.Controls.Add(Me.ToolStrip7)
        Me.tbFinanceiro.Controls.Add(Me.ToolStrip5)
        Me.tbFinanceiro.ImageIndex = 3
        Me.tbFinanceiro.Location = New System.Drawing.Point(4, 26)
        Me.tbFinanceiro.Name = "tbFinanceiro"
        Me.tbFinanceiro.Padding = New System.Windows.Forms.Padding(3)
        Me.tbFinanceiro.Size = New System.Drawing.Size(583, 76)
        Me.tbFinanceiro.TabIndex = 2
        Me.tbFinanceiro.Text = "Financeiro"
        Me.tbFinanceiro.UseVisualStyleBackColor = True
        '
        'ToolStrip7
        '
        Me.ToolStrip7.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip7.Font = New System.Drawing.Font("Calibri", 9.25!)
        Me.ToolStrip7.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip7.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnRelatorios})
        Me.ToolStrip7.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip7.Name = "ToolStrip7"
        Me.ToolStrip7.Size = New System.Drawing.Size(577, 70)
        Me.ToolStrip7.TabIndex = 7
        Me.ToolStrip7.Text = "ToolStrip7"
        '
        'btnRelatorios
        '
        Me.btnRelatorios.Font = New System.Drawing.Font("Calibri", 9.25!, System.Drawing.FontStyle.Bold)
        Me.btnRelatorios.Image = CType(resources.GetObject("btnRelatorios.Image"), System.Drawing.Image)
        Me.btnRelatorios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnRelatorios.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRelatorios.Name = "btnRelatorios"
        Me.btnRelatorios.Size = New System.Drawing.Size(66, 67)
        Me.btnRelatorios.Text = "Relatórios"
        Me.btnRelatorios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStrip5
        '
        Me.ToolStrip5.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip5.Font = New System.Drawing.Font("Calibri", 9.25!)
        Me.ToolStrip5.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip5.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton11, Me.ToolStripButton12})
        Me.ToolStrip5.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip5.Name = "ToolStrip5"
        Me.ToolStrip5.Size = New System.Drawing.Size(577, 70)
        Me.ToolStrip5.TabIndex = 6
        Me.ToolStrip5.Text = "ToolStrip5"
        Me.ToolStrip5.Visible = False
        '
        'ToolStripButton11
        '
        Me.ToolStripButton11.Font = New System.Drawing.Font("Calibri", 9.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton11.Image = CType(resources.GetObject("ToolStripButton11.Image"), System.Drawing.Image)
        Me.ToolStripButton11.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton11.Name = "ToolStripButton11"
        Me.ToolStripButton11.Size = New System.Drawing.Size(52, 67)
        Me.ToolStripButton11.Text = "Contas"
        Me.ToolStripButton11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton12
        '
        Me.ToolStripButton12.Font = New System.Drawing.Font("Calibri", 9.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton12.Image = CType(resources.GetObject("ToolStripButton12.Image"), System.Drawing.Image)
        Me.ToolStripButton12.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton12.Name = "ToolStripButton12"
        Me.ToolStripButton12.Size = New System.Drawing.Size(66, 67)
        Me.ToolStripButton12.Text = "Relatórios"
        Me.ToolStripButton12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tbConfiguracao
        '
        Me.tbConfiguracao.BackgroundImage = CType(resources.GetObject("tbConfiguracao.BackgroundImage"), System.Drawing.Image)
        Me.tbConfiguracao.Controls.Add(Me.ToolStrip8)
        Me.tbConfiguracao.Controls.Add(Me.ToolStrip3)
        Me.tbConfiguracao.ImageIndex = 2
        Me.tbConfiguracao.Location = New System.Drawing.Point(4, 26)
        Me.tbConfiguracao.Name = "tbConfiguracao"
        Me.tbConfiguracao.Padding = New System.Windows.Forms.Padding(3)
        Me.tbConfiguracao.Size = New System.Drawing.Size(583, 76)
        Me.tbConfiguracao.TabIndex = 3
        Me.tbConfiguracao.Text = "Configurações"
        Me.tbConfiguracao.UseVisualStyleBackColor = True
        '
        'ToolStrip8
        '
        Me.ToolStrip8.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip8.Font = New System.Drawing.Font("Calibri", 9.25!)
        Me.ToolStrip8.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip8.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnUsuarios})
        Me.ToolStrip8.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip8.Name = "ToolStrip8"
        Me.ToolStrip8.Size = New System.Drawing.Size(577, 70)
        Me.ToolStrip8.TabIndex = 8
        Me.ToolStrip8.Text = "ToolStrip8"
        '
        'btnUsuarios
        '
        Me.btnUsuarios.Font = New System.Drawing.Font("Calibri", 9.25!, System.Drawing.FontStyle.Bold)
        Me.btnUsuarios.Image = CType(resources.GetObject("btnUsuarios.Image"), System.Drawing.Image)
        Me.btnUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(57, 67)
        Me.btnUsuarios.Text = "Usuários"
        Me.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStrip3
        '
        Me.ToolStrip3.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip3.Font = New System.Drawing.Font("Calibri", 9.25!)
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton2})
        Me.ToolStrip3.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(577, 70)
        Me.ToolStrip3.TabIndex = 5
        Me.ToolStrip3.Text = "ToolStrip3"
        Me.ToolStrip3.Visible = False
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Font = New System.Drawing.Font("Calibri", 9.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(57, 67)
        Me.ToolStripButton3.Text = "Usuários"
        Me.ToolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Font = New System.Drawing.Font("Calibri", 9.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(73, 67)
        Me.ToolStripButton2.Text = "Permissões"
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tbAjuda
        '
        Me.tbAjuda.BackgroundImage = CType(resources.GetObject("tbAjuda.BackgroundImage"), System.Drawing.Image)
        Me.tbAjuda.Controls.Add(Me.ToolStrip9)
        Me.tbAjuda.Controls.Add(Me.ToolStrip4)
        Me.tbAjuda.ImageIndex = 4
        Me.tbAjuda.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.tbAjuda.Location = New System.Drawing.Point(4, 26)
        Me.tbAjuda.Name = "tbAjuda"
        Me.tbAjuda.Padding = New System.Windows.Forms.Padding(3)
        Me.tbAjuda.Size = New System.Drawing.Size(583, 76)
        Me.tbAjuda.TabIndex = 4
        Me.tbAjuda.Text = "Ajuda"
        Me.tbAjuda.UseVisualStyleBackColor = True
        '
        'ToolStrip9
        '
        Me.ToolStrip9.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip9.Font = New System.Drawing.Font("Calibri", 9.25!)
        Me.ToolStrip9.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip9.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnInformacoes})
        Me.ToolStrip9.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip9.Name = "ToolStrip9"
        Me.ToolStrip9.Size = New System.Drawing.Size(577, 70)
        Me.ToolStrip9.TabIndex = 8
        Me.ToolStrip9.Text = "ToolStrip9"
        '
        'btnInformacoes
        '
        Me.btnInformacoes.Font = New System.Drawing.Font("Calibri", 9.25!, System.Drawing.FontStyle.Bold)
        Me.btnInformacoes.Image = CType(resources.GetObject("btnInformacoes.Image"), System.Drawing.Image)
        Me.btnInformacoes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnInformacoes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnInformacoes.Name = "btnInformacoes"
        Me.btnInformacoes.Size = New System.Drawing.Size(78, 67)
        Me.btnInformacoes.Text = "Informações"
        Me.btnInformacoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStrip4
        '
        Me.ToolStrip4.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip4.Font = New System.Drawing.Font("Calibri", 9.25!)
        Me.ToolStrip4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton8, Me.ToolStripButton9})
        Me.ToolStrip4.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip4.Name = "ToolStrip4"
        Me.ToolStrip4.Size = New System.Drawing.Size(577, 70)
        Me.ToolStrip4.TabIndex = 6
        Me.ToolStrip4.Text = "ToolStrip4"
        Me.ToolStrip4.Visible = False
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.Font = New System.Drawing.Font("Calibri", 9.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton8.Image = CType(resources.GetObject("ToolStripButton8.Image"), System.Drawing.Image)
        Me.ToolStripButton8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(78, 67)
        Me.ToolStripButton8.Text = "Informações"
        Me.ToolStripButton8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton9
        '
        Me.ToolStripButton9.Font = New System.Drawing.Font("Calibri", 9.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton9.Image = CType(resources.GetObject("ToolStripButton9.Image"), System.Drawing.Image)
        Me.ToolStripButton9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton9.Name = "ToolStripButton9"
        Me.ToolStripButton9.Size = New System.Drawing.Size(55, 67)
        Me.ToolStripButton9.Text = "Contato"
        Me.ToolStripButton9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "acoes16x16.png")
        Me.ImageList1.Images.SetKeyName(1, "bairros16x16.png")
        Me.ImageList1.Images.SetKeyName(2, "manutencao16x16.png")
        Me.ImageList1.Images.SetKeyName(3, "orcamento16x16.png")
        Me.ImageList1.Images.SetKeyName(4, "help.png")
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Calibri", 9.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(56, 67)
        Me.ToolStripButton1.Text = "Médicos"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'ToolStripButton6
        '
        Me.ToolStripButton6.Font = New System.Drawing.Font("Calibri", 9.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(76, 67)
        Me.ToolStripButton6.Text = "Atendentes"
        Me.ToolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton13
        '
        Me.ToolStripButton13.Font = New System.Drawing.Font("Calibri", 9.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton13.Image = CType(resources.GetObject("ToolStripButton13.Image"), System.Drawing.Image)
        Me.ToolStripButton13.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton13.Name = "ToolStripButton13"
        Me.ToolStripButton13.Size = New System.Drawing.Size(52, 67)
        Me.ToolStripButton13.Text = "Agenda"
        Me.ToolStripButton13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton14
        '
        Me.ToolStripButton14.Font = New System.Drawing.Font("Calibri", 9.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton14.Image = CType(resources.GetObject("ToolStripButton14.Image"), System.Drawing.Image)
        Me.ToolStripButton14.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton14.Name = "ToolStripButton14"
        Me.ToolStripButton14.Size = New System.Drawing.Size(86, 67)
        Me.ToolStripButton14.Text = "Fornecedores"
        Me.ToolStripButton14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 424)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(591, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'frmPrincipal
        '
        Me.AccessibleDescription = ""
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 446)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.tabMenu)
        Me.IsMdiContainer = True
        Me.Name = "frmPrincipal"
        Me.Text = "SGCM - SISTEMA DE GESTÃO DE CLÍNICA MÉDICA"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tabMenu.ResumeLayout(False)
        Me.tbGeral.ResumeLayout(False)
        Me.tbGeral.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.tbAdministracao.ResumeLayout(False)
        Me.tbAdministracao.PerformLayout()
        Me.ToolStrip6.ResumeLayout(False)
        Me.ToolStrip6.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.tbFinanceiro.ResumeLayout(False)
        Me.tbFinanceiro.PerformLayout()
        Me.ToolStrip7.ResumeLayout(False)
        Me.ToolStrip7.PerformLayout()
        Me.ToolStrip5.ResumeLayout(False)
        Me.ToolStrip5.PerformLayout()
        Me.tbConfiguracao.ResumeLayout(False)
        Me.tbConfiguracao.PerformLayout()
        Me.ToolStrip8.ResumeLayout(False)
        Me.ToolStrip8.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.tbAjuda.ResumeLayout(False)
        Me.tbAjuda.PerformLayout()
        Me.ToolStrip9.ResumeLayout(False)
        Me.ToolStrip9.PerformLayout()
        Me.ToolStrip4.ResumeLayout(False)
        Me.ToolStrip4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabMenu As System.Windows.Forms.TabControl
    Friend WithEvents tbGeral As System.Windows.Forms.TabPage
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnMedicos As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPacientes As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEnfermeiras As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnFornecedores As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbAdministracao As System.Windows.Forms.TabPage
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton10 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbFinanceiro As System.Windows.Forms.TabPage
    Friend WithEvents ToolStrip5 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton11 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton12 As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbConfiguracao As System.Windows.Forms.TabPage
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbAjuda As System.Windows.Forms.TabPage
    Friend WithEvents ToolStrip4 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton9 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ToolStrip6 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnConvenios As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnConsultas As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMateriais As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton13 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton14 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip7 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnRelatorios As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip8 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnUsuarios As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip9 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnInformacoes As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCirurgias As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAgenda As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnLeitos As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSecretarias As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
End Class
