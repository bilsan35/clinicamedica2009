Imports ClinicaMedica.Classes

Public Class frmCadastroUsuarios

    Private pID As Integer

    Private Sub LimparFormulario()

        txtLogin.Text = ""
        txtSenha.Text = ""
        cboTipo.SelectedIndex = 0
        txtNome.Text = ""
        txtRG.Text = ""
        txtCPF.Text = ""
        txtDataNascimento.Text = ""
        cboEstadoCivil.SelectedIndex = 0
        txtEmail.Text = ""
        txtLogradouro.Text = ""
        txtNumero.Text = ""
        txtBairro.Text = ""
        txtCidade.Text = ""
        txtCEP.Text = ""
        cboEstado.SelectedIndex = 0
        txtTelefone.Text = ""

    End Sub

    Public Sub CarregaObjeto(ByVal ID As String)

        Dim objUsuario As New UTFPR.classUsuario(Convert.ToInt32(ID))
        With objUsuario
            txtLogin.Text = .Login
            txtSenha.Text = .Senha
            cboTipo.SelectedIndex = .Tipo - 1
            txtNome.Text = .Nome
            txtRG.Text = .RG
            txtCPF.Text = .CPF
            txtDataNascimento.Text = .DataNascimento
            cboEstadoCivil.SelectedItem = .Estado
            If .Sexo = "M" Then
                rdoMasculino.Checked = True
            Else
                rdoFeminino.Checked = True
            End If
            txtEmail.Text = .Email
            txtLogradouro.Text = .Lougradouro
            txtNumero.Text = .Numero
            txtBairro.Text = .Bairro
            txtCidade.Text = .Cidade
            txtCEP.Text = .CEP
            cboEstado.SelectedItem = .Estado
            txtTelefone.Text = .Telefone

        End With
    End Sub

    Public Sub New(Optional ByVal ID As Integer = 0)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        cboEstado.SelectedIndex = 0
        cboEstadoCivil.SelectedIndex = 0
        cboTipo.SelectedIndex = 0

        If ID > 0 Then
            pID = ID
            CarregaObjeto(ID)
        End If
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Hide()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        If pID = 0 Then
            LimparFormulario()
        End If
        CarregaObjeto(pID)
    End Sub

    Private Sub btnCadastrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrar.Click
        Try

            Dim objUsuario As UTFPR.classUsuario

            If pID = 0 Then
                objUsuario = New UTFPR.classUsuario
            Else
                objUsuario = New UTFPR.classUsuario(pID)
            End If
            With objUsuario
                .Login = txtLogin.Text
                .Senha = txtSenha.Text
                .Tipo = cboTipo.SelectedIndex + 1
                .Nome = txtNome.Text
                .RG = txtRG.Text
                .CPF = txtCPF.Text
                .DataNascimento = txtDataNascimento.Text
                .EstadoCivil = cboEstadoCivil.SelectedItem
                If rdoMasculino.Checked = True Then
                    .Sexo = "M"
                ElseIf rdoFeminino.Checked = True Then
                    .Sexo = "F"
                End If
                .Email = txtEmail.Text
                .Lougradouro = txtLogradouro.Text
                .Numero = txtNumero.Text
                .Bairro = txtBairro.Text
                .Cidade = txtCidade.Text
                .CEP = txtCEP.Text
                .Estado = cboEstado.SelectedItem
                .Telefone = txtTelefone.Text

            End With

            If objUsuario.save = True Then
                MessageBox.Show("Salvo com Sucesso!")
                LimparFormulario()
            Else
                MessageBox.Show("Não foi possível salvar!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class