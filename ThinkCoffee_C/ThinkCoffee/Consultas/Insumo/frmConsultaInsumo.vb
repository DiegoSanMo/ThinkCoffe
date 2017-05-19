Public Class frmConsultaInsumo
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        dgvConsultaInsumo.Rows.Clear()
        If rbtTodo.Checked Then
            comando.CommandText = "Select tlb_insumo.idInsumo, tlb_insumo.nombre, tlb_insumo.maximo, tlb_insumo.minimo, tlb_insumo.existencia, tlb_insumo.costo, tlb_insumo.fecha from tlb_insumo"
            lector = comando.ExecuteReader
            While lector.Read
                dgvConsultaInsumo.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6))
            End While
            lector.Close()
        ElseIf rbtUnidadDeMedida.Checked Then
            comando.CommandText = "Select tlb_insumo.idInsumo, tlb_insumo.nombre, tlb_insumo.maximo, tlb_insumo.minimo, tlb_insumo.existencia, tlb_insumo.costo, tlb_insumo.fecha from tlb_insumo Where tlb_insumo.nombre='" & cboInsumo.Text & "'"
            lector = comando.ExecuteReader
            While lector.Read
                dgvConsultaInsumo.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6))
            End While
            lector.Close()
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        conexionSql.Close()
        Me.Close()
    End Sub

    Private Sub frmConsultaInsumo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionSql.Open()
    End Sub

    Private Sub rbtNombre_CheckedChanged(sender As Object, e As EventArgs) Handles rbtNombre.CheckedChanged
        If rbtNombre.Checked Then
            txtNombre.Visible = True
            btnBuscarNom.Visible = True
        Else
            txtNombre.Visible = False
            btnBuscarNom.Visible = False
        End If
    End Sub

    Private Sub rbtUnidadDeMedida_CheckedChanged(sender As Object, e As EventArgs) Handles rbtUnidadDeMedida.CheckedChanged
        If rbtUnidadDeMedida.Checked Then
            cboInsumo.Visible = True
        Else
            cboInsumo.Visible = False
        End If
    End Sub
End Class