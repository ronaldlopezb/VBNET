Public Class FrmPrincipal
    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If isLogin = False Then FrmLogin.Show() : Me.Close()
    End Sub

    Private Sub BtnAbrirCerrar_Click(sender As Object, e As EventArgs) Handles BtnAbrirCerrar.Click
        If (PanelMenuPrincipal.Width = 250) Then
            PanelMenuPrincipal.Width = 70
        Else
            PanelMenuPrincipal.Width = 250
        End If
    End Sub
End Class