<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaProducto
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
        Me.rbtConsultaCategoria = New System.Windows.Forms.RadioButton()
        Me.rbtConsultaTodo = New System.Windows.Forms.RadioButton()
        Me.cboCategoriaConsulta = New System.Windows.Forms.ComboBox()
        Me.dgvConsultaProductos = New System.Windows.Forms.DataGridView()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.clmIdProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvConsultaProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.cboCategoriaConsulta)
        Me.GroupBox1.Controls.Add(Me.rbtConsultaTodo)
        Me.GroupBox1.Controls.Add(Me.rbtConsultaCategoria)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(447, 117)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipos de consulta:"
        '
        'rbtConsultaCategoria
        '
        Me.rbtConsultaCategoria.AutoSize = True
        Me.rbtConsultaCategoria.Location = New System.Drawing.Point(4, 23)
        Me.rbtConsultaCategoria.Name = "rbtConsultaCategoria"
        Me.rbtConsultaCategoria.Size = New System.Drawing.Size(72, 17)
        Me.rbtConsultaCategoria.TabIndex = 1
        Me.rbtConsultaCategoria.TabStop = True
        Me.rbtConsultaCategoria.Text = "Categoría"
        Me.rbtConsultaCategoria.UseVisualStyleBackColor = True
        '
        'rbtConsultaTodo
        '
        Me.rbtConsultaTodo.AutoSize = True
        Me.rbtConsultaTodo.Location = New System.Drawing.Point(6, 60)
        Me.rbtConsultaTodo.Name = "rbtConsultaTodo"
        Me.rbtConsultaTodo.Size = New System.Drawing.Size(50, 17)
        Me.rbtConsultaTodo.TabIndex = 2
        Me.rbtConsultaTodo.TabStop = True
        Me.rbtConsultaTodo.Text = "Todo"
        Me.rbtConsultaTodo.UseVisualStyleBackColor = True
        '
        'cboCategoriaConsulta
        '
        Me.cboCategoriaConsulta.FormattingEnabled = True
        Me.cboCategoriaConsulta.Location = New System.Drawing.Point(82, 19)
        Me.cboCategoriaConsulta.Name = "cboCategoriaConsulta"
        Me.cboCategoriaConsulta.Size = New System.Drawing.Size(121, 21)
        Me.cboCategoriaConsulta.TabIndex = 4
        Me.cboCategoriaConsulta.Visible = False
        '
        'dgvConsultaProductos
        '
        Me.dgvConsultaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsultaProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmIdProducto, Me.clmNombre, Me.clmCategoria, Me.clmPrecio})
        Me.dgvConsultaProductos.Location = New System.Drawing.Point(13, 144)
        Me.dgvConsultaProductos.Name = "dgvConsultaProductos"
        Me.dgvConsultaProductos.Size = New System.Drawing.Size(745, 162)
        Me.dgvConsultaProductos.TabIndex = 1
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(6, 83)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(435, 23)
        Me.btnBuscar.TabIndex = 5
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(177, 312)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(448, 23)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'clmIdProducto
        '
        Me.clmIdProducto.HeaderText = "IdProducto"
        Me.clmIdProducto.Name = "clmIdProducto"
        Me.clmIdProducto.ReadOnly = True
        '
        'clmNombre
        '
        Me.clmNombre.HeaderText = "Nombre"
        Me.clmNombre.Name = "clmNombre"
        Me.clmNombre.ReadOnly = True
        Me.clmNombre.Width = 250
        '
        'clmCategoria
        '
        Me.clmCategoria.HeaderText = "Categoría"
        Me.clmCategoria.Name = "clmCategoria"
        Me.clmCategoria.ReadOnly = True
        Me.clmCategoria.Width = 250
        '
        'clmPrecio
        '
        Me.clmPrecio.HeaderText = "Precio"
        Me.clmPrecio.Name = "clmPrecio"
        Me.clmPrecio.ReadOnly = True
        '
        'frmConsultaProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 362)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.dgvConsultaProductos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmConsultaProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de producto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvConsultaProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboCategoriaConsulta As ComboBox
    Friend WithEvents rbtConsultaTodo As RadioButton
    Friend WithEvents rbtConsultaCategoria As RadioButton
    Friend WithEvents dgvConsultaProductos As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents clmIdProducto As DataGridViewTextBoxColumn
    Friend WithEvents clmNombre As DataGridViewTextBoxColumn
    Friend WithEvents clmCategoria As DataGridViewTextBoxColumn
    Friend WithEvents clmPrecio As DataGridViewTextBoxColumn
End Class
