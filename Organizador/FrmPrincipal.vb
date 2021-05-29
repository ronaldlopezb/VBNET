Public Class FrmPrincipal
    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.WindowState = FormWindowState.Normal Then
            pbRestaurar.Visible = False
            pbMaximizar.Visible = True
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles pbCerrar.Click
        Application.Exit()
    End Sub

    Private Sub pbSideBar_Click_1(sender As Object, e As EventArgs) Handles pbSideBar.Click
        If (PanelLateralPrincipal.Width = 230) Then
            PanelLateralPrincipal.Width = 70
        Else
            PanelLateralPrincipal.Width = 230
        End If
    End Sub

    Private Sub pbRestaurar_Click(sender As Object, e As EventArgs) Handles pbRestaurar.Click
        Me.WindowState = FormWindowState.Normal
        pbRestaurar.Visible = False
        pbMaximizar.Visible = True
    End Sub

    Private Sub pbMaximizar_Click(sender As Object, e As EventArgs) Handles pbMaximizar.Click
        Me.WindowState = FormWindowState.Maximized
        pbMaximizar.Visible = False
        pbRestaurar.Visible = True
    End Sub

    Private Sub pbMinimizar_Click(sender As Object, e As EventArgs) Handles pbMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PanelSuperior_DoubleClick(sender As Object, e As EventArgs) Handles PanelSuperior.DoubleClick
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
            pbMaximizar.Visible = False
            pbRestaurar.Visible = True
        Else
            Me.WindowState = FormWindowState.Normal
            pbMaximizar.Visible = True
            pbRestaurar.Visible = False
        End If
    End Sub
End Class