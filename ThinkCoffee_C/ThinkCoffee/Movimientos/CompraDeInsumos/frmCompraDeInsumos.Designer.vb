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
        Me.cboProveedor = New System.Windows.Forms.ComboBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtIdProveedor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbInsumos = New System.Windows.Forms.GroupBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnAgregarI = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtNuevoC = New System.Windows.Forms.TextBox()
        Me.btnBuscarIn = New System.Windows.Forms.Button()
        Me.txtNombreInsumo = New System.Windows.Forms.TextBox()
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
        Me.dgInsumosC = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ptbBarra = New System.Windows.Forms.PictureBox()
        Me.gbProveedores.SuspendLayout()
        Me.gbInsumos.SuspendLayout()
        CType(Me.dgInsumosC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ptbBarra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(150, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IdCompra:"
        Me.Label1.Visible = False
        '
        'txtIdCompra
        '
        Me.txtIdCompra.Enabled = False
        Me.txtIdCompra.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!)
        Me.txtIdCompra.Location = New System.Drawing.Point(254, 89)
        Me.txtIdCompra.Name = "txtIdCompra"
        Me.txtIdCompra.Size = New System.Drawing.Size(100, 27)
        Me.txtIdCompra.TabIndex = 1
        Me.txtIdCompra.Visible = False
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!)
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(755, 93)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(98, 27)
        Me.dtpFecha.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(680, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha:"
        '
        'gbProveedores
        '
        Me.gbProveedores.Controls.Add(Me.cboProveedor)
        Me.gbProveedores.Controls.Add(Me.txtTelefono)
        Me.gbProveedores.Controls.Add(Me.Label6)
        Me.gbProveedores.Controls.Add(Me.txtDireccion)
        Me.gbProveedores.Controls.Add(Me.Label5)
        Me.gbProveedores.Controls.Add(Me.txtIdProveedor)
        Me.gbProveedores.Controls.Add(Me.Label4)
        Me.gbProveedores.Controls.Add(Me.Label3)
        Me.gbProveedores.Location = New System.Drawing.Point(141, 122)
        Me.gbProveedores.Name = "gbProveedores"
        Me.gbProveedores.Size = New System.Drawing.Size(726, 97)
        Me.gbProveedores.TabIndex = 4
        Me.gbProveedores.TabStop = False
        Me.gbProveedores.Text = "Proveedores:"
        '
        'cboProveedor
        '
        Me.cboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProveedor.Enabled = False
        Me.cboProveedor.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!)
        Me.cboProveedor.FormattingEnabled = True
        Me.cboProveedor.Location = New System.Drawing.Point(228, 21)
        Me.cboProveedor.Name = "cboProveedor"
        Me.cboProveedor.Size = New System.Drawing.Size(301, 28)
        Me.cboProveedor.TabIndex = 2
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!)
        Me.txtTelefono.Location = New System.Drawing.Point(582, 56)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.ReadOnly = True
        Me.txtTelefono.Size = New System.Drawing.Size(117, 27)
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
        Me.txtDireccion.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!)
        Me.txtDireccion.Location = New System.Drawing.Point(107, 57)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ReadOnly = True
        Me.txtDireccion.Size = New System.Drawing.Size(310, 27)
        Me.txtDireccion.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 24)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Dirección:"
        '
        'txtIdProveedor
        '
        Me.txtIdProveedor.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!)
        Me.txtIdProveedor.Location = New System.Drawing.Point(582, 21)
        Me.txtIdProveedor.Name = "txtIdProveedor"
        Me.txtIdProveedor.ReadOnly = True
        Me.txtIdProveedor.Size = New System.Drawing.Size(100, 27)
        Me.txtIdProveedor.TabIndex = 4
        Me.txtIdProveedor.Visible = False
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
        Me.Label4.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(118, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 24)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Proveedor:"
        '
        'gbInsumos
        '
        Me.gbInsumos.Controls.Add(Me.txtCantidad)
        Me.gbInsumos.Controls.Add(Me.Label19)
        Me.gbInsumos.Controls.Add(Me.btnAgregarI)
        Me.gbInsumos.Controls.Add(Me.Label18)
        Me.gbInsumos.Controls.Add(Me.txtNuevoC)
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
        Me.gbInsumos.Location = New System.Drawing.Point(142, 225)
        Me.gbInsumos.Name = "gbInsumos"
        Me.gbInsumos.Size = New System.Drawing.Size(726, 144)
        Me.gbInsumos.TabIndex = 5
        Me.gbInsumos.TabStop = False
        Me.gbInsumos.Text = "Insumos:"
        '
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!)
        Me.txtCantidad.Location = New System.Drawing.Point(413, 103)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.ReadOnly = True
        Me.txtCantidad.Size = New System.Drawing.Size(117, 27)
        Me.txtCantidad.TabIndex = 24
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(327, 106)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(84, 24)
        Me.Label19.TabIndex = 23
        Me.Label19.Text = "Cantidad"
        '
        'btnAgregarI
        '
        Me.btnAgregarI.Enabled = False
        Me.btnAgregarI.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnAgregarI.Location = New System.Drawing.Point(582, 103)
        Me.btnAgregarI.Name = "btnAgregarI"
        Me.btnAgregarI.Size = New System.Drawing.Size(100, 31)
        Me.btnAgregarI.TabIndex = 22
        Me.btnAgregarI.Text = "Agregar"
        Me.btnAgregarI.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(48, 99)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(121, 24)
        Me.Label18.TabIndex = 21
        Me.Label18.Text = "Nuevo costo:"
        '
        'txtNuevoC
        '
        Me.txtNuevoC.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!)
        Me.txtNuevoC.Location = New System.Drawing.Point(175, 99)
        Me.txtNuevoC.Name = "txtNuevoC"
        Me.txtNuevoC.ReadOnly = True
        Me.txtNuevoC.Size = New System.Drawing.Size(117, 27)
        Me.txtNuevoC.TabIndex = 20
        '
        'btnBuscarIn
        '
        Me.btnBuscarIn.Enabled = False
        Me.btnBuscarIn.Image = Global.ThinkCoffee.My.Resources.Resources.Search_20
        Me.btnBuscarIn.Location = New System.Drawing.Point(543, 19)
        Me.btnBuscarIn.Name = "btnBuscarIn"
        Me.btnBuscarIn.Size = New System.Drawing.Size(44, 27)
        Me.btnBuscarIn.TabIndex = 9
        Me.btnBuscarIn.UseVisualStyleBackColor = True
        '
        'txtNombreInsumo
        '
        Me.txtNombreInsumo.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!)
        Me.txtNombreInsumo.Location = New System.Drawing.Point(179, 19)
        Me.txtNombreInsumo.Name = "txtNombreInsumo"
        Me.txtNombreInsumo.ReadOnly = True
        Me.txtNombreInsumo.Size = New System.Drawing.Size(351, 27)
        Me.txtNombreInsumo.TabIndex = 19
        '
        'txtFechaInsumo
        '
        Me.txtFechaInsumo.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!)
        Me.txtFechaInsumo.Location = New System.Drawing.Point(388, 55)
        Me.txtFechaInsumo.Name = "txtFechaInsumo"
        Me.txtFechaInsumo.ReadOnly = True
        Me.txtFechaInsumo.Size = New System.Drawing.Size(100, 27)
        Me.txtFechaInsumo.TabIndex = 18
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(254, 56)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(130, 24)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Última compra"
        '
        'txtCosto
        '
        Me.txtCosto.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!)
        Me.txtCosto.Location = New System.Drawing.Point(635, 56)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.ReadOnly = True
        Me.txtCosto.Size = New System.Drawing.Size(72, 27)
        Me.txtCosto.TabIndex = 16
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(503, 57)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(131, 24)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Costo anterior:"
        '
        'txtExistencias
        '
        Me.txtExistencias.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!)
        Me.txtExistencias.Location = New System.Drawing.Point(116, 56)
        Me.txtExistencias.Name = "txtExistencias"
        Me.txtExistencias.ReadOnly = True
        Me.txtExistencias.Size = New System.Drawing.Size(92, 27)
        Me.txtExistencias.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(19, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 24)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Existencia"
        '
        'txtMinimo
        '
        Me.txtMinimo.Location = New System.Drawing.Point(299, 57)
        Me.txtMinimo.Name = "txtMinimo"
        Me.txtMinimo.ReadOnly = True
        Me.txtMinimo.Size = New System.Drawing.Size(100, 20)
        Me.txtMinimo.TabIndex = 12
        Me.txtMinimo.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(234, 55)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 24)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Mínimo:"
        Me.Label11.Visible = False
        '
        'txtMaximo
        '
        Me.txtMaximo.Location = New System.Drawing.Point(103, 56)
        Me.txtMaximo.Name = "txtMaximo"
        Me.txtMaximo.ReadOnly = True
        Me.txtMaximo.Size = New System.Drawing.Size(100, 20)
        Me.txtMaximo.TabIndex = 10
        Me.txtMaximo.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 24)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Máximo:"
        Me.Label10.Visible = False
        '
        'txtUnidadM
        '
        Me.txtUnidadM.Location = New System.Drawing.Point(599, 58)
        Me.txtUnidadM.Name = "txtUnidadM"
        Me.txtUnidadM.ReadOnly = True
        Me.txtUnidadM.Size = New System.Drawing.Size(100, 20)
        Me.txtUnidadM.TabIndex = 8
        Me.txtUnidadM.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(515, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 24)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Medida:"
        Me.Label9.Visible = False
        '
        'txtIdInsumo
        '
        Me.txtIdInsumo.Location = New System.Drawing.Point(122, 58)
        Me.txtIdInsumo.Name = "txtIdInsumo"
        Me.txtIdInsumo.ReadOnly = True
        Me.txtIdInsumo.Size = New System.Drawing.Size(100, 20)
        Me.txtIdInsumo.TabIndex = 6
        Me.txtIdInsumo.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 24)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "IdInsumo:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(98, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 24)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Insumo:"
        '
        'dgInsumosC
        '
        Me.dgInsumosC.AllowUserToAddRows = False
        Me.dgInsumosC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgInsumosC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgInsumosC.Location = New System.Drawing.Point(142, 377)
        Me.dgInsumosC.Name = "dgInsumosC"
        Me.dgInsumosC.Size = New System.Drawing.Size(725, 150)
        Me.dgInsumosC.TabIndex = 6
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID insumo"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Insumo"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 275
        '
        'Column3
        '
        Me.Column3.HeaderText = "Cantidad"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Costo"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Importe"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Enabled = False
        Me.txtSubtotal.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!)
        Me.txtSubtotal.Location = New System.Drawing.Point(749, 537)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(100, 27)
        Me.txtSubtotal.TabIndex = 8
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(661, 538)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(82, 24)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Subtotal:"
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = Global.ThinkCoffee.My.Resources.Resources.Add_List_30
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(9, 15)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(100, 42)
        Me.btnNuevo.TabIndex = 13
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = Global.ThinkCoffee.My.Resources.Resources.Burn_CD_30
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(9, 73)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(100, 42)
        Me.btnGuardar.TabIndex = 14
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.ThinkCoffee.My.Resources.Resources.Cancel_30
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(9, 127)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 41)
        Me.btnCancelar.TabIndex = 15
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.ThinkCoffee.My.Resources.Resources.Exit_Sign_Filled_30
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(9, 350)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(100, 39)
        Me.btnSalir.TabIndex = 16
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 122)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(124, 395)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(134, 46)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(664, 37)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "COMPRAS POR CONCEPTO DE INSUMO"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ptbBarra
        '
        Me.ptbBarra.Dock = System.Windows.Forms.DockStyle.Top
        Me.ptbBarra.Image = Global.ThinkCoffee.My.Resources.Resources.BarraSuperior
        Me.ptbBarra.Location = New System.Drawing.Point(0, 0)
        Me.ptbBarra.Name = "ptbBarra"
        Me.ptbBarra.Size = New System.Drawing.Size(891, 33)
        Me.ptbBarra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbBarra.TabIndex = 25
        Me.ptbBarra.TabStop = False
        '
        'frmCompraDeInsumos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(891, 581)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.ptbBarra)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.dgInsumosC)
        Me.Controls.Add(Me.gbInsumos)
        Me.Controls.Add(Me.gbProveedores)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.txtIdCompra)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCompraDeInsumos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compra De Insumos"
        Me.gbProveedores.ResumeLayout(False)
        Me.gbProveedores.PerformLayout()
        Me.gbInsumos.ResumeLayout(False)
        Me.gbInsumos.PerformLayout()
        CType(Me.dgInsumosC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ptbBarra, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgInsumosC As DataGridView
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnBuscarIn As Button
    Friend WithEvents txtNombreInsumo As TextBox
    Friend WithEvents btnAgregarI As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents txtNuevoC As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents ptbBarra As PictureBox
End Class
