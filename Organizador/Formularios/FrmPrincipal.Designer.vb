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
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.BunifuMoverFormulario = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuBordeForm = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.tmOcultarSidebar = New System.Windows.Forms.Timer(Me.components)
        Me.tmMostrarSideBar = New System.Windows.Forms.Timer(Me.components)
        Me.tmMostrarNotificaciones = New System.Windows.Forms.Timer(Me.components)
        Me.tmOcultarNotificacinoes = New System.Windows.Forms.Timer(Me.components)
        Me.pbNotificaciones = New System.Windows.Forms.PictureBox()
        Me.pbSideBar = New System.Windows.Forms.PictureBox()
        Me.pbRestaurar = New System.Windows.Forms.PictureBox()
        Me.pbMinimizar = New System.Windows.Forms.PictureBox()
        Me.pbMaximizar = New System.Windows.Forms.PictureBox()
        Me.pbCerrar = New System.Windows.Forms.PictureBox()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.TxtBuscadorGeneral2 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PanelNotificaciones = New System.Windows.Forms.Panel()
        Me.BtnContactos = New System.Windows.Forms.Button()
        Me.BtnCalendario = New System.Windows.Forms.Button()
        Me.BtnNotas = New System.Windows.Forms.Button()
        Me.BtnEnlaces = New System.Windows.Forms.Button()
        Me.LblLinea = New System.Windows.Forms.Label()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.BtnProyectos = New System.Windows.Forms.Button()
        Me.pbInicialUsuario = New System.Windows.Forms.PictureBox()
        Me.LblInicialUsuario = New System.Windows.Forms.Label()
        Me.BtnConfiguracion = New System.Windows.Forms.Button()
        Me.PanelLateralPrincipal = New System.Windows.Forms.Panel()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.PanelFormularios = New System.Windows.Forms.Panel()
        Me.PanelSuperior.SuspendLayout()
        CType(Me.pbNotificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSideBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelNotificaciones.SuspendLayout()
        CType(Me.pbInicialUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelLateralPrincipal.SuspendLayout()
        Me.PanelFormularios.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelSuperior
        '
        Me.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.PanelSuperior.Controls.Add(Me.pbNotificaciones)
        Me.PanelSuperior.Controls.Add(Me.TxtBuscadorGeneral2)
        Me.PanelSuperior.Controls.Add(Me.pbSideBar)
        Me.PanelSuperior.Controls.Add(Me.pbRestaurar)
        Me.PanelSuperior.Controls.Add(Me.pbMinimizar)
        Me.PanelSuperior.Controls.Add(Me.pbMaximizar)
        Me.PanelSuperior.Controls.Add(Me.pbCerrar)
        Me.PanelSuperior.Controls.Add(Me.LblTitulo)
        Me.PanelSuperior.Controls.Add(Me.pbLogo)
        Me.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanelSuperior.Name = "PanelSuperior"
        Me.PanelSuperior.Size = New System.Drawing.Size(1100, 50)
        Me.PanelSuperior.TabIndex = 3
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
        'BunifuMoverFormulario
        '
        Me.BunifuMoverFormulario.Fixed = True
        Me.BunifuMoverFormulario.Horizontal = True
        Me.BunifuMoverFormulario.TargetControl = Me.PanelSuperior
        Me.BunifuMoverFormulario.Vertical = True
        '
        'BunifuBordeForm
        '
        Me.BunifuBordeForm.ElipseRadius = 7
        Me.BunifuBordeForm.TargetControl = Me
        '
        'tmOcultarSidebar
        '
        Me.tmOcultarSidebar.Interval = 15
        '
        'tmMostrarSideBar
        '
        Me.tmMostrarSideBar.Interval = 15
        '
        'tmMostrarNotificaciones
        '
        Me.tmMostrarNotificaciones.Interval = 15
        '
        'tmOcultarNotificacinoes
        '
        Me.tmOcultarNotificacinoes.Interval = 15
        '
        'pbNotificaciones
        '
        Me.pbNotificaciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbNotificaciones.Image = CType(resources.GetObject("pbNotificaciones.Image"), System.Drawing.Image)
        Me.pbNotificaciones.Location = New System.Drawing.Point(232, 12)
        Me.pbNotificaciones.Name = "pbNotificaciones"
        Me.pbNotificaciones.Size = New System.Drawing.Size(30, 30)
        Me.pbNotificaciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbNotificaciones.TabIndex = 12
        Me.pbNotificaciones.TabStop = False
        '
        'pbSideBar
        '
        Me.pbSideBar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbSideBar.Image = CType(resources.GetObject("pbSideBar.Image"), System.Drawing.Image)
        Me.pbSideBar.Location = New System.Drawing.Point(194, 12)
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
        Me.pbRestaurar.Location = New System.Drawing.Point(1022, 5)
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
        Me.pbMinimizar.Location = New System.Drawing.Point(986, 5)
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
        Me.pbMaximizar.Location = New System.Drawing.Point(1022, 5)
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
        Me.pbCerrar.Location = New System.Drawing.Point(1058, 5)
        Me.pbCerrar.Name = "pbCerrar"
        Me.pbCerrar.Size = New System.Drawing.Size(30, 30)
        Me.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbCerrar.TabIndex = 2
        Me.pbCerrar.TabStop = False
        '
        'pbLogo
        '
        Me.pbLogo.Image = CType(resources.GetObject("pbLogo.Image"), System.Drawing.Image)
        Me.pbLogo.Location = New System.Drawing.Point(12, 5)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(40, 40)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbLogo.TabIndex = 0
        Me.pbLogo.TabStop = False
        '
        'TxtBuscadorGeneral2
        '
        Me.TxtBuscadorGeneral2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBuscadorGeneral2.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscadorGeneral2.ForeColor = System.Drawing.Color.White
        Me.TxtBuscadorGeneral2.HintForeColor = System.Drawing.Color.White
        Me.TxtBuscadorGeneral2.HintText = "Buscador..."
        Me.TxtBuscadorGeneral2.isPassword = False
        Me.TxtBuscadorGeneral2.LineFocusedColor = System.Drawing.Color.Lavender
        Me.TxtBuscadorGeneral2.LineIdleColor = System.Drawing.Color.White
        Me.TxtBuscadorGeneral2.LineMouseHoverColor = System.Drawing.Color.Lavender
        Me.TxtBuscadorGeneral2.LineThickness = 4
        Me.TxtBuscadorGeneral2.Location = New System.Drawing.Point(274, 12)
        Me.TxtBuscadorGeneral2.Margin = New System.Windows.Forms.Padding(34, 1, 1, 1)
        Me.TxtBuscadorGeneral2.Name = "TxtBuscadorGeneral2"
        Me.TxtBuscadorGeneral2.Size = New System.Drawing.Size(186, 34)
        Me.TxtBuscadorGeneral2.TabIndex = 11
        Me.TxtBuscadorGeneral2.TabStop = False
        Me.TxtBuscadorGeneral2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.MistyRose
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(204, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(23, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PanelNotificaciones
        '
        Me.PanelNotificaciones.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanelNotificaciones.BackColor = System.Drawing.Color.Gainsboro
        Me.PanelNotificaciones.Controls.Add(Me.Button1)
        Me.PanelNotificaciones.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelNotificaciones.Location = New System.Drawing.Point(230, 50)
        Me.PanelNotificaciones.Name = "PanelNotificaciones"
        Me.PanelNotificaciones.Size = New System.Drawing.Size(0, 600)
        Me.PanelNotificaciones.TabIndex = 21
        '
        'BtnContactos
        '
        Me.BtnContactos.FlatAppearance.BorderSize = 0
        Me.BtnContactos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnContactos.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnContactos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnContactos.Image = CType(resources.GetObject("BtnContactos.Image"), System.Drawing.Image)
        Me.BtnContactos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnContactos.Location = New System.Drawing.Point(10, 143)
        Me.BtnContactos.Name = "BtnContactos"
        Me.BtnContactos.Size = New System.Drawing.Size(210, 45)
        Me.BtnContactos.TabIndex = 10
        Me.BtnContactos.Text = "               Contactos"
        Me.BtnContactos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnContactos.UseVisualStyleBackColor = True
        '
        'BtnCalendario
        '
        Me.BtnCalendario.FlatAppearance.BorderSize = 0
        Me.BtnCalendario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCalendario.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalendario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnCalendario.Image = CType(resources.GetObject("BtnCalendario.Image"), System.Drawing.Image)
        Me.BtnCalendario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCalendario.Location = New System.Drawing.Point(10, 204)
        Me.BtnCalendario.Name = "BtnCalendario"
        Me.BtnCalendario.Size = New System.Drawing.Size(210, 45)
        Me.BtnCalendario.TabIndex = 12
        Me.BtnCalendario.Text = "               Calendario"
        Me.BtnCalendario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCalendario.UseVisualStyleBackColor = True
        '
        'BtnNotas
        '
        Me.BtnNotas.FlatAppearance.BorderSize = 0
        Me.BtnNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNotas.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNotas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnNotas.Image = CType(resources.GetObject("BtnNotas.Image"), System.Drawing.Image)
        Me.BtnNotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNotas.Location = New System.Drawing.Point(10, 265)
        Me.BtnNotas.Name = "BtnNotas"
        Me.BtnNotas.Size = New System.Drawing.Size(210, 45)
        Me.BtnNotas.TabIndex = 13
        Me.BtnNotas.Text = "               Notas"
        Me.BtnNotas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNotas.UseVisualStyleBackColor = True
        '
        'BtnEnlaces
        '
        Me.BtnEnlaces.FlatAppearance.BorderSize = 0
        Me.BtnEnlaces.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEnlaces.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEnlaces.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnEnlaces.Image = CType(resources.GetObject("BtnEnlaces.Image"), System.Drawing.Image)
        Me.BtnEnlaces.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEnlaces.Location = New System.Drawing.Point(10, 326)
        Me.BtnEnlaces.Name = "BtnEnlaces"
        Me.BtnEnlaces.Size = New System.Drawing.Size(210, 45)
        Me.BtnEnlaces.TabIndex = 14
        Me.BtnEnlaces.Text = "               Enlaces"
        Me.BtnEnlaces.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEnlaces.UseVisualStyleBackColor = True
        '
        'LblLinea
        '
        Me.LblLinea.AutoSize = True
        Me.LblLinea.BackColor = System.Drawing.Color.Transparent
        Me.LblLinea.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLinea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.LblLinea.Location = New System.Drawing.Point(2, 29)
        Me.LblLinea.Name = "LblLinea"
        Me.LblLinea.Size = New System.Drawing.Size(225, 19)
        Me.LblLinea.TabIndex = 16
        Me.LblLinea.Text = "................................................................................." &
    "..........................."
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblUsuario.Location = New System.Drawing.Point(12, 12)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(90, 28)
        Me.LblUsuario.TabIndex = 7
        Me.LblUsuario.Text = "Hola, User"
        '
        'BtnProyectos
        '
        Me.BtnProyectos.FlatAppearance.BorderSize = 0
        Me.BtnProyectos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProyectos.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProyectos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnProyectos.Image = CType(resources.GetObject("BtnProyectos.Image"), System.Drawing.Image)
        Me.BtnProyectos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnProyectos.Location = New System.Drawing.Point(10, 82)
        Me.BtnProyectos.Name = "BtnProyectos"
        Me.BtnProyectos.Size = New System.Drawing.Size(210, 45)
        Me.BtnProyectos.TabIndex = 15
        Me.BtnProyectos.Text = "               Proyectos"
        Me.BtnProyectos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnProyectos.UseVisualStyleBackColor = True
        '
        'pbInicialUsuario
        '
        Me.pbInicialUsuario.BackColor = System.Drawing.Color.Transparent
        Me.pbInicialUsuario.Image = CType(resources.GetObject("pbInicialUsuario.Image"), System.Drawing.Image)
        Me.pbInicialUsuario.Location = New System.Drawing.Point(8, 11)
        Me.pbInicialUsuario.Name = "pbInicialUsuario"
        Me.pbInicialUsuario.Size = New System.Drawing.Size(53, 53)
        Me.pbInicialUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbInicialUsuario.TabIndex = 18
        Me.pbInicialUsuario.TabStop = False
        Me.pbInicialUsuario.Visible = False
        '
        'LblInicialUsuario
        '
        Me.LblInicialUsuario.BackColor = System.Drawing.Color.White
        Me.LblInicialUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblInicialUsuario.Font = New System.Drawing.Font("Poppins Medium", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInicialUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblInicialUsuario.Location = New System.Drawing.Point(18, 16)
        Me.LblInicialUsuario.Name = "LblInicialUsuario"
        Me.LblInicialUsuario.Size = New System.Drawing.Size(29, 34)
        Me.LblInicialUsuario.TabIndex = 0
        Me.LblInicialUsuario.Text = "X"
        '
        'BtnConfiguracion
        '
        Me.BtnConfiguracion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnConfiguracion.FlatAppearance.BorderSize = 0
        Me.BtnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConfiguracion.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfiguracion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnConfiguracion.Image = CType(resources.GetObject("BtnConfiguracion.Image"), System.Drawing.Image)
        Me.BtnConfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnConfiguracion.Location = New System.Drawing.Point(10, 549)
        Me.BtnConfiguracion.Name = "BtnConfiguracion"
        Me.BtnConfiguracion.Size = New System.Drawing.Size(210, 45)
        Me.BtnConfiguracion.TabIndex = 19
        Me.BtnConfiguracion.Text = "               Configuración"
        Me.BtnConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnConfiguracion.UseVisualStyleBackColor = True
        '
        'PanelLateralPrincipal
        '
        Me.PanelLateralPrincipal.BackColor = System.Drawing.Color.MistyRose
        Me.PanelLateralPrincipal.Controls.Add(Me.BtnConfiguracion)
        Me.PanelLateralPrincipal.Controls.Add(Me.LblInicialUsuario)
        Me.PanelLateralPrincipal.Controls.Add(Me.pbInicialUsuario)
        Me.PanelLateralPrincipal.Controls.Add(Me.BtnProyectos)
        Me.PanelLateralPrincipal.Controls.Add(Me.LblUsuario)
        Me.PanelLateralPrincipal.Controls.Add(Me.LblLinea)
        Me.PanelLateralPrincipal.Controls.Add(Me.BtnEnlaces)
        Me.PanelLateralPrincipal.Controls.Add(Me.BtnNotas)
        Me.PanelLateralPrincipal.Controls.Add(Me.BtnCalendario)
        Me.PanelLateralPrincipal.Controls.Add(Me.BtnContactos)
        Me.PanelLateralPrincipal.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLateralPrincipal.Location = New System.Drawing.Point(0, 50)
        Me.PanelLateralPrincipal.Name = "PanelLateralPrincipal"
        Me.PanelLateralPrincipal.Size = New System.Drawing.Size(230, 600)
        Me.PanelLateralPrincipal.TabIndex = 5
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.BackColor = System.Drawing.Color.MistyRose
        Me.BtnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.ForeColor = System.Drawing.Color.Black
        Me.BtnCerrar.Location = New System.Drawing.Point(1074, 1)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(23, 23)
        Me.BtnCerrar.TabIndex = 20
        Me.BtnCerrar.Text = "X"
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'PanelFormularios
        '
        Me.PanelFormularios.AutoSize = True
        Me.PanelFormularios.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanelFormularios.BackColor = System.Drawing.Color.White
        Me.PanelFormularios.Controls.Add(Me.BtnCerrar)
        Me.PanelFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormularios.Location = New System.Drawing.Point(230, 50)
        Me.PanelFormularios.Name = "PanelFormularios"
        Me.PanelFormularios.Size = New System.Drawing.Size(870, 600)
        Me.PanelFormularios.TabIndex = 6
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1100, 650)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelNotificaciones)
        Me.Controls.Add(Me.PanelFormularios)
        Me.Controls.Add(Me.PanelLateralPrincipal)
        Me.Controls.Add(Me.PanelSuperior)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(950, 600)
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPrincipal"
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelSuperior.PerformLayout()
        CType(Me.pbNotificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSideBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelNotificaciones.ResumeLayout(False)
        CType(Me.pbInicialUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelLateralPrincipal.ResumeLayout(False)
        Me.PanelLateralPrincipal.PerformLayout()
        Me.PanelFormularios.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelSuperior As Panel
    Friend WithEvents LblTitulo As Label
    Friend WithEvents pbCerrar As PictureBox
    Friend WithEvents BunifuMoverFormulario As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuBordeForm As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents pbSideBar As PictureBox
    Friend WithEvents pbRestaurar As PictureBox
    Friend WithEvents pbMinimizar As PictureBox
    Friend WithEvents pbMaximizar As PictureBox
    Friend WithEvents tmOcultarSidebar As Timer
    Friend WithEvents tmMostrarSideBar As Timer
    Friend WithEvents pbNotificaciones As PictureBox
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents tmMostrarNotificaciones As Timer
    Friend WithEvents tmOcultarNotificacinoes As Timer
    Friend WithEvents TxtBuscadorGeneral2 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents PanelNotificaciones As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents PanelLateralPrincipal As Panel
    Friend WithEvents BtnConfiguracion As Button
    Friend WithEvents LblInicialUsuario As Label
    Friend WithEvents pbInicialUsuario As PictureBox
    Friend WithEvents BtnProyectos As Button
    Friend WithEvents LblUsuario As Label
    Friend WithEvents LblLinea As Label
    Friend WithEvents BtnEnlaces As Button
    Friend WithEvents BtnNotas As Button
    Friend WithEvents BtnCalendario As Button
    Friend WithEvents BtnContactos As Button
    Friend WithEvents PanelFormularios As Panel
    Friend WithEvents BtnCerrar As Button
End Class
