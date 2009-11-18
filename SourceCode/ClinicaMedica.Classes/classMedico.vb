Namespace UTFPR

    Public Class classMedico

        Inherits UTFPR.classPessoaFisica

        Private pID As Integer
        Public Property ID() As Integer
            Get
                Return pID
            End Get
            Set(ByVal value As Integer)
                pID = value
            End Set
        End Property

        Private pCRM As String
        Public Property CRM() As String
            Get
                Return pCRM
            End Get
            Set(ByVal value As String)
                pCRM = value
            End Set
        End Property

        Enum TipoAcao
            Inserir
            Atualizar
        End Enum

        Private Acao As TipoAcao

        Public Sub New(Optional ByVal ID As String = "")
            If ID.Length = 0 Then
                Acao = TipoAcao.Inserir
            Else
                Acao = TipoAcao.Atualizar
                pID = ID
                Recuperar()
            End If
        End Sub

        Private Sub Recuperar()
            Dim sql As String
            sql = "select * from TBMEDICO where ID ='" & pID & "'"

            Dim objDR As Data.DataRow
            objDR = retornaDataSet(sql).Tables(0).Rows(0)

            With objDR
                Nome = .Item("Nome")
                RG = .Item("RG")
                CPF = .Item("CPF")
                DataNascimento = .Item("DataNascimento")
                EstadoCivil = .Item("EstadoCivil")
                Sexo = .Item("Sexo")
                CRM = .Item("Nome")
                Email = .Item("Email")
                Lougradouro = .Item("Logradouro")
                Numero = .Item("Numero")
                Bairro = .Item("Bairro")
                Cidade = .Item("Cidade")
                CEP = .Item("CEP")
                Estado = .Item("Estado")
                Telefone = .Item("Telefone")
            End With
        End Sub

        Public Function Delete() As Boolean

            Dim sql As String
            sql = "delete * from TBMEDICO where ID = '" & pID & "'"

            If ExecuteSQL(sql) = 1 Then
                Return True
            Else
                Return False
            End If

        End Function

        Public Function save() As Boolean
            Dim sql As String

            If Acao = TipoAcao.Inserir Then
                sql = "insert into TBMEDICO(NOME,RG,CPF,DATANASCIMENTO,ESTADOCIVIL,SEXO,CRM,EMAIL,LOGRADOURO,NUMERO,BAIRRO,CIDADE,CEP,ESTADO,TELEFONE) values('" & Nome & "','" & RG & "','" & CPF & "','" & DataNascimento & "','" & EstadoCivil & "','" & Sexo & "','" & CRM & "','" & Email & "','" & Lougradouro & "','" & Numero & "','" & Bairro & "','" & Cidade & "','" & CEP & "','" & Estado & "','" & Telefone & "')"
            Else
                sql = "update TBMEDICO set Nome ='" & Nome & _
                    "',RG ='" & RG & _
                    "',CPF ='" & CPF & _
                    "',DataNascimento ='" & DataNascimento & _
                    "',EstadoCivil ='" & EstadoCivil & _
                    "',Sexo ='" & Sexo & _
                    "',CRM ='" & CRM & _
                    "',Email ='" & Email & _
                    "',Logradouro ='" & Lougradouro & _
                    "',Numero ='" & Numero & _
                    "',Bairro ='" & Bairro & _
                    "',Cidade ='" & Cidade & _
                    "',CEP ='" & CEP & _
                    "',Estado ='" & Estado & _
                    "',Telefone ='" & Telefone & _
                    "'where ID = '" & ID & "'"
            End If
            If ExecuteSQL(sql) = 1 Then
                Return True
            Else
                Return False
            End If
        End Function

    End Class

End Namespace
