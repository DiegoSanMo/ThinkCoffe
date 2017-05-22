Public Class ConsultaOtros
    Private Sub btnBuscarP_Click(sender As Object, e As EventArgs) Handles btnBuscarP.Click

    End Sub

    Private Sub rbProducto_CheckedChanged(sender As Object, e As EventArgs) Handles rbProducto.CheckedChanged
        If rbProducto.Checked Then
            txtProducto.Visible = True
            btnBuscarP.Visible = True
        Else
            txtProducto.Visible = False
            btnBuscarP.Visible = False
        End If
    End Sub

    Private Sub rbCategoria_CheckedChanged(sender As Object, e As EventArgs) Handles rbCategoria.CheckedChanged
        If rbCategoria.Checked Then
            txtCategoria.Visible = True
            btnBuscarC.Visible = True
        Else
            txtCategoria.Visible = False
            btnBuscarC.Visible = False
        End If
    End Sub

    Private Sub rbFecha_CheckedChanged(sender As Object, e As EventArgs) Handles rbFecha.CheckedChanged
        If rbFecha.Checked Then
            lblDesde.Visible = True
            lblHasta.Visible = True
            dtpFechaFinal.Visible = True
            dtpFechaInicial.Visible = True
        Else
            lblDesde.Visible = False
            lblHasta.Visible = False
            dtpFechaFinal.Visible = False
            dtpFechaInicial.Visible = False
        End If
    End Sub
End Class