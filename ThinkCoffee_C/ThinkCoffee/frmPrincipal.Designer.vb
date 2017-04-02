<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.lblMensajeProv = New System.Windows.Forms.Label()
        Me.btnModificaciones = New System.Windows.Forms.Button()
        Me.btnRegistro = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HolaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatálogosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecordatoriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsumosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMensajeProv
        '
        Me.lblMensajeProv.BackColor = System.Drawing.Color.Transparent
        Me.lblMensajeProv.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensajeProv.Location = New System.Drawing.Point(551, 113)
        Me.lblMensajeProv.Name = "lblMensajeProv"
        Me.lblMensajeProv.Size = New System.Drawing.Size(295, 103)
        Me.lblMensajeProv.TabIndex = 3
        Me.lblMensajeProv.Text = "En este apartado podrás realizar registro, consulta y modificación de los proveed" &
    "ores"
        Me.lblMensajeProv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMensajeProv.Visible = False
        '
        'btnModificaciones
        '
        Me.btnModificaciones.BackColor = System.Drawing.Color.Transparent
        Me.btnModificaciones.FlatAppearance.BorderSize = 0
        Me.btnModificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificaciones.Image = Global.ThinkCoffee.My.Resources.Resources.Edit_User_Male_80
        Me.btnModificaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificaciones.Location = New System.Drawing.Point(306, 160)
        Me.btnModificaciones.Name = "btnModificaciones"
        Me.btnModificaciones.Size = New System.Drawing.Size(176, 89)
        Me.btnModificaciones.TabIndex = 2
        Me.btnModificaciones.Text = "Modificaciones"
        Me.btnModificaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnModificaciones.UseCompatibleTextRendering = True
        Me.btnModificaciones.UseVisualStyleBackColor = False
        Me.btnModificaciones.Visible = False
        '
        'btnRegistro
        '
        Me.btnRegistro.BackColor = System.Drawing.Color.Transparent
        Me.btnRegistro.FlatAppearance.BorderSize = 0
        Me.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistro.Image = Global.ThinkCoffee.My.Resources.Resources.Create_New_80
        Me.btnRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistro.Location = New System.Drawing.Point(306, 33)
        Me.btnRegistro.Name = "btnRegistro"
        Me.btnRegistro.Size = New System.Drawing.Size(148, 89)
        Me.btnRegistro.TabIndex = 1
        Me.btnRegistro.Text = "Registro"
        Me.btnRegistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRegistro.UseCompatibleTextRendering = True
        Me.btnRegistro.UseVisualStyleBackColor = False
        Me.btnRegistro.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImage = Global.ThinkCoffee.My.Resources.Resources.barraMenuB
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HolaToolStripMenuItem, Me.CatálogosToolStripMenuItem, Me.CategoriaToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.VentaToolStripMenuItem, Me.RecordatoriosToolStripMenuItem, Me.InsumosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(200, 741)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HolaToolStripMenuItem
        '
        Me.HolaToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HolaToolStripMenuItem.Image = Global.ThinkCoffee.My.Resources.Resources.thinkCoffeMiniLuz1
        Me.HolaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.HolaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.HolaToolStripMenuItem.Margin = New System.Windows.Forms.Padding(10, 10, 10, 0)
        Me.HolaToolStripMenuItem.Name = "HolaToolStripMenuItem"
        Me.HolaToolStripMenuItem.Size = New System.Drawing.Size(167, 37)
        '
        'CatálogosToolStripMenuItem
        '
        Me.CatálogosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProveedoresToolStripMenuItem1, Me.ProductosToolStripMenuItem1})
        Me.CatálogosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CatálogosToolStripMenuItem.Image = Global.ThinkCoffee.My.Resources.Resources.Dossier_50
        Me.CatálogosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CatálogosToolStripMenuItem.Name = "CatálogosToolStripMenuItem"
        Me.CatálogosToolStripMenuItem.Size = New System.Drawing.Size(187, 54)
        Me.CatálogosToolStripMenuItem.Text = "Catálogos"
        '
        'CategoriaToolStripMenuItem
        '
        Me.CategoriaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CategoriaToolStripMenuItem.Image = Global.ThinkCoffee.My.Resources.Resources.Tree_Structure_50
        Me.CategoriaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CategoriaToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 5, 0, 10)
        Me.CategoriaToolStripMenuItem.Name = "CategoriaToolStripMenuItem"
        Me.CategoriaToolStripMenuItem.Size = New System.Drawing.Size(187, 54)
        Me.CategoriaToolStripMenuItem.Text = "Categoria"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ProductosToolStripMenuItem.Image = Global.ThinkCoffee.My.Resources.Resources.Coffee_to_Go_50
        Me.ProductosToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ProductosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ProductosToolStripMenuItem.Margin = New System.Windows.Forms.Padding(7, 5, 0, 10)
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(180, 54)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'VentaToolStripMenuItem
        '
        Me.VentaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.VentaToolStripMenuItem.Image = Global.ThinkCoffee.My.Resources.Resources.Cash_Register_50
        Me.VentaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.VentaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.VentaToolStripMenuItem.Margin = New System.Windows.Forms.Padding(10, 5, 0, 10)
        Me.VentaToolStripMenuItem.Name = "VentaToolStripMenuItem"
        Me.VentaToolStripMenuItem.Size = New System.Drawing.Size(177, 54)
        Me.VentaToolStripMenuItem.Text = "Venta"
        Me.VentaToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RecordatoriosToolStripMenuItem
        '
        Me.RecordatoriosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RecordatoriosToolStripMenuItem.Image = Global.ThinkCoffee.My.Resources.Resources.Alarm_Clock_48
        Me.RecordatoriosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RecordatoriosToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 5, 0, 10)
        Me.RecordatoriosToolStripMenuItem.Name = "RecordatoriosToolStripMenuItem"
        Me.RecordatoriosToolStripMenuItem.Size = New System.Drawing.Size(187, 52)
        Me.RecordatoriosToolStripMenuItem.Text = "Recordatorios"
        '
        'InsumosToolStripMenuItem
        '
        Me.InsumosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.InsumosToolStripMenuItem.Image = Global.ThinkCoffee.My.Resources.Resources.Food_And_Wine_48
        Me.InsumosToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.InsumosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.InsumosToolStripMenuItem.Margin = New System.Windows.Forms.Padding(8, 5, 0, 10)
        Me.InsumosToolStripMenuItem.Name = "InsumosToolStripMenuItem"
        Me.InsumosToolStripMenuItem.Size = New System.Drawing.Size(179, 52)
        Me.InsumosToolStripMenuItem.Text = "Insumos"
        Me.InsumosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ProveedoresToolStripMenuItem1
        '
        Me.ProveedoresToolStripMenuItem1.Image = Global.ThinkCoffee.My.Resources.Resources.Conference_48
        Me.ProveedoresToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ProveedoresToolStripMenuItem1.Name = "ProveedoresToolStripMenuItem1"
        Me.ProveedoresToolStripMenuItem1.Size = New System.Drawing.Size(184, 54)
        Me.ProveedoresToolStripMenuItem1.Text = "Proveedores"
        '
        'ProductosToolStripMenuItem1
        '
        Me.ProductosToolStripMenuItem1.Name = "ProductosToolStripMenuItem1"
        Me.ProductosToolStripMenuItem1.Size = New System.Drawing.Size(184, 54)
        Me.ProductosToolStripMenuItem1.Text = "Productos"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ThinkCoffee.My.Resources.Resources.fondo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(947, 741)
        Me.Controls.Add(Me.lblMensajeProv)
        Me.Controls.Add(Me.btnModificaciones)
        Me.Controls.Add(Me.btnRegistro)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ThinkCoffee"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents VentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HolaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnRegistro As Button
    Friend WithEvents RecordatoriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnModificaciones As Button
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsumosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblMensajeProv As Label
    Friend WithEvents CatálogosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem1 As ToolStripMenuItem
End Class
