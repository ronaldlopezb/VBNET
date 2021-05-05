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
        Me.PanelMenuPrincipal = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnAbrirCerrar = New System.Windows.Forms.Button()
        Me.PanelMenuPrincipal.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMenuPrincipal
        '
        Me.PanelMenuPrincipal.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.PanelMenuPrincipal.Controls.Add(Me.Panel1)
        Me.PanelMenuPrincipal.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenuPrincipal.Name = "PanelMenuPrincipal"
        Me.PanelMenuPrincipal.Size = New System.Drawing.Size(250, 631)
        Me.PanelMenuPrincipal.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Info
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(250, 50)
        Me.Panel1.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkRed
        Me.Panel2.Controls.Add(Me.BtnAbrirCerrar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(250, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(720, 52)
        Me.Panel2.TabIndex = 3
        '
        'BtnAbrirCerrar
        '
        Me.BtnAbrirCerrar.Location = New System.Drawing.Point(6, 3)
        Me.BtnAbrirCerrar.Name = "BtnAbrirCerrar"
        Me.BtnAbrirCerrar.Size = New System.Drawing.Size(75, 46)
        Me.BtnAbrirCerrar.TabIndex = 4
        Me.BtnAbrirCerrar.Text = "Abrir/Cerrar"
        Me.BtnAbrirCerrar.UseVisualStyleBackColor = True
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(970, 631)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PanelMenuPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "FrmPrincipal"
        Me.Text = "FrmPrincipal"
        Me.PanelMenuPrincipal.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenuPrincipal As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnAbrirCerrar As Button
    Friend WithEvents Panel1 As Panel
End Class
