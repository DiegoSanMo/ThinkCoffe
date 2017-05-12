Imports System.ComponentModel

Public Class frmCatalogoInsumos
    Dim banModi As Boolean = False
    Dim filaSel As Integer
    Dim idtari As Integer

    Private Sub frmCatalogoInsumos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionSql.Open()
        dgInsumo.Rows.Clear()
        Dim n As Integer
        comando.CommandText = String.Format("Select count(tlb_insumo.idInsumo) from tlb_insumo")
        n = comando.ExecuteScalar + 1
        If n > 1 Then
            dgInsumo.SelectionMode = DataGridViewSelectionMode.FullRowSelect
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

        limpiarCajaInsumos()

        btnNuevo.Enabled = False
        btnSalir.Enabled = False
        btnModificar.Enabled = False

        activarCajasInsumo()
        txtNombre.Focus()

        comando.CommandText = "Select count(*) from tlb_insumo"
        Dim n As Integer = comando.ExecuteScalar + 1

        txtIdInsumo.Text = n

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If banModi Then

            MsgBox(filaSel)
            dgInsumo.Item(1, filaSel).Value = txtNombre.Text
            dgInsumo.Item(2, filaSel).Value = cboUnidadM.Text
            dgInsumo.Item(3, filaSel).Value = txtMax.Text
            dgInsumo.Item(4, filaSel).Value = txtMin.Text
            dgInsumo.Item(5, filaSel).Value = txtExist.Text
            dgInsumo.Item(6, filaSel).Value = txtCosto.Text
            dgInsumo.Item(7, filaSel).Value = dtpFecha.Value.Date


            btnGrabar.Enabled = True
            btnCancelar.Enabled = True

            limpiarCajaInsumos()
            bloquearCajasInsumo()

        Else
            dgInsumo.Rows.Add(txtIdInsumo.Text, txtNombre.Text, cboUnidadM.Text, txtMax.Text, txtMin.Text, txtExist.Text, txtCosto.Text, dtpFecha.Value.Date)

            btnGrabar.Enabled = True
            btnCancelar.Enabled = True

            limpiarCajaInsumos()
            bloquearCajasInsumo()
        End If


    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaValida, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
        btnAceptar.Enabled = True
    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        If Len(txtNombre.Text) < 5 Then
            MessageBox.Show("DEBES INTRODUCIR AL MENOS 10 CARACTERES", "FALTA INFORMACION",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNombre.Focus()
        End If
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click

        If banModi Then
            comando.CommandText = "Update tlb_insumo set nombre = '" & dgInsumo.Item(1, filaSel).Value & "', unidadM = '" & dgInsumo.Item(2, filaSel).Value & "', maximo = " & CDec(dgInsumo.Item(3, filaSel).Value) & ", minimo = " & CDec(dgInsumo.Item(4, filaSel).Value) & ", existencia = " & CDec(dgInsumo.Item(5, filaSel).Value) & ", costo = " & CDec(dgInsumo.Item(6, filaSel).Value) & ", fecha = '" & dgInsumo.Item(7, filaSel).Value & "' where idInsumo = " & Val(dgInsumo.Item(0, filaSel).Value) & ""
            comando.ExecuteNonQuery()

            btnCancelar.Enabled = False
            btnGrabar.Enabled = False
            btnNuevo.Enabled = True
            btnModificar.Enabled = True
            btnSalir.Enabled = True
            banModi = False

        Else
            Dim ultimo As Integer = dgInsumo.RowCount - 1
            comando.CommandText = "Insert into tlb_insumo(idInsumo, nombre, unidadM, maximo, minimo, existencia, costo, fecha) values(" & Val(dgInsumo.Item(0, ultimo).Value) & ",'" & CStr(dgInsumo.Item(1, ultimo).Value) & "', '" & CStr(dgInsumo.Item(2, ultimo).Value) & "', " & CDec(dgInsumo.Item(3, ultimo).Value) & ", " & CDec(dgInsumo.Item(4, ultimo).Value) & ", " & CDec(dgInsumo.Item(5, ultimo).Value) & "," & CDec(dgInsumo.Item(6, ultimo).Value) & ",'" & dgInsumo.Item(7, ultimo).Value & "')"
            comando.ExecuteNonQuery()

            btnCancelar.Enabled = False
            btnGrabar.Enabled = False
            btnNuevo.Enabled = True
            btnModificar.Enabled = True
            btnSalir.Enabled = True

        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If banModi Then

            'Variables que tomarán los datos del insumo que corresponda al ID y en caso de que se cancele la 
            'modificacion el dataGried tomará los datos de las variebles que previamente tienen los datos ya registrados

            Dim nombre, unidadM As String
            Dim fecha As Date
            Dim exis, min, max, costo As Decimal

            'comando para realizar la busqueda del insumo apartir de su id
            comando.CommandText = "Select * from tlb_insumo where  idInsumo =" & dgInsumo.Item(0, filaSel).Value & " "
            lector = comando.ExecuteReader
            lector.Read()

            'se almacenan
            nombre = lector(1)
            unidadM = lector(2)
            max = lector(3)
            min = lector(4)
            exis = lector(5)
            costo = lector(6)
            fecha = lector(7)
            lector.Close()

            dgInsumo.Item(1, filaSel).Value = nombre
            dgInsumo.Item(2, filaSel).Value = unidadM
            dgInsumo.Item(3, filaSel).Value = max
            dgInsumo.Item(4, filaSel).Value = min
            dgInsumo.Item(5, filaSel).Value = exis
            dgInsumo.Item(6, filaSel).Value = costo
            dgInsumo.Item(7, filaSel).Value = fecha

            btnCancelar.Enabled = False
            btnGrabar.Enabled = False
            btnNuevo.Enabled = True
            btnSalir.Enabled = True
            btnModificar.Enabled = True

            banModi = False
        Else
            Dim ultimo As Integer = dgInsumo.RowCount - 1
            dgInsumo.Rows.RemoveAt(ultimo)
            dgInsumo.Refresh()

            btnCancelar.Enabled = False
            btnGrabar.Enabled = False
            btnNuevo.Enabled = True
            btnSalir.Enabled = True
            btnModificar.Enabled = True
        End If

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnSalir.Enabled = False
        activarCajasInsumo()
        txtNombre.Focus()
        banModi = True

    End Sub

    Private Sub dgInsumo_SelectionChanged(sender As Object, e As EventArgs) Handles dgInsumo.SelectionChanged
        filaSel = dgInsumo.Item(0, dgInsumo.CurrentRow.Index).Value - 1

        txtIdInsumo.Text = dgInsumo(0, filaSel).Value
        txtNombre.Text = dgInsumo(1, filaSel).Value
        cboUnidadM.Text = dgInsumo(2, filaSel).Value
        txtMax.Text = dgInsumo(3, filaSel).Value
        txtMin.Text = dgInsumo(4, filaSel).Value
        txtExist.Text = dgInsumo(5, filaSel).Value
        txtCosto.Text = dgInsumo(6, filaSel).Value
        dtpFecha.Value = dgInsumo(7, filaSel).Value
    End Sub

    Private Sub cboUnidadM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUnidadM.SelectedIndexChanged

    End Sub
End Class