Public Class frmConsultaReceta
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        dgvConsultaDetRecetas.Rows.Clear()
        dgvRecetas.Rows.Clear()
        If rbtConsultaNombre.Checked Then
            comando.CommandText = "Select tlb_insumo.nombre, tlb_detReceta.cantidad, tlb_detReceta.unidadM From tlb_detReceta Inner Join tlb_receta On tlb_detReceta.idReceta = tlb_receta.idReceta Inner Join tlb_insumo On tlb_detReceta.idInsumo = tlb_insumo.idInsumo Where tlb_receta.nombre like '%" & txtConsultaNombre.Text & "%'"
            lector = comando.ExecuteReader
            While lector.Read
                dgvConsultaDetRecetas.Rows.Add(lector(0), lector(1), lector(2))
            End While
            lector.Close()
        ElseIf rbtConsultaTodo.Checked Then
            comando.CommandText = "Select tlb_receta.idReceta, tlb_receta.nombre, tlb_insumo.nombre, tlb_detReceta.cantidad, tlb_detReceta.unidadM From tlb_receta Inner Join tlb_detReceta On tlb_receta.idReceta = tlb_detReceta.idReceta Inner Join tlb_insumo On tlb_detReceta.idInsumo = tlb_insumo.idInsumo"
            lector = comando.ExecuteReader
            While lector.Read
                dgvRecetas.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
            End While
            lector.Close()
        End If
    End Sub
    Private Sub frmConsultaReceta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionSql.Open()
    End Sub

    Private Sub rbtConsultaNombre_CheckedChanged(sender As Object, e As EventArgs) Handles rbtConsultaNombre.CheckedChanged
        If rbtConsultaNombre.Checked Then
            txtConsultaNombre.Visible = True
            dgvConsultaDetRecetas.Visible = True
            txtConsultaNombre.Clear()
        Else
            txtConsultaNombre.Visible = False
            dgvConsultaDetRecetas.Visible = False
        End If
    End Sub

    Private Sub txtConsultaNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConsultaNombre.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaValida, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

    Private Sub btnSeleccionarReceta_Click(sender As Object, e As EventArgs) Handles btnSeleccionarReceta.Click
        Dim receta As New frmAgregarReceta
        receta.dgvRecetas.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        Dim ban As Boolean = False
        receta.ShowDialog()

        If receta.dgvRecetas.CurrentRow IsNot Nothing Then
            Dim fila As Integer = receta.dgvRecetas.CurrentRow.Index
            txtConsultaNombre.Text = receta.dgvRecetas(1, fila).Value
        Else
            MessageBox.Show("NO SE HA SELECCIONADO RECETA", "FALTA DE INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub rbtConsultaTodo_CheckedChanged(sender As Object, e As EventArgs) Handles rbtConsultaTodo.CheckedChanged
        If rbtConsultaTodo.Checked Then
            dgvRecetas.Visible = True
        Else
            dgvRecetas.Visible = False
        End If
    End Sub

    Private Sub btnSalir_Click_1(sender As Object, e As EventArgs) Handles btnSalir.Click
        conexionSql.Close()
        Me.Close()
    End Sub
End Class