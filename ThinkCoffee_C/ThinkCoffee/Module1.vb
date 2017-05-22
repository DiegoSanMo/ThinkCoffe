Imports System.Data.SqlClient
Module Module1
    Public ex, ey As Integer
    Public mover As Boolean
    Public CadenaValida As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ "
    Public CadenaNumeros As String = "0123456789-., "
    Public CadenaDirecciones As String = "0123456789.ABCDEFGHIJKLMNÑOPQRSTUVWXYZ "
    Public nombreInsumo As String

    Public conexionSql As New SqlConnection("Data Source = 'LUCY'; Initial Catalog = 'thinkCoffee'; Integrated security = true")
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
        frmCatalogoProductos.cboCategoria.Text = ""
        frmCatalogoProductos.ptbImagen.Image = Nothing
    End Sub

    Public Sub bloquearCajaProductos()

        frmCatalogoProductos.txtNombre.Enabled = False
        frmCatalogoProductos.txtPrecio.Enabled = False
        frmCatalogoProductos.cboCategoria.Enabled = False
        frmCatalogoProductos.btnBuscarR.Enabled = False
        frmCatalogoProductos.btnAceptar.Enabled = False
        frmCatalogoProductos.btnBuscar.Enabled = False
    End Sub


  Public Sub activarCajaProductos()
        frmCatalogoProductos.txtNombre.Enabled = True
        frmCatalogoProductos.txtPrecio.Enabled = True
        frmCatalogoProductos.cboCategoria.Enabled = True
        frmCatalogoProductos.btnBuscarR.Enabled = True
        frmCatalogoProductos.btnAceptar.Enabled = True
        frmCatalogoProductos.btnBuscar.Enabled = True
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
        frmCatalogoInsumos.btnAceptar.Enabled = True
    End Sub

    Public Sub bloquearCajasInsumo()
        frmCatalogoInsumos.dtpFecha.Enabled = False
        frmCatalogoInsumos.txtNombre.Enabled = False
        frmCatalogoInsumos.cboUnidadM.Enabled = False
        frmCatalogoInsumos.txtMax.Enabled = False
        frmCatalogoInsumos.txtMin.Enabled = False
        frmCatalogoInsumos.txtExist.Enabled = False
        frmCatalogoInsumos.btnAceptar.Enabled = False

    End Sub

    Public Sub limpiarCajaInsumos()
        frmCatalogoInsumos.txtNombre.Text = ""
        frmCatalogoInsumos.txtMax.Text = vbEmpty
        frmCatalogoInsumos.txtMin.Text = vbEmpty
        frmCatalogoInsumos.txtExist.Text = vbEmpty

    End Sub
    '-*****************************************ventas otros*-----------------------------------
    Public Sub calcularPorcion(idProducto As Integer, cantidadP As Integer)
        Dim cantidadProductos As Integer = cantidadP
        Dim id, idReceta As Integer
        id = idProducto

        MsgBox(cantidadProductos)
        comando.CommandText = "select tlb_producto.idReceta from tlb_producto where tlb_producto.idProducto = " & id & ""
        lector = comando.ExecuteReader
        lector.Read()
        idReceta = lector(0)
        lector.Close()


        'Saber las porciones correspondientes a los insumos dependiendo de la receta y descontar insumos
        comando.CommandText = "select count(tlb_detReceta.idInsumo) from tlb_detReceta where tlb_detReceta.idReceta = " & idReceta & ""
        Dim n As Integer = comando.ExecuteScalar

        'arreglo para almacenar la cantida de insumos que tiene nuestra receta
        Dim insumos(n, 3) As String

        'Se almacena en el arreglo loss datos del insumo que serán utilizados para la venta del producto(id del insumo, cantidad y la unidad de medida) 
        comando.CommandText = "select tlb_detReceta.idInsumo, tlb_detReceta.cantidad, tlb_detReceta.unidadM from tlb_detReceta where tlb_detReceta.idReceta = " & idReceta & ""
        lector = comando.ExecuteReader()
        Dim cont As Integer = 0
        While lector.Read

            insumos(cont, 0) = lector(0)
            insumos(cont, 1) = lector(1)
            insumos(cont, 2) = lector(2)
            'cont += 1
            cont += 1
        End While
        lector.Close()




        comando.CommandText = "Select count(tlb_insumo.idInsumo) from tlb_insumo"
        Dim cantInsumos As Integer = comando.ExecuteScalar
        Dim todosInsumos(cantInsumos, 3) As String

        comando.CommandText = "Select tlb_insumo.idInsumo, tlb_insumo.unidadM, tlb_insumo.existencia from tlb_insumo"
        lector = comando.ExecuteReader

        Dim p As Integer = 0
        While lector.Read
            todosInsumos(p, 0) = lector(0)
            todosInsumos(p, 1) = lector(1)
            todosInsumos(p, 2) = lector(2)

            p += 1
        End While
        lector.Close()



        For t = 0 To n - 1
            For x = 0 To cantInsumos - 1
                If insumos(t, 0) = todosInsumos(x, 0) Then
                    'obtener la unidad de medida del insumo
                    Dim unidad As String
                    unidad = todosInsumos(x, 1)
                    'Variable que nos guarda saber la existencia del insumo que se busca
                    Dim unidadBase As Decimal = todosInsumos(x, 2)

                    Dim cantidadInsumo As Decimal

                    Dim insumoRestante As Decimal

                    If unidad = "LTS" Then


                        cantidadInsumo = insumos(t, 1) * 0.0295735
                        cantidadInsumo = cantidadInsumo * cantidadProductos
                        insumoRestante = unidadBase - cantidadInsumo


                    ElseIf unidad = "KG" Then
                        MsgBox("Son kilos")

                        cantidadInsumo = insumos(t, 1) * 0.0283495
                        cantidadInsumo = cantidadInsumo * cantidadProductos
                        insumoRestante = unidadBase - cantidadInsumo


                    ElseIf unidad = "GR" Then
                        MsgBox("Son gramos")

                        cantidadInsumo = insumos(t, 1) * 28.3495
                        cantidadInsumo = cantidadInsumo * cantidadProductos
                        insumoRestante = unidadBase - cantidadInsumo


                    ElseIf unidad = "MLT" Then
                        MsgBox("Son mililitros")
                        cantidadInsumo = insumos(t, 1) * 28.4131
                        cantidadInsumo = cantidadInsumo * cantidadProductos
                        insumoRestante = unidadBase - cantidadInsumo


                    ElseIf unidad = "PZA" Then
                        MsgBox("son piezas")
                        cantidadInsumo = insumos(t, 1) * cantidadProductos
                        insumoRestante = unidadBase - cantidadInsumo

                    End If
                    'actualizar las existencias del insumo
                    comando.CommandText = "Update tlb_insumo set existencia = " & insumoRestante & " where idInsumo = " & todosInsumos(x, 0) & ""
                    comando.ExecuteNonQuery()
                End If
            Next
        Next
    End Sub
    '/****************************************Cargar insumos a arreglo*********************************/



    '/*/*/*//*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/**Limpiar los checkbox de venta pizzas/*/*/*//*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/

    Public limite As Integer

    Public Sub limpiarLista()
        For i = 0 To 20
            frmMovimientoVentasPizzas.CheckedListBox1.SetItemChecked(i, False)
        Next
    End Sub

    Public Function buscarCheck()
        Dim con As Integer
        For i = 0 To 20
            If frmMovimientoVentasPizzas.CheckedListBox1.GetItemCheckState(i) = 1 Then
                con += 1
            End If
        Next
        Return con
    End Function
    Public Sub limpiarSeleccionado(seleccionado As String)

        For i = 0 To 20
            'MsgBox(frmMovimientoVentasPizzas.CheckedListBox1.Items(i))
            If frmMovimientoVentasPizzas.CheckedListBox1.Items(i) = seleccionado Then
                MsgBox("iguales")
                frmMovimientoVentasPizzas.CheckedListBox1.SetItemChecked(i, False)
                Exit For
            End If
        Next
    End Sub


    Public Sub mensajeGrabar()
        MessageBox.Show("SU INFORMACIÓN HA SIDO GUARDADA", "REGISTRO COMPLETO", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub mensajeVenta()
        MessageBox.Show("VENTA REGISTRADA CON EXITO", "REGISTRO COMPLETO", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Module
