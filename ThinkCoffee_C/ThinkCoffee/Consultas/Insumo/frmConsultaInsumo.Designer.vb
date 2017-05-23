<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaInsumo
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
        Me.gbConsultaInsumos = New System.Windows.Forms.GroupBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.cboInsumo = New System.Windows.Forms.ComboBox()
        Me.rbtTodo = New System.Windows.Forms.RadioButton()
        Me.rbtUnidadDeMedida = New System.Windows.Forms.RadioButton()
        Me.dgvConsultaInsumo = New System.Windows.Forms.DataGridView()
        Me.clmIdInsumo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmUnidadM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmMaximo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmMinimo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmExistencias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ptbBarra = New System.Windows.Forms.PictureBox()
        Me.gbConsultaInsumos.SuspendLayout()
        CType(Me.dgvConsultaInsumo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbBarra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbConsultaInsumos
        '
        Me.gbConsultaInsumos.Controls.Add(Me.btnAceptar)
        Me.gbConsultaInsumos.Controls.Add(Me.cboInsumo)
        Me.gbConsultaInsumos.Controls.Add(Me.rbtTodo)
        Me.gbConsultaInsumos.Controls.Add(Me.rbtUnidadDeMedida)
        Me.gbConsultaInsumos.Location = New System.Drawing.Point(262, 85)
        Me.gbConsultaInsumos.Name = "gbConsultaInsumos"
        Me.gbConsultaInsumos.Size = New System.Drawing.Size(499, 138)
        Me.gbConsultaInsumos.TabIndex = 0
        Me.gbConsultaInsumos.TabStop = False
        Me.gbConsultaInsumos.Text = "Consulta por:"
        '
        'btnAceptar
        '
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnAceptar.Location = New System.Drawing.Point(386, 65)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(90, 33)
        Me.btnAceptar.TabIndex = 9
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'cboInsumo
        '
        Me.cboInsumo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboInsumo.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!)
        Me.cboInsumo.FormattingEnabled = True
        Me.cboInsumo.Items.AddRange(New Object() {"LTS", "KG", "GR" & Global.Microsoft.VisualBasic.ChrW(9), "MLT", "PZA"})
        Me.cboInsumo.Location = New System.Drawing.Point(195, 27)
        Me.cboInsumo.Name = "cboInsumo"
        Me.cboInsumo.Size = New System.Drawing.Size(121, 28)
        Me.cboInsumo.TabIndex = 8
        Me.cboInsumo.Visible = False
        '
        'rbtTodo
        '
        Me.rbtTodo.AutoSize = True
        Me.rbtTodo.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Bold)
        Me.rbtTodo.Location = New System.Drawing.Point(18, 69)
        Me.rbtTodo.Name = "rbtTodo"
        Me.rbtTodo.Size = New System.Drawing.Size(66, 24)
        Me.rbtTodo.TabIndex = 2
        Me.rbtTodo.TabStop = True
        Me.rbtTodo.Text = "Todo"
        Me.rbtTodo.UseVisualStyleBackColor = True
        '
        'rbtUnidadDeMedida
        '
        Me.rbtUnidadDeMedida.AutoSize = True
        Me.rbtUnidadDeMedida.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Bold)
        Me.rbtUnidadDeMedida.Location = New System.Drawing.Point(18, 29)
        Me.rbtUnidadDeMedida.Name = "rbtUnidadDeMedida"
        Me.rbtUnidadDeMedida.Size = New System.Drawing.Size(171, 24)
        Me.rbtUnidadDeMedida.TabIndex = 1
        Me.rbtUnidadDeMedida.TabStop = True
        Me.rbtUnidadDeMedida.Text = "Unidad de medida:"
        Me.rbtUnidadDeMedida.UseVisualStyleBackColor = True
        '
        'dgvConsultaInsumo
        '
        Me.dgvConsultaInsumo.AllowDrop = True
        Me.dgvConsultaInsumo.AllowUserToAddRows = False
        Me.dgvConsultaInsumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsultaInsumo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmIdInsumo, Me.clmNombre, Me.clmUnidadM, Me.clmMaximo, Me.clmMinimo, Me.clmExistencias, Me.clmCosto, Me.clmFecha})
        Me.dgvConsultaInsumo.Location = New System.Drawing.Point(12, 229)
        Me.dgvConsultaInsumo.Name = "dgvConsultaInsumo"
        Me.dgvConsultaInsumo.ReadOnly = True
        Me.dgvConsultaInsumo.Size = New System.Drawing.Size(948, 234)
        Me.dgvConsultaInsumo.TabIndex = 1
        '
        'clmIdInsumo
        '
        Me.clmIdInsumo.HeaderText = "IdInsumo"
        Me.clmIdInsumo.Name = "clmIdInsumo"
        Me.clmIdInsumo.ReadOnly = True
        '
        'clmNombre
        '
        Me.clmNombre.HeaderText = "Nombre"
        Me.clmNombre.Name = "clmNombre"
        Me.clmNombre.ReadOnly = True
        Me.clmNombre.Width = 200
        '
        'clmUnidadM
        '
        Me.clmUnidadM.HeaderText = "Unidad de Medida"
        Me.clmUnidadM.Name = "clmUnidadM"
        Me.clmUnidadM.ReadOnly = True
        '
        'clmMaximo
        '
        Me.clmMaximo.HeaderText = "Máximo"
        Me.clmMaximo.Name = "clmMaximo"
        Me.clmMaximo.ReadOnly = True
        '
        'clmMinimo
        '
        Me.clmMinimo.HeaderText = "Mínimo"
        Me.clmMinimo.Name = "clmMinimo"
        Me.clmMinimo.ReadOnly = True
        '
        'clmExistencias
        '
        Me.clmExistencias.HeaderText = "Existencias"
        Me.clmExistencias.Name = "clmExistencias"
        Me.clmExistencias.ReadOnly = True
        '
        'clmCosto
        '
        Me.clmCosto.HeaderText = "Costo"
        Me.clmCosto.Name = "clmCosto"
        Me.clmCosto.ReadOnly = True
        '
        'clmFecha
        '
        Me.clmFecha.HeaderText = "Fecha"
        Me.clmFecha.Name = "clmFecha"
        Me.clmFecha.ReadOnly = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSalir.Image = Global.ThinkCoffee.My.Resources.Resources.Exit_Sign_Filled_30
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(867, 469)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(93, 39)
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
        Me.Label10.Location = New System.Drawing.Point(304, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(422, 37)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "CONSULTA DE INSUMOS"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ptbBarra
        '
        Me.ptbBarra.Dock = System.Windows.Forms.DockStyle.Top
        Me.ptbBarra.Image = Global.ThinkCoffee.My.Resources.Resources.BarraSuperior
        Me.ptbBarra.Location = New System.Drawing.Point(0, 0)
        Me.ptbBarra.Name = "ptbBarra"
        Me.ptbBarra.Size = New System.Drawing.Size(972, 33)
        Me.ptbBarra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbBarra.TabIndex = 60
        Me.ptbBarra.TabStop = False
        '
        'frmConsultaInsumo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 520)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ptbBarra)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.dgvConsultaInsumo)
        Me.Controls.Add(Me.gbConsultaInsumos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmConsultaInsumo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmConsultaInsumo"
        Me.gbConsultaInsumos.ResumeLayout(False)
        Me.gbConsultaInsumos.PerformLayout()
        CType(Me.dgvConsultaInsumo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbBarra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbConsultaInsumos As GroupBox
    Friend WithEvents rbtTodo As RadioButton
    Friend WithEvents rbtUnidadDeMedida As RadioButton
    Friend WithEvents cboInsumo As ComboBox
    Friend WithEvents dgvConsultaInsumo As DataGridView
    Friend WithEvents btnAceptar As Button
    Friend WithEvents clmIdInsumo As DataGridViewTextBoxColumn
    Friend WithEvents clmNombre As DataGridViewTextBoxColumn
    Friend WithEvents clmUnidadM As DataGridViewTextBoxColumn
    Friend WithEvents clmMaximo As DataGridViewTextBoxColumn
    Friend WithEvents clmMinimo As DataGridViewTextBoxColumn
    Friend WithEvents clmExistencias As DataGridViewTextBoxColumn
    Friend WithEvents clmCosto As DataGridViewTextBoxColumn
    Friend WithEvents clmFecha As DataGridViewTextBoxColumn
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents ptbBarra As PictureBox
End Class
