Public Class frmPrincipal
    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        btnRegistro.Visible = True
        btnModificaciones.Visible = True
        lblMensajeProv.Visible = True
    End Sub

    Private Sub btnRegistro_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
        frmCatalogoProveedores.Show()
    End Sub
End Class