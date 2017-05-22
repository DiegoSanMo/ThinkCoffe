Public Class frmPrincipal
    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnRegistro_Click(sender As Object, e As EventArgs)
        frmCatalogoProveedores.ShowDialog()
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
        frmCatalogoRecetas.ShowDialog()
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
        frmMovimientoVentasPizzas.ShowDialog()
    End Sub

    Private Sub RegistroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroToolStripMenuItem.Click
        frmCatalogoProductos.ShowDialog()
    End Sub

    Private Sub ModificaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificaciónToolStripMenuItem.Click
        frmModificacionProducto.ShowDialog()
    End Sub

    Private Sub CompraToolStripMenuItem_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub CompraDeInsumosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompraDeInsumosToolStripMenuItem.Click
        frmCompraDeInsumos.ShowDialog()
    End Sub

    Private Sub ComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprasToolStripMenuItem.Click
        frmConsultaCompra.ShowDialog()
    End Sub

    Private Sub InsumosToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles InsumosToolStripMenuItem.Click
        frmConsultaInsumo.ShowDialog()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click

    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        frmConsultaProducto.ShowDialog()
    End Sub

    Private Sub RecetasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecetasToolStripMenuItem.Click
        frmConsultaReceta.ShowDialog()
    End Sub

    Private Sub PizzaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PizzaToolStripMenuItem.Click
        ConsultaVentaPizzas.ShowDialog()
    End Sub

    Private Sub OtrosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OtrosToolStripMenuItem1.Click
        ConsultaOtros.ShowDialog()
    End Sub
End Class