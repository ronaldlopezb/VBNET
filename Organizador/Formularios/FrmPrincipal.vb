Imports System.Runtime.InteropServices

Public Class FrmPrincipal
    'Tamaño del Form -> Restaurar tamaño del form
    Dim lx, ly As Integer
    Dim sw, sh As Integer
    Dim FormMax As Boolean

    'Load
    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lx = Me.Location.X
        ly = Me.Location.Y
        sw = Me.Size.Width
        sh = Me.Size.Height
        FormMax = False
        pbRestaurar.Visible = False
        pbMaximizar.Visible = True

        ''Nombre del Usuario Logeado
        LblUsuario.Text = "Hola, " + UserName
        LblInicialUsuario.Text = UserInitial
        pbInicialUsuario.Visible = False
        LblInicialUsuario.Visible = False

        ''Notificaciones
        FrmNotificaciones.TopLevel = False
        FrmNotificaciones.Dock = DockStyle.Fill
        PanelNotificaciones.Controls.Add(FrmNotificaciones)
        PanelNotificaciones.Tag = FrmNotificaciones
        FrmNotificaciones.Show()
        FrmNotificaciones.BringToFront()
    End Sub

    'Maximizar el formulario con Doble Click
    Private Sub PanelSuperior_DoubleClick(sender As Object, e As EventArgs) Handles PanelSuperior.DoubleClick
        If FormMax = True Then
            Me.Size = New Size(sw, sh)
            Me.Location = New Point(lx, ly)
            FormMax = False
            pbRestaurar.Visible = False
            pbMaximizar.Visible = True
        Else
            lx = Me.Location.X
            ly = Me.Location.Y
            sw = Me.Size.Width
            sh = Me.Size.Height
            FormMax = True

            'Maximizamos diciendo que abarque el tamaño de la pantalla
            Me.Size = Screen.PrimaryScreen.WorkingArea.Size
            Me.Location = Screen.PrimaryScreen.WorkingArea.Location
            pbMaximizar.Visible = False
            pbRestaurar.Visible = True
        End If
    End Sub

    'SideBar efecto
    Private Sub pbSideBar_Click_1(sender As Object, e As EventArgs) Handles pbSideBar.Click
        If PanelLateralPrincipal.Width = 230 Then
            tmOcultarSidebar.Enabled = True
            pbInicialUsuario.Visible = True
            LblInicialUsuario.Visible = True
            LblLinea.Visible = False
            LblUsuario.Visible = False
        ElseIf PanelLateralPrincipal.Width = 70 Then
            tmMostrarSideBar.Enabled = True
            pbInicialUsuario.Visible = False
            LblInicialUsuario.Visible = False
            LblLinea.Visible = True
            LblUsuario.Visible = True
        End If
    End Sub

    Private Sub tmOcultar_Tick(sender As Object, e As EventArgs) Handles tmOcultarSidebar.Tick
        If PanelLateralPrincipal.Width <= 70 Then
            Me.tmOcultarSidebar.Enabled = False
        Else
            Me.PanelLateralPrincipal.Width = PanelLateralPrincipal.Width - 10
        End If
    End Sub

    Private Sub tmMostrar_Tick(sender As Object, e As EventArgs) Handles tmMostrarSideBar.Tick
        If PanelLateralPrincipal.Width >= 230 Then
            Me.tmMostrarSideBar.Enabled = False
        Else
            Me.PanelLateralPrincipal.Width = PanelLateralPrincipal.Width + 10
        End If
    End Sub

    'Botonera
    Private Sub pbMaximizar_Click(sender As Object, e As EventArgs) Handles pbMaximizar.Click
        'Capturamos el tamaño y lugar actual del Formulario Principal
        lx = Me.Location.X
        ly = Me.Location.Y
        sw = Me.Size.Width
        sh = Me.Size.Height
        FormMax = True

        'Maximizamos diciendo que abarque el tamaño de la pantalla
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
        pbMaximizar.Visible = False
        pbRestaurar.Visible = True
    End Sub

    Private Sub pbRestaurar_Click(sender As Object, e As EventArgs) Handles pbRestaurar.Click
        'Para restaurar el Formulario le brindamos el valor de las variables de tamaño y location
        Me.Size = New Size(sw, sh)
        Me.Location = New Point(lx, ly)
        FormMax = False
        pbRestaurar.Visible = False
        pbMaximizar.Visible = True
    End Sub

    Private Sub pbMinimizar_Click(sender As Object, e As EventArgs) Handles pbMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub pbCerrar_Click(sender As Object, e As EventArgs) Handles pbCerrar.Click
        Application.Exit()
    End Sub

    ''Método para abrir los formularios
    Private Sub AbrirFormEnPanel(Of Miform As {Form, New})()
        Dim Formulario As Form
        Formulario = PanelFormularios.Controls.OfType(Of Miform)().FirstOrDefault() 'Busca el formulario en la coleccion
        'Si form no fue econtrado/ no existe
        If Formulario Is Nothing Then
            Formulario = New Miform()
            Formulario.TopLevel = False

            Formulario.FormBorderStyle = FormBorderStyle.None
            Formulario.Dock = DockStyle.Fill

            PanelFormularios.Controls.Add(Formulario)
            PanelFormularios.Tag = Formulario
            ColorBack()
            AddHandler Formulario.FormClosed, AddressOf Me.CerrarFormulario

            Formulario.Width = PanelFormularios.Width
            Formulario.Height = PanelFormularios.Height
            Formulario.Show()
            Formulario.BringToFront()

        Else
            Formulario.BringToFront()
            Formulario.Width = PanelFormularios.Width
            Formulario.Height = PanelFormularios.Height
            ColorBack()
        End If
    End Sub

    'Método para el backcolor predeterminado de los botones del menu
    Private Sub ColorBack()
        BtnContactos.BackColor = Color.FromArgb(255, 228, 225)
        BtnCalendario.BackColor = Color.FromArgb(255, 228, 225)
        BtnNotas.BackColor = Color.FromArgb(255, 228, 225)
        BtnEnlaces.BackColor = Color.FromArgb(255, 228, 225)
        BtnProyectos.BackColor = Color.FromArgb(255, 228, 225)
        BtnConfiguracion.BackColor = Color.FromArgb(255, 228, 225)
    End Sub

    'Método/evento al cerrar los Forms
    Private Sub CerrarFormulario(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        'CONDICION SI FORMS ESTA ABIERTO
        If (Application.OpenForms("FrmProyectos") Is Nothing) Then
            BtnNotas.BackColor = Color.FromArgb(255, 228, 225)
        End If

        If (Application.OpenForms("FrmContactos") Is Nothing) Then
            BtnContactos.BackColor = Color.FromArgb(255, 228, 225)
        End If

        If (Application.OpenForms("FrmCalendario") Is Nothing) Then
            BtnCalendario.BackColor = Color.FromArgb(255, 228, 225)
        End If

        If (Application.OpenForms("FrmNotas") Is Nothing) Then
            BtnNotas.BackColor = Color.FromArgb(255, 228, 225)
        End If

        If (Application.OpenForms("FrmEnlaces") Is Nothing) Then
            BtnNotas.BackColor = Color.FromArgb(255, 228, 225)
        End If

        If (Application.OpenForms("FrmConfiguracion") Is Nothing) Then
            BtnConfiguracion.BackColor = Color.FromArgb(255, 228, 225)
        End If
    End Sub

    'Botones de Menu
    Private Sub btnProyectos_Click(sender As Object, e As EventArgs) Handles BtnProyectos.Click
        AbrirFormEnPanel(Of FrmProyectos)()
        BtnProyectos.BackColor = Color.FromArgb(229, 205, 202)
    End Sub

    Private Sub btnContactos_Click(sender As Object, e As EventArgs) Handles BtnContactos.Click
        AbrirFormEnPanel(Of FrmContactos)()
        BtnContactos.BackColor = Color.FromArgb(229, 205, 202)
    End Sub

    Private Sub btnCalendario_Click(sender As Object, e As EventArgs) Handles BtnCalendario.Click
        AbrirFormEnPanel(Of FrmCalendario)()
        BtnCalendario.BackColor = Color.FromArgb(229, 205, 202)
    End Sub

    Private Sub btnNotas_Click(sender As Object, e As EventArgs) Handles BtnNotas.Click
        AbrirFormEnPanel(Of FrmNotas)()
        BtnNotas.BackColor = Color.FromArgb(229, 205, 202)
    End Sub

    Private Sub btnEnlaces_Click(sender As Object, e As EventArgs) Handles BtnEnlaces.Click
        AbrirFormEnPanel(Of FrmEnlaces)()
        BtnEnlaces.BackColor = Color.FromArgb(229, 205, 202)
    End Sub

    Private Sub btnConfiguracion_Click(sender As Object, e As EventArgs) Handles BtnConfiguracion.Click
        AbrirFormEnPanel(Of FrmConfiguracion)()
        BtnConfiguracion.BackColor = Color.FromArgb(229, 205, 202)
    End Sub

    'Notificaciones
    Private Sub pbNotificaciones_Click(sender As Object, e As EventArgs) Handles pbNotificaciones.Click
        If PanelNotificaciones.Width = 230 Then
            tmOcultarNotificacinoes.Enabled = True
        ElseIf PanelNotificaciones.Width = 0 Then
            tmMostrarNotificaciones.Enabled = True
        End If
    End Sub

    Private Sub PanelFormularios_Paint(sender As Object, e As PaintEventArgs) Handles PanelFormularios.Paint

    End Sub

    Private Sub tmOcultarNotificacinoes_Tick(sender As Object, e As EventArgs) Handles tmOcultarNotificacinoes.Tick
        If PanelNotificaciones.Width <= 0 Then
            Me.tmOcultarNotificacinoes.Enabled = False
        Else
            Me.PanelNotificaciones.Width = PanelNotificaciones.Width - 10
        End If
    End Sub

    Private Sub tmMostrarNotificaciones_Tick(sender As Object, e As EventArgs) Handles tmMostrarNotificaciones.Tick
        If PanelNotificaciones.Width >= 230 Then
            Me.tmMostrarNotificaciones.Enabled = False
        Else
            Me.PanelNotificaciones.Width = PanelNotificaciones.Width + 10
        End If
    End Sub


End Class