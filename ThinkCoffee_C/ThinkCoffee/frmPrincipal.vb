Public Class frmPrincipal
    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnRegistro_Click(sender As Object, e As EventArgs)
        frmCatalogoProveedores.ShowDialog()
    End Sub

    Private Sub RecordatoriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecordatoriosToolStripMenuItem.Click
        frmCatalogoRecordatorios.ShowDialog()
    End Sub

    Private Sub InsumosToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub ProveedoresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem1.Click
        frmCatalogoProveedores.ShowDialog()

    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        menuBar.Width = 80
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Private Sub PromocionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PromocionesToolStripMenuItem.Click
    End Sub

    Private Sub ProductosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem1.Click
    End Sub

    Private Sub CategoriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriasToolStripMenuItem.Click
        frmCatalogoCategoria.ShowDialog()
    End Sub

    Private Sub IngredientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngredientesToolStripMenuItem.Click
        frmCatalogoInsumos.ShowDialog()
    End Sub

    Private Sub VentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentaToolStripMenuItem.Click

    End Sub


    Private Sub OtrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OtrosToolStripMenuItem.Click
        frmMovimientoVentas.ShowDialog()
    End Sub

    Private Sub PiizaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PiizaToolStripMenuItem.Click
        VentaPizza.ShowDialog()
    End Sub

    Private Sub RegistroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroToolStripMenuItem.Click
        frmCatalogoProductos.ShowDialog()
    End Sub

    Private Sub ModificaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificaciónToolStripMenuItem.Click
        frmModificacionProducto.ShowDialog()
    End Sub

    Private Sub RegistrarRecetaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarRecetaToolStripMenuItem.Click
        frmCatalogoRecetas.ShowDialog()
    End Sub

    Private Sub CompraToolStripMenuItem_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub CompraDeInsumosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompraDeInsumosToolStripMenuItem.Click
        frmCompraDeInsumos.ShowDialog()
    End Sub
End Class