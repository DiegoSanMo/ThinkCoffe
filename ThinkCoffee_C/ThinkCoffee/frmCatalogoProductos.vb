Imports System.ComponentModel

Public Class frmCatalogoProductos
    Private Sub frmCatalogoProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionSql.Open()
        dgProductos.Rows.Clear()
        Dim n As Integer
        comando.CommandText = String.Format("Select count(*) from tlb_producto	")
        n = comando.ExecuteScalar + 1

        If n > 1 Then
            comando.CommandText = String.Format("Select * from tlb_producto")
            lector = comando.ExecuteReader()
            While lector.Read
                dgProductos.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5))
            End While
            lector.Close()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        OpenFileDialog1.ShowDialog()
        Dim ruta As String
        ruta = OpenFileDialog1.FileName
        MsgBox(ruta)
        ptbImagen.Image = Image.FromFile(ruta)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        conexionSql.Close()
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        btnNuevo.Enabled = False
        btnSalir.Enabled = False
        btnGrabar.Enabled = True
        btnCancelar.Enabled = True
        btnAceptar.Enabled = True

        txtNombre.Enabled = True
        cboReceta.Enabled = True
        cboCategoria.Enabled = True
        txtPrecio.Enabled = True
        btnBuscar.Enabled = True

        Dim n As Integer
        comando.CommandText = String.Format("Select count(*) from tlb_producto")
        n = comando.ExecuteScalar + 1

        txtIdProducto.Text = n
        txtNombre.Focus()


    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        btnGrabar.Enabled = False
        btnCancelar.Enabled = False
        btnSalir.Enabled = True
        btnNuevo.Enabled = True

        bloquearCajaProductos()

    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        btnGrabar.Enabled = False
        btnCancelar.Enabled = False
        btnSalir.Enabled = True
        btnNuevo.Enabled = True

        bloquearCajaProductos()

    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaValida, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        dgProductos.Rows.Add(txtIdProducto.Text, txtNombre.Text, cboCategoria.SelectedItem, txtIdCategoria.Text, cboReceta.SelectedItem, txtIdReceta.Text, txtPrecio.Text)


        limpiarCajaProductos()
        bloquearCajaProductos()

    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        If Len(txtNombre.Text) < 5 Then
            MessageBox.Show("DEBES INTRODUCIR AL MENOS 10 CARACTERES", "FALTA INFORMACION",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNombre.Focus()
        End If
    End Sub
End Class