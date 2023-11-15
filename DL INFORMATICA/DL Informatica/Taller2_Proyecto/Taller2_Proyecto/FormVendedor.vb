Imports System.ComponentModel

Public Class FormVendedor
    Dim objEmpleado As Eempleados = New Eempleados
    Private Sub FormVendedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Centrar el Panel
        Dim desktopSize As Size = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        'Captura el Tamaño del Monitor
        Dim ancho As Int32 = (Me.Width - panel3.Width) \ 2
        panel3.Location = New Point(ancho, panel3.Location.Y)
        lblfecha.Text = "Fecha: " & DateTime.Now.ToShortDateString() 'captura la fecha actual  del sistema




        lbluser.Text = "Usuario Vendedor: " + DatosImportantes.Mapellido + ", " + DatosImportantes.Mnombre
        '  lbluser.Text = "Usuario Vendedor: " + +", " + DatosImportantes.Mnombre


        lblhoras.Text = "Hora: " & DateTime.Now.ToLongTimeString() ' captura la hora actual del sistema
    End Sub

    'redimensionar la imagen de insumos informaticos
    Private Sub FormVendedor_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        PictureBox2.Width = Me.Width - 330
        PictureBox2.Height = Me.Height - 280
    End Sub


#Region "BOTONES de la ventana principal"

    Private Sub BtnGestionarClientes_Click(sender As Object, e As EventArgs) Handles BtnGestionarClientes.Click
        FormGestionarClientes.ShowDialog()

    End Sub

    Private Sub BtnConsultarClientes_Click(sender As Object, e As EventArgs) Handles BtnConsultarClientes.Click
        FormConsultarClientes.ShowDialog()

    End Sub

    Private Sub BtnConsultarProducto_Click(sender As Object, e As EventArgs) Handles BtnConsultarProducto.Click
        FormConsultarProductos.ShowDialog()

    End Sub

    Private Sub BtnRealizarVenta_Click(sender As Object, e As EventArgs) Handles BtnRealizarVenta.Click
        FormFacturacion.ShowDialog()

    End Sub

    Private Sub BtnConsultarVentas_Click(sender As Object, e As EventArgs) Handles BtnConsultarVentas.Click
        FormConsultarVentasVendedor.ShowDialog()
    End Sub

    Private Sub btnmin_Click(sender As Object, e As EventArgs) Handles btnmin.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        If MessageBox.Show("Estas seguro que desea Salir", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
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

    Private Sub BtnConsultarProducto_MouseEnter(sender As Object, e As EventArgs) Handles BtnConsultarProducto.MouseEnter
        BtnConsultarProducto.BackColor = Color.LimeGreen
    End Sub

    Private Sub BtnGestionarClientes_MouseEnter(sender As Object, e As EventArgs) Handles BtnGestionarClientes.MouseEnter
        BtnGestionarClientes.BackColor = Color.LimeGreen
    End Sub

    Private Sub BtnRealizarVenta_MouseEnter(sender As Object, e As EventArgs) Handles BtnRealizarVenta.MouseEnter
        BtnRealizarVenta.BackColor = Color.LimeGreen
    End Sub

    Private Sub BtnConsultarVentas_MouseEnter(sender As Object, e As EventArgs) Handles BtnConsultarVentas.MouseEnter
        BtnConsultarVentas.BackColor = Color.LimeGreen
    End Sub

    'VUELVE A SUS COLOR ORIGINAL CUANDO SE ALEJA DEL BOTON
    Private Sub BtnConsultarClientes_MouseLeave(sender As Object, e As EventArgs) Handles BtnConsultarClientes.MouseLeave
        BtnConsultarClientes.BackColor = Color.LightGreen
    End Sub

    Private Sub BtnConsultarProducto_MouseLeave(sender As Object, e As EventArgs) Handles BtnConsultarProducto.MouseLeave
        BtnConsultarProducto.BackColor = Color.LightGreen
    End Sub

    Private Sub BtnGestionarClientes_MouseLeave(sender As Object, e As EventArgs) Handles BtnGestionarClientes.MouseLeave
        BtnGestionarClientes.BackColor = Color.LightGreen
    End Sub

    Private Sub BtnRealizarVenta_MouseLeave(sender As Object, e As EventArgs) Handles BtnRealizarVenta.MouseLeave
        BtnRealizarVenta.BackColor = Color.LightGreen
    End Sub

    Private Sub BtnConsultarVentas_MouseLeave(sender As Object, e As EventArgs) Handles BtnConsultarVentas.MouseLeave
        BtnConsultarVentas.BackColor = Color.LightGreen
    End Sub

    Private Sub lbluser_Click(sender As Object, e As EventArgs) Handles lbluser.Click

    End Sub


#End Region

End Class