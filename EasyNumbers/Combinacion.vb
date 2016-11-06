Public Class Combinacion
    Private Sub cmdCalcular_Click(sender As Object, e As EventArgs)
        Dim resultado As Double = CalcularCombinacion()
        txtResultado.Text = resultado
    End Sub

    Function CalcularCombinacion()
        Dim elementos As Integer = txtN.Text
        Dim conjuntos As Integer = txtR.Text
        Dim c_e As Integer = elementos - conjuntos
        Dim factorialN As Integer = 1
        Dim factorial_CE As Integer = 1
        Dim factorialR As Integer = 1
        Dim i As Integer
        Dim j As Integer
        Dim k As Integer

        For i = 1 To elementos
            factorialN = factorialN * i
        Next i

        For j = 1 To conjuntos
            factorialR = factorialR * j
        Next j

        For k = 1 To c_e
            factorial_CE = factorial_CE * k
        Next k

        Dim resultado = factorialN / (factorialR * factorial_CE)
        ' MsgBox("Factorial N: " & factorialN & " Factorial de R: " & factorialR & "Factorial de CE: " & factorial_CE)

        Return resultado
    End Function

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub txtN_TextChanged(sender As Object, e As EventArgs) Handles txtN.TextChanged

    End Sub

    Private Sub txtR_TextChanged(sender As Object, e As EventArgs) Handles txtR.TextChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub txtResultado_Click(sender As Object, e As EventArgs) Handles txtResultado.Click

    End Sub

    Private Sub cmdCalcular_Click_1(sender As Object, e As EventArgs) Handles cmdCalcular.Click

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click

    End Sub
End Class