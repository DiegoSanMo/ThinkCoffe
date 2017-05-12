Public Class buscarProducto
    Dim banRegresar As Boolean = False
    Private Sub buscarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgProductosBuscados.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgProductosBuscados.Rows.Clear()

        comando.CommandText = "Select tlb_categoria.nombre from tlb_categoria"
        lector = comando.ExecuteReader

        While lector.Read
            cboCategoria.Items.Add(lector(0))
        End While
        lector.Close()

        comando.CommandText = "Select tlb_producto.idProducto, tlb_producto.nombre, tlb_categoria.nombre from tlb_producto inner join tlb_categoria on tlb_categoria.idCategoria = tlb_producto.idCategoria"
        lector = comando.ExecuteReader()
        While lector.Read
            dgProductosBuscados.Rows.Add(lector(0), lector(1), lector(2))
        End While
        lector.Close()



    End Sub

    Private Sub cboCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategoria.SelectedIndexChanged
        dgProductosBuscados.Rows.Clear()
        comando.CommandText = "Select tlb_producto.idProducto, tlb_producto.nombre, tlb_categoria.nombre from tlb_producto inner join tlb_categoria on tlb_categoria.idCategoria = tlb_producto.idCategoria where tlb_categoria.nombre like'%" & cboCategoria.Text & "%'"
        lector = comando.ExecuteReader()
        While lector.Read
            dgProductosBuscados.Rows.Add(lector(0), lector(1), lector(2))
        End While
        lector.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        dgProductosBuscados.Rows.Clear()
        comando.CommandText = "Select tlb_producto.idProducto, tlb_producto.nombre, tlb_categoria.nombre from tlb_producto inner join tlb_categoria on tlb_categoria.idCategoria = tlb_producto.idCategoria where tlb_producto.nombre like '%" & txtNombre.Text & "%'"
        lector = comando.ExecuteReader()
        While lector.Read
            dgProductosBuscados.Rows.Add(lector(0), lector(1), lector(2))
        End While
        lector.Close()
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Close()
    End Sub
End Class