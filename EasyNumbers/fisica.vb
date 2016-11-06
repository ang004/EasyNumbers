Public Class fisica
    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs)
        If panel1.Visible Then
            panel1.Visible = False
        Else

            panel2.Visible = False
            panel3.Visible = False
            panel1.Visible = True
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        If panel2.Visible Then
            panel2.Visible = False
        Else
            panel1.Visible = False
            panel3.Visible = False
            panel2.Visible = True

        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)
        If panel3.Visible Then
            panel3.Visible = False
        Else
            panel1.Visible = False
            panel2.Visible = False
            panel3.Visible = True

        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        main.Show()
        Me.Hide()
    End Sub
End Class