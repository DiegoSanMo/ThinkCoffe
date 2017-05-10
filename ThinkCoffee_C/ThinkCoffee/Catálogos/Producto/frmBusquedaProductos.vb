Public Class frmBusquedaProductos
    Private Sub frmBusquedaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comando.CommandText = "Select * from tlb_receta"
        lector = comando.ExecuteReader

        While lector.Read
            dgBusquedaRecetas.Rows.Add(lector(0), lector(1))
        End While
        lector.Close()

    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        dgBusquedaRecetas.Rows.Clear()

        comando.CommandText = "Select tlb_receta.idReceta, tlb_receta.nombre  from tlb_receta where tlb_receta.nombre like '%" & txtNombre.Text & "%'"
        lector = comando.ExecuteReader

        While lector.Read
            dgBusquedaRecetas.Rows.Add(lector(0), lector(1))
        End While
        lector.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Me.Close()
    End Sub
End Class