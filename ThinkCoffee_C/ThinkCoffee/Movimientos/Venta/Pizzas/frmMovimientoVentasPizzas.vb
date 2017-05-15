Public Class frmMovimientoVentasPizzas

    Dim selec As Integer = 0
    Dim ubicación As Integer = 0
    Private Sub frmMovimientoVentasPizzas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cboTamaño.SelectedIndex = 0
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub
    Private Sub cboTamaño_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTamaño.SelectedIndexChanged
        If cboTamaño.Text = "REBANADA" Then
            limpiarLista()
            limite = 2

        ElseIf cboTamaño.Text = "CHICA" Then
            limpiarLista()
            limite = 5

        ElseIf cboTamaño.Text = "GRANDE" Then
            limpiarLista()
            limite = 9

        End If
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged

        If buscarCheck() >= limite Then
            MsgBox("No sé pueden ingresar más toppings")
            limpiarSeleccionado(CheckedListBox1.SelectedItem.ToString())
        End If
    End Sub
End Class