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
        Me.pbCerrar = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuMoverFormulario = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuMetroTextbox1 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.BunifuBordeForm = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.PanelLateralPrincipal = New System.Windows.Forms.Panel()
        Me.pbSideBar = New System.Windows.Forms.PictureBox()
        Me.PanelSuperior.SuspendLayout()
        CType(Me.pbCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSideBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelSuperior
        '
        Me.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.PanelSuperior.Controls.Add(Me.pbCerrar)
        Me.PanelSuperior.Controls.Add(Me.Label1)
        Me.PanelSuperior.Controls.Add(Me.PictureBox1)
        Me.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanelSuperior.Name = "PanelSuperior"
        Me.PanelSuperior.Size = New System.Drawing.Size(950, 50)
        Me.PanelSuperior.TabIndex = 3
        '
        'pbCerrar
        '
        Me.pbCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbCerrar.Image = CType(resources.GetObject("pbCerrar.Image"), System.Drawing.Image)
        Me.pbCerrar.Location = New System.Drawing.Point(908, 5)
        Me.pbCerrar.Name = "pbCerrar"
        Me.pbCerrar.Size = New System.Drawing.Size(30, 30)
        Me.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbCerrar.TabIndex = 2
        Me.pbCerrar.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(67, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Calendary"
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
        'pbSideBar
        '
        Me.pbSideBar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbSideBar.Image = CType(resources.GetObject("pbSideBar.Image"), System.Drawing.Image)
        Me.pbSideBar.Location = New System.Drawing.Point(54, 56)
        Me.pbSideBar.Name = "pbSideBar"
        Me.pbSideBar.Size = New System.Drawing.Size(30, 30)
        Me.pbSideBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbSideBar.TabIndex = 6
        Me.pbSideBar.TabStop = False
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(950, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.pbSideBar)
        Me.Controls.Add(Me.PanelLateralPrincipal)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.BunifuMetroTextbox1)
        Me.Controls.Add(Me.PanelSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(950, 600)
        Me.Name = "FrmPrincipal"
        Me.Text = "FrmPrincipal"
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelSuperior.PerformLayout()
        CType(Me.pbCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSideBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelSuperior As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pbCerrar As PictureBox
    Friend WithEvents BunifuMoverFormulario As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuMetroTextbox1 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents BunifuBordeForm As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents PanelLateralPrincipal As Panel
    Friend WithEvents pbSideBar As PictureBox
End Class
