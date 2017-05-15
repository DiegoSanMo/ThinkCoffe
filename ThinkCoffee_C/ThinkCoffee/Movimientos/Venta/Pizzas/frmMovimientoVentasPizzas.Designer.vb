<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMovimientoVentasPizzas
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
        Me.gbMixta = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboTamaño = New System.Windows.Forms.ComboBox()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.gbMixta.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbMixta
        '
        Me.gbMixta.Controls.Add(Me.CheckedListBox1)
        Me.gbMixta.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Bold)
        Me.gbMixta.Location = New System.Drawing.Point(12, 132)
        Me.gbMixta.Name = "gbMixta"
        Me.gbMixta.Size = New System.Drawing.Size(701, 189)
        Me.gbMixta.TabIndex = 71
        Me.gbMixta.TabStop = False
        Me.gbMixta.Text = "Toppings"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(8, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 20)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Tamaño"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(259, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 20)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "Tipo"
        '
        'cboTamaño
        '
        Me.cboTamaño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTamaño.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!)
        Me.cboTamaño.FormattingEnabled = True
        Me.cboTamaño.Items.AddRange(New Object() {"REBANADA", "CHICA", "MEDIANA", "GRANDE"})
        Me.cboTamaño.Location = New System.Drawing.Point(104, 18)
        Me.cboTamaño.Name = "cboTamaño"
        Me.cboTamaño.Size = New System.Drawing.Size(128, 28)
        Me.cboTamaño.TabIndex = 74
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!)
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Location = New System.Drawing.Point(329, 18)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(128, 28)
        Me.cboTipo.TabIndex = 75
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtPrecio)
        Me.GroupBox2.Controls.Add(Me.cboTipo)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cboTamaño)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 44)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(701, 73)
        Me.GroupBox2.TabIndex = 82
        Me.GroupBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(484, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 20)
        Me.Label6.TabIndex = 76
        Me.Label6.Text = "Precio"
        '
        'txtPrecio
        '
        Me.txtPrecio.Enabled = False
        Me.txtPrecio.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!)
        Me.txtPrecio.Location = New System.Drawing.Point(567, 19)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 27)
        Me.txtPrecio.TabIndex = 77
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Emoji", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(262, -9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 50)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Pizzas"
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.CheckedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CheckedListBox1.CheckOnClick = True
        Me.CheckedListBox1.ColumnWidth = 225
        Me.CheckedListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckedListBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"CARAMEL PRETZEL", "CLÁSICA", "FRUTAS Y PHILADELPHIA", "RESSES´S", "M & M´S", "CAJETA CON NUEZ", "PLATANO Y LECHERA", "MENTA", "OREO", "BUBULUBU", "SNICKERS", "STRAWBERRY", "ROCKY SMORE", "CHOCOCHIPS", "CHAI Y MAZAPAN", "PEANUT BUTTER Y JELLY", "CAFÉ Y ALMENDRAS", "PIÑA COLADA", "FERRERO", "ALMON JOY Y COCO", "NUTELLOSA"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(6, 26)
        Me.CheckedListBox1.MultiColumn = True
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(678, 147)
        Me.CheckedListBox1.TabIndex = 78
        Me.CheckedListBox1.UseCompatibleTextRendering = True
        '
        'frmMovimientoVentasPizzas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 382)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbMixta)
        Me.Name = "frmMovimientoVentasPizzas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Venta Pizzas"
        Me.gbMixta.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbMixta As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboTamaño As ComboBox
    Friend WithEvents cboTipo As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckedListBox1 As CheckedListBox
End Class
