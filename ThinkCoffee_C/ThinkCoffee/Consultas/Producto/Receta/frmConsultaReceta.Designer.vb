﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaReceta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSeleccionarReceta = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtConsultaNombre = New System.Windows.Forms.TextBox()
        Me.rbtConsultaTodo = New System.Windows.Forms.RadioButton()
        Me.rbtConsultaNombre = New System.Windows.Forms.RadioButton()
        Me.dgvConsultaDetRecetas = New System.Windows.Forms.DataGridView()
        Me.clmNombreInsumo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmUnidadDeMedida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.dgvRecetas = New System.Windows.Forms.DataGridView()
        Me.clmIdReceta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmNombreReceta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmNombreInsumoPrincipal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCantidadPrincipal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmUnidadMedida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvConsultaDetRecetas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRecetas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSeleccionarReceta)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.txtConsultaNombre)
        Me.GroupBox1.Controls.Add(Me.rbtConsultaTodo)
        Me.GroupBox1.Controls.Add(Me.rbtConsultaNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(476, 115)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipos de consulta:"
        '
        'btnSeleccionarReceta
        '
        Me.btnSeleccionarReceta.Location = New System.Drawing.Point(391, 19)
        Me.btnSeleccionarReceta.Name = "btnSeleccionarReceta"
        Me.btnSeleccionarReceta.Size = New System.Drawing.Size(75, 35)
        Me.btnSeleccionarReceta.TabIndex = 4
        Me.btnSeleccionarReceta.Text = "Seleccionar receta"
        Me.btnSeleccionarReceta.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(7, 86)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(459, 23)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtConsultaNombre
        '
        Me.txtConsultaNombre.Enabled = False
        Me.txtConsultaNombre.Location = New System.Drawing.Point(76, 20)
        Me.txtConsultaNombre.Name = "txtConsultaNombre"
        Me.txtConsultaNombre.Size = New System.Drawing.Size(294, 20)
        Me.txtConsultaNombre.TabIndex = 2
        Me.txtConsultaNombre.Visible = False
        '
        'rbtConsultaTodo
        '
        Me.rbtConsultaTodo.AutoSize = True
        Me.rbtConsultaTodo.Location = New System.Drawing.Point(7, 53)
        Me.rbtConsultaTodo.Name = "rbtConsultaTodo"
        Me.rbtConsultaTodo.Size = New System.Drawing.Size(50, 17)
        Me.rbtConsultaTodo.TabIndex = 1
        Me.rbtConsultaTodo.TabStop = True
        Me.rbtConsultaTodo.Text = "Todo"
        Me.rbtConsultaTodo.UseVisualStyleBackColor = True
        '
        'rbtConsultaNombre
        '
        Me.rbtConsultaNombre.AutoSize = True
        Me.rbtConsultaNombre.Location = New System.Drawing.Point(7, 20)
        Me.rbtConsultaNombre.Name = "rbtConsultaNombre"
        Me.rbtConsultaNombre.Size = New System.Drawing.Size(62, 17)
        Me.rbtConsultaNombre.TabIndex = 0
        Me.rbtConsultaNombre.TabStop = True
        Me.rbtConsultaNombre.Text = "Nombre"
        Me.rbtConsultaNombre.UseVisualStyleBackColor = True
        '
        'dgvConsultaDetRecetas
        '
        Me.dgvConsultaDetRecetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsultaDetRecetas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmNombreInsumo, Me.clmCantidad, Me.clmUnidadDeMedida})
        Me.dgvConsultaDetRecetas.Location = New System.Drawing.Point(12, 145)
        Me.dgvConsultaDetRecetas.Name = "dgvConsultaDetRecetas"
        Me.dgvConsultaDetRecetas.Size = New System.Drawing.Size(496, 150)
        Me.dgvConsultaDetRecetas.TabIndex = 1
        Me.dgvConsultaDetRecetas.Visible = False
        '
        'clmNombreInsumo
        '
        Me.clmNombreInsumo.HeaderText = "Nombre de insumo"
        Me.clmNombreInsumo.Name = "clmNombreInsumo"
        Me.clmNombreInsumo.ReadOnly = True
        Me.clmNombreInsumo.Width = 250
        '
        'clmCantidad
        '
        Me.clmCantidad.HeaderText = "Cantidad"
        Me.clmCantidad.Name = "clmCantidad"
        Me.clmCantidad.ReadOnly = True
        '
        'clmUnidadDeMedida
        '
        Me.clmUnidadDeMedida.HeaderText = "Unidad de medida"
        Me.clmUnidadDeMedida.Name = "clmUnidadDeMedida"
        Me.clmUnidadDeMedida.ReadOnly = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(248, 309)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(379, 23)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'dgvRecetas
        '
        Me.dgvRecetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecetas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmIdReceta, Me.clmNombreReceta, Me.clmNombreInsumoPrincipal, Me.clmCantidadPrincipal, Me.clmUnidadMedida})
        Me.dgvRecetas.Location = New System.Drawing.Point(12, 145)
        Me.dgvRecetas.Name = "dgvRecetas"
        Me.dgvRecetas.Size = New System.Drawing.Size(846, 150)
        Me.dgvRecetas.TabIndex = 5
        Me.dgvRecetas.Visible = False
        '
        'clmIdReceta
        '
        Me.clmIdReceta.HeaderText = "IdReceta"
        Me.clmIdReceta.Name = "clmIdReceta"
        Me.clmIdReceta.ReadOnly = True
        '
        'clmNombreReceta
        '
        Me.clmNombreReceta.HeaderText = "Nombre Receta"
        Me.clmNombreReceta.Name = "clmNombreReceta"
        Me.clmNombreReceta.ReadOnly = True
        Me.clmNombreReceta.Width = 250
        '
        'clmNombreInsumoPrincipal
        '
        Me.clmNombreInsumoPrincipal.HeaderText = "Nombre Insumo"
        Me.clmNombreInsumoPrincipal.Name = "clmNombreInsumoPrincipal"
        Me.clmNombreInsumoPrincipal.ReadOnly = True
        Me.clmNombreInsumoPrincipal.Width = 250
        '
        'clmCantidadPrincipal
        '
        Me.clmCantidadPrincipal.HeaderText = "Cantidad"
        Me.clmCantidadPrincipal.Name = "clmCantidadPrincipal"
        Me.clmCantidadPrincipal.ReadOnly = True
        '
        'clmUnidadMedida
        '
        Me.clmUnidadMedida.HeaderText = "Unidad de medida"
        Me.clmUnidadMedida.Name = "clmUnidadMedida"
        Me.clmUnidadMedida.ReadOnly = True
        '
        'frmConsultaReceta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 344)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvRecetas)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.dgvConsultaDetRecetas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmConsultaReceta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de recetas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvConsultaDetRecetas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRecetas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbtConsultaTodo As RadioButton
    Friend WithEvents rbtConsultaNombre As RadioButton
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtConsultaNombre As TextBox
    Friend WithEvents dgvConsultaDetRecetas As DataGridView
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnSeleccionarReceta As Button
    Friend WithEvents clmNombreInsumo As DataGridViewTextBoxColumn
    Friend WithEvents clmCantidad As DataGridViewTextBoxColumn
    Friend WithEvents clmUnidadDeMedida As DataGridViewTextBoxColumn
    Friend WithEvents dgvRecetas As DataGridView
    Friend WithEvents clmIdReceta As DataGridViewTextBoxColumn
    Friend WithEvents clmNombreReceta As DataGridViewTextBoxColumn
    Friend WithEvents clmNombreInsumoPrincipal As DataGridViewTextBoxColumn
    Friend WithEvents clmCantidadPrincipal As DataGridViewTextBoxColumn
    Friend WithEvents clmUnidadMedida As DataGridViewTextBoxColumn
End Class
