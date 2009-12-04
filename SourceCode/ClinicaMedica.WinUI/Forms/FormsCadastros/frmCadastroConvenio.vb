Imports ClinicaMedica.Classes

Public Class frmCadastroConvenio

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Hide()
    End Sub

    'Private Sub btnCadastrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrar.Click
    '    Dim dt As Date = dtValidade.Value
    '    MessageBox.Show(dt.Day & "/" & dt.Month & "/" & dt.Year)
    'End Sub

    Private pID As Integer

    'Private Sub LimparFormulario()

    '    txtNome.Text = ""
    '    txtRegistro.Text = ""
    '    dtpValidade.Value = DateTime.Now
    '    txtValor.Text = ""
    '    dtpDataInclusao.Value = DateTime.Now
    '    txtPlano.Text = ""
    '    txtWebsite.Text = ""
    '    txtLogradouro.Text = ""
    '    txtNumero.Text = ""
    '    txtComplemento.Text = ""
    '    txtBairro.Text = ""
    '    txtCidade.Text = ""
    '    txtCEP.Text = ""
    '    cboEstado.SelectedIndex = 0
    '    txtTelefone.Text = ""

    'End Sub

    'Public Sub CarregaObjeto(ByVal ID As String)

    '    Dim objConvenio As New UTFPR.classConvenio(Convert.ToInt32(ID))
    '    With objConvenio
    '        txtNome.Text = .Nome
    '        txtRegistro.Text = .Registro
    '        dtpValidade.Value = .Validade
    '        txtValor.Text = .Valor
    '        dtpDataInclusao.Value = .DataInclusao
    '        txtPlano.Text = .Plano
    '        txtWebsite.Text = .Website
    '        txtLogradouro.Text = .Lougradouro
    '        txtNumero.Text = .Numero
    '        txtComplemento.Text = .Complemento
    '        txtBairro.Text = .Bairro
    '        txtCidade.Text = .Cidade
    '        txtCEP.Text = .CEP
    '        cboEstado.SelectedItem = .Estado
    '        txtTelefone.Text = .Telefone

    '    End With
    'End Sub

    Public Sub New(Optional ByVal ID As Integer = 0)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        cboEstado.SelectedIndex = 0

        If ID > 0 Then
            pID = ID
            'CarregaObjeto(ID)
        End If
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        If pID = 0 Then
            'LimparFormulario()
        End If
        'CarregaObjeto(pID)
    End Sub

    'Private Sub btnCadastrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrar.Click
    '    Try

    '        Dim objConvenio As UTFPR.classConvenio

    '        If pID = 0 Then
    '            objConvenio = New UTFPR.classConvenio
    '        Else
    '            objConvenio = New UTFPR.classConvenio(pID)
    '        End If
    '        With objConvenio
    '            .Nome = txtNome.Text
    '            .Registro = txtRegistro.Text
    '            .Validade = dtpValidade.Value
    '            .Valor = txtValor.Text
    '            .DataInclusao = dtpDataInclusao.Value
    '            .Plano = txtPlano.Text
    '            .Website = txtWebsite.Text
    '            .Lougradouro = txtLogradouro.Text
    '            .Numero = txtNumero.Text
    '            .Complemento = txtComplemento.Text
    '            .Bairro = txtBairro.Text
    '            .Cidade = txtCidade.Text
    '            .CEP = txtCEP.Text
    '            .Estado = cboEstado.SelectedItem
    '            .Telefone = txtTelefone.Text

    '        End With

    '        If objConvenio.save = True Then
    '            MessageBox.Show("Salvo com Sucesso!")
    '            LimparFormulario()
    '        Else
    '            MessageBox.Show("Não foi possível salvar!")
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub
End Class