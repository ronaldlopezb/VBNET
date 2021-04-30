Public Class FrmPrincipal
    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If isLogin = False Then FrmLogin.Show() : Me.Close()
    End Sub


End Class