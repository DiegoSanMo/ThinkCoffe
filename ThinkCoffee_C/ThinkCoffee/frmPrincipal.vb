Public Class frmPrincipal
    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnRegistro_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
        frmCatalogoProveedores.Show()
    End Sub

    Private Sub RecordatoriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecordatoriosToolStripMenuItem.Click
        btnRegistro.Visible = False
        btnModificaciones.Visible = False
        lblMensajeProv.Visible = False
        frmCatalogoRecordatorios.Show()
    End Sub

    Private Sub InsumosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsumosToolStripMenuItem.Click
    End Sub

    Private Sub CategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriaToolStripMenuItem.Click
        btnRegistro.Visible = False
        btnModificaciones.Visible = False
        lblMensajeProv.Visible = False
        frmCatalogoCategoria.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem1.Click
        btnRegistro.Visible = True
        btnModificaciones.Visible = True
        lblMensajeProv.Visible = True
    End Sub
End Class