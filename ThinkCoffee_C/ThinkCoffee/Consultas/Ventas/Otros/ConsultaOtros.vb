Public Class ConsultaOtros
    Private Sub btnBuscarP_Click(sender As Object, e As EventArgs) Handles btnBuscarP.Click
        buscarProducto.ShowDialog()
        Dim fila, idProd As Integer
        If buscarProducto.dgProductosBuscados.CurrentRow IsNot Nothing Then
            fila = buscarProducto.dgProductosBuscados.CurrentCell.RowIndex
            idProd = buscarProducto.dgProductosBuscados(0, fila).Value

            comando.CommandText = "Select tlb_producto.nombre from tlb_producto where tlb_producto.idProducto = " & idProd & ""
            lector = comando.ExecuteReader
            lector.Read()
            txtProducto.Text = lector(0)
            lector.Close()
        Else
            MessageBox.Show("NO SE HA INGRESADO PRODUCTO", "FALTA DE INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub rbProducto_CheckedChanged(sender As Object, e As EventArgs) Handles rbProducto.CheckedChanged
        If rbProducto.Checked Then
            txtProducto.Visible = True
            txtProducto.Text = ""
            btnBuscarP.Visible = True
        Else
            txtProducto.Visible = False
            btnBuscarP.Visible = False
        End If
    End Sub

    Private Sub rbCategoria_CheckedChanged(sender As Object, e As EventArgs) Handles rbCategoria.CheckedChanged
        If rbCategoria.Checked Then
            cboCategoria.Visible = True
        Else
            cboCategoria.Visible = False
        End If
    End Sub

    Private Sub rbFecha_CheckedChanged(sender As Object, e As EventArgs) Handles rbFecha.CheckedChanged
        If rbFecha.Checked Then
            lblDesde.Visible = True
            lblHasta.Visible = True
            dtpFechaFinal.Visible = True
            dtpFechaInicial.Visible = True
        Else
            lblDesde.Visible = False
            lblHasta.Visible = False
            dtpFechaFinal.Visible = False
            dtpFechaInicial.Visible = False
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        conexionSql.Close()
        Me.Close()
    End Sub

    Private Sub ConsultaOtros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionSql.Open()
        cboCategoria.Items.Clear()

        comando.CommandText = "Select count(tlb_categoria.idCategoria) from tlb_categoria"
        Dim n As Integer = comando.ExecuteScalar
        If n > 0 Then
            comando.CommandText = "Select tlb_categoria.nombre from tlb_categoria"
            lector = comando.ExecuteReader
            While lector.Read
                cboCategoria.Items.Add(lector(0))
            End While
            lector.Close()
        Else
            cboCategoria.Items.Add("NO SE HAN REGISTRADO CATEGORÍAS")
        End If
    End Sub

    Private Sub cboCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategoria.SelectedIndexChanged

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        dgVentaOtro.Rows.Clear()

        comando.CommandText = "select count(tlb_otro.idVenta) from tlb_otro"
        Dim n As Integer = comando.ExecuteScalar

        If n > 0 Then
            If rbProducto.Checked Then
                If txtProducto.Text = "" Then
                    MessageBox.Show("NO SE HA INGRESADO PRODUCTO PARA REALIZAR BUSQUEDA", "FALTA DE INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Else

                    comando.CommandText = "select tlb_otro.idVenta, tlb_producto.nombre, tlb_categoria.nombre, tlb_venta.fecha, tlb_venta.total from tlb_otro inner join tlb_producto on tlb_otro.idProducto = tlb_producto.idProducto inner join tlb_categoria on tlb_producto.idCategoria = tlb_categoria.idCategoria inner join tlb_venta on tlb_otro.idVenta = tlb_venta.idVenta  where tlb_producto.nombre = '" & txtProducto.Text & "'"
                    lector = comando.ExecuteReader
                    While lector.Read
                        dgVentaOtro.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
                    End While
                    lector.Close()
                End If
            ElseIf rbCategoria.Checked Then
                If cboCategoria.Text = "NO SE HAN REGISTRADO CATEGORÍAS" Or cboCategoria.Text = "" Then
                    MessageBox.Show("NO EXISTEN CATEGORÍAS PARA REALIZAR BUSQUEDA", "FALTA DE INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    comando.CommandText = "select tlb_otro.idVenta, tlb_producto.nombre, tlb_categoria.nombre, tlb_venta.fecha, tlb_venta.total from tlb_otro inner join tlb_producto on tlb_otro.idProducto = tlb_producto.idProducto inner join tlb_categoria on tlb_producto.idCategoria = tlb_categoria.idCategoria inner join tlb_venta on tlb_otro.idVenta = tlb_venta.idVenta where tlb_categoria.nombre = '" & cboCategoria.Text & "'"
                    lector = comando.ExecuteReader
                    While lector.Read
                        dgVentaOtro.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
                    End While
                    lector.Close()

                End If
            ElseIf rbFecha.Checked Then
                comando.CommandText = "select tlb_otro.idVenta, tlb_producto.nombre, tlb_categoria.nombre, tlb_venta.fecha, tlb_venta.total from tlb_otro inner join tlb_producto on tlb_otro.idProducto = tlb_producto.idProducto inner join tlb_categoria on tlb_producto.idCategoria = tlb_categoria.idCategoria inner join tlb_venta on tlb_otro.idVenta = tlb_venta.idVenta  where tlb_venta.fecha  between '" & dtpFechaInicial.Value & "' and '" & dtpFechaFinal.Value & "' "
                lector = comando.ExecuteReader
                While lector.Read
                    dgVentaOtro.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
                End While
                lector.Close()

            End If

        Else
            MessageBox.Show("NO SE HAN REALIZADO VENTAS", "FALTA DE VENTAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


    End Sub
End Class