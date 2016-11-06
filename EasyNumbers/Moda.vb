Public Class Moda
    Private Sub cmdCalcular_Click(sender As Object, e As EventArgs)
        txtResultado.Text = CalcularModa()
    End Sub

    Function CalcularModa()
        Dim numeros() As String = Split(txtNumeros.Text, ",")
        Dim i As Integer
        Dim j As Integer
        Dim contador As Integer = 0
        Dim sum As Integer = 0
        Dim moda As Integer = 0

        For i = 0 To numeros.GetUpperBound(0)
            contador = 0
            For j = 0 To numeros.GetUpperBound(0)
                If (CInt(numeros(i)) = CInt(numeros(j))) Then
                    contador = contador + 1
                End If
            Next

            If contador >= sum Then
                sum = contador
                moda = numeros(i)
            End If

        Next

        Return moda

    End Function

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        matematicas.Show()
        Me.Close()
    End Sub
End Class