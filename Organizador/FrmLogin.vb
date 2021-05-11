Public Class FrmLogin



    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConectarBD()
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    Private Sub TimerLoading_Tick(sender As Object, e As EventArgs) Handles TimerLoading.Tick
        PbLogin.Increment(1)

        If PbLogin.Value = PbLogin.Maximum Then
            TimerLoading.Stop()
            TimerLoading.Enabled = False

            FrmPrincipal.Show()
            Me.Close()
        End If
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        If TxtUsuario.Text = "" Then MsgBox("Por favor ingrese su Nombre de Usuario", vbInformation, "Error - Identificación") : TxtUsuario.Select() : Return
        If TxtClave.Text = "" Then MsgBox("Por favor ingrese su Contraseña", vbInformation, "Error - Identificación") : TxtClave.Select() : Return

        If Login(TxtUsuario.Text, TxtClave.Text) Then

            PbLogin.Visible = False
            ImgLoading.Visible = True

            TimerLoading.Interval = 10
            TimerLoading.Enabled = True

        Else
            MsgBox("Lo sentimos, las credenciales ingresadas no son correctas. ", vbInformation, "Error - Identificación")
        End If
    End Sub

    Private Sub LblClave_Click(sender As Object, e As EventArgs) Handles LblClave.Click

    End Sub
End Class
