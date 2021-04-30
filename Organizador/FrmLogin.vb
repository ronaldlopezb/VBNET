Public Class FrmLogin

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        If TxtUsuario.Text = "" Then MsgBox("Por favor ingrese su Nombre de Usuario", vbInformation, "Error - Identificación") : TxtUsuario.Select() : Return
        If TxtClave.Text = "" Then MsgBox("Por favor ingrese su Contraseña", vbInformation, "Error - Identificación") : TxtClave.Select() : Return
        Login(TxtUsuario.Text, TxtClave.Text)
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConectarBD()
    End Sub

End Class
