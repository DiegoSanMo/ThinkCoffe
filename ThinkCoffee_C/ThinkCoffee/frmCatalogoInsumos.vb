Public Class frmCatalogoInsumos
    Private Sub frmCatalogoInsumos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionSql.Open()
        Dim n As Integer
        comando.CommandText = String.Format("Select count(*) from tlb_insumo")
        n = comando.ExecuteScalar + 1
        If n > 1 Then
            comando.CommandText = String.Format("Select * from tlb_insumo")
            lector = comando.ExecuteReader

            While lector.Read
                dgInsumo.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6), lector(7))
            End While
            lector.Close()

        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        conexionSql.Close()
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        btnNuevo.Enabled = False
        btnSalir.Enabled = False
        activarCajasInsumo()
        txtNombre.Focus()

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        limpiarCajaInsumos()
        bloquearCajasInsumo()
    End Sub
End Class