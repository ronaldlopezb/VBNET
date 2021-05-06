Public Class FrmLogin

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnIngresar.Click
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

    Private Sub FrmLogin_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        AgarrarFormulario(e)
    End Sub

    Private Sub FrmLogin_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        SoltarFormulario()
    End Sub

    Private Sub FrmLogin_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Moverformulario(Me)
    End Sub



    Private Sub LblLoginTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles LblLoginTitulo.MouseMove
        Moverformulario(Me)
    End Sub

    Private Sub LblLoginTitulo_MouseUp(sender As Object, e As MouseEventArgs) Handles LblLoginTitulo.MouseUp
        SoltarFormulario()
    End Sub

    Private Sub LblLoginTitulo_MouseDown(sender As Object, e As MouseEventArgs) Handles LblLoginTitulo.MouseDown

        AgarrarFormulario(e)
    End Sub



    Private Sub LblSubTitulo_MouseDown(sender As Object, e As MouseEventArgs) Handles LblSubTitulo.MouseDown
        AgarrarFormulario(e)
    End Sub

    Private Sub LblSubTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles LblSubTitulo.MouseMove
        Moverformulario(Me)
    End Sub

    Private Sub LblSubTitulo_MouseUp(sender As Object, e As MouseEventArgs) Handles LblSubTitulo.MouseUp
        SoltarFormulario()
    End Sub

    Private Sub BtnIngresar_MouseHover(sender As Object, e As EventArgs) Handles BtnIngresar.MouseHover
        BtnIngresar.BackColor = ColorTranslator.FromHtml("#0078D7")
    End Sub

    Private Sub BtnIngresar_MouseLeave(sender As Object, e As EventArgs) Handles BtnIngresar.MouseLeave
        BtnIngresar.BackColor = ColorTranslator.FromHtml("#456BD3")
    End Sub
End Class
