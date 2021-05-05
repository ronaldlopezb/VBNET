Module ModuloMain
    Dim ex, ey As Integer
    Dim Arrastre As Boolean
    Public Sub Main()

        ' Lo primero que hacemos es habilitar los estilos visuales
        Application.EnableVisualStyles()

        ' Ejecutamos el código que creamos conveniente.
        '
        ' ....

        Try
            ' Mostramos el formulario principal de la aplicación
            '
            Application.Run(New FrmLogin())

            MessageBox.Show("La aplicación va a finalizar.")


        Catch ex As Exception
            ' Se ha producido un error no controlado en
            ' alguna parte de nuestra aplicación.
            '
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Public Sub AgarrarFormulario(e As MouseEventArgs)
        ex = e.X
        ey = e.Y
        'ex = Formulario.Location.X
        'ey = Formulario.Location.Y
        Arrastre = True
    End Sub

    Public Sub SoltarFormulario()
        Arrastre = False
    End Sub

    Public Sub Moverformulario(Formulario As Form)
        If Arrastre Then Formulario.Location = Formulario.PointToScreen(New Point(Formulario.MousePosition.X - Formulario.Location.X - ex, Formulario.MousePosition.Y - Formulario.Location.Y - ey))
    End Sub
End Module
