Public Class FrmPrincipal
    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles pbCerrar.Click
        Application.Exit()
    End Sub



    Private Sub pbSideBar_Click_1(sender As Object, e As EventArgs) Handles pbSideBar.Click
        If (PanelLateralPrincipal.Width = 230) Then
            PanelLateralPrincipal.Width = 70
            pbSideBar.Location.X = 54
            pbSideBar.Location.Y = 56
        Else
            PanelLateralPrincipal.Width = 230
        End If
    End Sub
End Class