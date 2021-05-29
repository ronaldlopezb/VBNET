<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.PanelSuperior = New System.Windows.Forms.Panel()
        Me.pbSideBar = New System.Windows.Forms.PictureBox()
        Me.pbRestaurar = New System.Windows.Forms.PictureBox()
        Me.pbMinimizar = New System.Windows.Forms.PictureBox()
        Me.pbMaximizar = New System.Windows.Forms.PictureBox()
        Me.pbCerrar = New System.Windows.Forms.PictureBox()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuMoverFormulario = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuMetroTextbox1 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.BunifuBordeForm = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.PanelLateralPrincipal = New System.Windows.Forms.Panel()
        Me.BunifuTextbox1 = New Bunifu.Framework.UI.BunifuTextbox()
        Me.BunifuCustomTextbox1 = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuMaterialTextbox1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.PanelSuperior.SuspendLayout()
        CType(Me.pbSideBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelSuperior
        '
        Me.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.PanelSuperior.Controls.Add(Me.pbSideBar)
        Me.PanelSuperior.Controls.Add(Me.pbRestaurar)
        Me.PanelSuperior.Controls.Add(Me.pbMinimizar)
        Me.PanelSuperior.Controls.Add(Me.pbMaximizar)
        Me.PanelSuperior.Controls.Add(Me.pbCerrar)
        Me.PanelSuperior.Controls.Add(Me.LblTitulo)
        Me.PanelSuperior.Controls.Add(Me.PictureBox1)
        Me.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanelSuperior.Name = "PanelSuperior"
        Me.PanelSuperior.Size = New System.Drawing.Size(950, 50)
        Me.PanelSuperior.TabIndex = 3
        '
        'pbSideBar
        '
        Me.pbSideBar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbSideBar.Image = CType(resources.GetObject("pbSideBar.Image"), System.Drawing.Image)
        Me.pbSideBar.Location = New System.Drawing.Point(180, 12)
        Me.pbSideBar.Name = "pbSideBar"
        Me.pbSideBar.Size = New System.Drawing.Size(30, 30)
        Me.pbSideBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbSideBar.TabIndex = 6
        Me.pbSideBar.TabStop = False
        '
        'pbRestaurar
        '
        Me.pbRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRestaurar.Image = CType(resources.GetObject("pbRestaurar.Image"), System.Drawing.Image)
        Me.pbRestaurar.Location = New System.Drawing.Point(872, 5)
        Me.pbRestaurar.Name = "pbRestaurar"
        Me.pbRestaurar.Size = New System.Drawing.Size(30, 30)
        Me.pbRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbRestaurar.TabIndex = 5
        Me.pbRestaurar.TabStop = False
        '
        'pbMinimizar
        '
        Me.pbMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbMinimizar.Image = CType(resources.GetObject("pbMinimizar.Image"), System.Drawing.Image)
        Me.pbMinimizar.Location = New System.Drawing.Point(836, 5)
        Me.pbMinimizar.Name = "pbMinimizar"
        Me.pbMinimizar.Size = New System.Drawing.Size(30, 30)
        Me.pbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbMinimizar.TabIndex = 4
        Me.pbMinimizar.TabStop = False
        '
        'pbMaximizar
        '
        Me.pbMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbMaximizar.Image = CType(resources.GetObject("pbMaximizar.Image"), System.Drawing.Image)
        Me.pbMaximizar.Location = New System.Drawing.Point(872, 5)
        Me.pbMaximizar.Name = "pbMaximizar"
        Me.pbMaximizar.Size = New System.Drawing.Size(30, 30)
        Me.pbMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbMaximizar.TabIndex = 3
        Me.pbMaximizar.TabStop = False
        '
        'pbCerrar
        '
        Me.pbCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbCerrar.Image = CType(resources.GetObject("pbCerrar.Image"), System.Drawing.Image)
        Me.pbCerrar.Location = New System.Drawing.Point(908, 5)
        Me.pbCerrar.Name = "pbCerrar"
        Me.pbCerrar.Size = New System.Drawing.Size(30, 30)
        Me.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbCerrar.TabIndex = 2
        Me.pbCerrar.TabStop = False
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.ForeColor = System.Drawing.Color.White
        Me.LblTitulo.Location = New System.Drawing.Point(58, 9)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(116, 34)
        Me.LblTitulo.TabIndex = 1
        Me.LblTitulo.Text = "Calendary"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BunifuMoverFormulario
        '
        Me.BunifuMoverFormulario.Fixed = True
        Me.BunifuMoverFormulario.Horizontal = True
        Me.BunifuMoverFormulario.TargetControl = Me.PanelSuperior
        Me.BunifuMoverFormulario.Vertical = True
        '
        'BunifuMetroTextbox1
        '
        Me.BunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.Blue
        Me.BunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.BunifuMetroTextbox1.BorderThickness = 1
        Me.BunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextbox1.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMetroTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox1.isPassword = False
        Me.BunifuMetroTextbox1.Location = New System.Drawing.Point(494, 70)
        Me.BunifuMetroTextbox1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BunifuMetroTextbox1.Name = "BunifuMetroTextbox1"
        Me.BunifuMetroTextbox1.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.BunifuMetroTextbox1.Size = New System.Drawing.Size(416, 40)
        Me.BunifuMetroTextbox1.TabIndex = 4
        Me.BunifuMetroTextbox1.Text = "Buscar..."
        Me.BunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(501, 75)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'BunifuBordeForm
        '
        Me.BunifuBordeForm.ElipseRadius = 7
        Me.BunifuBordeForm.TargetControl = Me
        '
        'PanelLateralPrincipal
        '
        Me.PanelLateralPrincipal.BackColor = System.Drawing.Color.MistyRose
        Me.PanelLateralPrincipal.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLateralPrincipal.Location = New System.Drawing.Point(0, 50)
        Me.PanelLateralPrincipal.Name = "PanelLateralPrincipal"
        Me.PanelLateralPrincipal.Size = New System.Drawing.Size(70, 550)
        Me.PanelLateralPrincipal.TabIndex = 5
        '
        'BunifuTextbox1
        '
        Me.BunifuTextbox1.BackColor = System.Drawing.Color.White
        Me.BunifuTextbox1.BackgroundImage = CType(resources.GetObject("BunifuTextbox1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTextbox1.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuTextbox1.Icon = CType(resources.GetObject("BunifuTextbox1.Icon"), System.Drawing.Image)
        Me.BunifuTextbox1.Location = New System.Drawing.Point(94, 132)
        Me.BunifuTextbox1.Margin = New System.Windows.Forms.Padding(0)
        Me.BunifuTextbox1.Name = "BunifuTextbox1"
        Me.BunifuTextbox1.Size = New System.Drawing.Size(417, 49)
        Me.BunifuTextbox1.TabIndex = 6
        Me.BunifuTextbox1.text = "Buscar..."
        '
        'BunifuCustomTextbox1
        '
        Me.BunifuCustomTextbox1.BorderColor = System.Drawing.Color.SeaGreen
        Me.BunifuCustomTextbox1.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomTextbox1.Location = New System.Drawing.Point(569, 151)
        Me.BunifuCustomTextbox1.Margin = New System.Windows.Forms.Padding(30, 3, 3, 3)
        Me.BunifuCustomTextbox1.Name = "BunifuCustomTextbox1"
        Me.BunifuCustomTextbox1.Size = New System.Drawing.Size(217, 30)
        Me.BunifuCustomTextbox1.TabIndex = 7
        Me.BunifuCustomTextbox1.Text = "Buscar..."
        '
        'BunifuMaterialTextbox1
        '
        Me.BunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextbox1.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty
        Me.BunifuMaterialTextbox1.HintText = ""
        Me.BunifuMaterialTextbox1.isPassword = False
        Me.BunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Blue
        Me.BunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.BunifuMaterialTextbox1.LineThickness = 5
        Me.BunifuMaterialTextbox1.Location = New System.Drawing.Point(304, 290)
        Me.BunifuMaterialTextbox1.Margin = New System.Windows.Forms.Padding(30, 1, 1, 1)
        Me.BunifuMaterialTextbox1.Name = "BunifuMaterialTextbox1"
        Me.BunifuMaterialTextbox1.Size = New System.Drawing.Size(416, 39)
        Me.BunifuMaterialTextbox1.TabIndex = 8
        Me.BunifuMaterialTextbox1.Text = "Buscar..."
        Me.BunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(950, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.BunifuMaterialTextbox1)
        Me.Controls.Add(Me.BunifuCustomTextbox1)
        Me.Controls.Add(Me.BunifuTextbox1)
        Me.Controls.Add(Me.PanelLateralPrincipal)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.BunifuMetroTextbox1)
        Me.Controls.Add(Me.PanelSuperior)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(950, 600)
        Me.Name = "FrmPrincipal"
        Me.Text = "FrmPrincipal"
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelSuperior.PerformLayout()
        CType(Me.pbSideBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelSuperior As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblTitulo As Label
    Friend WithEvents pbCerrar As PictureBox
    Friend WithEvents BunifuMoverFormulario As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuMetroTextbox1 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents BunifuBordeForm As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents PanelLateralPrincipal As Panel
    Friend WithEvents pbSideBar As PictureBox
    Friend WithEvents pbRestaurar As PictureBox
    Friend WithEvents pbMinimizar As PictureBox
    Friend WithEvents pbMaximizar As PictureBox
    Friend WithEvents BunifuTextbox1 As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents BunifuMaterialTextbox1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomTextbox1 As WindowsFormsControlLibrary1.BunifuCustomTextbox
End Class
