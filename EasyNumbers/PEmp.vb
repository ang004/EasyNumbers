Public Class PEmp


    Private Sub cmdCalcular_Click(sender As Object, e As EventArgs) Handles cmdCalcular.Click
        txtResultado.Text = Calcular_PE()
    End Sub

    Function Calcular_PE()
        Dim k As Integer = txtK.Text
        Dim n As Integer = txtN.Text

        Dim Resultado As Double = k / n

        Return Resultado
    End Function

    Private Sub Button13_Click(sender As Object, e As EventArgs)
        matematicas.Show()
        Me.Close()
    End Sub
End Class