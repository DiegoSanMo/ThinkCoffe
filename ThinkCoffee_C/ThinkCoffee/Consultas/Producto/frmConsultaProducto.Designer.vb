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
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.cboCategoriaConsulta = New System.Windows.Forms.ComboBox()
        Me.rbtConsultaTodo = New System.Windows.Forms.RadioButton()
        Me.rbtConsultaCategoria = New System.Windows.Forms.RadioButton()
        Me.dgvConsultaProductos = New System.Windows.Forms.DataGridView()
        Me.clmIdProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ptbBarra = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvConsultaProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbBarra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.cboCategoriaConsulta)
        Me.GroupBox1.Controls.Add(Me.rbtConsultaTodo)
        Me.GroupBox1.Controls.Add(Me.rbtConsultaCategoria)
        Me.GroupBox1.Location = New System.Drawing.Point(198, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(437, 117)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipos de consulta:"
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnBuscar.Location = New System.Drawing.Point(323, 74)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(87, 28)
        Me.btnBuscar.TabIndex = 5
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'cboCategoriaConsulta
        '
        Me.cboCategoriaConsulta.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!)
        Me.cboCategoriaConsulta.FormattingEnabled = True
        Me.cboCategoriaConsulta.Location = New System.Drawing.Point(119, 22)
        Me.cboCategoriaConsulta.Name = "cboCategoriaConsulta"
        Me.cboCategoriaConsulta.Size = New System.Drawing.Size(121, 28)
        Me.cboCategoriaConsulta.TabIndex = 4
        Me.cboCategoriaConsulta.Visible = False
        '
        'rbtConsultaTodo
        '
        Me.rbtConsultaTodo.AutoSize = True
        Me.rbtConsultaTodo.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Bold)
        Me.rbtConsultaTodo.Location = New System.Drawing.Point(14, 60)
        Me.rbtConsultaTodo.Name = "rbtConsultaTodo"
        Me.rbtConsultaTodo.Size = New System.Drawing.Size(66, 24)
        Me.rbtConsultaTodo.TabIndex = 2
        Me.rbtConsultaTodo.TabStop = True
        Me.rbtConsultaTodo.Text = "Todo"
        Me.rbtConsultaTodo.UseVisualStyleBackColor = True
        '
        'rbtConsultaCategoria
        '
        Me.rbtConsultaCategoria.AutoSize = True
        Me.rbtConsultaCategoria.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Bold)
        Me.rbtConsultaCategoria.Location = New System.Drawing.Point(12, 23)
        Me.rbtConsultaCategoria.Name = "rbtConsultaCategoria"
        Me.rbtConsultaCategoria.Size = New System.Drawing.Size(101, 24)
        Me.rbtConsultaCategoria.TabIndex = 1
        Me.rbtConsultaCategoria.TabStop = True
        Me.rbtConsultaCategoria.Text = "Categoría"
        Me.rbtConsultaCategoria.UseVisualStyleBackColor = True
        '
        'dgvConsultaProductos
        '
        Me.dgvConsultaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsultaProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmIdProducto, Me.clmNombre, Me.clmCategoria, Me.clmPrecio})
        Me.dgvConsultaProductos.Location = New System.Drawing.Point(16, 209)
        Me.dgvConsultaProductos.Name = "dgvConsultaProductos"
        Me.dgvConsultaProductos.Size = New System.Drawing.Size(745, 162)
        Me.dgvConsultaProductos.TabIndex = 1
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
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSalir.Image = Global.ThinkCoffee.My.Resources.Resources.Exit_Sign_Filled_30
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(658, 377)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(103, 39)
        Me.btnSalir.TabIndex = 40
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(156, 36)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(479, 37)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "CONSULTA DE PRODUCTOS"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ptbBarra
        '
        Me.ptbBarra.Dock = System.Windows.Forms.DockStyle.Top
        Me.ptbBarra.Image = Global.ThinkCoffee.My.Resources.Resources.BarraSuperior
        Me.ptbBarra.Location = New System.Drawing.Point(0, 0)
        Me.ptbBarra.Name = "ptbBarra"
        Me.ptbBarra.Size = New System.Drawing.Size(773, 33)
        Me.ptbBarra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbBarra.TabIndex = 60
        Me.ptbBarra.TabStop = False
        '
        'frmConsultaProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 424)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ptbBarra)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.dgvConsultaProductos)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmConsultaProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de producto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvConsultaProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbBarra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboCategoriaConsulta As ComboBox
    Friend WithEvents rbtConsultaTodo As RadioButton
    Friend WithEvents rbtConsultaCategoria As RadioButton
    Friend WithEvents dgvConsultaProductos As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents clmIdProducto As DataGridViewTextBoxColumn
    Friend WithEvents clmNombre As DataGridViewTextBoxColumn
    Friend WithEvents clmCategoria As DataGridViewTextBoxColumn
    Friend WithEvents clmPrecio As DataGridViewTextBoxColumn
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents ptbBarra As PictureBox
End Class
