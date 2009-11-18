Namespace UTFPR

    Public Class classPessoaJuridica

        Inherits UTFPR.classPessoa

        'Private CNPJ As String
        'Private InscricaoEstadual As String
        'Private RazaoSocial As String

        Private pCNPJ As String
        Public Property CNPJ() As String
            Get
                Return pCNPJ
            End Get
            Set(ByVal value As String)
                pCNPJ = value
            End Set
        End Property

        Private pInscricaoEstadual As String
        Public Property InscricaoEstadual() As String
            Get
                Return pInscricaoEstadual
            End Get
            Set(ByVal value As String)
                pInscricaoEstadual = value
            End Set
        End Property

        Private pRazaoSocial As String
        Public Property RazaoSocial() As String
            Get
                Return pRazaoSocial
            End Get
            Set(ByVal value As String)
                pRazaoSocial = value
            End Set
        End Property

    End Class

End Namespace
