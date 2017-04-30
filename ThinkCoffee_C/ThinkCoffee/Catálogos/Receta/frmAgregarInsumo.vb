Public Class frmAgregarInsumo


    Private Sub frmAgregarInsumo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        dgInsumos.Rows.Clear()

        comando.CommandText = "Select tlb_insumo.idInsumo, tlb_insumo.nombre, tlb_insumo.unidadM, tlb_insumo.existencia  from tlb_insumo where tlb_insumo.nombre like '" & txtNombre.Text & "'"
        lector = comando.ExecuteReader()

        While lector.Read
            dgInsumos.Rows.Add(lector(0), lector(1), lector(2), lector(3))
        End While
        lector.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Me.Close()
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaValida, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub
End Class