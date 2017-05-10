<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompraDeInsumos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdCompra = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbProveedores = New System.Windows.Forms.GroupBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtIdProveedor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboProveedor = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbInsumos = New System.Windows.Forms.GroupBox()
        Me.txtFechaInsumo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtExistencias = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtMinimo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtMaximo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtUnidadM = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtIdInsumo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtIVA = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtNombreInsumo = New System.Windows.Forms.TextBox()
        Me.btnBuscarIn = New System.Windows.Forms.Button()
        Me.gbProveedores.SuspendLayout()
        Me.gbInsumos.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(536, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IdCompra:"
        '
        'txtIdCompra
        '
        Me.txtIdCompra.Enabled = False
        Me.txtIdCompra.Location = New System.Drawing.Point(640, 12)
        Me.txtIdCompra.Name = "txtIdCompra"
        Me.txtIdCompra.Size = New System.Drawing.Size(100, 20)
        Me.txtIdCompra.TabIndex = 1
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(640, 54)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(98, 20)
        Me.dtpFecha.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(536, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha:"
        '
        'gbProveedores
        '
        Me.gbProveedores.Controls.Add(Me.txtTelefono)
        Me.gbProveedores.Controls.Add(Me.Label6)
        Me.gbProveedores.Controls.Add(Me.txtDireccion)
        Me.gbProveedores.Controls.Add(Me.Label5)
        Me.gbProveedores.Controls.Add(Me.txtIdProveedor)
        Me.gbProveedores.Controls.Add(Me.Label4)
        Me.gbProveedores.Controls.Add(Me.cboProveedor)
        Me.gbProveedores.Controls.Add(Me.Label3)
        Me.gbProveedores.Location = New System.Drawing.Point(12, 80)
        Me.gbProveedores.Name = "gbProveedores"
        Me.gbProveedores.Size = New System.Drawing.Size(726, 109)
        Me.gbProveedores.TabIndex = 4
        Me.gbProveedores.TabStop = False
        Me.gbProveedores.Text = "Proveedores:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Enabled = False
        Me.txtTelefono.Location = New System.Drawing.Point(582, 58)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefono.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(486, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 24)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Teléfono:"
        '
        'txtDireccion
        '
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.Location = New System.Drawing.Point(107, 58)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(310, 20)
        Me.txtDireccion.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 24)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Dirección:"
        '
        'txtIdProveedor
        '
        Me.txtIdProveedor.Enabled = False
        Me.txtIdProveedor.Location = New System.Drawing.Point(582, 21)
        Me.txtIdProveedor.Name = "txtIdProveedor"
        Me.txtIdProveedor.Size = New System.Drawing.Size(100, 20)
        Me.txtIdProveedor.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(458, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "IdProveedor:"
        '
        'cboProveedor
        '
        Me.cboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProveedor.Enabled = False
        Me.cboProveedor.FormattingEnabled = True
        Me.cboProveedor.Location = New System.Drawing.Point(116, 20)
        Me.cboProveedor.Name = "cboProveedor"
        Me.cboProveedor.Size = New System.Drawing.Size(301, 21)
        Me.cboProveedor.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 24)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Proveedor:"
        '
        'gbInsumos
        '
        Me.gbInsumos.Controls.Add(Me.btnBuscarIn)
        Me.gbInsumos.Controls.Add(Me.txtNombreInsumo)
        Me.gbInsumos.Controls.Add(Me.txtFechaInsumo)
        Me.gbInsumos.Controls.Add(Me.Label14)
        Me.gbInsumos.Controls.Add(Me.txtCosto)
        Me.gbInsumos.Controls.Add(Me.Label13)
        Me.gbInsumos.Controls.Add(Me.txtExistencias)
        Me.gbInsumos.Controls.Add(Me.Label12)
        Me.gbInsumos.Controls.Add(Me.txtMinimo)
        Me.gbInsumos.Controls.Add(Me.Label11)
        Me.gbInsumos.Controls.Add(Me.txtMaximo)
        Me.gbInsumos.Controls.Add(Me.Label10)
        Me.gbInsumos.Controls.Add(Me.txtUnidadM)
        Me.gbInsumos.Controls.Add(Me.Label9)
        Me.gbInsumos.Controls.Add(Me.txtIdInsumo)
        Me.gbInsumos.Controls.Add(Me.Label8)
        Me.gbInsumos.Controls.Add(Me.Label7)
        Me.gbInsumos.Location = New System.Drawing.Point(13, 195)
        Me.gbInsumos.Name = "gbInsumos"
        Me.gbInsumos.Size = New System.Drawing.Size(726, 135)
        Me.gbInsumos.TabIndex = 5
        Me.gbInsumos.TabStop = False
        Me.gbInsumos.Text = "Insumos:"
        '
        'txtFechaInsumo
        '
        Me.txtFechaInsumo.Enabled = False
        Me.txtFechaInsumo.Location = New System.Drawing.Point(609, 91)
        Me.txtFechaInsumo.Name = "txtFechaInsumo"
        Me.txtFechaInsumo.Size = New System.Drawing.Size(100, 20)
        Me.txtFechaInsumo.TabIndex = 18
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(479, 85)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(130, 24)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Última compra"
        '
        'txtCosto
        '
        Me.txtCosto.Location = New System.Drawing.Point(161, 91)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(100, 20)
        Me.txtCosto.TabIndex = 16
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(24, 86)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(131, 24)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Costo anterior:"
        '
        'txtExistencias
        '
        Me.txtExistencias.Enabled = False
        Me.txtExistencias.Location = New System.Drawing.Point(615, 17)
        Me.txtExistencias.Name = "txtExistencias"
        Me.txtExistencias.Size = New System.Drawing.Size(100, 20)
        Me.txtExistencias.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(499, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 24)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Existencias:"
        '
        'txtMinimo
        '
        Me.txtMinimo.Enabled = False
        Me.txtMinimo.Location = New System.Drawing.Point(328, 53)
        Me.txtMinimo.Name = "txtMinimo"
        Me.txtMinimo.Size = New System.Drawing.Size(100, 20)
        Me.txtMinimo.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(245, 49)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 24)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Mínimo:"
        '
        'txtMaximo
        '
        Me.txtMaximo.Enabled = False
        Me.txtMaximo.Location = New System.Drawing.Point(93, 53)
        Me.txtMaximo.Name = "txtMaximo"
        Me.txtMaximo.Size = New System.Drawing.Size(100, 20)
        Me.txtMaximo.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(5, 49)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 24)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Máximo:"
        '
        'txtUnidadM
        '
        Me.txtUnidadM.Enabled = False
        Me.txtUnidadM.Location = New System.Drawing.Point(615, 55)
        Me.txtUnidadM.Name = "txtUnidadM"
        Me.txtUnidadM.Size = New System.Drawing.Size(100, 20)
        Me.txtUnidadM.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(439, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(170, 24)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Unidad de medida:"
        '
        'txtIdInsumo
        '
        Me.txtIdInsumo.Enabled = False
        Me.txtIdInsumo.Location = New System.Drawing.Point(375, 18)
        Me.txtIdInsumo.Name = "txtIdInsumo"
        Me.txtIdInsumo.Size = New System.Drawing.Size(100, 20)
        Me.txtIdInsumo.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(277, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 24)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "IdInsumo:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 24)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Insumo:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(14, 346)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(725, 150)
        Me.DataGridView1.TabIndex = 6
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Enabled = False
        Me.txtSubtotal.Location = New System.Drawing.Point(639, 510)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(100, 20)
        Me.txtSubtotal.TabIndex = 8
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(540, 506)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(82, 24)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Subtotal:"
        '
        'txtIVA
        '
        Me.txtIVA.Enabled = False
        Me.txtIVA.Location = New System.Drawing.Point(639, 541)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.Size = New System.Drawing.Size(100, 20)
        Me.txtIVA.TabIndex = 10
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(543, 536)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 24)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "IVA:"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(639, 574)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 12
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(540, 570)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 24)
        Me.Label17.TabIndex = 11
        Me.Label17.Text = "Total:"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(33, 533)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 53)
        Me.btnNuevo.TabIndex = 13
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Location = New System.Drawing.Point(148, 533)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 53)
        Me.btnGuardar.TabIndex = 14
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(267, 534)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 53)
        Me.btnCancelar.TabIndex = 15
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(396, 536)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 53)
        Me.btnSalir.TabIndex = 16
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtNombreInsumo
        '
        Me.txtNombreInsumo.Enabled = False
        Me.txtNombreInsumo.Location = New System.Drawing.Point(93, 16)
        Me.txtNombreInsumo.Name = "txtNombreInsumo"
        Me.txtNombreInsumo.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreInsumo.TabIndex = 19
        '
        'btnBuscarIn
        '
        Me.btnBuscarIn.Image = Global.ThinkCoffee.My.Resources.Resources.Search_20
        Me.btnBuscarIn.Location = New System.Drawing.Point(199, 12)
        Me.btnBuscarIn.Name = "btnBuscarIn"
        Me.btnBuscarIn.Size = New System.Drawing.Size(42, 30)
        Me.btnBuscarIn.TabIndex = 9
        Me.btnBuscarIn.UseVisualStyleBackColor = True
        '
        'frmCompraDeInsumos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 606)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtIVA)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.gbInsumos)
        Me.Controls.Add(Me.gbProveedores)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.txtIdCompra)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCompraDeInsumos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compra De Insumos"
        Me.gbProveedores.ResumeLayout(False)
        Me.gbProveedores.PerformLayout()
        Me.gbInsumos.ResumeLayout(False)
        Me.gbInsumos.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdCompra As TextBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents gbProveedores As GroupBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtIdProveedor As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboProveedor As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents gbInsumos As GroupBox
    Friend WithEvents txtExistencias As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtMinimo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtMaximo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtUnidadM As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtIdInsumo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtFechaInsumo As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtCosto As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtIVA As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnBuscarIn As Button
    Friend WithEvents txtNombreInsumo As TextBox
End Class
