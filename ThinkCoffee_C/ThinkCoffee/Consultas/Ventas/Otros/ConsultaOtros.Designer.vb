<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaOtros
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
        Me.cboCategoria = New System.Windows.Forms.ComboBox()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.lblDesde = New System.Windows.Forms.Label()
        Me.rbCategoria = New System.Windows.Forms.RadioButton()
        Me.btnBuscarP = New System.Windows.Forms.Button()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.rbFecha = New System.Windows.Forms.RadioButton()
        Me.rbProducto = New System.Windows.Forms.RadioButton()
        Me.dgVentaOtro = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnDetallesP = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ptbBarra = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgVentaOtro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbBarra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboCategoria)
        Me.GroupBox1.Controls.Add(Me.lblHasta)
        Me.GroupBox1.Controls.Add(Me.lblDesde)
        Me.GroupBox1.Controls.Add(Me.rbCategoria)
        Me.GroupBox1.Controls.Add(Me.btnBuscarP)
        Me.GroupBox1.Controls.Add(Me.txtProducto)
        Me.GroupBox1.Controls.Add(Me.btnAceptar)
        Me.GroupBox1.Controls.Add(Me.dtpFechaFinal)
        Me.GroupBox1.Controls.Add(Me.dtpFechaInicial)
        Me.GroupBox1.Controls.Add(Me.rbFecha)
        Me.GroupBox1.Controls.Add(Me.rbProducto)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!)
        Me.GroupBox1.Location = New System.Drawing.Point(81, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(569, 148)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consultas por:"
        '
        'cboCategoria
        '
        Me.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategoria.FormattingEnabled = True
        Me.cboCategoria.Location = New System.Drawing.Point(128, 68)
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.Size = New System.Drawing.Size(371, 28)
        Me.cboCategoria.TabIndex = 13
        Me.cboCategoria.Visible = False
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Enabled = False
        Me.lblHasta.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHasta.Location = New System.Drawing.Point(298, 110)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(47, 20)
        Me.lblHasta.TabIndex = 12
        Me.lblHasta.Text = "Hasta"
        Me.lblHasta.Visible = False
        '
        'lblDesde
        '
        Me.lblDesde.AutoSize = True
        Me.lblDesde.Enabled = False
        Me.lblDesde.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesde.Location = New System.Drawing.Point(124, 110)
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Size = New System.Drawing.Size(51, 20)
        Me.lblDesde.TabIndex = 11
        Me.lblDesde.Text = "Desde"
        Me.lblDesde.Visible = False
        '
        'rbCategoria
        '
        Me.rbCategoria.AutoSize = True
        Me.rbCategoria.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Bold)
        Me.rbCategoria.Location = New System.Drawing.Point(21, 70)
        Me.rbCategoria.Name = "rbCategoria"
        Me.rbCategoria.Size = New System.Drawing.Size(101, 24)
        Me.rbCategoria.TabIndex = 9
        Me.rbCategoria.TabStop = True
        Me.rbCategoria.Text = "Categoría"
        Me.rbCategoria.UseVisualStyleBackColor = True
        '
        'btnBuscarP
        '
        Me.btnBuscarP.Image = Global.ThinkCoffee.My.Resources.Resources.Search_20
        Me.btnBuscarP.Location = New System.Drawing.Point(505, 25)
        Me.btnBuscarP.Name = "btnBuscarP"
        Me.btnBuscarP.Size = New System.Drawing.Size(49, 29)
        Me.btnBuscarP.TabIndex = 6
        Me.btnBuscarP.UseVisualStyleBackColor = True
        Me.btnBuscarP.Visible = False
        '
        'txtProducto
        '
        Me.txtProducto.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!)
        Me.txtProducto.Location = New System.Drawing.Point(128, 27)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.ReadOnly = True
        Me.txtProducto.Size = New System.Drawing.Size(371, 27)
        Me.txtProducto.TabIndex = 5
        Me.txtProducto.Visible = False
        '
        'btnAceptar
        '
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnAceptar.Location = New System.Drawing.Point(468, 104)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(95, 32)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!)
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.Location = New System.Drawing.Point(351, 107)
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
        Me.dtpFechaInicial.Location = New System.Drawing.Point(181, 107)
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
        Me.rbFecha.Location = New System.Drawing.Point(21, 108)
        Me.rbFecha.Name = "rbFecha"
        Me.rbFecha.Size = New System.Drawing.Size(70, 24)
        Me.rbFecha.TabIndex = 1
        Me.rbFecha.TabStop = True
        Me.rbFecha.Text = "Fecha"
        Me.rbFecha.UseVisualStyleBackColor = True
        '
        'rbProducto
        '
        Me.rbProducto.AutoSize = True
        Me.rbProducto.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Bold)
        Me.rbProducto.Location = New System.Drawing.Point(21, 30)
        Me.rbProducto.Name = "rbProducto"
        Me.rbProducto.Size = New System.Drawing.Size(95, 24)
        Me.rbProducto.TabIndex = 0
        Me.rbProducto.TabStop = True
        Me.rbProducto.Text = "Producto"
        Me.rbProducto.UseVisualStyleBackColor = True
        '
        'dgVentaOtro
        '
        Me.dgVentaOtro.AllowUserToAddRows = False
        Me.dgVentaOtro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVentaOtro.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column5, Me.Column3, Me.Column4})
        Me.dgVentaOtro.Location = New System.Drawing.Point(12, 266)
        Me.dgVentaOtro.Name = "dgVentaOtro"
        Me.dgVentaOtro.Size = New System.Drawing.Size(720, 230)
        Me.dgVentaOtro.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.HeaderText = "No.Venta"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Producto"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 170
        '
        'Column5
        '
        Me.Column5.HeaderText = "Categoría"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "Fecha de venta"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "Total"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(12, 502)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(720, 23)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnDetallesP
        '
        Me.btnDetallesP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetallesP.ForeColor = System.Drawing.Color.Black
        Me.btnDetallesP.Location = New System.Drawing.Point(517, 233)
        Me.btnDetallesP.Name = "btnDetallesP"
        Me.btnDetallesP.Size = New System.Drawing.Size(209, 27)
        Me.btnDetallesP.TabIndex = 45
        Me.btnDetallesP.Text = "Información extra de venta"
        Me.btnDetallesP.UseVisualStyleBackColor = True
        Me.btnDetallesP.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(74, 39)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(601, 37)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "CONSULTA DE VENTAS CAFETERÍA"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ptbBarra
        '
        Me.ptbBarra.Dock = System.Windows.Forms.DockStyle.Top
        Me.ptbBarra.Image = Global.ThinkCoffee.My.Resources.Resources.BarraSuperior
        Me.ptbBarra.Location = New System.Drawing.Point(0, 0)
        Me.ptbBarra.Name = "ptbBarra"
        Me.ptbBarra.Size = New System.Drawing.Size(744, 33)
        Me.ptbBarra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbBarra.TabIndex = 60
        Me.ptbBarra.TabStop = False
        '
        'ConsultaOtros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 530)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ptbBarra)
        Me.Controls.Add(Me.btnDetallesP)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.dgVentaOtro)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ConsultaOtros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ConsultaOtros"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgVentaOtro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbBarra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBuscarP As Button
    Friend WithEvents txtProducto As TextBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents dtpFechaFinal As DateTimePicker
    Friend WithEvents dtpFechaInicial As DateTimePicker
    Friend WithEvents rbFecha As RadioButton
    Friend WithEvents rbProducto As RadioButton
    Friend WithEvents rbCategoria As RadioButton
    Friend WithEvents lblHasta As Label
    Friend WithEvents lblDesde As Label
    Friend WithEvents dgVentaOtro As DataGridView
    Friend WithEvents btnSalir As Button
    Friend WithEvents cboCategoria As ComboBox
    Friend WithEvents btnDetallesP As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Label10 As Label
    Friend WithEvents ptbBarra As PictureBox
End Class
