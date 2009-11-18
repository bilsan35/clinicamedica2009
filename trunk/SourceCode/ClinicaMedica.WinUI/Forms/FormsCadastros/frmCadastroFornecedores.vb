Imports ClinicaMedica.Classes

Public Class frmCadastroFornecedores

    Private pID As Integer

    Private Sub LimparFormulario()

        txtCodigo.Text = ""
        txtCNPJ.Text = ""
        txtNome.Text = ""
        txtDataCriacao.Text = ""
        txtInscricaoEstadual.Text = ""
        txtRazaoSocial.Text = ""
        txtLogradouro.Text = ""
        txtNumero.Text = ""
        txtBairro.Text = ""
        txtCidade.Text = ""
        txtCEP.Text = ""
        cboEstado.SelectedIndex = 0
        txtTelefone.Text = ""

    End Sub

    Public Sub CarregaObjeto(ByVal ID As String)

        Dim objFornecedor As New UTFPR.classFornecedor(Convert.ToInt32(ID))
        With objFornecedor
            txtCodigo.Text = .Codigo
            txtCNPJ.Text = .CNPJ
            txtNome.Text = .Nome
            txtDataCriacao.Text = .DataCriacao
            txtInscricaoEstadual.Text = .InscricaoEstadual
            txtRazaoSocial.Text = .RazaoSocial
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

        If ID > 0 Then
            pID = ID
            CarregaObjeto(ID)
        End If
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        If pID = 0 Then
            LimparFormulario()
        End If
        CarregaObjeto(pID)
    End Sub

    Private Sub btnCadastrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrar.Click
        Try

            Dim objFornecedor As UTFPR.classFornecedor

            If pID = 0 Then
                objFornecedor = New UTFPR.classFornecedor
            Else
                objFornecedor = New UTFPR.classFornecedor(pID)
            End If
            With objFornecedor
                .Codigo = txtCodigo.Text
                .CNPJ = txtCNPJ.Text
                .Nome = txtNome.Text()
                .DataCriacao = txtDataCriacao.Text
                .InscricaoEstadual = txtInscricaoEstadual.Text
                .RazaoSocial = txtRazaoSocial.Text
                .Lougradouro = txtLogradouro.Text
                .Numero = txtNumero.Text
                .Bairro = txtBairro.Text
                .Cidade = txtCidade.Text
                .CEP = txtCEP.Text
                .Estado = cboEstado.SelectedItem
                .Telefone = txtTelefone.Text

            End With

            If objFornecedor.save = True Then
                MessageBox.Show("Salvo com Sucesso!")
                LimparFormulario()
            Else
                MessageBox.Show("Salvo sem Sucesso!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Hide()
    End Sub

End Class