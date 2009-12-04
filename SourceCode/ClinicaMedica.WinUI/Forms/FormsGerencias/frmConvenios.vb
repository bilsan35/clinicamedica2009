Imports ClinicaMedica.Classes

Public Class frmConvenios

    Public Sub AtualizarGrid()
        CargaGrid(txtPesquisar.Text)
    End Sub

#Region "Rotinas"

    Private Sub CargaGrid(ByVal filtro As String)

        Dim objDB As New UTFPR.classBanco

        Dim sql As String

        sql = "select *  from vwConvenio where Nome like '%x%'"
        sql = sql.Replace("x", filtro)

        With Grid
            .DataSource = objDB.retornaDataSet(sql).Tables(0)
            .Refresh()
        End With

    End Sub

    Private Function Deletar(ByVal ID As String) As Boolean

        Dim objDB As New UTFPR.classBanco

        Dim sql As String

        sql = "delete from TBCONVENIO where ID = '@ID'"
        sql = sql.Replace("@ID", ID)

        If objDB.ExecuteSQL(sql) = 1 Then

            Return True

        Else

            Return False

        End If

    End Function

#End Region

#Region "Eventos"

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Hide()
    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

        Dim frmCadastroConvenio As New frmCadastroConvenio

        frmCadastroConvenio.ShowDialog()

    End Sub

    Private Sub btnPesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            CargaGrid(txtPesquisar.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Editar()
        Try
            Dim CHAVE As String
            CHAVE = Grid.Item(0, Grid.CurrentCell.RowIndex).Value
            Dim objEdicao As New frmCadastroConvenio(CHAVE)
            objEdicao.ShowDialog()
            CargaGrid(txtPesquisar.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Grid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid.DoubleClick
        Editar()
    End Sub

    Private Sub Remover()
        Try

            Dim chave As String

            chave = Grid.Item(0, Grid.CurrentCell.RowIndex).Value

            If MessageBox.Show("Deseja deletar este elemento?", "Deletar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                If Deletar(chave) = True Then

                    MessageBox.Show("Deletado!")

                Else
                    MessageBox.Show("Falhou!")
                End If
                CargaGrid(txtPesquisar.Text)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Grid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Grid.KeyDown
        If e.KeyCode <> Keys.Delete Then
            Exit Sub
        End If
        Remover()
    End Sub

#End Region

    Private Sub frmMedicos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'CargaGrid(txtPesquisar.Text)
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        Editar()
    End Sub

    Private Sub btnRemover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemover.Click
        Remover()
    End Sub
End Class