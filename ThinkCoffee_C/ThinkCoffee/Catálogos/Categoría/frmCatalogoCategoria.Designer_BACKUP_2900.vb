<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCatalogoCategoria
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ptbBarra = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
<<<<<<< HEAD:ThinkCoffee_C/ThinkCoffee/Catálogos/Categoría/frmCatalogoCategoria.Designer.vb
=======

>>>>>>> master:ThinkCoffee_C/ThinkCoffee/frmCatalogoCategoria.Designer.vb
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIdCategoria = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgCategoria = New System.Windows.Forms.DataGridView()
<<<<<<< HEAD:ThinkCoffee_C/ThinkCoffee/Catálogos/Categoría/frmCatalogoCategoria.Designer.vb
=======

>>>>>>> master:ThinkCoffee_C/ThinkCoffee/frmCatalogoCategoria.Designer.vb
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
<<<<<<< HEAD:ThinkCoffee_C/ThinkCoffee/Catálogos/Categoría/frmCatalogoCategoria.Designer.vb
=======
    
>>>>>>> master:ThinkCoffee_C/ThinkCoffee/frmCatalogoCategoria.Designer.vb
        CType(Me.ptbBarra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ptbBarra
        '
        Me.ptbBarra.Dock = System.Windows.Forms.DockStyle.Top
        Me.ptbBarra.Image = Global.ThinkCoffee.My.Resources.Resources.BarraSuperior
        Me.ptbBarra.Location = New System.Drawing.Point(0, 0)
        Me.ptbBarra.Name = "ptbBarra"
        Me.ptbBarra.Size = New System.Drawing.Size(547, 33)
        Me.ptbBarra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbBarra.TabIndex = 0
        Me.ptbBarra.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Adobe Gothic Std B", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(164, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(206, 40)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "CATEGORIAS"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
<<<<<<< HEAD:ThinkCoffee_C/ThinkCoffee/Catálogos/Categoría/frmCatalogoCategoria.Designer.vb
=======

>>>>>>> master:ThinkCoffee_C/ThinkCoffee/frmCatalogoCategoria.Designer.vb
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!)
        Me.txtNombre.Location = New System.Drawing.Point(113, 62)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(273, 27)
        Me.txtNombre.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(36, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 20)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Nombre"
        '
        'txtIdCategoria
        '
        Me.txtIdCategoria.Enabled = False
        Me.txtIdCategoria.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!)
        Me.txtIdCategoria.Location = New System.Drawing.Point(113, 15)
        Me.txtIdCategoria.Name = "txtIdCategoria"
        Me.txtIdCategoria.Size = New System.Drawing.Size(100, 27)
        Me.txtIdCategoria.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(9, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 20)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "idCategoria"

        '
        'dgCategoria
        '
        Me.dgCategoria.AllowUserToAddRows = False
        Me.dgCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCategoria.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.dgCategoria.Location = New System.Drawing.Point(42, 217)
        Me.dgCategoria.Name = "dgCategoria"
        Me.dgCategoria.ReadOnly = True
        Me.dgCategoria.Size = New System.Drawing.Size(487, 150)
        Me.dgCategoria.TabIndex = 31

        '
        'Column1
        '
<<<<<<< HEAD:ThinkCoffee_C/ThinkCoffee/Catálogos/Categoría/frmCatalogoCategoria.Designer.vb
        'Column1
        '
=======
>>>>>>> master:ThinkCoffee_C/ThinkCoffee/frmCatalogoCategoria.Designer.vb
        Me.Column1.HeaderText = "Clave"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 315
<<<<<<< HEAD:ThinkCoffee_C/ThinkCoffee/Catálogos/Categoría/frmCatalogoCategoria.Designer.vb
=======

>>>>>>> master:ThinkCoffee_C/ThinkCoffee/frmCatalogoCategoria.Designer.vb
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSalir.Image = Global.ThinkCoffee.My.Resources.Resources.Exit_Sign_Filled_30
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(440, 388)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(87, 39)
        Me.btnSalir.TabIndex = 39
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.Image = Global.ThinkCoffee.My.Resources.Resources.Cancel_30
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(334, 388)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(101, 39)
        Me.btnCancelar.TabIndex = 38
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.Enabled = False
        Me.btnGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrabar.ForeColor = System.Drawing.Color.Black
        Me.btnGrabar.Image = Global.ThinkCoffee.My.Resources.Resources.Burn_CD_30
        Me.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGrabar.Location = New System.Drawing.Point(242, 388)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(87, 39)
        Me.btnGrabar.TabIndex = 37
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.Black
        Me.btnNuevo.Image = Global.ThinkCoffee.My.Resources.Resources.Add_List_30
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(42, 388)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(87, 39)
        Me.btnNuevo.TabIndex = 36
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnAceptar)
        Me.GroupBox1.Controls.Add(Me.txtIdCategoria)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(506, 107)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        '
        'btnAceptar
        '
        Me.btnAceptar.Enabled = False
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.Black
        Me.btnAceptar.Location = New System.Drawing.Point(414, 62)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(78, 27)
        Me.btnAceptar.TabIndex = 41
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.Black
        Me.btnModificar.Image = Global.ThinkCoffee.My.Resources.Resources.Sort_By_Modified_Date_30
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(134, 388)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(103, 39)
        Me.btnModificar.TabIndex = 41
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificar.UseVisualStyleBackColor = True
<<<<<<< HEAD:ThinkCoffee_C/ThinkCoffee/Catálogos/Categoría/frmCatalogoCategoria.Designer.vb
=======

>>>>>>> master:ThinkCoffee_C/ThinkCoffee/frmCatalogoCategoria.Designer.vb
        '
        'frmCatalogoCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BackgroundImage = Global.ThinkCoffee.My.Resources.Resources.fondo_formulario_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
<<<<<<< HEAD:ThinkCoffee_C/ThinkCoffee/Catálogos/Categoría/frmCatalogoCategoria.Designer.vb
        Me.ClientSize = New System.Drawing.Size(547, 445)
        Me.Controls.Add(Me.btnModificar)
=======

        Me.ClientSize = New System.Drawing.Size(547, 445)
        Me.Controls.Add(Me.btnModificar)
        
>>>>>>> master:ThinkCoffee_C/ThinkCoffee/frmCatalogoCategoria.Designer.vb
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnNuevo)
<<<<<<< HEAD:ThinkCoffee_C/ThinkCoffee/Catálogos/Categoría/frmCatalogoCategoria.Designer.vb
=======

>>>>>>> master:ThinkCoffee_C/ThinkCoffee/frmCatalogoCategoria.Designer.vb
        Me.Controls.Add(Me.dgCategoria)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ptbBarra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCatalogoCategoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCatalogoCategoria"
        CType(Me.ptbBarra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ptbBarra As PictureBox
    Friend WithEvents Label10 As Label

    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIdCategoria As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgCategoria As DataGridView

    Friend WithEvents btnSalir As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGrabar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn

    Friend WithEvents btnModificar As Button
End Class
