Public Class Pantalla_Inicio
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Tipo_Usuario.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        System.Diagnostics.Process.Start("https://www.joyfe.es/etapas/ciclos-formativos/dam/")
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        System.Diagnostics.Process.Start("https://www.joyfe.es/etapas/ciclos-formativos/smr/")
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        System.Diagnostics.Process.Start("https://www.joyfe.es/etapas/ciclos-formativos/teas/?utm_source=facebook-ads&utm_medium=cpc&utm_campaign=TEAS+-+Copia")
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        System.Diagnostics.Process.Start("https://joyfe.jobteaser.com/es/users/sign_in?back_to_after_login=%2F")
    End Sub
End Class
