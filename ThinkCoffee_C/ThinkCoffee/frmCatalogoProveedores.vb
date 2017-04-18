Public Class frmCatalogoProveedores
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ptbBarra_MouseDown(sender As Object, e As MouseEventArgs) Handles ptbBarra.MouseDown
        ex = e.X
        ey = e.Y
        mover = True

    End Sub
    Private Sub ptbBarra_Move(sender As Object, e As EventArgs) Handles ptbBarra.Move
        If mover = True Then
            If mover Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))
        End If

    End Sub


    Private Sub ptbBarra_MouseUp(sender As Object, e As MouseEventArgs) Handles ptbBarra.MouseUp
        mover = False
    End Sub

    Private Sub frmCatalogoProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionSql.Open()
        dgProveedores.Rows.Clear()
        Dim n As Integer
        comando.CommandText = String.Format("Select count(*) from tlb_proveedor	")
        n = comando.ExecuteScalar + 1

        If n > 1 Then
            comando.CommandText = String.Format("Select * from tlb_proveedor")
            lector = comando.ExecuteReader()
            While lector.Read
                dgProveedores.Rows.Add(lector(0), lector(1), lector(2), lector(3))
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


    End Sub

    Private Sub txtDireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDireccion.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaDirecciones, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
        btnAceptar.Enabled = True
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtNombre.Enabled = True
        txtDireccion.Enabled = True

        mskTelefono.Enabled = True

        Dim n As Integer
        comando.CommandText = String.Format("Select count(*) from tlb_proveedor	")
        n = comando.ExecuteScalar + 1
        txtIdProveedor.Text = n

        btnNuevo.Enabled = False
        btnSalir.Enabled = False

        btnCancelar.Enabled = True

    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaNumeros, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If

    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Dim ultimo As Integer

        For x = 0 To dgProveedores.RowCount - 2
            If IsNothing(dgProveedores.Item(0, x).Value) Then
            Else
                ultimo = x
            End If


        Next

        For i = ultimo To dgProveedores.RowCount - 2
            comando.CommandText = String.Format("Insert into tlb_proveedor(idProveedor, nombre, telefono, direccion) values ({0}, '{1}', '{2}', '{3}' )", Val(dgProveedores.Item(0, i).Value), dgProveedores.Item(1, i).Value, dgProveedores.Item(2, i).Value, dgProveedores.Item(3, i).Value)
            comando.ExecuteNonQuery()
        Next

        btnGrabar.Enabled = False
        btnCancelar.Enabled = False
        btnNuevo.Enabled = True
        btnSalir.Enabled = True


    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        dgProveedores.Rows.Add(txtIdProveedor.Text, txtNombre.Text, txtDireccion.Text, mskTelefono.Text)
        txtIdProveedor.Text = ""
        txtNombre.Text = ""
        txtDireccion.Text = ""
        mskTelefono.Text = ""

        btnAceptar.Enabled = False
        txtIdProveedor.Enabled = False
        txtNombre.Enabled = False
        txtDireccion.Enabled = False
        mskTelefono.Enabled = False
        btnGrabar.Enabled = True

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        conexionSql.Close()
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

    End Sub
End Class
