<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarReceta
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
        Me.dgvRecetas = New System.Windows.Forms.DataGridView()
        Me.clmIdReceta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmNombreReceta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAgregarReceta = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ptbBarra = New System.Windows.Forms.PictureBox()
        CType(Me.dgvRecetas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbBarra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvRecetas
        '
        Me.dgvRecetas.AllowUserToAddRows = False
        Me.dgvRecetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecetas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmIdReceta, Me.clmNombreReceta})
        Me.dgvRecetas.Location = New System.Drawing.Point(12, 87)
        Me.dgvRecetas.Name = "dgvRecetas"
        Me.dgvRecetas.Size = New System.Drawing.Size(507, 220)
        Me.dgvRecetas.TabIndex = 0
        '
        'clmIdReceta
        '
        Me.clmIdReceta.HeaderText = "IdReceta"
        Me.clmIdReceta.Name = "clmIdReceta"
        Me.clmIdReceta.ReadOnly = True
        '
        'clmNombreReceta
        '
        Me.clmNombreReceta.HeaderText = "Receta"
        Me.clmNombreReceta.Name = "clmNombreReceta"
        Me.clmNombreReceta.ReadOnly = True
        Me.clmNombreReceta.Width = 350
        '
        'btnAgregarReceta
        '
        Me.btnAgregarReceta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnAgregarReceta.Image = Global.ThinkCoffee.My.Resources.Resources.Checked_48
        Me.btnAgregarReceta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregarReceta.Location = New System.Drawing.Point(172, 313)
        Me.btnAgregarReceta.Name = "btnAgregarReceta"
        Me.btnAgregarReceta.Size = New System.Drawing.Size(210, 47)
        Me.btnAgregarReceta.TabIndex = 1
        Me.btnAgregarReceta.Text = "Agregar Receta"
        Me.btnAgregarReceta.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(53, 47)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(427, 37)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "BUSQUEDA DE RECETAS"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ptbBarra
        '
        Me.ptbBarra.Dock = System.Windows.Forms.DockStyle.Top
        Me.ptbBarra.Image = Global.ThinkCoffee.My.Resources.Resources.BarraSuperior
        Me.ptbBarra.Location = New System.Drawing.Point(0, 0)
        Me.ptbBarra.Name = "ptbBarra"
        Me.ptbBarra.Size = New System.Drawing.Size(531, 33)
        Me.ptbBarra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbBarra.TabIndex = 60
        Me.ptbBarra.TabStop = False
        '
        'frmAgregarReceta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 368)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ptbBarra)
        Me.Controls.Add(Me.btnAgregarReceta)
        Me.Controls.Add(Me.dgvRecetas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAgregarReceta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Receta"
        CType(Me.dgvRecetas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbBarra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvRecetas As DataGridView
    Friend WithEvents btnAgregarReceta As Button
    Friend WithEvents clmIdReceta As DataGridViewTextBoxColumn
    Friend WithEvents clmNombreReceta As DataGridViewTextBoxColumn
    Friend WithEvents Label10 As Label
    Friend WithEvents ptbBarra As PictureBox
End Class
