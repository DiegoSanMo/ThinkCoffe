Imports System.ComponentModel

Public Class frmCatalogoInsumos

    Dim banModi As Boolean = False

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

        limpiarCajaInsumos()

        btnNuevo.Enabled = False
        btnSalir.Enabled = False
        activarCajasInsumo()
        txtNombre.Focus()

        comando.CommandText = "Select count(*) from tlb_insumo"
        Dim n As Integer = comando.ExecuteScalar + 1

        txtIdInsumo.Text = n

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        dgInsumo.Rows.Add(txtIdInsumo.Text, txtNombre.Text, cboUnidadM.Text, txtMax.Text, txtMin.Text, txtExist.Text, txtCosto.Text, dtpFecha.Value.Date)

        btnGrabar.Enabled = True
        btnCancelar.Enabled = True

        limpiarCajaInsumos()
        bloquearCajasInsumo()
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

        Else
            Dim ultimo As Integer = dgInsumo.RowCount - 2
            MsgBox(Val(dgInsumo.Item(0, ultimo).Value))
            MsgBox(dgInsumo.Item(1, ultimo).Value,)
            MsgBox(dgInsumo.Item(2, ultimo).Value)
            MsgBox(CDec(dgInsumo.Item(3, ultimo).Value))
            MsgBox(CDec(dgInsumo.Item(4, ultimo).Value))
            MsgBox(CDec(dgInsumo.Item(5, ultimo).Value))
            MsgBox(CDec(dgInsumo.Item(6, ultimo).Value),)
            MsgBox(dgInsumo.Item(7, ultimo).Value)


            comando.CommandText = String.Format("Insert into tlb_insumo(idInsumo, nombre, unidadM, maximo, minimo, existencia, costo, fecha) values({0},'{1}','{2}',{3},{4},{5},{6},{7})", Val(dgInsumo.Item(0, ultimo).Value), CStr(dgInsumo.Item(1, ultimo).Value), CStr(dgInsumo.Item(2, ultimo).Value), CDec(dgInsumo.Item(3, ultimo).Value), CDec(dgInsumo.Item(4, ultimo).Value), CDec(dgInsumo.Item(5, ultimo).Value), CDec(dgInsumo.Item(6, ultimo).Value), dgInsumo.Item(7, ultimo).Value)
            comando.ExecuteNonQuery()


            'comando.CommandText = String.Format("Insert into tlb_insumo(idInsumo, nombre, unidadM, maximo, minimo, existencia, costo, fecha) values ({0}, '{1}','{2}',{3},{4},{5},{6},{7})", Val(dgInsumo.Item(0, ultimo).Value), dgInsumo.Item(1, ultimo).Value, dgInsumo.Item(2, ultimo).Value, CDec(dgInsumo.Item(3, ultimo).Value), CDec(dgInsumo.Item(4, ultimo).Value), CDec(dgInsumo.Item(5, ultimo).Value)
            'comando.ExecuteNonQuery()
        End If
    End Sub
End Class