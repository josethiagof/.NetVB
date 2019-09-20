Namespace Classes.Funcionarios

    Public Class Funcionario

#Region "Propriedades"
        Public Property nome As String
        Public Property cpf As String
        Public Property salario As Double
#End Region

#Region "Métodos"
        Public Function GetBonificacao() As Double
            Return salario * 0.1
        End Function
#End Region

    End Class

End Namespace