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
        Me.btnBuscarC = New System.Windows.Forms.Button()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.rbCategoria = New System.Windows.Forms.RadioButton()
        Me.btnBuscarP = New System.Windows.Forms.Button()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.rbFecha = New System.Windows.Forms.RadioButton()
        Me.rbProducto = New System.Windows.Forms.RadioButton()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.lblDesde = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblHasta)
        Me.GroupBox1.Controls.Add(Me.btnBuscarC)
        Me.GroupBox1.Controls.Add(Me.lblDesde)
        Me.GroupBox1.Controls.Add(Me.txtCategoria)
        Me.GroupBox1.Controls.Add(Me.rbCategoria)
        Me.GroupBox1.Controls.Add(Me.btnBuscarP)
        Me.GroupBox1.Controls.Add(Me.txtProducto)
        Me.GroupBox1.Controls.Add(Me.btnAceptar)
        Me.GroupBox1.Controls.Add(Me.dtpFechaFinal)
        Me.GroupBox1.Controls.Add(Me.dtpFechaInicial)
        Me.GroupBox1.Controls.Add(Me.rbFecha)
        Me.GroupBox1.Controls.Add(Me.rbProducto)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(569, 201)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consultas por:"
        '
        'btnBuscarC
        '
        Me.btnBuscarC.Image = Global.ThinkCoffee.My.Resources.Resources.Search_20
        Me.btnBuscarC.Location = New System.Drawing.Point(505, 69)
        Me.btnBuscarC.Name = "btnBuscarC"
        Me.btnBuscarC.Size = New System.Drawing.Size(49, 29)
        Me.btnBuscarC.TabIndex = 11
        Me.btnBuscarC.UseVisualStyleBackColor = True
        Me.btnBuscarC.Visible = False
        '
        'txtCategoria
        '
        Me.txtCategoria.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!)
        Me.txtCategoria.Location = New System.Drawing.Point(128, 69)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.ReadOnly = True
        Me.txtCategoria.Size = New System.Drawing.Size(371, 27)
        Me.txtCategoria.TabIndex = 10
        Me.txtCategoria.Visible = False
        '
        'rbCategoria
        '
        Me.rbCategoria.AutoSize = True
        Me.rbCategoria.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Bold)
        Me.rbCategoria.Location = New System.Drawing.Point(21, 72)
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
        Me.btnAceptar.Location = New System.Drawing.Point(468, 153)
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
        Me.dtpFechaFinal.Location = New System.Drawing.Point(351, 119)
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
        Me.dtpFechaInicial.Location = New System.Drawing.Point(181, 118)
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
        Me.rbFecha.Location = New System.Drawing.Point(21, 118)
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
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Enabled = False
        Me.lblHasta.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHasta.Location = New System.Drawing.Point(298, 122)
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
        Me.lblDesde.Location = New System.Drawing.Point(124, 122)
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Size = New System.Drawing.Size(51, 20)
        Me.lblDesde.TabIndex = 11
        Me.lblDesde.Text = "Desde"
        Me.lblDesde.Visible = False
        '
        'ConsultaOtros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 236)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ConsultaOtros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ConsultaOtros"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents btnBuscarC As Button
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents lblHasta As Label
    Friend WithEvents lblDesde As Label
End Class
