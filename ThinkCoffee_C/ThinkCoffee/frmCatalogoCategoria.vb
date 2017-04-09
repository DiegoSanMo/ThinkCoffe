Imports System.Data.SqlClient
Public Class frmCatalogoCategoria
    Dim conexion As New SqlConnection("Data Source = 'LUCY'; Initial Catalog = 'thinkCoffee'; Integrated Security = true")
    Dim comando As SqlCommand = conexion.CreateCommand
    Dim lector As SqlDataReader
    Private Sub frmCatalogoCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        btnGrabar.Enabled = True
        btnCancelar.Enabled = True
        btnAgregar.Enabled = True

        btnNuevo.Enabled = False
        btnSalir.Enabled = True

        Dim n As Integer
        conexion.Open()
        comando.CommandText = "Select count(*) from categoria"

        n = comando.ExecuteScalar() + 1
        txtIdCategoria.Text = n


    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        conexion.Close()
        Me.Dispose()

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Dispose()

    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click


        comando.CommandText = "Insert into categoria(idCategoria, nombre) values(" & Val(txtIdCategoria.Text) & ", '" & txtNombre.Text & "')"
        comando.ExecuteNonQuery()

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        dgCategoria.Rows.Add(txtIdCategoria.Text, txtNombre.Text)
    End Sub
End Class