Public Class buscarProducto
    Private Sub buscarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionSql.Open()

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
End Class