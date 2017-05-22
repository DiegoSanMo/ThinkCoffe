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
        Me.lblFinal = New System.Windows.Forms.Label()
        Me.lblInicial = New System.Windows.Forms.Label()
        Me.btnBuscarP = New System.Windows.Forms.Button()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.rbFecha = New System.Windows.Forms.RadioButton()
        Me.rbProducto = New System.Windows.Forms.RadioButton()
        Me.rbCategoria = New System.Windows.Forms.RadioButton()
        Me.btnBuscarC = New System.Windows.Forms.Button()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBuscarC)
        Me.GroupBox1.Controls.Add(Me.txtCategoria)
        Me.GroupBox1.Controls.Add(Me.rbCategoria)
        Me.GroupBox1.Controls.Add(Me.lblFinal)
        Me.GroupBox1.Controls.Add(Me.lblInicial)
        Me.GroupBox1.Controls.Add(Me.btnBuscarP)
        Me.GroupBox1.Controls.Add(Me.txtProducto)
        Me.GroupBox1.Controls.Add(Me.btnAceptar)
        Me.GroupBox1.Controls.Add(Me.dtpFechaFinal)
        Me.GroupBox1.Controls.Add(Me.dtpFechaInicial)
        Me.GroupBox1.Controls.Add(Me.rbFecha)
        Me.GroupBox1.Controls.Add(Me.rbProducto)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(569, 220)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consultas por:"
        '
        'lblFinal
        '
        Me.lblFinal.AutoSize = True
        Me.lblFinal.Location = New System.Drawing.Point(274, 102)
        Me.lblFinal.Name = "lblFinal"
        Me.lblFinal.Size = New System.Drawing.Size(59, 13)
        Me.lblFinal.TabIndex = 8
        Me.lblFinal.Text = "Fecha final"
        Me.lblFinal.Visible = False
        '
        'lblInicial
        '
        Me.lblInicial.AutoSize = True
        Me.lblInicial.Location = New System.Drawing.Point(127, 102)
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
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(101, 28)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.ReadOnly = True
        Me.txtProducto.Size = New System.Drawing.Size(371, 20)
        Me.txtProducto.TabIndex = 5
        Me.txtProducto.Visible = False
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(21, 168)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(523, 36)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.Location = New System.Drawing.Point(277, 118)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(98, 20)
        Me.dtpFechaFinal.TabIndex = 3
        Me.dtpFechaFinal.Value = New Date(2017, 5, 18, 0, 0, 0, 0)
        Me.dtpFechaFinal.Visible = False
        '
        'dtpFechaInicial
        '
        Me.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicial.Location = New System.Drawing.Point(130, 118)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.Size = New System.Drawing.Size(98, 20)
        Me.dtpFechaInicial.TabIndex = 2
        Me.dtpFechaInicial.Value = New Date(2017, 5, 18, 0, 0, 0, 0)
        Me.dtpFechaInicial.Visible = False
        '
        'rbFecha
        '
        Me.rbFecha.AutoSize = True
        Me.rbFecha.Location = New System.Drawing.Point(21, 118)
        Me.rbFecha.Name = "rbFecha"
        Me.rbFecha.Size = New System.Drawing.Size(55, 17)
        Me.rbFecha.TabIndex = 1
        Me.rbFecha.TabStop = True
        Me.rbFecha.Text = "Fecha"
        Me.rbFecha.UseVisualStyleBackColor = True
        '
        'rbProducto
        '
        Me.rbProducto.AutoSize = True
        Me.rbProducto.Location = New System.Drawing.Point(21, 30)
        Me.rbProducto.Name = "rbProducto"
        Me.rbProducto.Size = New System.Drawing.Size(68, 17)
        Me.rbProducto.TabIndex = 0
        Me.rbProducto.TabStop = True
        Me.rbProducto.Text = "Producto"
        Me.rbProducto.UseVisualStyleBackColor = True
        '
        'rbCategoria
        '
        Me.rbCategoria.AutoSize = True
        Me.rbCategoria.Location = New System.Drawing.Point(21, 72)
        Me.rbCategoria.Name = "rbCategoria"
        Me.rbCategoria.Size = New System.Drawing.Size(72, 17)
        Me.rbCategoria.TabIndex = 9
        Me.rbCategoria.TabStop = True
        Me.rbCategoria.Text = "Categoría"
        Me.rbCategoria.UseVisualStyleBackColor = True
        '
        'btnBuscarC
        '
        Me.btnBuscarC.Image = Global.ThinkCoffee.My.Resources.Resources.Search_20
        Me.btnBuscarC.Location = New System.Drawing.Point(495, 66)
        Me.btnBuscarC.Name = "btnBuscarC"
        Me.btnBuscarC.Size = New System.Drawing.Size(49, 29)
        Me.btnBuscarC.TabIndex = 11
        Me.btnBuscarC.UseVisualStyleBackColor = True
        Me.btnBuscarC.Visible = False
        '
        'txtCategoria
        '
        Me.txtCategoria.Location = New System.Drawing.Point(101, 70)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.ReadOnly = True
        Me.txtCategoria.Size = New System.Drawing.Size(371, 20)
        Me.txtCategoria.TabIndex = 10
        Me.txtCategoria.Visible = False
        '
        'ConsultaOtros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 342)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ConsultaOtros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ConsultaOtros"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblFinal As Label
    Friend WithEvents lblInicial As Label
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
End Class
