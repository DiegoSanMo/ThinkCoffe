Imports System.Data.SqlClient
Module Module1
    Public ex, ey As Integer
    Public mover As Boolean
    Public CadenaValida As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ "
    Public CadenaNumeros As String = "0123456789- "
    Public CadenaDirecciones As String = "0123456789.ABCDEFGHIJKLMNÑOPQRSTUVWXYZ "


    Public conexionSql As New SqlConnection("Data Source = 'PRO'; Initial Catalog = 'thinkCoffee'; integrated security = true")
    Public comando As SqlCommand = conexionSql.CreateCommand
    Public lector As SqlDataReader
    '***********************************************************************************************************************************************
    '****************************************************   ACCIONES PARA EL FORMULARIO DE CATEGORIAS   '********************************************






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


    '***********************************************************************************************************************************************
    '****************************************************   ACCIONES PARA EL FORMULARIO DE INSUMOS   '********************************************
    Public Sub activarCajasInsumo()
        frmCatalogoInsumos.dtpFecha.Enabled = True
        frmCatalogoInsumos.txtNombre.Enabled = True
        frmCatalogoInsumos.cboUnidadM.Enabled = True
        frmCatalogoInsumos.txtMax.Enabled = True
        frmCatalogoInsumos.txtMin.Enabled = True
        frmCatalogoInsumos.txtExist.Enabled = True
        frmCatalogoInsumos.txtCosto.Enabled = True
        frmCatalogoInsumos.btnAceptar.Enabled = True
    End Sub

    Public Sub bloquearCajasInsumo()
        frmCatalogoInsumos.dtpFecha.Enabled = False
        frmCatalogoInsumos.txtNombre.Enabled = False
        frmCatalogoInsumos.cboUnidadM.Enabled = False
        frmCatalogoInsumos.txtMax.Enabled = False
        frmCatalogoInsumos.txtMin.Enabled = False
        frmCatalogoInsumos.txtExist.Enabled = False
        frmCatalogoInsumos.txtCosto.Enabled = False
        frmCatalogoInsumos.btnAceptar.Enabled = False

    End Sub

    Public Sub limpiarCajaInsumos()
        frmCatalogoInsumos.txtNombre.Text = ""
        frmCatalogoInsumos.txtMax.Text = ""
        frmCatalogoInsumos.txtMin.Text = ""
        frmCatalogoInsumos.txtExist.Text = ""
        frmCatalogoInsumos.txtCosto.Text = ""

    End Sub
End Module
