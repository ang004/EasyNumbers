Public Class FTrig
    Dim grado, resultado As Double
    Private Sub cmdCalcular_Click(sender As Object, e As EventArgs) Handles cmdCalcular.Click
        If TextBox1.Text = Nothing Then
            grado = grados.Text
            grado /= (180 / Math.PI)
            resultado = Math.Sin(grado)

            TextBox1.Text = FormatNumber(resultado, 4)
        
        End If
        If TextBox2.Text = Nothing Then
            grado = grados.Text
            grado /= (180 / Math.PI)
            resultado = Math.Cos(grado)
            TextBox2.Text = FormatNumber(resultado, 4)
        
        End If
        If TextBox3.Text = Nothing Then
            grado = grados.Text
            grado /= (180 / Math.PI)
            resultado = Math.Tan(grado)

            TextBox3.Text = FormatNumber(resultado, 4)
        
        End If
        If TextBox4.Text = Nothing Then
            grado = grados.Text
            grado /= (180 / Math.PI)
            resultado = 1 / Math.Sin(grado)
            TextBox4.Text = FormatNumber(resultado, 4)
       
        End If
        If TextBox5.Text = Nothing Then
            grado = grados.Text
            grado /= (180 / Math.PI)
            resultado = 1 / Math.Sin(grado)

            TextBox5.Text = FormatNumber(resultado, 4)
        
        End If
        If TextBox6.Text = Nothing Then
            grado = grados.Text
            grado /= (180 / Math.PI)
            resultado = 1 / Math.Sin(grado)

            TextBox6.Text = FormatNumber(resultado, 4)
        
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