Public Class frmConsultaProducto
    Private Sub frmConsultaProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionSql.Open()
        cboCategoriaConsulta.Items.Clear()
        comando.CommandText = "Select tlb_categoria.nombre From tlb_categoria"
        lector = comando.ExecuteReader
        While lector.Read
            cboCategoriaConsulta.Items.Add(lector(0))
        End While
        lector.Close()
    End Sub

    Private Sub rbtConsultaCategoria_CheckedChanged(sender As Object, e As EventArgs) Handles rbtConsultaCategoria.CheckedChanged
        If rbtConsultaCategoria.Checked Then
            cboCategoriaConsulta.Visible = True
        Else
            cboCategoriaConsulta.Visible = False
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        dgvConsultaProductos.Rows.Clear()
        If rbtConsultaCategoria.Checked Then
            comando.CommandText = "Select tlb_producto.idProducto, tlb_producto.nombre, tlb_categoria.nombre, tlb_producto.precio From tlb_producto INNER JOIN tlb_categoria ON tlb_producto.idCategoria = tlb_categoria.idCategoria Where tlb_categoria.nombre='" & cboCategoriaConsulta.Text & "'"
            lector = comando.ExecuteReader
            While lector.Read
                dgvConsultaProductos.Rows.Add(lector(0), lector(1), lector(2), lector(3))
            End While
            lector.Close()
        ElseIf rbtConsultaTodo.Checked Then
            comando.CommandText = "Select tlb_producto.idProducto, tlb_producto.nombre, tlb_categoria.nombre, tlb_producto.precio From tlb_producto INNER JOIN tlb_categoria ON tlb_producto.idCategoria = tlb_categoria.idCategoria"
            lector = comando.ExecuteReader
            While lector.Read
                dgvConsultaProductos.Rows.Add(lector(0), lector(1), lector(2), lector(3))
            End While
            lector.Close()
        End If
    End Sub
    Private Sub btnSalir_Click_1(sender As Object, e As EventArgs) Handles btnSalir.Click
        conexionSql.Close()
        Me.Close()
    End Sub
End Class