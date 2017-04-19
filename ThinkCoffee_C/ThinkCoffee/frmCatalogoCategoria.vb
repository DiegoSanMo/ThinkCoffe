Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmCatalogoCategoria
    Dim celda As Integer
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub frmCatalogoCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionSql.Open()

        dgCategoria.Rows.Clear()

        Dim n As Integer
        comando.CommandText = String.Format("Select count(*) from tlb_categoria")
        n = comando.ExecuteScalar + 1
        If n > 1 Then
            comando.CommandText = String.Format("Select * from tlb_categoria")
            lector = comando.ExecuteReader
            While lector.Read
                dgCategoria.Rows.Add(lector(0), lector(1))
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
        btnAceptar.Enabled = True
    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        If Len(txtNombre.Text) < 5 Then
            MessageBox.Show("DEBES INTRODUCIR AL MENOS 10 CARACTERES", "FALTA INFORMACION",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNombre.Focus()
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim n As Integer
        comando.CommandText = String.Format("Select count(*) from tlb_categoria")
        n = comando.ExecuteScalar + 1
        txtIdCategoria.Text = n
        txtNombre.Enabled = True

        btnAnterior.Enabled = False
        btnSiguiente.Enabled = False
        btnUltimo.Enabled = False
        btnInicio.Enabled = False


        btnNuevo.Enabled = False
        btnSalir.Enabled = False
        txtNombre.Focus()

    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Dim ultimo As Integer = dgCategoria.RowCount - 2

        comando.CommandText = String.Format("Insert into tlb_categoria(idCategoria, nombre) values ({0}, '{1}')", Val(dgCategoria.Item(0, ultimo).Value), dgCategoria.Item(1, ultimo).Value)
        comando.ExecuteNonQuery()

        'acciones de los botones
        btnNuevo.Enabled = True
        btnSalir.Enabled = True
        btnGrabar.Enabled = False
        btnCancelar.Enabled = False

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        dgCategoria.Rows.Add(txtIdCategoria.Text, txtNombre.Text)
        txtIdCategoria.Text = ""
        txtNombre.Text = ""

        btnAceptar.Enabled = False
        txtNombre.Enabled = False
        btnGrabar.Enabled = True
        btnCancelar.Enabled = True

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        conexionSql.Close()
        Me.Close()

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim ultimo As Integer = dgCategoria.RowCount - 2

        dgCategoria.Rows.RemoveAt(ultimo)

        btnNuevo.Enabled = True
        btnSalir.Enabled = True
        btnGrabar.Enabled = False
        btnCancelar.Enabled = False
    End Sub
End Class