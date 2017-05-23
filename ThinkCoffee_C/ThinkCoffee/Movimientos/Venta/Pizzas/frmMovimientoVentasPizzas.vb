Public Class frmMovimientoVentasPizzas

    Dim selec As Integer = 0
    Dim ubicación As Integer = 0
    Private Sub frmMovimientoVentasPizzas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionSql.Open()

        CheckedListBox1.SelectionMode = SelectionMode.None

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub
    Private Sub cboTamaño_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTamaño.SelectedIndexChanged
        If cboTamaño.Text = "REBANADA" Then
            limpiarLista()
            limite = 2

            cboTipo.SelectedIndex = 0
            cboTipo.Enabled = False
            txtPrecio.Text = "35.00"

            CheckedListBox1.Enabled = True

            txtCantidad.Enabled = True
            txtCantidad.Focus()

        ElseIf cboTamaño.Text = "CHICA" Then
            limpiarLista()
            cboTipo.Enabled = True
            txtPrecio.Text = ""

            txtCantidad.Enabled = False
            CheckedListBox1.Enabled = True

        ElseIf cboTamaño.Text = "GRANDE" Then
            limpiarLista()
            cboTipo.Enabled = True
            txtPrecio.Text = ""

            txtCantidad.Enabled = False
            CheckedListBox1.Enabled = True
        End If
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged

        If buscarCheck() >= limite Then
            MsgBox("No sé pueden ingresar más toppings")
            limpiarSeleccionado(CheckedListBox1.SelectedItem.ToString())
        End If
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        btnCrear.Enabled = False
        btnSalir.Enabled = False
        btnCancelar.Enabled = True
        btnGrabar.Enabled = True

        comando.CommandText = "select count(tlb_venta.idVenta) from tlb_venta;"
        Dim n As Integer = comando.ExecuteScalar + 1
        txtIdVenta.Text = n
        cboTamaño.Enabled = True
        btnGrabar.Enabled = True
        CheckedListBox1.Enabled = True
        CheckedListBox1.SelectionMode = SelectionMode.One
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If String.IsNullOrWhiteSpace(txtCantidad.Text) Or txtCantidad.Text = "0" Then
            MessageBox.Show("CANTIDAD DE PIZZAS INCORRECTA", "FALTA DE INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPrecio.Focus()
        Else
            Dim entra As Boolean = False
            For i = 0 To 20
                If CheckedListBox1.GetItemCheckState(i) = 1 Then
                    entra = True
                End If
            Next


            If entra Then
                comando.CommandText = "Insert into tlb_venta(idVenta, tipo, fecha, total) values(" & CInt(txtIdVenta.Text) & ", '" & "PIZZA" & "', '" & dtpFecha.Value.Date & "', " & CDec(txtTotal.Text) & ")"
                comando.ExecuteNonQuery()

                comando.CommandText = "Insert into tlb_pizza(idVenta, idPizza,	size, tipo, cantidad, precio) values(" & CInt(txtIdVenta.Text) & ", '" & txtIdVenta.Text + "-" + cboTamaño.Text & "', '" & cboTamaño.Text & "', '" & cboTipo.Text & "', " & CInt(txtCantidad.Text) & ", " & CDec(txtPrecio.Text) & ")"
                comando.ExecuteNonQuery()
                For x = 0 To 20
                    If CheckedListBox1.GetItemCheckState(x) = 1 Then
                        comando.CommandText = "Insert into tlb_detPizza(idPizza, topping) values('" & txtIdVenta.Text + "-" + cboTamaño.Text & "', '" & CheckedListBox1.Items(x).ToString & "')"
                        comando.ExecuteNonQuery()
                    End If
                Next

                txtCantidad.Text = ""
                cboTamaño.SelectedIndex = 0
                cboTipo.SelectedIndex = 0

                'bloquear la caja de los toppings
                CheckedListBox1.SelectionMode = SelectionMode.None
                btnCancelar.Enabled = False
                btnCrear.Enabled = True
                btnSalir.Enabled = True
                btnGrabar.Enabled = False
                cboTipo.Enabled = False
                cboTamaño.Enabled = False
                txtPrecio.Enabled = False
                txtCantidad.Enabled = False


                limpiarLista()
                mensajeVenta()
            Else
                MessageBox.Show("NO SE HAN SELECCIONADO TOPPINGS", "FALTA DE INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If



    End Sub

    Private Sub cboTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipo.SelectedIndexChanged
        limpiarLista()
        If cboTamaño.Text = "CHICA" And cboTipo.Text = "NORMAL" Then
            txtPrecio.Text = "100.00"
            limite = 2

            btnGrabar.Enabled = True
            txtCantidad.Enabled = True
            txtCantidad.Focus()

        ElseIf cboTamaño.Text = "GRANDE" And cboTipo.Text = "NORMAL" Then

            limite = 2
            txtPrecio.Text = "180.00"

            txtCantidad.Enabled = True
            txtCantidad.Focus()

        ElseIf cboTamaño.Text = "CHICA" And cboTipo.Text = "MIXTA" Then
            limite = 5
            txtPrecio.Text = "120.00"

            txtCantidad.Enabled = True
            txtCantidad.Focus()

        ElseIf cboTamaño.Text = "GRANDE" And cboTipo.Text = "MIXTA" Then
            limite = 9
            txtPrecio.Text = "230.00"

            txtCantidad.Enabled = True
            txtCantidad.Focus()

        End If
    End Sub

    Private Sub cboTamaño_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboTamaño.SelectedValueChanged
        If cboTamaño.Text = "REBANADA" Then
            limpiarLista()
            limite = 2

            cboTipo.SelectedIndex = 0
            cboTipo.Enabled = False
            txtPrecio.Text = "35.00"

            CheckedListBox1.Enabled = True

        ElseIf cboTamaño.Text = "CHICA" Then
            limpiarLista()
            cboTipo.Enabled = True
            txtPrecio.Text = ""

            CheckedListBox1.Enabled = True
        ElseIf cboTamaño.Text = "GRANDE" Then
            limpiarLista()
            cboTipo.Enabled = True
            txtPrecio.Text = ""

            CheckedListBox1.Enabled = True
        End If
    End Sub

    Private Sub btnSalir_Click_1(sender As Object, e As EventArgs) Handles btnSalir.Click
        conexionSql.Close()
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtCantidad.Text = ""
        txtPrecio.Text = ""
        txtIdVenta.Text = ""

        txtIdVenta.Enabled = False
        txtPrecio.Enabled = False
        txtPrecio.Enabled = False

        btnCrear.Enabled = True
        btnGrabar.Enabled = False
        btnCancelar.Enabled = False
        btnSalir.Enabled = True

        cboTamaño.Enabled = False
        cboTipo.Enabled = False
        CheckedListBox1.Enabled = False
        txtCantidad.Enabled = False

        For i = 0 To 20
            If CheckedListBox1.GetItemCheckState(i) = 1 Then
                CheckedListBox1.SetItemCheckState(i, False)
            End If
        Next


    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(soloNumeros, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If

    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        If txtCantidad.Text = "" Or txtCantidad.Text = "0" Then

        Else
            txtTotal.Text = CDec(txtPrecio.Text) * CInt(txtCantidad.Text)
        End If
    End Sub
End Class