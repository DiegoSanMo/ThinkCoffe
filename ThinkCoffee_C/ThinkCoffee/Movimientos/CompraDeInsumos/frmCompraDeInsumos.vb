Public Class frmCompraDeInsumos
    Private Sub frmCompraDeInsumos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionSql.Open()

        comando.CommandText = "Select tlb_proveedor.nombre from tlb_proveedor"
        lector = comando.ExecuteReader
        While lector.Read
            cboProveedor.Items.Add(lector(0))
        End While
        lector.Close()

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        cboProveedor.Enabled = True

    End Sub

    Private Sub btnBuscarIn_Click(sender As Object, e As EventArgs) Handles btnBuscarIn.Click
        Dim fila As Integer

        frmAgregarInsumo.ShowDialog()
        fila = frmAgregarInsumo.dgInsumos.CurrentRow.Index
        Dim idInsumo As Integer = frmAgregarInsumo.dgInsumos.Item(0, fila).Value

        comando.CommandText = "select tlb_insumo.nombre, tlb_insumo.existencia, tlb_insumo.maximo, tlb_insumo.minimo, tlb_insumo.unidadM, tlb_insumo.fecha, tlb_insumo.costo from tlb_insumo where tlb_insumo.idInsumo = " & idInsumo & ""
        lector = comando.ExecuteReader
        lector.Read()

        txtIdInsumo.Text = idInsumo
        txtNombreInsumo.Text = lector(0)
        txtExistencias.Text = lector(1)
        txtMaximo.Text = lector(2)
        txtMinimo.Text = lector(3)
        txtUnidadM.Text = lector(4)
        txtFechaInsumo.Text = lector(5)
        txtCosto.Text = lector(6)
        lector.Close()


    End Sub
End Class