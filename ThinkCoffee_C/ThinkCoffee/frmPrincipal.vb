Public Class frmPrincipal
    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click

    End Sub

    Private Sub btnRegistro_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click

    End Sub

    Private Sub CategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriaToolStripMenuItem.Click
        frmCatalogoCategoria.Show()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        frmCatalogoProducto.Show()
    End Sub
End Class