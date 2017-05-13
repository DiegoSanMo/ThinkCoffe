Public Class frmMovimientoVentas
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        buscarProducto.ShowDialog()
        Dim fila, idProd As Integer

        If buscarProducto.dgProductosBuscados.CurrentRow IsNot Nothing Then
            fila = buscarProducto.dgProductosBuscados.CurrentCell.RowIndex
            idProd = buscarProducto.dgProductosBuscados(0, fila).Value

            comando.CommandText = "Select tlb_producto.nombre, tlb_categoria.nombre, tlb_producto.precio, tlb_producto.idProducto from tlb_producto inner join tlb_categoria on tlb_categoria.idCategoria = tlb_producto.idCategoria where tlb_producto.idProducto = " & idProd & ""
            lector = comando.ExecuteReader
            lector.Read()
            txtNombreP.Text = lector(0)
            txtCategoria.Text = lector(1)
            txtPrecio.Text = lector(2)
            txtIdProducto.Text = lector(3)
            lector.Close()
        End If
    End Sub

    Private Sub frmMovimientoVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionSql.Open()

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtCantidad.Enabled = True
        btnBuscar.Enabled = True
        btnAceptar.Enabled = True
        btnGrabar.Enabled = True

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim ban As Boolean = False
        Dim pos As Integer
        Dim suma As Decimal
        Dim total As Decimal


        For x = 0 To dgVenta.RowCount - 1
            If dgVenta(0, x).Value = txtIdProducto.Text Then
                pos = x
                ban = True
                Exit For
            Else
                ban = False
            End If
        Next

        If ban Then
            suma = dgVenta(2, pos).Value + Val(txtCantidad.Text)
            dgVenta(2, pos).Value = suma
            dgVenta(4, pos).Value = dgVenta(2, pos).Value * dgVenta(3, pos).Value
        Else
            dgVenta.Rows.Add(txtIdProducto.Text, txtNombreP.Text, txtCantidad.Text, txtPrecio.Text, txtCantidad.Text * txtPrecio.Text)
        End If


        For x = 0 To dgVenta.RowCount - 1
            total = total + CDec(dgVenta(4, x).Value)
        Next
        txtTotal.Text = total

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
        conexionSql.Close()
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        For x = 0 To dgVenta.RowCount - 1
            calcularPorcion(CInt(dgVenta(0, x).Value))
        Next
    End Sub
End Class