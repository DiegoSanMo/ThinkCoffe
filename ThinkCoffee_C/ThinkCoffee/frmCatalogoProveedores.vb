Public Class frmCatalogoProveedores
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ptbBarra_MouseDown(sender As Object, e As MouseEventArgs) Handles ptbBarra.MouseDown
        ex = e.X
        ey = e.Y
        mover = True

    End Sub
    Private Sub ptbBarra_Move(sender As Object, e As EventArgs) Handles ptbBarra.Move
        If mover = True Then
            If mover Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))
        End If

    End Sub


    Private Sub ptbBarra_MouseUp(sender As Object, e As MouseEventArgs) Handles ptbBarra.MouseUp
        mover = False
    End Sub



End Class
