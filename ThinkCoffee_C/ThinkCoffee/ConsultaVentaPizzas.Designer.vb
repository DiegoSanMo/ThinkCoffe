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
        Me.rbPizza = New System.Windows.Forms.RadioButton()
        Me.rbOtros = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'rbPizza
        '
        Me.rbPizza.AutoSize = True
        Me.rbPizza.Location = New System.Drawing.Point(44, 30)
        Me.rbPizza.Name = "rbPizza"
        Me.rbPizza.Size = New System.Drawing.Size(166, 17)
        Me.rbPizza.TabIndex = 0
        Me.rbPizza.TabStop = True
        Me.rbPizza.Text = "Ventas por concepto de pizza"
        Me.rbPizza.UseVisualStyleBackColor = True
        '
        'rbOtros
        '
        Me.rbOtros.AutoSize = True
        Me.rbOtros.Location = New System.Drawing.Point(44, 131)
        Me.rbOtros.Name = "rbOtros"
        Me.rbOtros.Size = New System.Drawing.Size(102, 17)
        Me.rbOtros.TabIndex = 1
        Me.rbOtros.TabStop = True
        Me.rbOtros.Text = "Ventas por otros"
        Me.rbOtros.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(238, 79)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(52, 17)
        Me.RadioButton2.TabIndex = 3
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Chica"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(101, 79)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(75, 17)
        Me.RadioButton3.TabIndex = 4
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Rebanada"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(355, 79)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(60, 17)
        Me.RadioButton1.TabIndex = 5
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Grande"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'ConsultaVentaPizzas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 316)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.rbOtros)
        Me.Controls.Add(Me.rbPizza)
        Me.Name = "ConsultaVentaPizzas"
        Me.Text = "ConsultaVentaPizzas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rbPizza As RadioButton
    Friend WithEvents rbOtros As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
End Class
