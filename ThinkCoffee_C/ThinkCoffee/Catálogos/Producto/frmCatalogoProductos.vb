﻿Imports System.ComponentModel

Public Class frmCatalogoProductos
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

        'Sube las recetas a la combito :v
        comando.CommandText = "Select tlb_receta.nombre from tlb_receta"
        lector = comando.ExecuteReader

        While lector.Read
            cboReceta.Items.Add(lector(0))
        End While
        lector.Close()

        'Añade los productos a la rejilla si es que existen
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

        btnModificar.Enabled = False

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
        Dim idProducto As Integer
        Dim idReceta As Integer
        Dim idCategoria As Integer
        Dim nombre As String
        Dim precio As Double
        Dim precioFin As String
        Dim imagen As String

        idProducto = CInt(txtIdProducto.Text)
        idReceta = CInt(txtIdReceta.Text)
        idCategoria = CInt(txtIdCategoria.Text)
        nombre = txtNombre.Text
        precio = CDbl(txtPrecio.Text)
        'Yo estoy usando la variable "precioFin" porque por el lenguaje de la base de datos
        'y de Visual, si guardo los decimales con una coma, me lo toma como otra columna,
        'y si lo guardo con punto, el programa no me muestra los precios como los guardé.
        'Si ustedes no tienen ese problema, solamente comenten la variable "precioFin", y
        'en la sentencia de SQL reemplacen la variable "precioFin" por "precio".
        precioFin = Replace(precio, ",", ".")
        imagen = OpenFileDialog1.FileName

        comando.CommandText = "Insert Into tlb_producto(idProducto, idReceta, idCategoria, nombre, precio, imagen) values(" & idProducto & "," & idReceta & "," & idCategoria & ",'" & nombre & "'," & precioFin & ",'" & imagen & "')"
        comando.ExecuteNonQuery()

        btnGrabar.Enabled = False
        btnCancelar.Enabled = False
        btnSalir.Enabled = True
        btnNuevo.Enabled = True

        bloquearCajaProductos()
        limpiarCajaProductos()
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

        dgProductos.Rows.Add(txtIdProducto.Text, txtNombre.Text, txtIdCategoria.Text, txtIdReceta.Text, txtPrecio.Text)


        'limpiarCajaProductos()
        bloquearCajaProductos()

    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        If Len(txtNombre.Text) < 5 Then
            MessageBox.Show("DEBES INTRODUCIR AL MENOS 10 CARACTERES", "FALTA INFORMACION",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNombre.Focus()
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

    Private Sub txtNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombre.KeyDown

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
        'If (txtPrecio.Text <> String.Empty) Then

        '    ' Convertimos a Decimal el valor del control TextBox. Si
        '    ' el valor no se puede convertir a Decimal, se mostrará
        '    ' un 0 en lugar de producirse un error.
        '    '
        '    Dim importe As Decimal
        '    Decimal.TryParse(txtPrecio.Text, importe)

        '    ' Formateamos a entero, sin decimales, el valor decimal obtenido.
        '    '
        '    txtPrecio.Text = String.Format("{0:C0}", importe)

        '    ' Establecemos el punto de inserción al final del valor del control TextBox.
        '    '
        '    txtPrecio.SelectionStart = txtPrecio.TextLength

        'End If
        'Dim value As Decimal = (txtPrecio.Text)

        'txtPrecio.Text = String.Format("{0:N0}", 2, 5)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub cboReceta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboReceta.SelectedIndexChanged
        comando.CommandText = "Select tlb_receta.idReceta From tlb_receta Where tlb_receta.nombre='" & cboReceta.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        txtIdReceta.Text = lector(0)
        lector.Close()
    End Sub
End Class