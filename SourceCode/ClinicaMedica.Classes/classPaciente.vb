Namespace UTFPR

    Public Class classPaciente

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

        Private pConvenio As String
        Public Property Convenio() As String
            Get
                Return pConvenio
            End Get
            Set(ByVal value As String)
                pConvenio = value
            End Set
        End Property

        Private pComplemento As String
        Public Property Complemento() As String
            Get
                Return pComplemento
            End Get
            Set(ByVal value As String)
                pComplemento = value
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
            sql = "select * from TBPACIENTE where ID ='" & pID & "'"

            Dim objDR As Data.DataRow
            objDR = retornaDataSet(sql).Tables(0).Rows(0)

            With objDR
                Nome = .Item("Nome")
                RG = .Item("RG")
                CPF = .Item("CPF")
                DataNascimento = .Item("DataNascimento")
                Convenio = .Item("Convenio")
                EstadoCivil = .Item("EstadoCivil")
                Sexo = .Item("Sexo")
                Email = .Item("Email")
                Lougradouro = .Item("Logradouro")
                Numero = .Item("Numero")
                Complemento = .Item("Complemento")
                Bairro = .Item("Bairro")
                Cidade = .Item("Cidade")
                CEP = .Item("CEP")
                Estado = .Item("Estado")
                Telefone = .Item("Telefone")
            End With
        End Sub

        Public Function Delete() As Boolean

            Dim sql As String
            sql = "delete * from TBPACIENTE where ID = '" & pID & "'"

            If ExecuteSQL(sql) = 1 Then
                Return True
            Else
                Return False
            End If

        End Function

        Public Function save() As Boolean
            Dim sql As String

            If Acao = TipoAcao.Inserir Then
                sql = "insert into TBPACIENTE(NOME,RG,CPF,DATANASCIMENTO,ESTADOCIVIL,SEXO,CONVENIO,EMAIL,LOGRADOURO,NUMERO,COMPLEMENTO,BAIRRO,CIDADE,CEP,ESTADO,TELEFONE) values('" & Nome & "','" & RG & "','" & CPF & "','" & DataNascimento & "','" & EstadoCivil & "','" & Sexo & "','" & Convenio & "','" & Email & "','" & Lougradouro & "','" & Numero & "','" & Complemento & "','" & Bairro & "','" & Cidade & "','" & CEP & "','" & Estado & "','" & Telefone & "')"
            Else
                sql = "update TBPACIENTE set Nome ='" & Nome & _
                    "',RG ='" & RG & _
                    "',CPF ='" & CPF & _
                    "',DataNascimento ='" & DataNascimento & _
                    "',EstadoCivil ='" & EstadoCivil & _
                    "',Sexo ='" & Sexo & _
                    "',Convenio ='" & Convenio & _
                    "',Email ='" & Email & _
                    "',Logradouro ='" & Lougradouro & _
                    "',Numero ='" & Numero & _
                    "',Complemento ='" & Complemento & _
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
