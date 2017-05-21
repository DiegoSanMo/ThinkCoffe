Public Class frmAgregarReceta
    Private Sub btnAgregarReceta_Click(sender As Object, e As EventArgs) Handles btnAgregarReceta.Click
        Me.Close()
    End Sub

    Private Sub frmAgregarReceta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvRecetas.Rows.Clear()
        comando.CommandText = "Select count (*) From tlb_receta"
        Dim n As Integer = comando.ExecuteScalar + 1

        If n > 0 Then
            comando.CommandText = "Select tlb_receta.idReceta, tlb_receta.nombre From tlb_receta"
            lector = comando.ExecuteReader
            While lector.Read
                dgvRecetas.Rows.Add(lector(0), lector(1))
            End While
            lector.Close()
        End If
    End Sub
End Class