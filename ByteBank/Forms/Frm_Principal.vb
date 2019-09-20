Imports ByteBank.Classes.Funcionarios

Public Class Frm_Principal
    Private Sub Btn_Clique_Click(sender As Object, e As EventArgs) Handles Btn_Clique.Click

        Dim Carlos As New Funcionario
        Carlos.nome = "Carlos Antônio"
        Carlos.cpf = "111.111.111-11"
        Carlos.salario = 10000

        MsgBox("O salário do " + Carlos.nome + " é " + Carlos.salario.ToString)
        MsgBox("A bonificação de " + Carlos.nome + " é " + Carlos.GetBonificacao.ToString)
    End Sub
End Class