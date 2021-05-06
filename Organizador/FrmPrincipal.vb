Public Class FrmPrincipal
    Dim ex, ey As Integer
    Dim Arrastre As Boolean
    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If isLogin = False Then FrmLogin.Show() : Me.Close()
    End Sub

    Private Sub BtnAbrirCerrar_Click(sender As Object, e As EventArgs) Handles BtnAbrirCerrar.Click
        If (PanelMenuPrincipal.Width = 230) Then
            PanelMenuPrincipal.Width = 50
        Else
            PanelMenuPrincipal.Width = 230
        End If
    End Sub

    Private Sub FrmPrincipal_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub FrmPrincipal_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        Arrastre = False
    End Sub



    Private Sub FrmPrincipal_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        'Si el formulario no tiene borde (FormBorderStyle = none) la siguiente linea funciona bien
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))
        'pero si quieres dejar los bordes y la barra de titulo entonces es necesario descomentar la siguiente linea y comentar la anterior, osea ponerle el apostrofe
        'If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex - 8, Me.MousePosition.Y - Me.Location.Y - ey - 60))
    End Sub

    Private Sub PanelSuperior_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelSuperior.MouseDown
        AgarrarFormulario(e)
    End Sub

    Private Sub PanelSuperior_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelSuperior.MouseMove
        Moverformulario(Me)
    End Sub

    Private Sub PanelSuperior_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelSuperior.MouseUp
        SoltarFormulario()
    End Sub

    Private Sub BtnCerrarVentana_Click(sender As Object, e As EventArgs) Handles BtnCerrarVentana.Click
        Me.Close()
    End Sub

    Private Sub BtnMaximizarVentana_Click(sender As Object, e As EventArgs) Handles BtnMaximizarVentana.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BtnRestaurarVentana_Click(sender As Object, e As EventArgs) Handles BtnRestaurarVentana.Click
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub LblLoginTitulo_Click(sender As Object, e As EventArgs) Handles LblLoginTitulo.Click

    End Sub

    Private Sub BtnMinimizarVentana_Click(sender As Object, e As EventArgs) Handles BtnMinimizarVentana.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


End Class