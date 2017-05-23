﻿Public Class frmCatalogoProveedores
    Dim presionado As Boolean = False
    Private Sub frmCatalogoProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionSql.Open()
        dgProveedores.Rows.Clear()
        Dim n As Integer
        comando.CommandText = String.Format("Select count(*) from tlb_proveedor	")
        n = comando.ExecuteScalar

        If n > 0 Then
            comando.CommandText = String.Format("Select * from tlb_proveedor")
            lector = comando.ExecuteReader()
            While lector.Read
                dgProveedores.Rows.Add(lector(0), lector(1), lector(2), lector(3))
            End While
            lector.Close()
        End If

    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaValida, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If


    End Sub

    Private Sub txtDireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDireccion.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaDirecciones, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
        btnAceptar.Enabled = True
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtNombre.Enabled = True
        txtDireccion.Enabled = True
        txtNombre.Focus()
        mskTelefono.Enabled = True

        Dim n As Integer
        comando.CommandText = String.Format("Select count(*) from tlb_proveedor	")
        n = comando.ExecuteScalar + 1
        txtIdProveedor.Text = n

        btnNuevo.Enabled = False
        btnSalir.Enabled = False


    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaNumeros, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If

    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If presionado Then
            Dim ultimo As Integer = dgProveedores.RowCount - 1

            comando.CommandText = String.Format("Insert into tlb_proveedor(idProveedor, nombre, direccion,  telefono) values ({0}, '{1}', '{2}', '{3}' )", Val(dgProveedores.Item(0, ultimo).Value), dgProveedores.Item(1, ultimo).Value, dgProveedores.Item(2, ultimo).Value, dgProveedores.Item(3, ultimo).Value)
            comando.ExecuteNonQuery()

            mensajeGrabar()
            btnGrabar.Enabled = False
            btnCancelar.Enabled = False
            btnCan.Enabled = False
            btnNuevo.Enabled = True
            btnSalir.Enabled = True
            presionado = False
        Else
            MessageBox.Show("ES NECESARIO PRESIONAR EL BOTÓNDE ACEPTAR PARA COMPLETAR EL REGISTRO DE PROVEEDOR", "ERROR, PRESIONAR BOTÓN DE ACEPTAR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If




    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        If String.IsNullOrWhiteSpace(txtNombre.Text) Or String.IsNullOrWhiteSpace(txtDireccion.Text) Or String.IsNullOrWhiteSpace(mskTelefono.Text) Then
            MessageBox.Show("AÚN HAY ESPACIOS EN BLANCO, FAVOR DE COMPLETAR EL FORMULARIO", "ERROR, FALTA DE INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            dgProveedores.Rows.Add(txtIdProveedor.Text, txtNombre.Text, txtDireccion.Text, mskTelefono.Text)
            txtIdProveedor.Text = ""
            txtNombre.Text = ""
            txtDireccion.Text = ""
            mskTelefono.Text = ""

            btnAceptar.Enabled = False
            txtIdProveedor.Enabled = False
            txtNombre.Enabled = False
            txtDireccion.Enabled = False
            mskTelefono.Enabled = False
            btnGrabar.Enabled = True
            btnCan.Enabled = True

            presionado = True
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        conexionSql.Close()
        Me.Close()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCan.Click
        If presionado Then
            Dim ultimo As Integer = dgProveedores.RowCount - 1

            dgProveedores.Rows.RemoveAt(ultimo)
            dgProveedores.Refresh()

            btnNuevo.Enabled = True
            btnSalir.Enabled = True
            btnGrabar.Enabled = False
            btnCan.Enabled = False
            txtIdProveedor.Text = ""
            txtNombre.Text = ""
            txtDireccion.Text = ""
            mskTelefono.Text = ""
            presionado = False

        Else
        End If
    End Sub
End Class
