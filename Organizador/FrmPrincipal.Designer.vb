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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.PanelMenuPrincipal = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.LblLoginTitulo = New System.Windows.Forms.Label()
        Me.PanelSuperior = New System.Windows.Forms.Panel()
        Me.BtnRestaurarVentana = New System.Windows.Forms.Button()
        Me.BtnMaximizarVentana = New System.Windows.Forms.Button()
        Me.BtnMinimizarVentana = New System.Windows.Forms.Button()
        Me.BtnCerrarVentana = New System.Windows.Forms.Button()
        Me.BtnAbrirCerrar = New System.Windows.Forms.Button()
        Me.PanelMenuPrincipal.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        Me.PanelSuperior.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMenuPrincipal
        '
        Me.PanelMenuPrincipal.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.PanelMenuPrincipal.Controls.Add(Me.Button1)
        Me.PanelMenuPrincipal.Controls.Add(Me.PanelLogo)
        Me.PanelMenuPrincipal.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenuPrincipal.Name = "PanelMenuPrincipal"
        Me.PanelMenuPrincipal.Size = New System.Drawing.Size(230, 670)
        Me.PanelMenuPrincipal.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.AutoEllipsis = True
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(0, 83)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(230, 49)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Proyectos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.PanelLogo.Controls.Add(Me.LblLoginTitulo)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(230, 50)
        Me.PanelLogo.TabIndex = 5
        '
        'LblLoginTitulo
        '
        Me.LblLoginTitulo.AutoSize = True
        Me.LblLoginTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LblLoginTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblLoginTitulo.Font = New System.Drawing.Font("Calibri", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLoginTitulo.ForeColor = System.Drawing.Color.White
        Me.LblLoginTitulo.Location = New System.Drawing.Point(3, 2)
        Me.LblLoginTitulo.Name = "LblLoginTitulo"
        Me.LblLoginTitulo.Size = New System.Drawing.Size(176, 45)
        Me.LblLoginTitulo.TabIndex = 1
        Me.LblLoginTitulo.Text = "Calendary"
        '
        'PanelSuperior
        '
        Me.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.PanelSuperior.Controls.Add(Me.BtnRestaurarVentana)
        Me.PanelSuperior.Controls.Add(Me.BtnMaximizarVentana)
        Me.PanelSuperior.Controls.Add(Me.BtnMinimizarVentana)
        Me.PanelSuperior.Controls.Add(Me.BtnCerrarVentana)
        Me.PanelSuperior.Controls.Add(Me.BtnAbrirCerrar)
        Me.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperior.Location = New System.Drawing.Point(230, 0)
        Me.PanelSuperior.Name = "PanelSuperior"
        Me.PanelSuperior.Size = New System.Drawing.Size(894, 50)
        Me.PanelSuperior.TabIndex = 3
        '
        'BtnRestaurarVentana
        '
        Me.BtnRestaurarVentana.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRestaurarVentana.Image = CType(resources.GetObject("BtnRestaurarVentana.Image"), System.Drawing.Image)
        Me.BtnRestaurarVentana.Location = New System.Drawing.Point(787, 8)
        Me.BtnRestaurarVentana.Name = "BtnRestaurarVentana"
        Me.BtnRestaurarVentana.Size = New System.Drawing.Size(25, 25)
        Me.BtnRestaurarVentana.TabIndex = 12
        Me.BtnRestaurarVentana.UseVisualStyleBackColor = True
        '
        'BtnMaximizarVentana
        '
        Me.BtnMaximizarVentana.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMaximizarVentana.BackColor = System.Drawing.Color.Transparent
        Me.BtnMaximizarVentana.Image = CType(resources.GetObject("BtnMaximizarVentana.Image"), System.Drawing.Image)
        Me.BtnMaximizarVentana.Location = New System.Drawing.Point(817, 8)
        Me.BtnMaximizarVentana.Name = "BtnMaximizarVentana"
        Me.BtnMaximizarVentana.Size = New System.Drawing.Size(25, 25)
        Me.BtnMaximizarVentana.TabIndex = 11
        Me.BtnMaximizarVentana.UseVisualStyleBackColor = False
        '
        'BtnMinimizarVentana
        '
        Me.BtnMinimizarVentana.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMinimizarVentana.Image = Global.Calendary.My.Resources.Resources.BtnMinimizar
        Me.BtnMinimizarVentana.Location = New System.Drawing.Point(758, 8)
        Me.BtnMinimizarVentana.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnMinimizarVentana.Name = "BtnMinimizarVentana"
        Me.BtnMinimizarVentana.Size = New System.Drawing.Size(25, 25)
        Me.BtnMinimizarVentana.TabIndex = 10
        Me.BtnMinimizarVentana.UseVisualStyleBackColor = True
        '
        'BtnCerrarVentana
        '
        Me.BtnCerrarVentana.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrarVentana.BackColor = System.Drawing.Color.Transparent
        Me.BtnCerrarVentana.FlatAppearance.BorderSize = 0
        Me.BtnCerrarVentana.Image = Global.Calendary.My.Resources.Resources.BtnCerrar
        Me.BtnCerrarVentana.Location = New System.Drawing.Point(848, 8)
        Me.BtnCerrarVentana.Name = "BtnCerrarVentana"
        Me.BtnCerrarVentana.Size = New System.Drawing.Size(25, 25)
        Me.BtnCerrarVentana.TabIndex = 9
        Me.BtnCerrarVentana.UseVisualStyleBackColor = False
        '
        'BtnAbrirCerrar
        '
        Me.BtnAbrirCerrar.Location = New System.Drawing.Point(6, 16)
        Me.BtnAbrirCerrar.Name = "BtnAbrirCerrar"
        Me.BtnAbrirCerrar.Size = New System.Drawing.Size(75, 31)
        Me.BtnAbrirCerrar.TabIndex = 4
        Me.BtnAbrirCerrar.Text = "Abrir/Cerrar"
        Me.BtnAbrirCerrar.UseVisualStyleBackColor = True
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 631)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelSuperior)
        Me.Controls.Add(Me.PanelMenuPrincipal)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(1124, 670)
        Me.Name = "FrmPrincipal"
        Me.Text = "FrmPrincipal"
        Me.PanelMenuPrincipal.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        Me.PanelLogo.PerformLayout()
        Me.PanelSuperior.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenuPrincipal As Panel
    Friend WithEvents PanelSuperior As Panel
    Friend WithEvents BtnAbrirCerrar As Button
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents BtnMinimizarVentana As Button
    Friend WithEvents BtnCerrarVentana As Button
    Friend WithEvents BtnMaximizarVentana As Button
    Friend WithEvents BtnRestaurarVentana As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents LblLoginTitulo As Label
End Class
