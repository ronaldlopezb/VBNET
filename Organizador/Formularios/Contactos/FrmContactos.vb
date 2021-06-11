Public Class FrmContactos
    Private dv As New DataView
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    Private Sub FrmContactos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cargar Lista de Contactos
        llenarGrid()

    End Sub

    ''Llenar Grid de Agenda de Contactos
    Private Sub llenarGrid()
        Dim dsContactos As New DataSet
        Dim dtContactos As New DataTable
        Dim sql As String = "select IdContacto, Nombres + ' ' + ApellidoPaterno + ' ' + ApellidoMaterno as ContactoNombre FROM TablaContactos"
        Dim adpContactos As New OleDb.OleDbDataAdapter(sql, Conn)

        dsContactos.Tables.Add("tabla")
        adpContactos.Fill(dsContactos.Tables("tabla"))

        dv.Table = dsContactos.Tables("tabla")
        Me.gdgListaContactos.DataSource = dv

        ''Diseño
        gdgListaContactos.Columns(0).Visible = False
        'gdgListaContactos.Sort(gdgListaContactos.Columns(1), Asc)

    End Sub

    Private Sub TxtBuscadorContactos_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscadorContactos.TextChanged
        dv.RowFilter = String.Format("ContactoNombre Like '%{0}%'", TxtBuscadorContactos.Text)
    End Sub

End Class