Public Class ConsultaVentaPizzas

    Private Sub ConsultaVentaPizzas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgVentaP.Rows.Clear()
        conexionSql.Open()

    End Sub

    Private Sub rbChica_CheckedChanged(sender As Object, e As EventArgs) Handles rbChica.CheckedChanged
        dgVentaP.Rows.Clear()
        comando.CommandText = "Select tlb_venta.idVenta, tlb_pizza.size, tlb_pizza.tipo , tlb_pizza.cantidad,  tlb_venta.total from tlb_venta inner join tlb_pizza on tlb_pizza.idVenta	= tlb_venta.idVenta where  tlb_pizza.size = '" & rbChica.Text & "'"
        lector = comando.ExecuteReader

        While lector.Read
            dgVentaP.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
        End While
        lector.Close()
    End Sub

    Private Sub rbGrande_CheckedChanged(sender As Object, e As EventArgs) Handles rbGrande.CheckedChanged
        dgVentaP.Rows.Clear()
        comando.CommandText = "Select tlb_venta.idVenta, tlb_pizza.size, tlb_pizza.tipo , tlb_pizza.cantidad,  tlb_venta.total from tlb_venta inner join tlb_pizza on tlb_pizza.idVenta	= tlb_venta.idVenta where  tlb_pizza.size = '" & rbGrande.Text & "'"
        lector = comando.ExecuteReader

        While lector.Read
            dgVentaP.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
        End While
        lector.Close()

    End Sub

    Private Sub rbRebanada_CheckedChanged(sender As Object, e As EventArgs) Handles rbRebanada.CheckedChanged
        dgVentaP.Rows.Clear()
        comando.CommandText = "Select tlb_venta.idVenta, tlb_pizza.size, tlb_pizza.tipo , tlb_pizza.cantidad,  tlb_venta.total from tlb_venta inner join tlb_pizza on tlb_pizza.idVenta	= tlb_venta.idVenta where  tlb_pizza.size = '" & rbRebanada.Text & "'"
        lector = comando.ExecuteReader

        While lector.Read
            dgVentaP.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
        End While
        lector.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        conexionSql.Close()
        Me.Close()
    End Sub
End Class