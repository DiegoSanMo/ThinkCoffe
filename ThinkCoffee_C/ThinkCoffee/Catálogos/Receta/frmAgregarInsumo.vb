Public Class frmAgregarInsumo
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim agregas As New frmInsumosAagregar

        agregas.dgInsumos.Rows.Clear()

        comando.CommandText = "Select * from tlb_insumo"
        lector = comando.ExecuteReader
        While lector.Read
            agregas.dgInsumos.Rows.Add(lector(0), lector(1), lector(5), lector(3), lector(4))
        End While
        lector.Close()
        agregas.ShowDialog()
    End Sub
End Class