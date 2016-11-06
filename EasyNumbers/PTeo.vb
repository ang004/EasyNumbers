Public Class PTeo
    Private Sub cmdCalcular_Click(sender As Object, e As EventArgs)
        txtResultado.Text = Calcular_PT()
    End Sub

    Function Calcular_PT()
        Dim k As Integer = txtK.Text
        Dim n As Integer = txtN.Text

        Dim Resultado As Double = k / n

        Return Resultado
    End Function

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        matematicas.Show()
        Me.Close()
    End Sub
End Class