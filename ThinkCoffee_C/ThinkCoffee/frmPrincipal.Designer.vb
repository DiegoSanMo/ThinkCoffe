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
        Me.CatálogosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngredientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PromocionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PiizaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecordatoriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuBar = New System.Windows.Forms.MenuStrip()
        Me.HolaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.RegistroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'CatálogosToolStripMenuItem
        '
        Me.CatálogosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CategoriasToolStripMenuItem, Me.IngredientesToolStripMenuItem, Me.ProductosToolStripMenuItem1, Me.ProveedoresToolStripMenuItem1, Me.PromocionesToolStripMenuItem})
        Me.CatálogosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CatálogosToolStripMenuItem.Image = Global.ThinkCoffee.My.Resources.Resources.Dossier_50
        Me.CatálogosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CatálogosToolStripMenuItem.Margin = New System.Windows.Forms.Padding(-6, 0, 0, 0)
        Me.CatálogosToolStripMenuItem.Name = "CatálogosToolStripMenuItem"
        Me.CatálogosToolStripMenuItem.Padding = New System.Windows.Forms.Padding(2, 0, 4, 0)
        Me.CatálogosToolStripMenuItem.Size = New System.Drawing.Size(193, 54)
        Me.CatálogosToolStripMenuItem.Text = "Catálogos"
        '
        'CategoriasToolStripMenuItem
        '
        Me.CategoriasToolStripMenuItem.Image = Global.ThinkCoffee.My.Resources.Resources.Tree_Structure_50
        Me.CategoriasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CategoriasToolStripMenuItem.Name = "CategoriasToolStripMenuItem"
        Me.CategoriasToolStripMenuItem.Size = New System.Drawing.Size(186, 56)
        Me.CategoriasToolStripMenuItem.Text = "Categorias"
        '
        'IngredientesToolStripMenuItem
        '
        Me.IngredientesToolStripMenuItem.Image = Global.ThinkCoffee.My.Resources.Resources.Vegetarian_Food_50
        Me.IngredientesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.IngredientesToolStripMenuItem.Name = "IngredientesToolStripMenuItem"
        Me.IngredientesToolStripMenuItem.Size = New System.Drawing.Size(186, 56)
        Me.IngredientesToolStripMenuItem.Text = "Insumos"
        '
        'ProductosToolStripMenuItem1
        '
        Me.ProductosToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroToolStripMenuItem, Me.ModificaciónToolStripMenuItem})
        Me.ProductosToolStripMenuItem1.Image = Global.ThinkCoffee.My.Resources.Resources.Coffee_to_Go_50
        Me.ProductosToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ProductosToolStripMenuItem1.Name = "ProductosToolStripMenuItem1"
        Me.ProductosToolStripMenuItem1.Size = New System.Drawing.Size(186, 56)
        Me.ProductosToolStripMenuItem1.Text = "Productos"
        '
        'ProveedoresToolStripMenuItem1
        '
        Me.ProveedoresToolStripMenuItem1.Image = Global.ThinkCoffee.My.Resources.Resources.Conference_48
        Me.ProveedoresToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ProveedoresToolStripMenuItem1.Name = "ProveedoresToolStripMenuItem1"
        Me.ProveedoresToolStripMenuItem1.Size = New System.Drawing.Size(186, 56)
        Me.ProveedoresToolStripMenuItem1.Text = "Proveedores"
        '
        'PromocionesToolStripMenuItem
        '
        Me.PromocionesToolStripMenuItem.Image = Global.ThinkCoffee.My.Resources.Resources.Book_48
        Me.PromocionesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PromocionesToolStripMenuItem.Name = "PromocionesToolStripMenuItem"
        Me.PromocionesToolStripMenuItem.Size = New System.Drawing.Size(186, 56)
        Me.PromocionesToolStripMenuItem.Text = "Recetas"
        '
        'VentaToolStripMenuItem
        '
        Me.VentaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PiizaToolStripMenuItem, Me.OtrosToolStripMenuItem})
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
        'PiizaToolStripMenuItem
        '
        Me.PiizaToolStripMenuItem.Name = "PiizaToolStripMenuItem"
        Me.PiizaToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.PiizaToolStripMenuItem.Text = "Pizza"
        '
        'OtrosToolStripMenuItem
        '
        Me.OtrosToolStripMenuItem.Name = "OtrosToolStripMenuItem"
        Me.OtrosToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.OtrosToolStripMenuItem.Text = "Otros"
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
        'menuBar
        '
        Me.menuBar.BackgroundImage = Global.ThinkCoffee.My.Resources.Resources.barraFinal1
        Me.menuBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.menuBar.Dock = System.Windows.Forms.DockStyle.Left
        Me.menuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HolaToolStripMenuItem, Me.CatálogosToolStripMenuItem, Me.VentaToolStripMenuItem, Me.RecordatoriosToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.menuBar.Location = New System.Drawing.Point(0, 0)
        Me.menuBar.Name = "menuBar"
        Me.menuBar.Size = New System.Drawing.Size(200, 741)
        Me.menuBar.TabIndex = 0
        Me.menuBar.Text = "menuBar"
        '
        'HolaToolStripMenuItem
        '
        Me.HolaToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HolaToolStripMenuItem.Image = Global.ThinkCoffee.My.Resources.Resources.thinkCoffeMiniLuz1
        Me.HolaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.HolaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.HolaToolStripMenuItem.Margin = New System.Windows.Forms.Padding(10, 10, 10, 50)
        Me.HolaToolStripMenuItem.Name = "HolaToolStripMenuItem"
        Me.HolaToolStripMenuItem.Size = New System.Drawing.Size(167, 37)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = Global.ThinkCoffee.My.Resources.Resources.Exit_48
        Me.SalirToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SalirToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SalirToolStripMenuItem.Margin = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(172, 52)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(455, 359)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(36, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "<<"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnMin
        '
        Me.btnMin.BackColor = System.Drawing.Color.Transparent
        Me.btnMin.FlatAppearance.BorderSize = 0
        Me.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMin.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnMin.Location = New System.Drawing.Point(33, 47)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(36, 23)
        Me.btnMin.TabIndex = 3
        Me.btnMin.Text = ">>"
        Me.btnMin.UseVisualStyleBackColor = False
        Me.btnMin.Visible = False
        '
        'RegistroToolStripMenuItem
        '
        Me.RegistroToolStripMenuItem.Name = "RegistroToolStripMenuItem"
        Me.RegistroToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RegistroToolStripMenuItem.Text = "Registro"
        '
        'ModificaciónToolStripMenuItem
        '
        Me.ModificaciónToolStripMenuItem.Name = "ModificaciónToolStripMenuItem"
        Me.ModificaciónToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ModificaciónToolStripMenuItem.Text = "Modificación"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ThinkCoffee.My.Resources.Resources.fondo_del_principal_2W
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(947, 741)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.menuBar)
        Me.Controls.Add(Me.btnMin)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ThinkCoffee"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.menuBar.ResumeLayout(False)
        Me.menuBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CatálogosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents IngredientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PromocionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecordatoriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuBar As MenuStrip
    Friend WithEvents Button1 As Button
    Friend WithEvents btnMin As Button
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HolaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoriasToolStripMenuItem As ToolStripMenuItem
    
    Friend WithEvents PiizaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OtrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificaciónToolStripMenuItem As ToolStripMenuItem
End Class
