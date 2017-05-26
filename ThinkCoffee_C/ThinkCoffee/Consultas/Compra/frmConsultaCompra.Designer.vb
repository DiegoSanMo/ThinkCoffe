<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaCompra
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
        Me.rbProveedor = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.lblDesde = New System.Windows.Forms.Label()
        Me.btnBuscarP = New System.Windows.Forms.Button()
        Me.txtProveedor = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.rbFecha = New System.Windows.Forms.RadioButton()
        Me.dgCompra = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDetalles = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ptbBarra = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbBarra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rbProveedor
        '
        Me.rbProveedor.AutoSize = True
        Me.rbProveedor.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Bold)
        Me.rbProveedor.Location = New System.Drawing.Point(21, 30)
        Me.rbProveedor.Name = "rbProveedor"
        Me.rbProveedor.Size = New System.Drawing.Size(104, 24)
        Me.rbProveedor.TabIndex = 0
        Me.rbProveedor.TabStop = True
        Me.rbProveedor.Text = "Proveedor"
        Me.rbProveedor.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblHasta)
        Me.GroupBox1.Controls.Add(Me.lblDesde)
        Me.GroupBox1.Controls.Add(Me.btnBuscarP)
        Me.GroupBox1.Controls.Add(Me.txtProveedor)
        Me.GroupBox1.Controls.Add(Me.btnAceptar)
        Me.GroupBox1.Controls.Add(Me.dtpFechaFinal)
        Me.GroupBox1.Controls.Add(Me.dtpFechaInicial)
        Me.GroupBox1.Controls.Add(Me.rbFecha)
        Me.GroupBox1.Controls.Add(Me.rbProveedor)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(569, 151)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consultas por:"
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Enabled = False
        Me.lblHasta.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHasta.Location = New System.Drawing.Point(279, 83)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(47, 20)
        Me.lblHasta.TabIndex = 10
        Me.lblHasta.Text = "Hasta"
        Me.lblHasta.Visible = False
        '
        'lblDesde
        '
        Me.lblDesde.AutoSize = True
        Me.lblDesde.Enabled = False
        Me.lblDesde.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesde.Location = New System.Drawing.Point(105, 83)
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Size = New System.Drawing.Size(51, 20)
        Me.lblDesde.TabIndex = 9
        Me.lblDesde.Text = "Desde"
        Me.lblDesde.Visible = False
        '
        'btnBuscarP
        '
        Me.btnBuscarP.Image = Global.ThinkCoffee.My.Resources.Resources.Search_20
        Me.btnBuscarP.Location = New System.Drawing.Point(465, 30)
        Me.btnBuscarP.Name = "btnBuscarP"
        Me.btnBuscarP.Size = New System.Drawing.Size(49, 29)
        Me.btnBuscarP.TabIndex = 6
        Me.btnBuscarP.UseVisualStyleBackColor = True
        Me.btnBuscarP.Visible = False
        '
        'txtProveedor
        '
        Me.txtProveedor.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!)
        Me.txtProveedor.Location = New System.Drawing.Point(127, 30)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.ReadOnly = True
        Me.txtProveedor.Size = New System.Drawing.Size(328, 27)
        Me.txtProveedor.TabIndex = 5
        Me.txtProveedor.Visible = False
        '
        'btnAceptar
        '
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnAceptar.Location = New System.Drawing.Point(460, 109)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(87, 33)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!)
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.Location = New System.Drawing.Point(330, 81)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(98, 27)
        Me.dtpFechaFinal.TabIndex = 3
        Me.dtpFechaFinal.Value = New Date(2017, 5, 18, 0, 0, 0, 0)
        Me.dtpFechaFinal.Visible = False
        '
        'dtpFechaInicial
        '
        Me.dtpFechaInicial.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!)
        Me.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicial.Location = New System.Drawing.Point(162, 81)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.Size = New System.Drawing.Size(98, 27)
        Me.dtpFechaInicial.TabIndex = 2
        Me.dtpFechaInicial.Value = New Date(2017, 5, 18, 0, 0, 0, 0)
        Me.dtpFechaInicial.Visible = False
        '
        'rbFecha
        '
        Me.rbFecha.AutoSize = True
        Me.rbFecha.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Bold)
        Me.rbFecha.Location = New System.Drawing.Point(21, 81)
        Me.rbFecha.Name = "rbFecha"
        Me.rbFecha.Size = New System.Drawing.Size(70, 24)
        Me.rbFecha.TabIndex = 1
        Me.rbFecha.TabStop = True
        Me.rbFecha.Text = "Fecha"
        Me.rbFecha.UseVisualStyleBackColor = True
        '
        'dgCompra
        '
        Me.dgCompra.AllowUserToAddRows = False
        Me.dgCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCompra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgCompra.Location = New System.Drawing.Point(12, 276)
        Me.dgCompra.Name = "dgCompra"
        Me.dgCompra.ReadOnly = True
        Me.dgCompra.Size = New System.Drawing.Size(569, 209)
        Me.dgCompra.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "No.Compra"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Proveedor"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 200
        '
        'Column3
        '
        Me.Column3.HeaderText = "Fecha"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 115
        '
        'Column4
        '
        Me.Column4.HeaderText = "Total"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'btnDetalles
        '
        Me.btnDetalles.Location = New System.Drawing.Point(472, 249)
        Me.btnDetalles.Name = "btnDetalles"
        Me.btnDetalles.Size = New System.Drawing.Size(104, 21)
        Me.btnDetalles.TabIndex = 9
        Me.btnDetalles.Text = "Ver detalles"
        Me.btnDetalles.UseVisualStyleBackColor = True
        Me.btnDetalles.Visible = False
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnSalir.Location = New System.Drawing.Point(259, 493)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(79, 30)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(104, 47)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(434, 37)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "CONSULTA DE COMPRAS"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ptbBarra
        '
        Me.ptbBarra.Dock = System.Windows.Forms.DockStyle.Top
        Me.ptbBarra.Image = Global.ThinkCoffee.My.Resources.Resources.BarraSuperior
        Me.ptbBarra.Location = New System.Drawing.Point(0, 0)
        Me.ptbBarra.Name = "ptbBarra"
        Me.ptbBarra.Size = New System.Drawing.Size(593, 33)
        Me.ptbBarra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbBarra.TabIndex = 60
        Me.ptbBarra.TabStop = False
        '
        'frmConsultaCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 530)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ptbBarra)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnDetalles)
        Me.Controls.Add(Me.dgCompra)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmConsultaCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Compra de Insumos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbBarra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rbProveedor As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBuscarP As Button
    Friend WithEvents txtProveedor As TextBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents dtpFechaFinal As DateTimePicker
    Friend WithEvents dtpFechaInicial As DateTimePicker
    Friend WithEvents rbFecha As RadioButton
    Friend WithEvents dgCompra As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents btnDetalles As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents lblDesde As Label
    Friend WithEvents lblHasta As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ptbBarra As PictureBox
End Class
