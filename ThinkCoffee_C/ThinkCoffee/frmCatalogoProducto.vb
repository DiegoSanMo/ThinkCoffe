Imports System.Data.SqlClient
Public Class frmCatalogoProducto
    Dim conexion As New SqlConnection("Data Source = 'LUCY'; Initial Catalog = 'thinkCoffee'; Integrated Security = true")
    Dim comando As SqlCommand = conexion.CreateCommand
    Dim lector As SqlDataReader
    Private Sub frmCatalogoProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        comando.CommandText = "Select * from categoria"
        lector = comando.ExecuteReader
        While lector.Read()
            cboCategoria.Items.Add(lector(1))
        End While
        lector.Close()

        comando.CommandText = "Select * from receta"
        lector = comando.ExecuteReader
        While lector.Read
            cboReceta.Items.Add(lector(1))
        End While
        lector.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        comando.CommandText = "Select count (*) from producto"
        Dim n As Integer = comando.ExecuteScalar + 1
        txtIdProducto.Text = n
        cboCategoria.Enabled = True
        cboReceta.Enabled = True
        txtIdCategoria.Enabled = True
        txtIdReceta.Enabled = True
        btnAgregar.Enabled = True
        ptbImagenProducto.Enabled = True
        btnBuscarImg.Enabled = True
        btnGrabar.Enabled = True
        btnCancelar.Enabled = True
        btnNuevo.Enabled = False
        btnSalir.Enabled = False
    End Sub

    Private Sub btnBuscarImg_Click(sender As Object, e As EventArgs) Handles btnBuscarImg.Click
        OpenFileDialog1.ShowDialog()


    End Sub
End Class