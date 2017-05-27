Public Class Instrucciones
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Close()
    End Sub

    Private Sub Instrucciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If banCategoria = True Then
            PictureBox1.Image = ThinkCoffee.My.Resources.Resources.categoria
            banCategoria = False
        ElseIf banInsumo = True Then
            PictureBox1.Image = ThinkCoffee.My.Resources.Resources.recetas
            banInsumo = False
        End If
    End Sub
End Class