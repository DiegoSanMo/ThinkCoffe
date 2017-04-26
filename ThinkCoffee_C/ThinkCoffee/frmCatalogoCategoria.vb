Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmCatalogoCategoria
    Dim banModi As Boolean = False

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs)
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

        btnNuevo.Enabled = False
        btnSalir.Enabled = False
        txtNombre.Focus()

    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If banModi Then
            For x = 0 To dgCategoria.RowCount - 2
                If dgCategoria(0, x).Value = Val(txtIdCategoria.Text) Then

                End If
            Next
            comando.CommandText = "Update tlb_categoria set nombre = '" & txtNombre.Text & "' where idCategoria = " & txtIdCategoria.Text & " "
            comando.ExecuteNonQuery()

            btnNuevo.Enabled = True
            btnSalir.Enabled = True
            btnGrabar.Enabled = False
            btnCancelar.Enabled = False
            dgCategoria.Enabled = True
            btnModificar.Enabled = True

        Else
            Dim ultimo As Integer = dgCategoria.RowCount - 2

            comando.CommandText = String.Format("Insert into tlb_categoria(idCategoria, nombre) values ({0}, '{1}')", Val(dgCategoria.Item(0, ultimo).Value), dgCategoria.Item(1, ultimo).Value)
            comando.ExecuteNonQuery()

            'acciones de los botones
            btnNuevo.Enabled = True
            btnSalir.Enabled = True
            btnGrabar.Enabled = False
            btnCancelar.Enabled = False
        End If


    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If banModi Then
            Dim fila As Integer = Val(dgCategoria.Item(0, dgCategoria.CurrentRow.Index).Value) - 1
            dgCategoria.Item(1, fila).Value = txtNombre.Text

            txtNombre.Enabled = False
            btnGrabar.Enabled = True
            btnCancelar.Enabled = True
            btnAceptar.Enabled = False

        Else
            dgCategoria.Rows.Add(txtIdCategoria.Text, txtNombre.Text)
            txtIdCategoria.Text = ""
            txtNombre.Text = ""

            txtNombre.Enabled = False
            btnGrabar.Enabled = True
            btnCancelar.Enabled = True
            btnAceptar.Enabled = False
        End If



    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        conexionSql.Close()
        Me.Close()

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If banModi Then
            Dim nombre As String

            comando.CommandText = "Select * from tlb_categoria where idCategoria = " & Val(txtIdCategoria.Text) & ""
            lector = comando.ExecuteReader
            lector.Read()
            nombre = lector(1)

            For x = 0 To dgCategoria.RowCount - 2
                If Val(txtIdCategoria.Text) = dgCategoria.Item(0, x).Value Then
                    dgCategoria(1, x).Value = nombre
                End If
            Next
            lector.Close()

            btnNuevo.Enabled = True
            btnSalir.Enabled = True
            btnGrabar.Enabled = False
            btnCancelar.Enabled = False
            btnModificar.Enabled = True
            txtNombre.Text = nombre


        Else
            Dim ultimo As Integer = dgCategoria.RowCount - 2

            dgCategoria.Rows.RemoveAt(ultimo)

            btnNuevo.Enabled = True
            btnSalir.Enabled = True
            btnGrabar.Enabled = False
            btnCancelar.Enabled = False
        End If


    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        btnNuevo.Enabled = False
        btnSalir.Enabled = False
        btnModificar.Enabled = False


        txtNombre.Enabled = True
        banModi = True
        dgCategoria.Enabled = False
    End Sub

    Private Sub dgCategoria_SelectionChanged(sender As Object, e As EventArgs) Handles dgCategoria.SelectionChanged
        Dim fila As Integer = dgCategoria.Item(0, dgCategoria.CurrentRow.Index).Value - 1

        txtIdCategoria.Text = dgCategoria(0, fila).Value
        txtNombre.Text = dgCategoria(1, fila).Value

    End Sub
End Class