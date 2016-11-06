Public Class Media
    Private Sub cmdCalcular_Click(sender As Object, e As EventArgs)
        txtResultado.Text = CalcularMedia()
    End Sub

    Function CalcularMedia()
        Dim numeros() As String = Split(txtNumeros.Text, ",")
        Dim suma As Integer = 0
        Dim contador As Integer = 0
        Dim resultado As Double = 0
        For Each num In numeros
            suma = suma + num
            contador = contador + 1
            ' MsgBox(suma)
            ' MsgBox(contador)
        Next num

        resultado = suma / contador
        Return resultado
    End Function

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        matematicas.Show()
        Me.Close()
    End Sub
End Class