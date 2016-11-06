Public Class Pitagoras
    Dim a, b, c As Double
    
    Private Sub cmdCalcular_Click(sender As Object, e As EventArgs) Handles cmdCalcular.Click
        If txt2.Text = Nothing Then
            b = txt3.Text
            c = txt1.Text
            a = Math.Sqrt(Math.Pow(c, 2) - Math.Pow(b, 2))
            txt2.Text = FormatNumber(a, 2)
        End If
        If txt3.Text = Nothing Then
            a = txt2.Text
            c = txt1.Text
            b = Math.Sqrt(Math.Pow(c, 2) - Math.Pow(a, 2))
            txt3.Text = FormatNumber(b, 2)
        End If
        If txt1.Text = Nothing Then
            a = txt2.Text
            b = txt3.Text
            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2))
            txt1.Text = FormatNumber(c, 2)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each control In Me.Controls
            If TypeOf control Is TextBox Then
                control.Text = Nothing
            End If
        Next
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        matematicas.Show()
        Me.Close()
    End Sub
End Class