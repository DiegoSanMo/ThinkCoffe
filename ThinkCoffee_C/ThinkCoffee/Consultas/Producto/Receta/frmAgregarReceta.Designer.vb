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
        CType(Me.dgvRecetas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvRecetas
        '
        Me.dgvRecetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecetas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmIdReceta, Me.clmNombreReceta})
        Me.dgvRecetas.Location = New System.Drawing.Point(12, 13)
        Me.dgvRecetas.Name = "dgvRecetas"
        Me.dgvRecetas.Size = New System.Drawing.Size(395, 150)
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
        Me.clmNombreReceta.Width = 250
        '
        'btnAgregarReceta
        '
        Me.btnAgregarReceta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnAgregarReceta.Location = New System.Drawing.Point(142, 171)
        Me.btnAgregarReceta.Name = "btnAgregarReceta"
        Me.btnAgregarReceta.Size = New System.Drawing.Size(138, 35)
        Me.btnAgregarReceta.TabIndex = 1
        Me.btnAgregarReceta.Text = "Agregar Receta"
        Me.btnAgregarReceta.UseVisualStyleBackColor = True
        '
        'frmAgregarReceta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 216)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnAgregarReceta)
        Me.Controls.Add(Me.dgvRecetas)
        Me.Name = "frmAgregarReceta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Receta"
        CType(Me.dgvRecetas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvRecetas As DataGridView
    Friend WithEvents btnAgregarReceta As Button
    Friend WithEvents clmIdReceta As DataGridViewTextBoxColumn
    Friend WithEvents clmNombreReceta As DataGridViewTextBoxColumn
End Class
