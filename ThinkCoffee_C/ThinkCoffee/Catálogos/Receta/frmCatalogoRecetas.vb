Public Class frmCatalogoRecetas
    Private Sub frmCatalogoRecetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionSql.Open()

        Dim n As Integer
        comando.CommandText = "Select count(*) from tlb_receta"
        n = comando.ExecuteScalar + 1

        If n > 1 Then
            comando.CommandText = "Select * from tlb_receta"
            lector = comando.ExecuteReader()
            While lector.Read
                dgReceta.Rows.Add(lector(0), lector(1))
            End While
            lector.Close()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim insumos As New frmAgregarInsumo

        insumos.txtIdReceta.Text = txtIdReceta.Text
        insumos.txtNombre.Text = txtNombre.Text

        insumos.ShowDialog()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        conexionSql.Close()
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim n As Integer
        comando.CommandText = "Select count(*) from tlb_receta"
        n = comando.ExecuteScalar + 1
        txtIdReceta.Text = n
        btnNuevo.Enabled = False
        btnSalir.Enabled = False
        btnGrabar.Enabled = True
        btnCancelar.Enabled = True

    End Sub

End Class