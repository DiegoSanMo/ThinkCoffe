﻿Public Class frmPrincipal
    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnRegistro_Click(sender As Object, e As EventArgs)
        frmCatalogoProveedores.ShowDialog()
    End Sub

    Private Sub RecordatoriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecordatoriosToolStripMenuItem.Click
        frmCatalogoRecordatorios.ShowDialog()
    End Sub

    Private Sub InsumosToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub ProveedoresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem1.Click
        frmCatalogoProveedores.ShowDialog()

    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        menuBar.Width = 80
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Private Sub PromocionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PromocionesToolStripMenuItem.Click
        frmCatalogoRecetas.ShowDialog()
    End Sub

    Private Sub ProductosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem1.Click
        frmCatalogoProductos.ShowDialog()
    End Sub

    Private Sub CategoriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriasToolStripMenuItem.Click
        frmCatalogoCategoria.ShowDialog()
    End Sub

    Private Sub IngredientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngredientesToolStripMenuItem.Click
        frmCatalogoInsumos.ShowDialog()
    End Sub
End Class