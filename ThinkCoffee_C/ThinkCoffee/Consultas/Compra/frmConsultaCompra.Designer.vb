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
        Me.lblFinal = New System.Windows.Forms.Label()
        Me.lblInicial = New System.Windows.Forms.Label()
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
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rbProveedor
        '
        Me.rbProveedor.AutoSize = True
        Me.rbProveedor.Location = New System.Drawing.Point(21, 30)
        Me.rbProveedor.Name = "rbProveedor"
        Me.rbProveedor.Size = New System.Drawing.Size(74, 17)
        Me.rbProveedor.TabIndex = 0
        Me.rbProveedor.TabStop = True
        Me.rbProveedor.Text = "Proveedor"
        Me.rbProveedor.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblFinal)
        Me.GroupBox1.Controls.Add(Me.lblInicial)
        Me.GroupBox1.Controls.Add(Me.btnBuscarP)
        Me.GroupBox1.Controls.Add(Me.txtProveedor)
        Me.GroupBox1.Controls.Add(Me.btnAceptar)
        Me.GroupBox1.Controls.Add(Me.dtpFechaFinal)
        Me.GroupBox1.Controls.Add(Me.dtpFechaInicial)
        Me.GroupBox1.Controls.Add(Me.rbFecha)
        Me.GroupBox1.Controls.Add(Me.rbProveedor)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(569, 167)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consultas por:"
        '
        'lblFinal
        '
        Me.lblFinal.AutoSize = True
        Me.lblFinal.Location = New System.Drawing.Point(274, 69)
        Me.lblFinal.Name = "lblFinal"
        Me.lblFinal.Size = New System.Drawing.Size(59, 13)
        Me.lblFinal.TabIndex = 8
        Me.lblFinal.Text = "Fecha final"
        Me.lblFinal.Visible = False
        '
        'lblInicial
        '
        Me.lblInicial.AutoSize = True
        Me.lblInicial.Location = New System.Drawing.Point(127, 69)
        Me.lblInicial.Name = "lblInicial"
        Me.lblInicial.Size = New System.Drawing.Size(66, 13)
        Me.lblInicial.TabIndex = 7
        Me.lblInicial.Text = "Fecha inicial"
        Me.lblInicial.Visible = False
        '
        'btnBuscarP
        '
        Me.btnBuscarP.Image = Global.ThinkCoffee.My.Resources.Resources.Search_20
        Me.btnBuscarP.Location = New System.Drawing.Point(495, 24)
        Me.btnBuscarP.Name = "btnBuscarP"
        Me.btnBuscarP.Size = New System.Drawing.Size(49, 29)
        Me.btnBuscarP.TabIndex = 6
        Me.btnBuscarP.UseVisualStyleBackColor = True
        Me.btnBuscarP.Visible = False
        '
        'txtProveedor
        '
        Me.txtProveedor.Location = New System.Drawing.Point(101, 28)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.ReadOnly = True
        Me.txtProveedor.Size = New System.Drawing.Size(371, 20)
        Me.txtProveedor.TabIndex = 5
        Me.txtProveedor.Visible = False
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(21, 125)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(523, 36)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.Location = New System.Drawing.Point(277, 85)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(98, 20)
        Me.dtpFechaFinal.TabIndex = 3
        Me.dtpFechaFinal.Value = New Date(2017, 5, 18, 0, 0, 0, 0)
        Me.dtpFechaFinal.Visible = False
        '
        'dtpFechaInicial
        '
        Me.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicial.Location = New System.Drawing.Point(130, 85)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.Size = New System.Drawing.Size(98, 20)
        Me.dtpFechaInicial.TabIndex = 2
        Me.dtpFechaInicial.Value = New Date(2017, 5, 18, 0, 0, 0, 0)
        Me.dtpFechaInicial.Visible = False
        '
        'rbFecha
        '
        Me.rbFecha.AutoSize = True
        Me.rbFecha.Location = New System.Drawing.Point(21, 85)
        Me.rbFecha.Name = "rbFecha"
        Me.rbFecha.Size = New System.Drawing.Size(55, 17)
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
        Me.dgCompra.Location = New System.Drawing.Point(12, 209)
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
        Me.btnDetalles.Location = New System.Drawing.Point(477, 185)
        Me.btnDetalles.Name = "btnDetalles"
        Me.btnDetalles.Size = New System.Drawing.Size(104, 21)
        Me.btnDetalles.TabIndex = 9
        Me.btnDetalles.Text = "Ver detalles"
        Me.btnDetalles.UseVisualStyleBackColor = True
        Me.btnDetalles.Visible = False
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(12, 424)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(569, 36)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmConsultaCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 464)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnDetalles)
        Me.Controls.Add(Me.dgCompra)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmConsultaCompra"
        Me.Text = "frmConsultaCompra"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rbProveedor As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblFinal As Label
    Friend WithEvents lblInicial As Label
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
End Class
