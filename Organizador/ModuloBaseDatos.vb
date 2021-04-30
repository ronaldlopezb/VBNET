'Importar la libreria de la Base de Datos con la que queremos trabajar.
Imports System.Data.OleDb


Module ModuloBaseDatos


    ''''''''''' Crear Variables del Sistema'''''''''''''''''
    'PASO 0: Crear Ruta de BD
    Dim rutaApp As String = Application.StartupPath()
    Dim rutaAppCount As Integer = Len(rutaApp) - 10
    Dim rutaBD As String = Mid(rutaApp, 1, rutaAppCount)

    'PASO 1: Crear la Cadena de Conexion
    Public Conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & rutaBD & "\BD.accdb")

    'PASO 2: Creamos los Command -->son comandos de ejecucion
    Public Cmd As New OleDbCommand


    'PASO 3: DataReader
    Public dr As OleDbDataReader 'Es una variable de tipo DataReader que sirve para almacenar todos los datos que nos brinde el Cmd o Command

    'PASO 4: Variable Texto llamda SQL
    Public sql As String = ""
    ''''''''''''''''''''''''''''''''''''''''''

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''Crear sub de conexion a la Base de Datos
    Public Sub ConectarBD()
        Try
            ''Abrir la conexion con BD
            Conn.Open() '' Abre la Conexion a la Base de Datos
            ''MsgBox("Felicitaciones ya estas conectado a SQL SERVER")
        Catch ex As Exception
            ''Que me diga que error salio
            MsgBox(ex.ToString)
            End
        End Try
    End Sub

    Public Sub main()

    End Sub
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Function Login(ByVal UsuarioVariable As String, ByVal ClaveVariable As String) As Boolean
        'PASO 01: Configurar el CMD o Command...
        Cmd.Connection = Conn 'Le decimos al CMD que Base de Datos Usar
        Cmd.CommandType = CommandType.Text 'Le decimos al CMD que es tipo Texto y va ejecutar TEXTO

        'PASO 02: Crear la Consulta SQL
        sql = ""
        sql = "Select IdUsuario, Usuario, Clave from TablaUsuario where Usuario='" + UsuarioVariable + "' and Clave='" + ClaveVariable + "'"
        'MsgBox(sql)

        'PASO 03: Le damos el SQL al CMD
        Cmd.CommandText = sql

        'PASO 04: Correr la SQL en el Commando
        Try
            dr = Cmd.ExecuteReader()
            ''Verificar si trajo por lo menos 1 registro.
            If dr.HasRows Then
                dr.Close()
                isLogin = True
                'FrmPrincipal.Show()
                'FrmLogin.Hide()
            Else
                dr.Close()
                isLogin = False
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            isLogin = False
            Return False
        End Try

        Return True

    End Function
End Module
