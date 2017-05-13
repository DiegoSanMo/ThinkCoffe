Public Class frmMovimientoVentasPizzas
    Private Sub frmMovimientoVentasPizzas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cboTamaño_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTamaño.SelectedIndexChanged
        If cboTamaño.Text = "REBANADA" Then
        ElseIf cboTamaño.Text = " CHICA" Then

        ElseIf cboTamaño.Text = " MEDIANA" Then

        ElseIf cboTamaño.Text = "GRANDE" Then

        End If


    End Sub
End Class