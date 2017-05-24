Public Class frmCompraDeInsumos
    Dim entro As Integer
    Private Sub frmCompraDeInsumos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionSql.Open()

        comando.CommandText = "Select count(tlb_proveedor.idProveedor) from tlb_proveedor"
        Dim n As Integer = comando.ExecuteScalar
        If n > 0 Then
            comando.CommandText = "Select tlb_proveedor.nombre from tlb_proveedor"
            lector = comando.ExecuteReader
            While lector.Read
                cboProveedor.Items.Add(lector(0))
            End While
            lector.Close()
            dgInsumosC.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Else
            MessageBox.Show("NO SE HAN REGISTRADO PROVEEDORES, FAVOR DE REGISTRAR PROVEEDORES PARA REALIZAR UN REGISTRO COMPLETO DE COMPRA", "ERROR, FALTA DE INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            conexionSql.Close()

        End If


    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim n As Integer
        comando.CommandText = "Select count(*) from tlb_compra"
        n = comando.ExecuteScalar + 1

        txtIdCompra.Text = n
        cboProveedor.Enabled = True
        btnBuscarIn.Enabled = True
        btnAgregarI.Enabled = True
        txtNuevoC.ReadOnly = False
        txtCantidad.ReadOnly = False

        btnNuevo.Enabled = False
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        btnSalir.Enabled = False


    End Sub

    Private Sub btnBuscarIn_Click(sender As Object, e As EventArgs) Handles btnBuscarIn.Click
        Dim n As Integer
        comando.CommandText = "Select count(*) from tlb_insumo"
        n = comando.ExecuteScalar
        If n > 1 Then
            Dim fila As Integer
            frmAgregarInsumo.dgInsumos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            frmAgregarInsumo.ShowDialog()
            If frmAgregarInsumo.dgInsumos.CurrentRow IsNot Nothing Then
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
            End If

        Else
            MessageBox.Show("No se han registrado insumos", "FALTA DE INSUMOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub cboProveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProveedor.SelectedIndexChanged
        comando.CommandText = "select tlb_proveedor.idProveedor, tlb_proveedor.direccion, tlb_proveedor.telefono from tlb_proveedor where tlb_proveedor.nombre = '" & cboProveedor.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        txtIdProveedor.Text = lector(0)
        txtDireccion.Text = lector(1)
        txtTelefono.Text = lector(2)
        lector.Close()
    End Sub



    Private Sub txtFechaInsumo_TextChanged(sender As Object, e As EventArgs) Handles txtFechaInsumo.TextChanged

    End Sub

    Private Sub btnAgregarI_Click(sender As Object, e As EventArgs) Handles btnAgregarI.Click
        Dim ban As Boolean = False
        Dim pos As Integer
        Dim suma As Decimal = 0

        If String.IsNullOrWhiteSpace(txtNombreInsumo.Text) Then
            MessageBox.Show("NO SE HA INGRESADO INSUMO, FAVOR DE SELECCIONAR UNO", "ERROR, FALTA DE INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnBuscarIn.Focus()
        Else
            For x = 0 To dgInsumosC.RowCount - 1
                If dgInsumosC(0, x).Value = txtIdInsumo.Text Then
                    ban = True
                    pos = x
                    Exit For
                Else
                    ban = False
                End If
            Next

            If ban Then
                dgInsumosC(2, pos).Value = CDec(dgInsumosC(2, pos).Value) + CDec(txtCantidad.Text)
                dgInsumosC(4, pos).Value = CDec(dgInsumosC(2, pos).Value) * CDec(dgInsumosC(3, pos).Value)
            Else
                If String.IsNullOrWhiteSpace(txtCantidad.Text) Or String.IsNullOrWhiteSpace(txtNuevoC.Text) Then
                    MessageBox.Show("HAY DATOS EN BLANCO", "ERROR, FALTA DE INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtNuevoC.Focus()
                Else
                    dgInsumosC.Rows.Add(txtIdInsumo.Text, txtNombreInsumo.Text, txtCantidad.Text, CDec(txtNuevoC.Text), CDec(txtCantidad.Text * txtNuevoC.Text))
                    dgInsumosC.CurrentCell = dgInsumosC.Rows(dgInsumosC.RowCount - 1).Cells(0)

                    txtIdInsumo.Text = ""
                    txtNombreInsumo.Text = ""
                    txtExistencias.Text = ""
                    txtMaximo.Text = ""
                    txtMinimo.Text = ""
                    txtUnidadM.Text = ""
                    txtFechaInsumo.Text = ""
                    txtCosto.Text = ""
                    txtNuevoC.Text = ""
                    txtCantidad.Text = ""
                End If
            End If
        End If


        For x = 0 To dgInsumosC.RowCount - 1
            suma = suma + CDec(dgInsumosC(4, x).Value)
            txtSubtotal.Text = suma
        Next
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If entro Then
            If String.IsNullOrWhiteSpace(txtIdProveedor.Text) Then
                MsgBox("No se ha ingresado proveedor")
                cboProveedor.Focus()
            Else
                If dgInsumosC.RowCount = 0 Then
                    MsgBox("No se han ingresado insumos")
                    btnAgregarI.Focus()
                Else
                    comando.CommandText = "Insert into tlb_compra(idCompra, idProveedor, fecha, total) values(" & Val(txtIdCompra.Text) & ", " & Val(txtIdProveedor.Text) & ", '" & dtpFecha.Value.Date & "', " & CDec(txtSubtotal.Text) & ")"
                    comando.ExecuteNonQuery()
                    For x = 0 To dgInsumosC.RowCount - 1
                        comando.CommandText = "Insert into tlb_detCompra(idCompra, idInsumo, cantidad, costo) values(" & Val(txtIdCompra.Text) & "," & Val(dgInsumosC(0, x).Value) & ", " & CDec(dgInsumosC(2, x).Value) & ", " & CDec(dgInsumosC(3, x).Value) & ")"
                        comando.ExecuteNonQuery()

                        comando.CommandText = "Update tlb_insumo set existencia = existencia + " & CDec(dgInsumosC(2, x).Value) & ", costo = " & CDec(dgInsumosC(3, x).Value) & " where idInsumo = " & Val(dgInsumosC(0, x).Value) & " "
                        comando.ExecuteNonQuery()
                    Next

                End If
            End If
            cboProveedor.Enabled = False
            btnBuscarIn.Enabled = False
            btnAgregarI.Enabled = False
            txtNuevoC.ReadOnly = False
            txtCantidad.ReadOnly = False
            btnCancelar.Enabled = False

            btnNuevo.Enabled = True
            btnGuardar.Enabled = False
            entro = False
        Else
            MessageBox.Show("PRESIONAR EL BOTÓN DE ACEPTAR PARA CONTINUAR CON LA ACCIÓN", "COMPLETAR EL REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
        conexionSql.Close()

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtCantidad.Text = ""
        txtCosto.Text = ""
        txtDireccion.Text = ""
        txtExistencias.Text = ""
        txtFechaInsumo.Text = ""
        txtIdCompra.Text = ""
        txtIdInsumo.Text = ""
        txtIdProveedor.Text = ""
        txtMaximo.Text = ""
        txtMinimo.Text = ""
        txtNombreInsumo.Text = ""
        txtNuevoC.Text = ""
        txtSubtotal.Text = ""
        txtTelefono.Text = ""
        txtUnidadM.Text = ""

        txtCantidad.ReadOnly = True
        txtCosto.Enabled = False
        txtDireccion.Enabled = False
        txtExistencias.Enabled = False
        txtFechaInsumo.Enabled = False
        txtIdCompra.Enabled = False
        txtIdInsumo.Enabled = False
        txtIdProveedor.Enabled = False
        txtMaximo.Enabled = False
        txtMinimo.Enabled = False
        txtNombreInsumo.Enabled = False
        txtNuevoC.ReadOnly = True
        txtSubtotal.Enabled = False
        txtTelefono.Enabled = False
        txtUnidadM.Enabled = False
        dgInsumosC.Rows.Clear()
        dgInsumosC.Enabled = False

        btnNuevo.Enabled = True
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False
        btnSalir.Enabled = True
        btnAgregarI.Enabled = False
        btnBuscarIn.Enabled = False
        cboProveedor.Enabled = False


    End Sub

    Private Sub txtNuevoC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNuevoC.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaNumeros, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If


    End Sub
End Class