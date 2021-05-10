Module ModuloMain

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


End Module
