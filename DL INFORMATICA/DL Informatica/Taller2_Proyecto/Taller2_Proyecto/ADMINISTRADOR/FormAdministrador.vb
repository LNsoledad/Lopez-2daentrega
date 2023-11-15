Public Class FormAdministrador
    Dim objEmpleado As Eempleados = New Eempleados
    Private Sub FormAdministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Centrar el Panel
        Dim desktopSize As Size = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
            'Captura el Tamaño del Monitor
            Dim ancho As Int32 = (Me.Width - Panel3.Width) \ 2
            Panel3.Location = New Point(ancho, Panel3.Location.Y)
            lblfecha.Text = "Fecha: " & DateTime.Now.ToShortDateString() 'captura la fecha actual  del sistema
        lbluser.Text = "Usuario Admi: " + DatosImportantes.Mapellido + ", " + DatosImportantes.Mnombre
        lblhoras.Text = "Hora: " & DateTime.Now.ToLongTimeString() ' captura la hora actual del sistema

    End Sub

    'redimensionar la imagen de insumos informaticos
    Private Sub FormAdministrador_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        PictureBox2.Width = Me.Width - 310
        PictureBox2.Height = Me.Height - 280
    End Sub

#Region "BOTONES"
    Private Sub BtnGestionarEmpleados_Click(sender As Object, e As EventArgs) Handles BtnGestionarEmpleados.Click
        FormGestionarEmpleados.ShowDialog()

    End Sub

    Private Sub BtnConsultarEmpleados_Click(sender As Object, e As EventArgs) Handles BtnConsultarEmpleados.Click
        FormConsultarEmpleados.ShowDialog()

    End Sub

    Private Sub BtnConsultarClientes_Click(sender As Object, e As EventArgs) Handles BtnConsultarClientes.Click
        FormConsultarClientes.ShowDialog()

    End Sub

    Private Sub BtnSolicitarReportes_Click(sender As Object, e As EventArgs) Handles BtnSolicitarReportes.Click
        FormReportes.ShowDialog()

    End Sub

    Private Sub BtnConsultarVentas_Click(sender As Object, e As EventArgs) Handles BtnConsultarVentas.Click
        FormConsultarVentas.ShowDialog()
    End Sub

    Private Sub BtnAltaBaja_Click(sender As Object, e As EventArgs) Handles BtnAltaBaja.Click
        FormEliminarCliente.ShowDialog()
    End Sub

    Private Sub btnmin_Click(sender As Object, e As EventArgs) Handles btnmin.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        If MessageBox.Show("Estas seguro que desea Salir", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            FormFondo.Show()
            Me.Hide() 'oculta el formulario

            FormLogin.Show()
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

    Private Sub BtnConsultarClientes_MouseEnter(sender As Object, e As EventArgs) Handles BtnConsultarClientes.MouseEnter
        BtnConsultarClientes.BackColor = Color.LimeGreen
    End Sub

    Private Sub BtnConsultarEmpleados_MouseEnter(sender As Object, e As EventArgs) Handles BtnConsultarEmpleados.MouseEnter
        BtnConsultarEmpleados.BackColor = Color.LimeGreen
    End Sub

    Private Sub BtnGestionarEmpleados_MouseEnter(sender As Object, e As EventArgs) Handles BtnGestionarEmpleados.MouseEnter
        BtnGestionarEmpleados.BackColor = Color.LimeGreen
    End Sub

    Private Sub BtnSolicitarReportes_MouseEnter(sender As Object, e As EventArgs) Handles BtnSolicitarReportes.MouseEnter
        BtnSolicitarReportes.BackColor = Color.LimeGreen
    End Sub

    Private Sub BtnConsultarVentas_MouseEnter(sender As Object, e As EventArgs) Handles BtnConsultarVentas.MouseEnter
        BtnConsultarVentas.BackColor = Color.LimeGreen
    End Sub

    Private Sub BtnAltaBaja_MouseEnter(sender As Object, e As EventArgs) Handles BtnAltaBaja.MouseEnter
        BtnAltaBaja.BackColor = Color.LimeGreen
    End Sub

    'VUELVE A SUS COLOR ORIGINAL CUANDO SE ALEJA DEL BOTON
    Private Sub BtnConsultarClientes_MouseLeave(sender As Object, e As EventArgs) Handles BtnConsultarClientes.MouseLeave
        BtnConsultarClientes.BackColor = Color.LightGreen
    End Sub

    Private Sub BtnConsultarEmpleados_MouseLeave(sender As Object, e As EventArgs) Handles BtnConsultarEmpleados.MouseLeave
        BtnConsultarEmpleados.BackColor = Color.LightGreen
    End Sub

    Private Sub BtnGestionarEmpleados_MouseLeave(sender As Object, e As EventArgs) Handles BtnGestionarEmpleados.MouseLeave
        BtnGestionarEmpleados.BackColor = Color.LightGreen
    End Sub

    Private Sub BtnSolicitarReportes_MouseLeave(sender As Object, e As EventArgs) Handles BtnSolicitarReportes.MouseLeave
        BtnSolicitarReportes.BackColor = Color.LightGreen
    End Sub

    Private Sub BtnConsultarVentas_MouseLeave(sender As Object, e As EventArgs) Handles BtnConsultarVentas.MouseLeave
        BtnConsultarVentas.BackColor = Color.LightGreen
    End Sub

    Private Sub BtnAltaBaja_MouseLeave(sender As Object, e As EventArgs) Handles BtnAltaBaja.MouseLeave
        BtnAltaBaja.BackColor = Color.LightGreen
    End Sub

    Private Sub lbluser_Click(sender As Object, e As EventArgs) Handles lbluser.Click

    End Sub









#End Region


End Class