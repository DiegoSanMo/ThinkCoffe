Public Class BuscarProveedor
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Close()
    End Sub

    Private Sub BuscarProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgProv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgProv.Rows.Clear()
        comando.CommandText = "select tlb_proveedor.idProveedor, tlb_proveedor.nombre from tlb_proveedor"
        lector = comando.ExecuteReader
        While lector.Read
            dgProv.Rows.Add(lector(0), lector(1))
        End While
        lector.Close()
    End Sub
End Class