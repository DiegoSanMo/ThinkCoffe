Imports System.ComponentModel

Public Class frmCatalogoProductos
    Dim presionado As Boolean = False
    Dim idR As Integer
    Dim idC As Integer
    Dim ubi As String

    Private Sub frmCatalogoProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionSql.Open()
        dgProductos.Rows.Clear()
        Dim n As Integer
        comando.CommandText = String.Format("Select count(*) from tlb_producto	")
        n = comando.ExecuteScalar + 1

        'Sube las categorías al combo
        comando.CommandText = "Select tlb_categoria.nombre from tlb_categoria"
        lector = comando.ExecuteReader

        While lector.Read
            cboCategoria.Items.Add(lector(0))
        End While
        lector.Close()


        'Añade los productos a la rejilla si es que existen
        If n > 0 Then
            comando.CommandText = String.Format("Select tlb_producto.idProducto, tlb_producto.nombre, tlb_categoria.nombre, tlb_receta.nombre, tlb_producto.precio from tlb_producto inner join tlb_categoria on tlb_producto.idCategoria = tlb_categoria.idCategoria inner join tlb_receta on tlb_producto.idReceta = tlb_receta.idReceta ")
            lector = comando.ExecuteReader()
            While lector.Read
                dgProductos.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
            End While
            lector.Close()
        End If


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        OpenFileDialog1.ShowDialog()
        Dim ruta As String
        ruta = OpenFileDialog1.FileName
        ptbImagen.Image = Image.FromFile(ruta)
        ubi = ruta
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

        btnModificar.Enabled = False

        txtNombre.Enabled = True
        btnBuscarR.Enabled = True
        cboCategoria.Enabled = True
        txtPrecio.Enabled = True
        btnBuscar.Enabled = True

        Dim n As Integer
        comando.CommandText = String.Format("Select count(tlb_producto.idProducto) from tlb_producto")
        n = comando.ExecuteScalar + 1

        txtIdProducto.Text = n
        txtNombre.Focus()


    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If presionado Then
            btnGrabar.Enabled = False
            btnCancelar.Enabled = False
            btnSalir.Enabled = True
            btnNuevo.Enabled = True
            bloquearCajaProductos()
            limpiarCajaProductos()

            If dgProductos.RowCount > 0 Then
                dgProductos.Rows.RemoveAt(dgProductos.RowCount - 1)
            End If

            txtIdProducto.Text = ""
            txtIdReceta.Text = ""
            txtIdCategoria.Text = ""
            txtNombre.Text = ""
            txtPrecio.Text = ""
            txtNombreReceta.Text = ""
        Else

        End If





    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If presionado Then
            If txtNombre.Text = "" Or txtIdCategoria.Text = "" Then

                Dim precioFin As String
                Dim imagen As String


                'Yo estoy usando la variable "precioFin" porque por el lenguaje de la base de datos
                'y de Visual, si guardo los decimales con una coma, me lo toma como otra columna,
                'y si lo guardo con punto, el programa no me muestra los precios como los guardé.
                'Si ustedes no tienen ese problema, solamente comenten la variable "precioFin", y
                'en la sentencia de SQL reemplacen la variable "precioFin" por "precio".
                imagen = OpenFileDialog1.FileName
                If imagen = "Buscar imagenes" Then
                    imagen = ubi
                End If
                Dim fila As Integer = dgProductos.RowCount - 1

                comando.CommandText = "Insert Into tlb_producto(idProducto, idReceta, idCategoria, nombre, precio, imagen) values(" & CInt(dgProductos(0, fila).Value) & "," & idR & "," & idC & ",'" & dgProductos(1, fila).Value & "'," & CDec(dgProductos(4, fila).Value) & ",'" & imagen & "')"
                comando.ExecuteNonQuery()
                mensajeGrabar()
                btnGrabar.Enabled = False
                btnCancelar.Enabled = False
                btnSalir.Enabled = True
                btnNuevo.Enabled = True

                bloquearCajaProductos()
                limpiarCajaProductos()
                txtNombreReceta.Text = ""
            Else
                MessageBox.Show("PRESIONAR EL BOTÓN DE ACEPTAR PARA GUARDAR PRODUCTO", "ERROR DE ALMACENAMIENTO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("PRESIONAR EL BOTÓN DE ACEPTAR PARA REGISTRAR PRODUCTO", "ERROR DE ALMACENAMIENTO", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If txtIdCategoria.Text = "" Then
            MessageBox.Show("NO SE HA INGRESADO CATEGORIA", "FALTA DE INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboCategoria.Focus()
            presionado = False

        Else

            If txtNombre.Text = "" Then
                MessageBox.Show("NO SE HA INGRESADO NOMBRE DEL PRODUCTO", "FALTA DE INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If txtIdReceta.Text = "" Then
                    MessageBox.Show("NO SE HA INGRESADO RECETA", "FALTA DE INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    btnBuscarR.Focus()
                Else
                    If Not IsNumeric(txtPrecio.Text) Then
                        MessageBox.Show("PRECIO NO VALIDO", "FALTA DE INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtPrecio.Focus()

                    Else
                        If String.IsNullOrWhiteSpace(ubi) Then

                            ubi = "~\ThinkCoffee_C\imagenes\producto.png"
                        End If
                        dgProductos.Rows.Add(txtIdProducto.Text, txtNombre.Text, cboCategoria.Text, txtNombreReceta.Text, txtPrecio.Text)
                        idR = CInt(txtIdReceta.Text)
                        idC = CInt(txtIdCategoria.Text)

                        limpiarCajaProductos()
                        bloquearCajaProductos()
                        presionado = True
                    End If

                End If
            End If


        End If


    End Sub

    Private Sub cboCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategoria.SelectedIndexChanged
        comando.CommandText = "Select tlb_categoria.idCategoria from tlb_categoria where tlb_categoria.nombre = '" & cboCategoria.Text & "'"
        lector = comando.ExecuteReader

        lector.Read()
        txtIdCategoria.Text = lector(0)
        lector.Close()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        'Bloqueo de botones principales
        btnModificar.Enabled = False
        btnSalir.Enabled = False
        btnNuevo.Enabled = False
        btnGrabar.Enabled = True
        btnCancelar.Enabled = True

        'limpieza de la caja de productos
        activarCajaProductos()



    End Sub


    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaNumeros, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub txtPrecio_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged


    End Sub


    Private Sub btnBuscarR_Click(sender As Object, e As EventArgs) Handles btnBuscarR.Click
        Dim id As Integer
        Dim buscar As New frmBusquedaRecetas
        buscar.dgBusquedaRecetas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        buscar.ShowDialog()


        If buscar.dgBusquedaRecetas.CurrentRow Is Nothing Then
            MessageBox.Show("NO SE HA SELECCIONADO RECETA", "FALTA DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Dim i As Integer = buscar.dgBusquedaRecetas.CurrentRow.Index
            id = buscar.dgBusquedaRecetas(0, i).Value
            comando.CommandText = "Select tlb_receta.nombre from tlb_receta where tlb_receta.idReceta = " & id & ""
            lector = comando.ExecuteReader
            lector.Read()
            txtNombreReceta.Text = lector(0)
            lector.Close()
            txtIdReceta.Text = id

        End If



    End Sub

End Class