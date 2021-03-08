Public Class Tipo_Usuario
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Pantalla_Inicio.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Registro.Show()
        Me.Hide()
    End Sub
End Class