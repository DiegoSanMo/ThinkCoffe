<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCatalogoCategoria
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIdCategoria = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgCategoria = New System.Windows.Forms.DataGridView()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.ptbBarra = New System.Windows.Forms.PictureBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAgregar = New System.Windows.Forms.Button()
        CType(Me.dgCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbBarra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(130, 46)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(311, 33)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Registro de categorias"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(163, 146)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(317, 20)
        Me.txtNombre.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(89, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 18)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Nombre"
        '
        'txtIdCategoria
        '
        Me.txtIdCategoria.Location = New System.Drawing.Point(163, 106)
        Me.txtIdCategoria.Name = "txtIdCategoria"
        Me.txtIdCategoria.Size = New System.Drawing.Size(100, 20)
        Me.txtIdCategoria.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(32, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 18)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Clave categoria"
        '
        'dgCategoria
        '
        Me.dgCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCategoria.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.dgCategoria.Location = New System.Drawing.Point(24, 201)
        Me.dgCategoria.Name = "dgCategoria"
        Me.dgCategoria.Size = New System.Drawing.Size(557, 150)
        Me.dgCategoria.TabIndex = 31
        '
        'btnMinimizar
        '
        Me.btnMinimizar.AllowDrop = True
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnMinimizar.Image = Global.ThinkCoffee.My.Resources.Resources.Minimize_Window_30
        Me.btnMinimizar.Location = New System.Drawing.Point(545, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(36, 33)
        Me.btnMinimizar.TabIndex = 23
        Me.btnMinimizar.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnMinimizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnMinimizar.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.AllowDrop = True
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCerrar.Image = Global.ThinkCoffee.My.Resources.Resources.Close_Window_30
        Me.btnCerrar.Location = New System.Drawing.Point(577, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(36, 33)
        Me.btnCerrar.TabIndex = 22
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'ptbBarra
        '
        Me.ptbBarra.Dock = System.Windows.Forms.DockStyle.Top
        Me.ptbBarra.Image = Global.ThinkCoffee.My.Resources.Resources.BarraSuperior
        Me.ptbBarra.Location = New System.Drawing.Point(0, 0)
        Me.ptbBarra.Name = "ptbBarra"
        Me.ptbBarra.Size = New System.Drawing.Size(613, 33)
        Me.ptbBarra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbBarra.TabIndex = 0
        Me.ptbBarra.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(429, 373)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 39
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Location = New System.Drawing.Point(299, 373)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 38
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.Enabled = False
        Me.btnGrabar.Location = New System.Drawing.Point(187, 373)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(75, 23)
        Me.btnGrabar.TabIndex = 37
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(59, 373)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 36
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Clave"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 400
        '
        'btnAgregar
        '
        Me.btnAgregar.Enabled = False
        Me.btnAgregar.Location = New System.Drawing.Point(506, 148)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 40
        Me.btnAgregar.Text = "Aceptar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'frmCatalogoCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(613, 411)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.dgCategoria)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIdCategoria)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnMinimizar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.ptbBarra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCatalogoCategoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCatalogoCategoria"
        CType(Me.dgCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbBarra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ptbBarra As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIdCategoria As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgCategoria As DataGridView
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGrabar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents btnAgregar As Button
End Class
