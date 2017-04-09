<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCatalogoProducto
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdProducto = New System.Windows.Forms.TextBox()
        Me.txtIdCategoria = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIdReceta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboCategoria = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboReceta = New System.Windows.Forms.ComboBox()
        Me.txtNombreProducto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ptbImagenProducto = New System.Windows.Forms.PictureBox()
        Me.btnBuscarImg = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.ptbImagenProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IdProducto"
        '
        'txtIdProducto
        '
        Me.txtIdProducto.Enabled = False
        Me.txtIdProducto.Location = New System.Drawing.Point(90, 25)
        Me.txtIdProducto.Name = "txtIdProducto"
        Me.txtIdProducto.Size = New System.Drawing.Size(122, 20)
        Me.txtIdProducto.TabIndex = 1
        '
        'txtIdCategoria
        '
        Me.txtIdCategoria.Enabled = False
        Me.txtIdCategoria.Location = New System.Drawing.Point(348, 66)
        Me.txtIdCategoria.Name = "txtIdCategoria"
        Me.txtIdCategoria.Size = New System.Drawing.Size(100, 20)
        Me.txtIdCategoria.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(266, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "IdCategoria"
        '
        'txtIdReceta
        '
        Me.txtIdReceta.Enabled = False
        Me.txtIdReceta.Location = New System.Drawing.Point(348, 118)
        Me.txtIdReceta.Name = "txtIdReceta"
        Me.txtIdReceta.Size = New System.Drawing.Size(100, 20)
        Me.txtIdReceta.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(286, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "IdReceta"
        '
        'cboCategoria
        '
        Me.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategoria.Enabled = False
        Me.cboCategoria.FormattingEnabled = True
        Me.cboCategoria.Location = New System.Drawing.Point(116, 65)
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.Size = New System.Drawing.Size(121, 21)
        Me.cboCategoria.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Categoría"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(68, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Receta"
        '
        'cboReceta
        '
        Me.cboReceta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboReceta.Enabled = False
        Me.cboReceta.FormattingEnabled = True
        Me.cboReceta.Location = New System.Drawing.Point(116, 117)
        Me.cboReceta.Name = "cboReceta"
        Me.cboReceta.Size = New System.Drawing.Size(121, 21)
        Me.cboReceta.TabIndex = 8
        '
        'txtNombreProducto
        '
        Me.txtNombreProducto.Enabled = False
        Me.txtNombreProducto.Location = New System.Drawing.Point(116, 25)
        Me.txtNombreProducto.Name = "txtNombreProducto"
        Me.txtNombreProducto.Size = New System.Drawing.Size(332, 20)
        Me.txtNombreProducto.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Nombre de producto"
        '
        'ptbImagenProducto
        '
        Me.ptbImagenProducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ptbImagenProducto.Enabled = False
        Me.ptbImagenProducto.Location = New System.Drawing.Point(587, 19)
        Me.ptbImagenProducto.Name = "ptbImagenProducto"
        Me.ptbImagenProducto.Size = New System.Drawing.Size(150, 167)
        Me.ptbImagenProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbImagenProducto.TabIndex = 12
        Me.ptbImagenProducto.TabStop = False
        '
        'btnBuscarImg
        '
        Me.btnBuscarImg.Enabled = False
        Me.btnBuscarImg.Location = New System.Drawing.Point(587, 202)
        Me.btnBuscarImg.Name = "btnBuscarImg"
        Me.btnBuscarImg.Size = New System.Drawing.Size(150, 23)
        Me.btnBuscarImg.TabIndex = 13
        Me.btnBuscarImg.Text = "Agregar imagen"
        Me.btnBuscarImg.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.txtNombreProducto)
        Me.GroupBox1.Controls.Add(Me.btnBuscarImg)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ptbImagenProducto)
        Me.GroupBox1.Controls.Add(Me.txtIdCategoria)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtIdReceta)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cboCategoria)
        Me.GroupBox1.Controls.Add(Me.cboReceta)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(757, 237)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'btnAgregar
        '
        Me.btnAgregar.Enabled = False
        Me.btnAgregar.Location = New System.Drawing.Point(227, 189)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(150, 23)
        Me.btnAgregar.TabIndex = 14
        Me.btnAgregar.Text = "Agregar producto"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 348)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(757, 150)
        Me.DataGridView1.TabIndex = 15
        '
        'Column1
        '
        Me.Column1.HeaderText = "idProducto"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre Producto"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 250
        '
        'Column3
        '
        Me.Column3.HeaderText = "Categoria"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "Receta"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 200
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(38, 504)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(107, 23)
        Me.btnNuevo.TabIndex = 15
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.Enabled = False
        Me.btnGrabar.Location = New System.Drawing.Point(192, 504)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(107, 23)
        Me.btnGrabar.TabIndex = 16
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Location = New System.Drawing.Point(353, 501)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(107, 23)
        Me.btnCancelar.TabIndex = 17
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(511, 501)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(107, 23)
        Me.btnSalir.TabIndex = 18
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "(*.bmp, *.jpg,*.png)|*.bmp;*.jpg,*.png"
        '
        'frmCatalogoProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 536)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtIdProducto)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCatalogoProducto"
        Me.Text = "frmCatalogoProducto"
        CType(Me.ptbImagenProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdProducto As TextBox
    Friend WithEvents txtIdCategoria As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIdReceta As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboCategoria As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cboReceta As ComboBox
    Friend WithEvents txtNombreProducto As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ptbImagenProducto As PictureBox
    Friend WithEvents btnBuscarImg As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGrabar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
