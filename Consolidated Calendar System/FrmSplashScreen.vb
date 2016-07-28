Public Class FrmSplashScreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        prgb.Increment(10)

        If prgb.Value = 100 Then
            Timer1.Stop()
            FrmLogin.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub FrmSplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class