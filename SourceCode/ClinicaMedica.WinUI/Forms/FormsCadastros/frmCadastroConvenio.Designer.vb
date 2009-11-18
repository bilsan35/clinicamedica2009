<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroConvenio
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
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtValor = New System.Windows.Forms.TextBox
        Me.dtpValidade = New System.Windows.Forms.DateTimePicker
        Me.dtpDataInclusao = New System.Windows.Forms.DateTimePicker
        Me.txtPlano = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtWebsite = New System.Windows.Forms.TextBox
        Me.txtRegistro = New System.Windows.Forms.TextBox
        Me.txtNome = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnFechar = New System.Windows.Forms.Button
        Me.btnCadastrar = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtCEP = New System.Windows.Forms.MaskedTextBox
        Me.txtTelefone = New System.Windows.Forms.MaskedTextBox
        Me.txtNumero = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.cboEstado = New System.Windows.Forms.ComboBox
        Me.txtCidade = New System.Windows.Forms.TextBox
        Me.txtBairro = New System.Windows.Forms.TextBox
        Me.txtComplemento = New System.Windows.Forms.TextBox
        Me.txtLogradouro = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(279, 362)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 18
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtValor)
        Me.GroupBox1.Controls.Add(Me.dtpValidade)
        Me.GroupBox1.Controls.Add(Me.dtpDataInclusao)
        Me.GroupBox1.Controls.Add(Me.txtPlano)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtWebsite)
        Me.GroupBox1.Controls.Add(Me.txtRegistro)
        Me.GroupBox1.Controls.Add(Me.txtNome)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(425, 172)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informações"
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(82, 80)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(131, 20)
        Me.txtValor.TabIndex = 26
        '
        'dtpValidade
        '
        Me.dtpValidade.CustomFormat = "dd/MM/yyyy"
        Me.dtpValidade.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpValidade.Location = New System.Drawing.Point(279, 51)
        Me.dtpValidade.Name = "dtpValidade"
        Me.dtpValidade.Size = New System.Drawing.Size(125, 20)
        Me.dtpValidade.TabIndex = 24
        '
        'dtpDataInclusao
        '
        Me.dtpDataInclusao.CustomFormat = "dd/MM/yyyy"
        Me.dtpDataInclusao.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDataInclusao.Location = New System.Drawing.Point(295, 80)
        Me.dtpDataInclusao.Name = "dtpDataInclusao"
        Me.dtpDataInclusao.Size = New System.Drawing.Size(109, 20)
        Me.dtpDataInclusao.TabIndex = 23
        '
        'txtPlano
        '
        Me.txtPlano.Location = New System.Drawing.Point(82, 108)
        Me.txtPlano.Name = "txtPlano"
        Me.txtPlano.Size = New System.Drawing.Size(324, 20)
        Me.txtPlano.TabIndex = 21
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(28, 112)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(34, 13)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Plano"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Valor"
        '
        'txtWebsite
        '
        Me.txtWebsite.Location = New System.Drawing.Point(82, 136)
        Me.txtWebsite.Name = "txtWebsite"
        Me.txtWebsite.Size = New System.Drawing.Size(324, 20)
        Me.txtWebsite.TabIndex = 12
        '
        'txtRegistro
        '
        Me.txtRegistro.Location = New System.Drawing.Point(82, 51)
        Me.txtRegistro.Name = "txtRegistro"
        Me.txtRegistro.Size = New System.Drawing.Size(131, 20)
        Me.txtRegistro.TabIndex = 7
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(82, 21)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(324, 20)
        Me.txtNome.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Website"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(216, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Data Inclusão"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(223, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Validade"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Registro"
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
        'btnFechar
        '
        Me.btnFechar.Location = New System.Drawing.Point(360, 362)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(75, 23)
        Me.btnFechar.TabIndex = 16
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'btnCadastrar
        '
        Me.btnCadastrar.Location = New System.Drawing.Point(198, 362)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCadastrar.TabIndex = 15
        Me.btnCadastrar.Text = "Cadastrar"
        Me.btnCadastrar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCEP)
        Me.GroupBox2.Controls.Add(Me.txtTelefone)
        Me.GroupBox2.Controls.Add(Me.txtNumero)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.cboEstado)
        Me.GroupBox2.Controls.Add(Me.txtCidade)
        Me.GroupBox2.Controls.Add(Me.txtBairro)
        Me.GroupBox2.Controls.Add(Me.txtComplemento)
        Me.GroupBox2.Controls.Add(Me.txtLogradouro)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 190)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(425, 165)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Endereço"
        '
        'txtCEP
        '
        Me.txtCEP.Location = New System.Drawing.Point(328, 115)
        Me.txtCEP.Mask = "09900-000"
        Me.txtCEP.Name = "txtCEP"
        Me.txtCEP.Size = New System.Drawing.Size(79, 20)
        Me.txtCEP.TabIndex = 39
        '
        'txtTelefone
        '
        Me.txtTelefone.Location = New System.Drawing.Point(81, 115)
        Me.txtTelefone.Mask = "(99) 0000-0000"
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(113, 20)
        Me.txtTelefone.TabIndex = 38
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(344, 35)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(60, 20)
        Me.txtNumero.TabIndex = 22
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 79)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(71, 13)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Complemento"
        '
        'cboEstado
        '
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Items.AddRange(New Object() {"AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO"})
        Me.cboEstado.Location = New System.Drawing.Point(242, 115)
        Me.cboEstado.MaxLength = 2
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(47, 21)
        Me.cboEstado.TabIndex = 15
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(313, 75)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(91, 20)
        Me.txtCidade.TabIndex = 18
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(186, 75)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(80, 20)
        Me.txtBairro.TabIndex = 17
        '
        'txtComplemento
        '
        Me.txtComplemento.Location = New System.Drawing.Point(82, 75)
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(64, 20)
        Me.txtComplemento.TabIndex = 16
        '
        'txtLogradouro
        '
        Me.txtLogradouro.Location = New System.Drawing.Point(82, 35)
        Me.txtLogradouro.Name = "txtLogradouro"
        Me.txtLogradouro.Size = New System.Drawing.Size(208, 20)
        Me.txtLogradouro.TabIndex = 15
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(17, 119)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 13)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Telefone"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(200, 119)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 13)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Estado"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(294, 119)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(28, 13)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "CEP"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(270, 79)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Cidade"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(150, 79)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Bairro"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(294, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Número"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Logradouro"
        '
        'frmCadastroConvenio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 392)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnCadastrar)
        Me.Name = "frmCadastroConvenio"
        Me.Text = "Cadastro Convênio"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpDataInclusao As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtPlano As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtWebsite As System.Windows.Forms.TextBox
    Friend WithEvents txtRegistro As System.Windows.Forms.TextBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents btnCadastrar As System.Windows.Forms.Button
    Friend WithEvents dtpValidade As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCEP As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtTelefone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cboEstado As System.Windows.Forms.ComboBox
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents txtComplemento As System.Windows.Forms.TextBox
    Friend WithEvents txtLogradouro As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
