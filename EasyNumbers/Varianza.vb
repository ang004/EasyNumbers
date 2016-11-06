Public Class Varianza
    Private Sub cmdCalcular_Click(sender As Object, e As EventArgs)
        txtResultado.Text = CalcularVarianza()
    End Sub

    Function CalcularVarianza()
        Dim numeros() As String = Split(txtNumeros.Text, ",")
        Dim suma As Integer = 0
        Dim suma_v As Integer = 0
        Dim contador As Integer = 0
        Dim contador_v As Double = 0
        Dim media As Double = 0
        Dim diferencia As Double = 0
        For Each num In numeros
            suma = suma + num
            contador = contador + 1
        Next num

        media = suma / contador

        For Each num In numeros
            diferencia = CInt(num) - media
            suma_v = suma_v + Math.Pow(diferencia, 2)
            contador_v = contador_v + 1
        Next num

        Dim varianza As Double = suma_v / contador_v

        Return varianza

    End Function

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        matematicas.Show()
        Me.Close()
    End Sub
End Class