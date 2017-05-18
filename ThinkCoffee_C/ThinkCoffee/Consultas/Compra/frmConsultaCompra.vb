Public Class frmConsultaCompra
    Private Sub rbProveedor_CheckedChanged(sender As Object, e As EventArgs) Handles rbProveedor.CheckedChanged
        If rbProveedor.Checked Then
            txtProveedor.Visible = True
            btnBuscarP.Visible = True
        Else
            txtProveedor.Visible = False
            btnBuscarP.Visible = False

        End If
    End Sub

    Private Sub rbFecha_CheckedChanged(sender As Object, e As EventArgs) Handles rbFecha.CheckedChanged
        If rbFecha.Checked Then
            dtpFechaInicial.Visible = True
            dtpFechaFinal.Visible = True
            lblInicial.Visible = True
            lblFinal.Visible = True
        Else
            dtpFechaInicial.Visible = False
            dtpFechaFinal.Visible = False
            lblInicial.Visible = False
            lblFinal.Visible = False
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If rbProveedor.Checked Then
            comando.CommandText = "Select tlb_compra.idCompra, tlb_proveedor.nombre, tlb_compra.fecha, tlb_compra.total from tlb_compra inner join tlb_proveedor on tlb_proveedor.idProveedor = tlb_compra.idProveedor where tlb_proveedor.nombre = '" & txtProveedor.Text & "'"
            lector = comando.ExecuteReader
            While lector.Read
                dgCompra.Rows.Add(lector(0), lector(1), lector(2), lector(3))
            End While
            lector.Close()

        End If
    End Sub

    Private Sub frmConsultaCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionSql.Open()
        dgCompra.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub btnBuscarP_Click(sender As Object, e As EventArgs) Handles btnBuscarP.Click
        comando.CommandText = "select tlb_proveedor.idProveedor, tlb_proveedor.nombre from tlb_proveedor"
        lector = comando.ExecuteReader
        While lector.Read
            BuscarProveedor.dgProv.Rows.Add(lector(0), lector(1))
        End While
        BuscarProveedor.ShowDialog()
    End Sub
End Class