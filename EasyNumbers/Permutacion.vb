Public Class Permutacion
    Private Sub cmdCalcular_Click(sender As Object, e As EventArgs)
        Dim resultado As Double
        ' CalcularPermutacion()
        resultado = CalcularPermutacion()
        txtResultado.Text = resultado
    End Sub

    Function CalcularPermutacion()
        Dim elementos As Integer = txtN.Text
        Dim conjuntos As Integer = txtR.Text
        Dim c_e As Integer = elementos - conjuntos
        Dim factorial As Integer = 1
        Dim factorial2 As Integer = 1
        Dim i As Integer

        For i = 1 To elementos
            factorial = factorial * i
        Next i

        For i = 1 To c_e
            factorial2 = factorial2 * i
        Next i

        Dim resultado = factorial / factorial2

        Return resultado

    End Function

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        matematicas.Show()
        Me.Hide()
    End Sub
End Class