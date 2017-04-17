Public Class frmCatalogoProductos
    Private Sub frmCatalogoProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionSql.Open()
        dgProductos.Rows.Clear()
        Dim n As Integer
        comando.CommandText = String.Format("Select count(*) from tlb_producto	")
        n = comando.ExecuteScalar + 1

        If n > 1 Then
            comando.CommandText = String.Format("Select * from tlb_producto")
            lector = comando.ExecuteReader()
            While lector.Read
                dgProductos.Rows.Add(lector(0), lector(1), lector(2), lector(3))
            End While
            lector.Close()
        End If
    End Sub
End Class