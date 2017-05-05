Public Class frmInsumosAagregar
    Dim filaSel As Integer
    Private Sub frmInsumosAagregar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim rejilla As New frmAgregarInsumo

    End Sub

    Private Sub dgInsumos_SelectionChanged(sender As Object, e As EventArgs) Handles dgInsumos.SelectionChanged
        filaSel = dgInsumos.CurrentCell.RowIndex
        MsgBox(filaSel)
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

        dgInsumos.Rows.Clear()

        comando.CommandText = "Select tlb_insumo.idInsumo, tlb_insumo.nombre, tlb_insumo.existencia, tlb_insumo.maximo, tlb_insumo.minimo from tlb_insumo where nombre like '" & txtBuscar.Text & "%'"
        lector = comando.ExecuteReader()

        While lector.Read
            dgInsumos.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
        End While
        lector.Close()

    End Sub
End Class