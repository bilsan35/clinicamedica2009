Public Class BaseEntity(Of T)
    Public Function selecionar() As List(Of T)
        Return New List(Of T)()
    End Function

End Class
