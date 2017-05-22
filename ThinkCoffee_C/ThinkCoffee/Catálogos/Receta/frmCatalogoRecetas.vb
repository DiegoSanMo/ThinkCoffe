Public Class frmCatalogoRecetas
    'Private Sub frmCatalogoRecetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    conexionSql.Open()
    'End Sub

    'Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
    '    Dim insumos As New frmAgregarInsumo
    '    Dim ban As Boolean = False
    '    insumos.ShowDialog()

    '    Dim fila As Integer = insumos.dgInsumos.CurrentRow.Index
    '    txtIdInsumo.Text = insumos.dgInsumos(0, fila).Value
    '    txtInsumo.Text = insumos.dgInsumos(1, fila).Value
    '    txtMedida.Text = insumos.dgInsumos(2, fila).Value
    '    txtExistencia.Text = insumos.dgInsumos(3, fila).Value

    '    btnAgregar.Enabled = True
    '    txtCantidad.Focus()

    'End Sub

    'Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
    '    conexionSql.Close()
    '    Me.Close()
    'End Sub

    'Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
    '    Dim n As Integer
    '    comando.CommandText = "Select count(*) from tlb_receta"
    '    n = comando.ExecuteScalar + 1

    '    txtIdReceta.Text = n
    '    btnNuevo.Enabled = False
    '    btnSalir.Enabled = False
    '    btnGrabar.Enabled = True
    '    btnCancelar.Enabled = True
    '    txtNombre.Enabled = True

    '    btnBuscar.Enabled = True

    '    txtNombre.Focus()
    '    txtCantidad.Enabled = True


    'End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
    '    dgReceta.Rows.Add(txtIdInsumo.Text, txtInsumo.Text, txtCantidad.Text)
    '    txtIdInsumo.Text = ""
    '    txtExistencia.Text = ""
    '    txtInsumo.Text = ""
    '    txtMedida.Text = ""
    '    txtCantidad.Text = ""

    '    btnAgregar.Enabled = False
    '    btnBuscar.Focus()
    'End Sub

    'Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
    '    comando.CommandText = "Insert into tlb_receta (idReceta, nombre) values(" & Val(txtIdReceta.Text) & ",'" & txtNombre.Text & "')"
    '    comando.ExecuteNonQuery()


    '    For x = 0 To dgReceta.RowCount - 1
    '        comando.CommandText = "Insert into tlb_detReceta (idReceta, idInsumo, cantidad) values(" & Val(txtIdReceta.Text) & ", " & Val(dgReceta(0, x).Value) & ", " & CDec(dgReceta(2, x).Value) & ")"
    '        comando.ExecuteNonQuery()
    '    Next

    '    txtIdReceta.Text = ""
    '    txtNombre.Text = ""
    '    dgReceta.Rows.Clear()


    '    btnNuevo.Enabled = True
    '    btnSalir.Enabled = True
    '    btnGrabar.Enabled = False
    '    btnCancelar.Enabled = True
    '    btnAgregar.Enabled = False
    '    txtCantidad.Enabled = False
    '    btnBuscar.Enabled = False
    '    txtNombre.Enabled = False

    'End Sub

    'Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
    '    Dim suma As Decimal

    '    suma = 0.00
    '    txtCantidad.Text = suma + Val(txtCantidad.Text)

    'End Sub

    'Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
    '    btnNuevo.Enabled = True
    '    btnSalir.Enabled = True
    '    btnGrabar.Enabled = False
    '    btnCancelar.Enabled = True
    '    btnAgregar.Enabled = False
    '    txtCantidad.Enabled = False
    '    btnBuscar.Enabled = False
    '    txtNombre.Enabled = False
    '    btnCancelar.Enabled = False

    '    txtIdReceta.Text = ""
    '    txtNombre.Text = ""

    '    txtIdInsumo.Text = ""
    '    txtExistencia.Text = ""
    '    txtInsumo.Text = ""
    '    txtMedida.Text = ""
    '    txtCantidad.Text = ""

    '    dgReceta.Rows.Clear()

    'End Sub

    'Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
    '    e.KeyChar = UCase(e.KeyChar)
    '    If e.KeyChar > ChrW(26) Then
    '        If InStr(CadenaValida, e.KeyChar) = 0 Then
    '            e.KeyChar = ChrW(0)
    '        End If
    '    End If
    'End Sub


    '***********************************************************************************************************************************************
    '****************************************************   APARTIR DE AQUI LUCY WAS HERE  '********************************************

    Private Sub frmCatalogoRecetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionSql.Open()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim insumos As New frmAgregarInsumo
        insumos.dgInsumos.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        Dim ban As Boolean = False
        insumos.ShowDialog()

        If insumos.dgInsumos.CurrentRow IsNot Nothing Then
            Dim fila As Integer = insumos.dgInsumos.CurrentRow.Index
            txtIdInsumo.Text = insumos.dgInsumos(0, fila).Value
            txtInsumo.Text = insumos.dgInsumos(1, fila).Value
            txtUnidadM.Text = insumos.dgInsumos(2, fila).Value
            txtExistencia.Text = insumos.dgInsumos(3, fila).Value

            btnAgregar.Enabled = True
            txtCantidad.Focus()
        Else
            MessageBox.Show("NO SE HA SELECCIONADO INSUMO", "FALTA DE INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


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
        txtCantidad.Enabled = True


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        dgReceta.Rows.Add(txtIdInsumo.Text, txtInsumo.Text, txtCantidad.Text, cmbUnidadM.Text)
        txtExistencia.Text = ""
        txtIdInsumo.Text = ""
        txtInsumo.Text = ""
        txtUnidadM.Text = ""
        txtCantidad.Text = ""
        cmbUnidadM.Text = ""

        btnAgregar.Enabled = False
        btnBuscar.Focus()
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        comando.CommandText = "Insert into tlb_receta (idReceta, nombre) values(" & Val(txtIdReceta.Text) & ",'" & txtNombre.Text & "'" & ")"
        comando.ExecuteNonQuery()


        For x = 0 To dgReceta.RowCount - 1
            comando.CommandText = "Insert into tlb_detReceta (idReceta, idInsumo, cantidad, unidadM) values(" & Val(txtIdReceta.Text) & ", " & CInt(dgReceta(0, x).Value) & ", '" & CDec(dgReceta(2, x).Value) & "','" & dgReceta(3, x).Value & "')"
            comando.ExecuteNonQuery()
        Next

        txtIdReceta.Text = ""
        txtNombre.Text = ""
        dgReceta.Rows.Clear()

        mensajeGrabar()

        btnNuevo.Enabled = True
        btnSalir.Enabled = True
        btnGrabar.Enabled = False
        btnCancelar.Enabled = True
        btnAgregar.Enabled = False
        txtCantidad.Enabled = False
        btnBuscar.Enabled = False
        txtNombre.Enabled = False

    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        Dim suma As Decimal
        suma = 0.00
        txtCantidad.Text = suma + Val(txtCantidad.Text)

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        btnNuevo.Enabled = True
        btnSalir.Enabled = True
        btnGrabar.Enabled = False
        btnCancelar.Enabled = True
        btnAgregar.Enabled = False
        txtCantidad.Enabled = False
        btnBuscar.Enabled = False
        txtNombre.Enabled = False
        btnCancelar.Enabled = False

        txtIdReceta.Text = ""
        txtNombre.Text = ""

        txtIdInsumo.Text = ""
        txtExistencia.Text = ""
        txtInsumo.Text = ""
        txtUnidadM.Text = ""
        txtCantidad.Text = ""

        dgReceta.Rows.Clear()

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