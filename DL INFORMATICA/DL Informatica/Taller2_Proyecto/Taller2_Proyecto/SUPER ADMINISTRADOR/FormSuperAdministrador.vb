Imports System.ComponentModel

Public Class FormSuperAdministrador
    Dim objEmpleado As Eempleados = New Eempleados
    Private Sub FormSuperAdministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Centrar el Panel
        Dim desktopSize As Size = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        'Captura el Tamaño del Monitor
        Dim ancho As Int32 = (Me.Width - panel3.Width) \ 2
        panel3.Location = New Point(ancho, panel3.Location.Y)
        lblfecha.Text = "Fecha: " & DateTime.Now.ToShortDateString() 'captura la fecha actual  del sistema
        lbluser.Text = "Usuario Super Administrador: " + DatosImportantes.Mapellido + ", " + DatosImportantes.Mnombre '& Module1.Usuario
        lblhoras.Text = "Hora: " & DateTime.Now.ToLongTimeString() ' captura la hora actual del sistema
    End Sub

    'redimensionar la imagen de insumos informaticos
    Private Sub FormSuperAdministrador_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        PictureBox2.Width = Me.Width - 410
        PictureBox2.Height = Me.Height - 280
    End Sub


#Region "BOTONES"

    Private Sub BtnGestionarUsuarios_Click(sender As Object, e As EventArgs) Handles BtnGestionarUsuarios.Click
        FormGestionarUsuarios.ShowDialog()

    End Sub

    Private Sub BtnConsultarUsuario_Click(sender As Object, e As EventArgs) Handles BtnConsultarUsuario.Click
        FormConsultarUsuarios.ShowDialog()

    End Sub

    Private Sub BtnRealizarBackUp_Click(sender As Object, e As EventArgs) Handles BtnRealizarBackUp.Click
        FormRealizarBackUp.ShowDialog()

    End Sub

    Private Sub btnmin_Click(sender As Object, e As EventArgs) Handles btnmin.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        If MessageBox.Show("Estas seguro que desea Salir", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            'Me.Hide() 'oculta el formulario
            FormFondo.Show()
            Me.Hide() 'oculta el formulario

            FormLogin.Show()
            'FormLogin.ShowDialog()
            'Application.[Exit]() cierra toda la aplicacion
            Me.Close() ' cierra el formulario
        End If
    End Sub

#End Region


    '_______para el reloj_______________
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblhoras.Text = "Hora: " & TimeOfDay.TimeOfDay.ToString

    End Sub

#Region "Cambio de color botones"

    'CAMBIA DE COLOR CUANDO SE ESTA ENCIMA DEL BOTON

    Private Sub BtnConsultarUsuario_MouseEnter(sender As Object, e As EventArgs) Handles BtnConsultarUsuario.MouseEnter
        BtnConsultarUsuario.BackColor = Color.LimeGreen
    End Sub

    Private Sub BtnRealizarBackUp_MouseEnter(sender As Object, e As EventArgs) Handles BtnRealizarBackUp.MouseEnter
        BtnRealizarBackUp.BackColor = Color.LimeGreen
    End Sub

    Private Sub BtnGestionarUsuarios_MouseEnter(sender As Object, e As EventArgs) Handles BtnGestionarUsuarios.MouseEnter
        BtnGestionarUsuarios.BackColor = Color.LimeGreen
    End Sub



    'VUELVE A SUS COLOR ORIGINAL CUANDO SE ALEJA DEL BOTON
    Private Sub BtnConsultarUsuario_MouseLeave(sender As Object, e As EventArgs) Handles BtnConsultarUsuario.MouseLeave
        BtnConsultarUsuario.BackColor = Color.LightGreen
    End Sub

    Private Sub BtnRealizarBackUp_MouseLeave(sender As Object, e As EventArgs) Handles BtnRealizarBackUp.MouseLeave
        BtnRealizarBackUp.BackColor = Color.LightGreen
    End Sub

    Private Sub BtnGestionarUsuarios_MouseLeave(sender As Object, e As EventArgs) Handles BtnGestionarUsuarios.MouseLeave
        BtnGestionarUsuarios.BackColor = Color.LightGreen
    End Sub

    Private Sub lbluser_Click(sender As Object, e As EventArgs) Handles lbluser.Click

    End Sub

    Private Sub lblfecha_Click(sender As Object, e As EventArgs) Handles lblfecha.Click

    End Sub





#End Region

End Class