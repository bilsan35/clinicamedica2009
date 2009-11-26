<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroUsuarios
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
        Me.btnFechar = New System.Windows.Forms.Button
        Me.txtLogradouro = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtDataNascimento = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.txtNumero = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cboEstadoCivil = New System.Windows.Forms.ComboBox
        Me.txtBairro = New System.Windows.Forms.TextBox
        Me.rdoFeminino = New System.Windows.Forms.RadioButton
        Me.Label12 = New System.Windows.Forms.Label
        Me.rdoMasculino = New System.Windows.Forms.RadioButton
        Me.txtCidade = New System.Windows.Forms.TextBox
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.txtCPF = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtRG = New System.Windows.Forms.TextBox
        Me.txtNome = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cboTipo = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtSenha = New System.Windows.Forms.MaskedTextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.lblLogin = New System.Windows.Forms.Label
        Me.txtLogin = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnCadastrar = New System.Windows.Forms.Button
        Me.txtCEP = New System.Windows.Forms.TextBox
        Me.txtTelefone = New System.Windows.Forms.TextBox
        Me.cboEstado = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnFechar
        '
        Me.btnFechar.Location = New System.Drawing.Point(362, 361)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(75, 23)
        Me.btnFechar.TabIndex = 8
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'txtLogradouro
        '
        Me.txtLogradouro.Location = New System.Drawing.Point(82, 36)
        Me.txtLogradouro.Name = "txtLogradouro"
        Me.txtLogradouro.Size = New System.Drawing.Size(322, 20)
        Me.txtLogradouro.TabIndex = 15
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(241, 117)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 13)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Telefone"
        '
        'txtDataNascimento
        '
        Me.txtDataNascimento.Location = New System.Drawing.Point(82, 81)
        Me.txtDataNascimento.MaxLength = 10
        Me.txtDataNascimento.Name = "txtDataNascimento"
        Me.txtDataNascimento.Size = New System.Drawing.Size(131, 20)
        Me.txtDataNascimento.TabIndex = 14
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(129, 118)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 13)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Estado"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(266, 111)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(142, 20)
        Me.txtEmail.TabIndex = 12
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(82, 74)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(36, 20)
        Me.txtNumero.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Data Nasc."
        '
        'cboEstadoCivil
        '
        Me.cboEstadoCivil.FormattingEnabled = True
        Me.cboEstadoCivil.Items.AddRange(New Object() {"Casado(a)", "Solteiro(a)", "Divorciado(a)", "Separado(a)", "Amasiado(a)", "Viúvo(a)", "Outro"})
        Me.cboEstadoCivil.Location = New System.Drawing.Point(285, 81)
        Me.cboEstadoCivil.Name = "cboEstadoCivil"
        Me.cboEstadoCivil.Size = New System.Drawing.Size(123, 21)
        Me.cboEstadoCivil.TabIndex = 11
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(166, 74)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(77, 20)
        Me.txtBairro.TabIndex = 17
        '
        'rdoFeminino
        '
        Me.rdoFeminino.AutoSize = True
        Me.rdoFeminino.Location = New System.Drawing.Point(157, 113)
        Me.rdoFeminino.Name = "rdoFeminino"
        Me.rdoFeminino.Size = New System.Drawing.Size(67, 17)
        Me.rdoFeminino.TabIndex = 10
        Me.rdoFeminino.Text = "Feminino"
        Me.rdoFeminino.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(32, 118)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(28, 13)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "CEP"
        '
        'rdoMasculino
        '
        Me.rdoMasculino.AutoSize = True
        Me.rdoMasculino.Checked = True
        Me.rdoMasculino.Location = New System.Drawing.Point(79, 113)
        Me.rdoMasculino.Name = "rdoMasculino"
        Me.rdoMasculino.Size = New System.Drawing.Size(73, 17)
        Me.rdoMasculino.TabIndex = 9
        Me.rdoMasculino.TabStop = True
        Me.rdoMasculino.Text = "Masculino"
        Me.rdoMasculino.UseVisualStyleBackColor = True
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(296, 75)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(108, 20)
        Me.txtCidade.TabIndex = 18
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(281, 361)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtCPF
        '
        Me.txtCPF.Location = New System.Drawing.Point(264, 53)
        Me.txtCPF.MaxLength = 14
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Size = New System.Drawing.Size(144, 20)
        Me.txtCPF.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(253, 78)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Cidade"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(129, 77)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Bairro"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(24, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Número"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Logradouro"
        '
        'txtRG
        '
        Me.txtRG.Location = New System.Drawing.Point(82, 53)
        Me.txtRG.MaxLength = 14
        Me.txtRG.Name = "txtRG"
        Me.txtRG.Size = New System.Drawing.Size(131, 20)
        Me.txtRG.TabIndex = 7
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(82, 21)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(170, 20)
        Me.txtNome.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(225, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "E-mail"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboTipo)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtSenha)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.lblLogin)
        Me.GroupBox1.Controls.Add(Me.txtLogin)
        Me.GroupBox1.Controls.Add(Me.txtDataNascimento)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.cboEstadoCivil)
        Me.GroupBox1.Controls.Add(Me.rdoFeminino)
        Me.GroupBox1.Controls.Add(Me.rdoMasculino)
        Me.GroupBox1.Controls.Add(Me.txtCPF)
        Me.GroupBox1.Controls.Add(Me.txtRG)
        Me.GroupBox1.Controls.Add(Me.txtNome)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(425, 172)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informações"
        '
        'cboTipo
        '
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Items.AddRange(New Object() {"1 - Administrador", "2 - Médico", "3 - Secretária"})
        Me.cboTipo.Location = New System.Drawing.Point(285, 21)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(123, 21)
        Me.cboTipo.TabIndex = 23
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(255, 24)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(28, 13)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "Tipo"
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(266, 141)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(142, 20)
        Me.txtSenha.TabIndex = 21
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(224, 144)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(38, 13)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Senha"
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Location = New System.Drawing.Point(29, 144)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(33, 13)
        Me.lblLogin.TabIndex = 17
        Me.lblLogin.Text = "Login"
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(82, 140)
        Me.txtLogin.MaxLength = 25
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(139, 20)
        Me.txtLogin.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(218, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Estado Civil"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Sexo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(225, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CPF"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "RG"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome"
        '
        'btnCadastrar
        '
        Me.btnCadastrar.Location = New System.Drawing.Point(200, 361)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCadastrar.TabIndex = 9
        Me.btnCadastrar.Text = "Cadastrar"
        Me.btnCadastrar.UseVisualStyleBackColor = True
        '
        'txtCEP
        '
        Me.txtCEP.Location = New System.Drawing.Point(82, 114)
        Me.txtCEP.Name = "txtCEP"
        Me.txtCEP.Size = New System.Drawing.Size(36, 20)
        Me.txtCEP.TabIndex = 19
        '
        'txtTelefone
        '
        Me.txtTelefone.Location = New System.Drawing.Point(296, 115)
        Me.txtTelefone.MaxLength = 14
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(108, 20)
        Me.txtTelefone.TabIndex = 20
        '
        'cboEstado
        '
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Items.AddRange(New Object() {"AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO"})
        Me.cboEstado.Location = New System.Drawing.Point(177, 114)
        Me.cboEstado.MaxLength = 2
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(58, 21)
        Me.cboEstado.TabIndex = 15
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTelefone)
        Me.GroupBox2.Controls.Add(Me.cboEstado)
        Me.GroupBox2.Controls.Add(Me.txtCEP)
        Me.GroupBox2.Controls.Add(Me.txtCidade)
        Me.GroupBox2.Controls.Add(Me.txtBairro)
        Me.GroupBox2.Controls.Add(Me.txtNumero)
        Me.GroupBox2.Controls.Add(Me.txtLogradouro)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 190)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(425, 165)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Endereço"
        '
        'frmCadastroUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 394)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCadastrar)
        Me.Controls.Add(Me.GroupBox2)
        Me.MinimizeBox = False
        Me.Name = "frmCadastroUsuarios"
        Me.Text = "Cadastro Usuários"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents txtLogradouro As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtDataNascimento As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboEstadoCivil As System.Windows.Forms.ComboBox
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents rdoFeminino As System.Windows.Forms.RadioButton
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents rdoMasculino As System.Windows.Forms.RadioButton
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents txtCPF As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtRG As System.Windows.Forms.TextBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblLogin As System.Windows.Forms.Label
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCadastrar As System.Windows.Forms.Button
    Friend WithEvents txtCEP As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefone As System.Windows.Forms.TextBox
    Friend WithEvents cboEstado As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSenha As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
