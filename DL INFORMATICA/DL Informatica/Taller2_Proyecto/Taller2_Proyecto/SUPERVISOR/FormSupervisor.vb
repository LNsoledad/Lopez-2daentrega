Imports System.ComponentModel

Public Class FormSupervisor
    Dim objEmpleado As Eempleados = New Eempleados

    Private Sub FormSupervisor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Centrar el Panel
        Dim desktopSize As Size = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        'Captura el Tamaño del Monitor
        Dim ancho As Int32 = (Me.Width - panel3.Width) \ 2
        panel3.Location = New Point(ancho, panel3.Location.Y)
        lblfecha.Text = "Fecha: " & DateTime.Now.ToShortDateString() 'captura la fecha actual  del sistema
        lbluser.Text = "Usuario Supervisor: " + DatosImportantes.Mapellido + ", " + DatosImportantes.Mnombre
        lblhoras.Text = "Hora: " & DateTime.Now.ToLongTimeString() ' captura la hora actual del sistema
    End Sub


    'redimensionar la imagen de insumos informaticos
    Private Sub FormSupervisor_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        PictureBox2.Width = Me.Width - 320
        PictureBox2.Height = Me.Height - 280
    End Sub


#Region "BOTONES"

    Private Sub BtnConsultarProductos_Click(sender As Object, e As EventArgs) Handles BtnConsultarProductos.Click
        FormConsultarProductos.ShowDialog()

    End Sub

    Private Sub BtnConsultarEmpleados_Click(sender As Object, e As EventArgs) Handles BtnConsultarEmpleados.Click
        FormConsultarEmpleados.ShowDialog()
    End Sub

    Private Sub BtnGestionarProductos_Click(sender As Object, e As EventArgs) Handles BtnGestionarProductos.Click
        FormGestionarProductos.ShowDialog()

    End Sub

    Private Sub BtnConsultarVentas_Click(sender As Object, e As EventArgs) Handles BtnConsultarVentas.Click
        FormConsultarVentas.ShowDialog()
    End Sub

    Private Sub btnmin_Click(sender As Object, e As EventArgs) Handles btnmin.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        If MessageBox.Show("Estas seguro que desea Salir", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            FormFondo.Show()
            Me.Hide() 'oculta el formulario

            FormLogin.Show()
            'Me.Hide()
            'FormLogin.ShowDialog()
            'Application.[Exit]()
            Me.Close()

        End If
    End Sub

    Private Sub BtnModPrecioStock_Click(sender As Object, e As EventArgs) Handles BtnModPrecioStock.Click
        FormModifStockPrecio.ShowDialog()
    End Sub
#End Region

    '_______para el reloj_______________
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblhoras.Text = "Hora: " & TimeOfDay.TimeOfDay.ToString

    End Sub

#Region "Cambio de color botones"

    'CAMBIA DE COLOR CUANDO SE ESTA ENCIMA DEL BOTON

    Private Sub BtnConsultarEmpleados_MouseEnter(sender As Object, e As EventArgs) Handles BtnConsultarEmpleados.MouseEnter
        BtnConsultarEmpleados.BackColor = Color.LimeGreen
    End Sub

    Private Sub BtnConsultarProducto_MouseEnter(sender As Object, e As EventArgs) Handles BtnConsultarProductos.MouseEnter
        BtnConsultarProductos.BackColor = Color.LimeGreen
    End Sub

    Private Sub BtnGestionarProductos_MouseEnter(sender As Object, e As EventArgs) Handles BtnGestionarProductos.MouseEnter
        BtnGestionarProductos.BackColor = Color.LimeGreen
    End Sub

    Private Sub BtnModPrecioStock_MouseEnter(sender As Object, e As EventArgs) Handles BtnModPrecioStock.MouseEnter
        BtnModPrecioStock.BackColor = Color.LimeGreen
    End Sub

    Private Sub BtnConsultarVentas_MouseEnter(sender As Object, e As EventArgs) Handles BtnConsultarVentas.MouseEnter
        BtnConsultarVentas.BackColor = Color.LimeGreen
    End Sub

    'VUELVE A SUS COLOR ORIGINAL CUANDO SE ALEJA DEL BOTON
    Private Sub BtnConsultarEmpleados_MouseLeave(sender As Object, e As EventArgs) Handles BtnConsultarEmpleados.MouseLeave
        BtnConsultarEmpleados.BackColor = Color.LightGreen
    End Sub

    Private Sub BtnConsultarProductos_MouseLeave(sender As Object, e As EventArgs) Handles BtnConsultarProductos.MouseLeave
        BtnConsultarProductos.BackColor = Color.LightGreen
    End Sub

    Private Sub BtnGestionarProductos_MouseLeave(sender As Object, e As EventArgs) Handles BtnGestionarProductos.MouseLeave
        BtnGestionarProductos.BackColor = Color.LightGreen
    End Sub

    Private Sub BtnModPrecioStock_MouseLeave(sender As Object, e As EventArgs) Handles BtnModPrecioStock.MouseLeave
        BtnModPrecioStock.BackColor = Color.LightGreen
    End Sub

    Private Sub BtnConsultarVentas_MouseLeave(sender As Object, e As EventArgs) Handles BtnConsultarVentas.MouseLeave
        BtnConsultarVentas.BackColor = Color.LightGreen
    End Sub

    Private Sub lbluser_Click(sender As Object, e As EventArgs) Handles lbluser.Click

    End Sub








#End Region



End Class