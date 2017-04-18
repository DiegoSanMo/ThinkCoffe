Imports System.Data.SqlClient
Module Module1
    Public ex, ey As Integer
    Public mover As Boolean
    Public CadenaValida As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZÁÉÍÓÚ "
    Public CadenaNumeros As String = "0123456789- "
    Public CadenaDirecciones As String = "0123456789.ABCDEFGHIJKLMNÑOPQRSTUVWXYZÁÉÍÓÚ "


    Public conexionSql As New SqlConnection("Data Source = 'PRO'; Initial Catalog = 'thinkCoffee'; integrated security = true")
    Public comando As SqlCommand = conexionSql.CreateCommand
    Public lector As SqlDataReader

    '***********************************************************************************************************************************************
    '****************************************************   ACCIONES PARA EL FORMULARIO DE PRODUCTOS   '********************************************

    Public Sub limpiarCajaProductos()
        frmCatalogoProductos.txtIdProducto.Text = ""
        frmCatalogoProductos.txtIdCategoria.Text = ""
        frmCatalogoProductos.txtNombre.Text = ""
        frmCatalogoProductos.txtIdReceta.Text = ""
        frmCatalogoProductos.txtPrecio.Text = ""
        frmCatalogoProductos.ptbImagen.Image = Nothing
    End Sub

    Public Sub bloquearCajaProductos()

        frmCatalogoProductos.txtNombre.Enabled = False
        frmCatalogoProductos.txtPrecio.Enabled = False
        frmCatalogoProductos.cboCategoria.Enabled = False
        frmCatalogoProductos.cboReceta.Enabled = False
        frmCatalogoProductos.btnAceptar.Enabled = False
        frmCatalogoProductos.btnBuscar.Enabled = False
    End Sub


End Module
