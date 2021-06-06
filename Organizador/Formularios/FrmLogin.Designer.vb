<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
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
        Me.LblLoginTitulo = New System.Windows.Forms.Label()
        Me.BtnIngresar = New System.Windows.Forms.Button()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.LblClave = New System.Windows.Forms.Label()
        Me.LblSubTitulo = New System.Windows.Forms.Label()
        Me.LblAutor = New System.Windows.Forms.Label()
        Me.PbLogin = New System.Windows.Forms.ProgressBar()
        Me.TimerLoading = New System.Windows.Forms.Timer(Me.components)
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.MoverFormulario = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.MoverFormularioTitulo = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.MoverFormularioSubTitulo = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuBorde = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.TxtUsuario = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.TxtClave = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.ImgLoading = New System.Windows.Forms.PictureBox()
        Me.BtnMinimizar = New System.Windows.Forms.Button()
        CType(Me.ImgLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblLoginTitulo
        '
        Me.LblLoginTitulo.AutoSize = True
        Me.LblLoginTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LblLoginTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblLoginTitulo.Font = New System.Drawing.Font("Calibri", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLoginTitulo.Location = New System.Drawing.Point(12, 9)
        Me.LblLoginTitulo.Name = "LblLoginTitulo"
        Me.LblLoginTitulo.Size = New System.Drawing.Size(383, 45)
        Me.LblLoginTitulo.TabIndex = 0
        Me.LblLoginTitulo.Text = "Bienvenido a Calendary"
        '
        'BtnIngresar
        '
        Me.BtnIngresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnIngresar.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIngresar.ForeColor = System.Drawing.Color.White
        Me.BtnIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnIngresar.Location = New System.Drawing.Point(567, 310)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.Size = New System.Drawing.Size(257, 48)
        Me.BtnIngresar.TabIndex = 3
        Me.BtnIngresar.Text = "Ingresar al sistema"
        Me.BtnIngresar.UseVisualStyleBackColor = False
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.BackColor = System.Drawing.Color.Transparent
        Me.LblUsuario.Font = New System.Drawing.Font("Calibri", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuario.Location = New System.Drawing.Point(651, 142)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(71, 23)
        Me.LblUsuario.TabIndex = 4
        Me.LblUsuario.Text = "Usuario"
        '
        'LblClave
        '
        Me.LblClave.AutoSize = True
        Me.LblClave.BackColor = System.Drawing.Color.Transparent
        Me.LblClave.Font = New System.Drawing.Font("Calibri", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblClave.Location = New System.Drawing.Point(635, 221)
        Me.LblClave.Name = "LblClave"
        Me.LblClave.Size = New System.Drawing.Size(100, 23)
        Me.LblClave.TabIndex = 6
        Me.LblClave.Text = "Contraseña"
        '
        'LblSubTitulo
        '
        Me.LblSubTitulo.AutoSize = True
        Me.LblSubTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LblSubTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblSubTitulo.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubTitulo.Location = New System.Drawing.Point(73, 54)
        Me.LblSubTitulo.Name = "LblSubTitulo"
        Me.LblSubTitulo.Size = New System.Drawing.Size(261, 19)
        Me.LblSubTitulo.TabIndex = 7
        Me.LblSubTitulo.Text = "Organízate y toma el control de tu vida"
        '
        'LblAutor
        '
        Me.LblAutor.AutoSize = True
        Me.LblAutor.BackColor = System.Drawing.Color.Transparent
        Me.LblAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblAutor.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAutor.Location = New System.Drawing.Point(500, 499)
        Me.LblAutor.Name = "LblAutor"
        Me.LblAutor.Size = New System.Drawing.Size(367, 23)
        Me.LblAutor.TabIndex = 8
        Me.LblAutor.Text = "Desarrollado por Ronald López. @0000 MasterhostPeru"
        '
        'PbLogin
        '
        Me.PbLogin.Location = New System.Drawing.Point(532, 468)
        Me.PbLogin.Name = "PbLogin"
        Me.PbLogin.Size = New System.Drawing.Size(320, 23)
        Me.PbLogin.Step = 1
        Me.PbLogin.TabIndex = 9
        Me.PbLogin.Visible = False
        '
        'TimerLoading
        '
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackColor = System.Drawing.Color.Transparent
        Me.BtnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.Location = New System.Drawing.Point(829, 9)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(23, 23)
        Me.BtnCerrar.TabIndex = 12
        Me.BtnCerrar.Text = "X"
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'MoverFormulario
        '
        Me.MoverFormulario.Fixed = True
        Me.MoverFormulario.Horizontal = True
        Me.MoverFormulario.TargetControl = Me
        Me.MoverFormulario.Vertical = True
        '
        'MoverFormularioTitulo
        '
        Me.MoverFormularioTitulo.Fixed = True
        Me.MoverFormularioTitulo.Horizontal = True
        Me.MoverFormularioTitulo.TargetControl = Me.LblLoginTitulo
        Me.MoverFormularioTitulo.Vertical = True
        '
        'MoverFormularioSubTitulo
        '
        Me.MoverFormularioSubTitulo.Fixed = True
        Me.MoverFormularioSubTitulo.Horizontal = True
        Me.MoverFormularioSubTitulo.TargetControl = Me.LblSubTitulo
        Me.MoverFormularioSubTitulo.Vertical = True
        '
        'BunifuBorde
        '
        Me.BunifuBorde.ElipseRadius = 7
        Me.BunifuBorde.TargetControl = Me
        '
        'TxtUsuario
        '
        Me.TxtUsuario.BorderColor = System.Drawing.Color.SeaGreen
        Me.TxtUsuario.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsuario.Location = New System.Drawing.Point(567, 168)
        Me.TxtUsuario.Margin = New System.Windows.Forms.Padding(30, 3, 3, 3)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(246, 30)
        Me.TxtUsuario.TabIndex = 13
        Me.TxtUsuario.Text = "RonaldLopezB"
        '
        'TxtClave
        '
        Me.TxtClave.BorderColor = System.Drawing.Color.SeaGreen
        Me.TxtClave.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClave.Location = New System.Drawing.Point(567, 247)
        Me.TxtClave.Name = "TxtClave"
        Me.TxtClave.Size = New System.Drawing.Size(246, 24)
        Me.TxtClave.TabIndex = 14
        Me.TxtClave.Text = "Sraonndarl817"
        Me.TxtClave.UseSystemPasswordChar = True
        '
        'ImgLoading
        '
        Me.ImgLoading.BackColor = System.Drawing.Color.Transparent
        Me.ImgLoading.Image = Global.Calendary.My.Resources.Resources.Spinner_1s_200px
        Me.ImgLoading.Location = New System.Drawing.Point(648, 385)
        Me.ImgLoading.Name = "ImgLoading"
        Me.ImgLoading.Size = New System.Drawing.Size(100, 100)
        Me.ImgLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgLoading.TabIndex = 11
        Me.ImgLoading.TabStop = False
        Me.ImgLoading.Visible = False
        '
        'BtnMinimizar
        '
        Me.BtnMinimizar.BackColor = System.Drawing.Color.Transparent
        Me.BtnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnMinimizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMinimizar.Location = New System.Drawing.Point(801, 9)
        Me.BtnMinimizar.Name = "BtnMinimizar"
        Me.BtnMinimizar.Size = New System.Drawing.Size(23, 23)
        Me.BtnMinimizar.TabIndex = 16
        Me.BtnMinimizar.Text = "-"
        Me.BtnMinimizar.UseVisualStyleBackColor = False
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImage = Global.Calendary.My.Resources.Resources.back02
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(864, 521)
        Me.Controls.Add(Me.BtnMinimizar)
        Me.Controls.Add(Me.TxtClave)
        Me.Controls.Add(Me.TxtUsuario)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.ImgLoading)
        Me.Controls.Add(Me.PbLogin)
        Me.Controls.Add(Me.LblAutor)
        Me.Controls.Add(Me.LblSubTitulo)
        Me.Controls.Add(Me.LblClave)
        Me.Controls.Add(Me.LblUsuario)
        Me.Controls.Add(Me.BtnIngresar)
        Me.Controls.Add(Me.LblLoginTitulo)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calendary - Identificación de Usuario"
        CType(Me.ImgLoading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblLoginTitulo As Label
    Friend WithEvents BtnIngresar As Button
    Friend WithEvents LblUsuario As Label
    Friend WithEvents LblClave As Label
    Friend WithEvents LblSubTitulo As Label
    Friend WithEvents LblAutor As Label
    Friend WithEvents PbLogin As ProgressBar
    Friend WithEvents TimerLoading As Timer
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents MoverFormulario As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents MoverFormularioTitulo As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents MoverFormularioSubTitulo As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuBorde As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents TxtClave As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents ImgLoading As PictureBox
    Public WithEvents TxtUsuario As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BtnMinimizar As Button
End Class
