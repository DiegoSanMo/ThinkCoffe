<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaVentaPizzas
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
        Me.rbChica = New System.Windows.Forms.RadioButton()
        Me.rbRebanada = New System.Windows.Forms.RadioButton()
        Me.rbGrande = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgVentaP = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDetallesP = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgVentaP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rbChica
        '
        Me.rbChica.AutoSize = True
        Me.rbChica.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Bold)
        Me.rbChica.Location = New System.Drawing.Point(16, 82)
        Me.rbChica.Name = "rbChica"
        Me.rbChica.Size = New System.Drawing.Size(68, 24)
        Me.rbChica.TabIndex = 3
        Me.rbChica.TabStop = True
        Me.rbChica.Text = "Chica"
        Me.rbChica.UseVisualStyleBackColor = True
        '
        'rbRebanada
        '
        Me.rbRebanada.AutoSize = True
        Me.rbRebanada.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Bold)
        Me.rbRebanada.Location = New System.Drawing.Point(16, 29)
        Me.rbRebanada.Name = "rbRebanada"
        Me.rbRebanada.Size = New System.Drawing.Size(102, 24)
        Me.rbRebanada.TabIndex = 4
        Me.rbRebanada.TabStop = True
        Me.rbRebanada.Text = "Rebanada"
        Me.rbRebanada.UseVisualStyleBackColor = True
        '
        'rbGrande
        '
        Me.rbGrande.AutoSize = True
        Me.rbGrande.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Bold)
        Me.rbGrande.Location = New System.Drawing.Point(16, 138)
        Me.rbGrande.Name = "rbGrande"
        Me.rbGrande.Size = New System.Drawing.Size(81, 24)
        Me.rbGrande.TabIndex = 5
        Me.rbGrande.TabStop = True
        Me.rbGrande.Text = "Grande"
        Me.rbGrande.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.rbGrande)
        Me.GroupBox1.Controls.Add(Me.rbChica)
        Me.GroupBox1.Controls.Add(Me.rbRebanada)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 115)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(138, 195)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'dgVentaP
        '
        Me.dgVentaP.AllowUserToAddRows = False
        Me.dgVentaP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVentaP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgVentaP.Location = New System.Drawing.Point(158, 120)
        Me.dgVentaP.Name = "dgVentaP"
        Me.dgVentaP.Size = New System.Drawing.Size(647, 190)
        Me.dgVentaP.TabIndex = 7
        '
        'Column1
        '
        Me.Column1.HeaderText = "No.Venta"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Tamaño"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 200
        '
        'Column3
        '
        Me.Column3.HeaderText = "Tipo"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Cantidad"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Total"
        Me.Column5.Name = "Column5"
        '
        'btnAceptar
        '
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.Black
        Me.btnAceptar.Location = New System.Drawing.Point(434, 317)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(78, 34)
        Me.btnAceptar.TabIndex = 42
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(242, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(354, 25)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "VENTAS POR CONCEPTO DE PIZZA"
        '
        'btnDetallesP
        '
        Me.btnDetallesP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetallesP.ForeColor = System.Drawing.Color.Black
        Me.btnDetallesP.Location = New System.Drawing.Point(596, 79)
        Me.btnDetallesP.Name = "btnDetallesP"
        Me.btnDetallesP.Size = New System.Drawing.Size(209, 35)
        Me.btnDetallesP.TabIndex = 44
        Me.btnDetallesP.Text = "Información extra de venta"
        Me.btnDetallesP.UseVisualStyleBackColor = True
        Me.btnDetallesP.Visible = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(16, 168)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton1.TabIndex = 45
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        Me.RadioButton1.Visible = False
        '
        'ConsultaVentaPizzas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 357)
        Me.Controls.Add(Me.btnDetallesP)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.dgVentaP)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ConsultaVentaPizzas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Ventas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgVentaP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbChica As RadioButton
    Friend WithEvents rbRebanada As RadioButton
    Friend WithEvents rbGrande As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgVentaP As DataGridView
    Friend WithEvents btnAceptar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents btnDetallesP As Button
    Friend WithEvents RadioButton1 As RadioButton
End Class
