Public Class FormBienvenida
    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value = ProgressBar1.Value + 10
            LCargando.Text = "Cargando el sistema al " & ProgressBar1.Value & "%"
        Else
            Timer1.Enabled = False
            FormFondo.Show()
            'Login.ShowDialog() 'llama al siguiente formulario(login)
            FormLogin.ShowDialog()


        End If
    End Sub

    Private Sub Bienvenida1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormFondo.Show()

        Timer1.Start()
        Timer1.Interval = 1000

    End Sub

End Class