Imports ClinicaMedica.Classes.UTFPR

Public Class frmLogin

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        End
    End Sub

    Private Sub Conectar()
        Dim banco As New classBanco
        Dim ds = banco.retornaDataSet("select * from TBUSUARIO where login = '" & txtLogin.Text & "' and senha = '" & txtSenha.Text & "'")
        If ds.Tables(0).Rows.Count = 0 Then
            MessageBox.Show("Login ou Senha Inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        '' preencher objeto do formPrincipal
        Dim objUsuario As New classUsuario
        objUsuario.Tipo = ds.Tables(0).Rows(0)("TIPO")

        frmPrincipal.Usuario = objUsuario
        DialogResult = Windows.Forms.DialogResult.OK
        Close()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Conectar()
    End Sub

    Private Sub txtLogin_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLogin.LostFocus
        If (txtLogin.Text.Trim().Length = 0) Then
            ErrorLogin.SetError(txtLogin, "Informe o Usuário")
            txtLogin.Focus()
        Else
            ErrorLogin.SetError(txtLogin, "")
        End If
    End Sub

    Private Sub txtSenha_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSenha.Validating
        If (txtSenha.Text.Trim().Length = 0) Then
            ErrorLogin.SetError(txtSenha, "Informe a Senha")
        Else
            ErrorLogin.SetError(txtSenha, "")
        End If
    End Sub

    Private Sub frmLogin_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If Not DialogResult = Windows.Forms.DialogResult.OK Then
            End
        End If
    End Sub

    Private Sub frmLogin_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If Not DialogResult = Windows.Forms.DialogResult.OK Then
            End
        End If
    End Sub

    Private Sub txtSenha_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSenha.KeyDown
        If e.KeyData = Keys.Enter Then
            Conectar()
        End If
    End Sub
End Class