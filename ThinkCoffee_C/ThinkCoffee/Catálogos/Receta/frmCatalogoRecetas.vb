Public Class frmCatalogoRecetas
    Private Sub frmCatalogoRecetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionSql.Open()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim insumos As New frmAgregarInsumo
        Dim ban As Boolean = False


        comando.CommandText = "Select tlb_insumo.idInsumo, tlb_insumo.nombre, tlb_insumo.unidadM, tlb_insumo.existencia  from tlb_insumo "
        lector = comando.ExecuteReader()

        While lector.Read
            insumos.dgInsumos.Rows.Add(lector(0), lector(1), lector(2), lector(3))
        End While
        lector.Close()
        insumos.ShowDialog()

        Dim fila As Integer = insumos.dgInsumos.CurrentRow.Index
        txtIdInsumo.Text = insumos.dgInsumos(0, fila).Value
        txtInsumo.Text = insumos.dgInsumos(1, fila).Value
        txtMedida.Text = insumos.dgInsumos(2, fila).Value
        txtExistencia.Text = insumos.dgInsumos(3, fila).Value

        btnAgregar.Enabled = True

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
        txtNombre.Enabled = True

        btnBuscar.Enabled = True

        txtNombre.Focus()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        dgReceta.Rows.Add(txtIdInsumo.Text, txtInsumo.Text, txtCantidad.Text)
        txtIdInsumo.Text = ""
        txtExistencia.Text = ""
        txtInsumo.Text = ""
        txtMedida.Text = ""
        txtCantidad.Text = ""

        btnAgregar.Enabled = False
        btnBuscar.Focus()
    End Sub
End Class