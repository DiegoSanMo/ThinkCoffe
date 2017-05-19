<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaInsumo
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
        Me.gbConsultaInsumos = New System.Windows.Forms.GroupBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.cboInsumo = New System.Windows.Forms.ComboBox()
        Me.btnBuscarNom = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.rbtTodo = New System.Windows.Forms.RadioButton()
        Me.rbtUnidadDeMedida = New System.Windows.Forms.RadioButton()
        Me.rbtNombre = New System.Windows.Forms.RadioButton()
        Me.dgvConsultaInsumo = New System.Windows.Forms.DataGridView()
        Me.clmIdInsumo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmUnidadM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmMaximo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmMinimo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmExistencias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.gbConsultaInsumos.SuspendLayout()
        CType(Me.dgvConsultaInsumo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbConsultaInsumos
        '
        Me.gbConsultaInsumos.Controls.Add(Me.btnAceptar)
        Me.gbConsultaInsumos.Controls.Add(Me.cboInsumo)
        Me.gbConsultaInsumos.Controls.Add(Me.btnBuscarNom)
        Me.gbConsultaInsumos.Controls.Add(Me.txtNombre)
        Me.gbConsultaInsumos.Controls.Add(Me.rbtTodo)
        Me.gbConsultaInsumos.Controls.Add(Me.rbtUnidadDeMedida)
        Me.gbConsultaInsumos.Controls.Add(Me.rbtNombre)
        Me.gbConsultaInsumos.Location = New System.Drawing.Point(13, 13)
        Me.gbConsultaInsumos.Name = "gbConsultaInsumos"
        Me.gbConsultaInsumos.Size = New System.Drawing.Size(597, 176)
        Me.gbConsultaInsumos.TabIndex = 0
        Me.gbConsultaInsumos.TabStop = False
        Me.gbConsultaInsumos.Text = "Consulta por:"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(33, 133)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(523, 36)
        Me.btnAceptar.TabIndex = 9
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'cboInsumo
        '
        Me.cboInsumo.FormattingEnabled = True
        Me.cboInsumo.Items.AddRange(New Object() {"LTS", "KG", "GR" & Global.Microsoft.VisualBasic.ChrW(9), "MLT", "PZA"})
        Me.cboInsumo.Location = New System.Drawing.Point(128, 64)
        Me.cboInsumo.Name = "cboInsumo"
        Me.cboInsumo.Size = New System.Drawing.Size(121, 21)
        Me.cboInsumo.TabIndex = 8
        Me.cboInsumo.Visible = False
        '
        'btnBuscarNom
        '
        Me.btnBuscarNom.Image = Global.ThinkCoffee.My.Resources.Resources.Search_20
        Me.btnBuscarNom.Location = New System.Drawing.Point(507, 14)
        Me.btnBuscarNom.Name = "btnBuscarNom"
        Me.btnBuscarNom.Size = New System.Drawing.Size(49, 29)
        Me.btnBuscarNom.TabIndex = 7
        Me.btnBuscarNom.UseVisualStyleBackColor = True
        Me.btnBuscarNom.Visible = False
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(99, 19)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(371, 20)
        Me.txtNombre.TabIndex = 6
        Me.txtNombre.Visible = False
        '
        'rbtTodo
        '
        Me.rbtTodo.AutoSize = True
        Me.rbtTodo.Location = New System.Drawing.Point(7, 99)
        Me.rbtTodo.Name = "rbtTodo"
        Me.rbtTodo.Size = New System.Drawing.Size(50, 17)
        Me.rbtTodo.TabIndex = 2
        Me.rbtTodo.TabStop = True
        Me.rbtTodo.Text = "Todo"
        Me.rbtTodo.UseVisualStyleBackColor = True
        '
        'rbtUnidadDeMedida
        '
        Me.rbtUnidadDeMedida.AutoSize = True
        Me.rbtUnidadDeMedida.Location = New System.Drawing.Point(7, 64)
        Me.rbtUnidadDeMedida.Name = "rbtUnidadDeMedida"
        Me.rbtUnidadDeMedida.Size = New System.Drawing.Size(114, 17)
        Me.rbtUnidadDeMedida.TabIndex = 1
        Me.rbtUnidadDeMedida.TabStop = True
        Me.rbtUnidadDeMedida.Text = "Unidad de medida:"
        Me.rbtUnidadDeMedida.UseVisualStyleBackColor = True
        '
        'rbtNombre
        '
        Me.rbtNombre.AutoSize = True
        Me.rbtNombre.Location = New System.Drawing.Point(7, 20)
        Me.rbtNombre.Name = "rbtNombre"
        Me.rbtNombre.Size = New System.Drawing.Size(65, 17)
        Me.rbtNombre.TabIndex = 0
        Me.rbtNombre.TabStop = True
        Me.rbtNombre.Text = "Nombre:"
        Me.rbtNombre.UseVisualStyleBackColor = True
        '
        'dgvConsultaInsumo
        '
        Me.dgvConsultaInsumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsultaInsumo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmIdInsumo, Me.clmNombre, Me.clmUnidadM, Me.clmMaximo, Me.clmMinimo, Me.clmExistencias, Me.clmCosto, Me.clmFecha})
        Me.dgvConsultaInsumo.Location = New System.Drawing.Point(12, 210)
        Me.dgvConsultaInsumo.Name = "dgvConsultaInsumo"
        Me.dgvConsultaInsumo.ReadOnly = True
        Me.dgvConsultaInsumo.Size = New System.Drawing.Size(948, 150)
        Me.dgvConsultaInsumo.TabIndex = 1
        '
        'clmIdInsumo
        '
        Me.clmIdInsumo.HeaderText = "IdInsumo"
        Me.clmIdInsumo.Name = "clmIdInsumo"
        Me.clmIdInsumo.ReadOnly = True
        '
        'clmNombre
        '
        Me.clmNombre.HeaderText = "Nombre"
        Me.clmNombre.Name = "clmNombre"
        Me.clmNombre.ReadOnly = True
        Me.clmNombre.Width = 200
        '
        'clmUnidadM
        '
        Me.clmUnidadM.HeaderText = "Unidad de Medida"
        Me.clmUnidadM.Name = "clmUnidadM"
        Me.clmUnidadM.ReadOnly = True
        '
        'clmMaximo
        '
        Me.clmMaximo.HeaderText = "Máximo"
        Me.clmMaximo.Name = "clmMaximo"
        Me.clmMaximo.ReadOnly = True
        '
        'clmMinimo
        '
        Me.clmMinimo.HeaderText = "Mínimo"
        Me.clmMinimo.Name = "clmMinimo"
        Me.clmMinimo.ReadOnly = True
        '
        'clmExistencias
        '
        Me.clmExistencias.HeaderText = "Existencias"
        Me.clmExistencias.Name = "clmExistencias"
        Me.clmExistencias.ReadOnly = True
        '
        'clmCosto
        '
        Me.clmCosto.HeaderText = "Costo"
        Me.clmCosto.Name = "clmCosto"
        Me.clmCosto.ReadOnly = True
        '
        'clmFecha
        '
        Me.clmFecha.HeaderText = "Fecha"
        Me.clmFecha.Name = "clmFecha"
        Me.clmFecha.ReadOnly = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(206, 380)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(569, 36)
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmConsultaInsumo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 423)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.dgvConsultaInsumo)
        Me.Controls.Add(Me.gbConsultaInsumos)
        Me.Name = "frmConsultaInsumo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmConsultaInsumo"
        Me.gbConsultaInsumos.ResumeLayout(False)
        Me.gbConsultaInsumos.PerformLayout()
        CType(Me.dgvConsultaInsumo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbConsultaInsumos As GroupBox
    Friend WithEvents rbtTodo As RadioButton
    Friend WithEvents rbtUnidadDeMedida As RadioButton
    Friend WithEvents rbtNombre As RadioButton
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents btnBuscarNom As Button
    Friend WithEvents cboInsumo As ComboBox
    Friend WithEvents dgvConsultaInsumo As DataGridView
    Friend WithEvents btnAceptar As Button
    Friend WithEvents clmIdInsumo As DataGridViewTextBoxColumn
    Friend WithEvents clmNombre As DataGridViewTextBoxColumn
    Friend WithEvents clmUnidadM As DataGridViewTextBoxColumn
    Friend WithEvents clmMaximo As DataGridViewTextBoxColumn
    Friend WithEvents clmMinimo As DataGridViewTextBoxColumn
    Friend WithEvents clmExistencias As DataGridViewTextBoxColumn
    Friend WithEvents clmCosto As DataGridViewTextBoxColumn
    Friend WithEvents clmFecha As DataGridViewTextBoxColumn
    Friend WithEvents btnSalir As Button
End Class
