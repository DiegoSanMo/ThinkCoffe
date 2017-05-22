Public Class ConsultaVentaPizzas

    Private Sub ConsultaVentaPizzas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionSql.Open()
        dgVentaP.Rows.Clear()
        rbRebanada.Checked = False
        rbChica.Checked = False
        rbGrande.Checked = False
    End Sub

    Private Sub rbChica_CheckedChanged(sender As Object, e As EventArgs) Handles rbChica.CheckedChanged
        If rbChica.Checked Then
            dgVentaP.Rows.Clear()

            comando.CommandText = "Select count(tlb_pizza.size) from tlb_pizza where tlb_pizza.size = '" & rbChica.Text & "'"
            Dim n As Integer = comando.ExecuteScalar

            If n > 0 Then
                comando.CommandText = "Select tlb_venta.idVenta, tlb_pizza.size, tlb_pizza.tipo , tlb_pizza.cantidad,  tlb_venta.total from tlb_venta inner join tlb_pizza on tlb_pizza.idVenta	= tlb_venta.idVenta where  tlb_pizza.size = '" & rbChica.Text & "'"
                lector = comando.ExecuteReader

                While lector.Read
                    dgVentaP.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
                End While
                lector.Close()
                btnDetallesP.Visible = True
            Else
                MessageBox.Show("NO SE HAN REGISTRADO VENTAS DE PIZZAS CHICAS", "INFORMACIÒN DE CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                btnDetallesP.Visible = False
            End If
            rbChica.Checked = False
        Else
            rbChica.Checked = False
        End If

    End Sub

    Private Sub rbGrande_CheckedChanged(sender As Object, e As EventArgs) Handles rbGrande.CheckedChanged

        If rbGrande.Checked Then
            dgVentaP.Rows.Clear()
            comando.CommandText = "Select count(tlb_pizza.size) from tlb_pizza where tlb_pizza.size = '" & rbGrande.Text & "'"
            Dim n As Integer = comando.ExecuteScalar

            If n > 0 Then
                comando.CommandText = "Select tlb_venta.idVenta, tlb_pizza.size, tlb_pizza.tipo , tlb_pizza.cantidad,  tlb_venta.total from tlb_venta inner join tlb_pizza on tlb_pizza.idVenta	= tlb_venta.idVenta where  tlb_pizza.size = '" & rbGrande.Text & "'"
                lector = comando.ExecuteReader

                While lector.Read
                    dgVentaP.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
                End While
                lector.Close()
                btnDetallesP.Visible = True
            Else
                MessageBox.Show("NO SE HAN REGISTRADO VENTAS DE PIZZAS GRANDES", "INFORMACIÒN DE CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                btnDetallesP.Visible = False
            End If
        Else
            rbGrande.Checked = False
        End If

    End Sub

    Private Sub rbRebanada_CheckedChanged(sender As Object, e As EventArgs) Handles rbRebanada.CheckedChanged
        If rbRebanada.Checked Then
            dgVentaP.Rows.Clear()
            comando.CommandText = "Select count(tlb_pizza.size) from tlb_pizza where tlb_pizza.size = '" & rbRebanada.Text & "'"
            Dim n As Integer = comando.ExecuteScalar

            If n > 0 Then
                comando.CommandText = "Select tlb_venta.idVenta, tlb_pizza.size, tlb_pizza.tipo , tlb_pizza.cantidad,  tlb_venta.total from tlb_venta inner join tlb_pizza on tlb_pizza.idVenta	= tlb_venta.idVenta where  tlb_pizza.size = '" & rbRebanada.Text & "'"
                lector = comando.ExecuteReader

                While lector.Read
                    dgVentaP.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
                End While
                lector.Close()
                btnDetallesP.Visible = True


            Else
                MessageBox.Show("NO SE HAN REGISTRADO VENTAS DE PIZZAS REBANADAS", "INFORMACIÒN DE CONSULTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                btnDetallesP.Visible = False
            End If
        Else
            rbRebanada.Checked = False

        End If

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        conexionSql.Close()
        Me.Close()
    End Sub

    Private Sub btnDetallesP_Click(sender As Object, e As EventArgs) Handles btnDetallesP.Click
        If dgVentaP.CurrentRow IsNot Nothing Then
            Dim fila As Integer = dgVentaP.CurrentRow.Index
            Dim idVenta As Integer = CInt(dgVentaP(0, fila).Value)
            Dim idPizza As String


            comando.CommandText = "Select tlb_pizza.idPizza, tlb_pizza.size, tlb_pizza.tipo, tlb_pizza.cantidad, tlb_pizza.precio, tlb_pizza.idPizza from tlb_pizza where tlb_pizza.idVenta = " & idVenta & ""
            lector = comando.ExecuteReader
            lector.Read()

            detallesVentaP.txtTamaño.Text = lector(1)
            detallesVentaP.txtTipo.Text = lector(2)
            detallesVentaP.txtCantidad.Text = lector(3)
            detallesVentaP.txtPrecio.Text = lector(4)
            idPizza = lector(5)
            lector.Close()


            For x = 0 To 20
                comando.CommandText = "Select tlb_detPizza.topping from tlb_detPizza where tlb_detPizza.idPizza = '" & idPizza & "' "
                lector = comando.ExecuteReader
                While lector.Read
                    If detallesVentaP.CheckedListBox1.Items(x) = lector(0) Then
                        detallesVentaP.CheckedListBox1.SetItemChecked(x, True)
                    End If

                End While
                lector.Close()
            Next
            detallesVentaP.ShowDialog()
        End If
    End Sub
End Class