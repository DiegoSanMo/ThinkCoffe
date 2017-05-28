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
        conexionSql.Open()

        comando.CommandText = "Select count(tlb_insumo.idInsumo) from tlb_insumo"
        Dim cantInsumo As Integer = comando.ExecuteScalar
        If cantInsumo > 0 Then
            conexionSql.Close()
            frmCatalogoRecetas.ShowDialog()
        Else
            MessageBox.Show("NO SE HAN REGISTRADO INSUMOS, FAVOR DE REGISTRAR INSUMOS", "FALTA DE INSUMOS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conexionSql.Close()
            mostrarGif(2)
        End If
    End Sub

    Private Sub ProductosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem1.Click
        conexionSql.Open()

        comando.CommandText = "Select count(tlb_categoria.idCategoria) from tlb_categoria"
        Dim cantCategoria As Integer = comando.ExecuteScalar
        If cantCategoria > 0 Then

            If contarInsumos() > 0 Then
                conexionSql.Close()
                frmCatalogoProductos.ShowDialog()
            Else
                MessageBox.Show("NO SE HAN REGISTRADO INSUMOS, FAVOR DE REGISTRAR INSUMOS", "FALTA DE INSUMOS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conexionSql.Close()
                mostrarGif(2)
            End If


            'comando.CommandText = "Select count(tlb_insumo.idInsumo) from tlb_insumo"
            'Dim cantInsumo As Integer = comando.ExecuteScalar
        Else
            MessageBox.Show("NO SE HAN REGISTRADO CATEGORIAS, FAVOR DE REGISTRAR CATEGORÌAS", "FALTA DE CATEGORIAS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conexionSql.Close()
            mostrarGif(1)

        End If



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


    Private Sub ModificaciónToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmModificacionProducto.ShowDialog()
    End Sub

    Private Sub CompraToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CompraDeInsumosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompraDeInsumosToolStripMenuItem.Click
        conexionSql.Open()


        If contarInsumos() > 0 Then

            comando.CommandText = "Select count(tlb_proveedor.idProveedor) from tlb_proveedor"
            Dim n As Integer = comando.ExecuteScalar
            If n > 0 Then
                conexionSql.Close()
                frmCompraDeInsumos.ShowDialog()

            Else
                MessageBox.Show("NO SE HAN REGISTRADO PROVEEDORES, FAVOR DE REGISTRAR PROVEEDORES PARA REALIZAR UN REGISTRO COMPLETO DE COMPRA", "ERROR, FALTA DE INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conexionSql.Close()
            End If
        Else
            MessageBox.Show("NO SE HAN REGISTRADO INSUMOS, FAVOR DE REGISTRAR INSUMOS PARA REALIZAR UN REGISTRO COMPLETO DE COMPRA", "ERROR, FALTA DE INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conexionSql.Close()
        End If
    End Sub

    Private Sub ComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprasToolStripMenuItem.Click
        frmConsultaCompra.ShowDialog()
    End Sub

    Private Sub InsumosToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles InsumosToolStripMenuItem.Click
        conexionSql.Open()
        If contarInsumos() > 0 Then
            conexionSql.Close()
            frmConsultaInsumo.ShowDialog()
        Else
            MessageBox.Show("NO SE HAN REGISTRADO INSUMOS", "FALTA DE INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conexionSql.Close()
        End If


    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click

    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        frmConsultaProducto.ShowDialog()
    End Sub

    Private Sub RecetasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecetasToolStripMenuItem.Click

        'comando.CommandText = "Select count(tlb_insumo.idInsumo) from tlb_insumo"
        'Dim cantInsumo As Integer = comando.ExecuteScalar

        frmConsultaReceta.ShowDialog()
    End Sub

    Private Sub PizzaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PizzaToolStripMenuItem.Click
        ConsultaVentaPizzas.ShowDialog()
    End Sub

    Private Sub OtrosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OtrosToolStripMenuItem1.Click
        ConsultaOtros.ShowDialog()
    End Sub
End Class