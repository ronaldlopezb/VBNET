Public Class FrmLogin

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        If TxtUsuario.Text = "" Then MsgBox("Por favor ingrese su Nombre de Usuario", vbInformation, "Error - Identificación") : TxtUsuario.Select() : Return
        If TxtClave.Text = "" Then MsgBox("Por favor ingrese su Contraseña", vbInformation, "Error - Identificación") : TxtClave.Select() : Return
        If Login(TxtUsuario.Text, TxtClave.Text) Then
            FrmPrincipal.Show()
            Me.Close()
        Else
            MsgBox("Lo sentimos, las credenciales ingresadas no son correctas. ", vbInformation, "Error - Identificación")
        End If
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConectarBD()
    End Sub

End Class
