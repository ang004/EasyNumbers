Public Class Mediana
    Private Sub cmdCalcular_Click(sender As Object, e As EventArgs)
        txtResultado.Text = CalcularMediana()
    End Sub

    Function CalcularMediana()
        Dim numeros() As String = Split(txtNumeros.Text, ",")
        Dim i = 0
        Dim aux As Integer
        Dim ordenacion As String = ""

        ' MsgBox(numeros.Length)
        For j = 1 To numeros.Length - 1
            For i = 0 To numeros.Length - j - 1

                If numeros(i) > numeros(i + 1) Then
                    aux = numeros(i + 1)
                    numeros(i + 1) = numeros(i)
                    numeros(i) = aux
                End If
                'MsgBox(numeros(i))
                ordenacion = ordenacion + numeros(i)
                MsgBox(ordenacion)

            Next
            ordenacion = ordenacion & Environment.NewLine
        Next

        'For Each num In numeros
        'MsgBox(num)
        'Next num

        Dim mediana As Double = 0

        Dim mitad As Integer = numeros.Length / 2
        MsgBox(mitad)
        'MsgBox((numeros.Length Mod 2) = 0)

        If ((numeros.Length Mod 2) = 0) Then
            'MsgBox(numeros(mitad) & " + " & numeros(mitad - 1))
            Dim med1 = CInt(numeros(mitad))
            Dim med2 = CInt(numeros(mitad - 1))
            mediana = (med1 + med2) / 2
        Else
            mediana = numeros(mitad)
        End If
        'MsgBox("Mediana es igual a " & mediana)
        Return mediana
    End Function

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        matematicas.Show()
        Me.Close()
    End Sub
End Class