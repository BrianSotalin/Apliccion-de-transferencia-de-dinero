Public Class Form1

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub


    Private Sub ingresar()
        If txtname.Text = "Sota" And txtpss.Text = "123" Then
            Me.Hide()
            MsgBox("*****BIENVENIDO SOTA*****")
            delivery.Show()
        Else
            MsgBox("Credenciales incorrectas", vbCritical)
            txtname.Text = ""
            txtpss.Text = ""
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ingresar()
    End Sub
End Class
