Public Class FormInformeFacturas
    Private Sub FormInformeFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetProyecto.Facturas' Puede moverla o quitarla según sea necesario.
        Me.FacturasTableAdapter.VerTodasLasFacturas(Me.DataSetProyecto.Facturas)
        dtpHasta.Text = DateTime.Today
        dtpDesde.Text = New DateTime(2018, 8, 10)
        Me.ReportViewer1.RefreshReport()
    End Sub


    Private Sub RBNumFact_CheckedChanged(sender As Object, e As EventArgs) Handles RBNumFact.CheckedChanged
        txt_BuscaFact.Enabled = True
        txt_BucarDniCliente.Enabled = False
        txt_BuscarDniVendedor.Enabled = False
        btnBUSCAR_FECHA.Enabled = False
        dtpDesde.Enabled = False
        dtpHasta.Enabled = False
        LimpiarCampos()
        Me.FacturasTableAdapter.VerTodasLasFacturas(Me.DataSetProyecto.Facturas)
    End Sub

    Private Sub txt_BuscaFact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_BuscaFact.KeyPress
        Validacion.validarSoloNumeros(e)

        If e.KeyChar = Chr(13) Then
            If txt_BuscaFact.TextLength = 0 Then
                MsgBox("Disculpe,Ingrese un numero de factura que desea buscar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERROR")


            Else

                Dim factura = txt_BuscaFact.Text
                If Me.FacturasTableAdapter.BuscarFacturaPorID(Me.DataSetProyecto.Facturas, txt_BuscaFact.Text) = False Then
                    MsgBox("Disculpe,El numero de factura ingresado no existe!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informacion")

                    Me.FacturasTableAdapter.VerTodasLasFacturas(Me.DataSetProyecto.Facturas)
                End If
                Me.ReportViewer1.RefreshReport()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_BuscaFact_TextChanged(sender As Object, e As EventArgs) Handles txt_BuscaFact.TextChanged
        Try
            Me.FacturasTableAdapter.BuscarFacturaPorID(Me.DataSetProyecto.Facturas, txt_BuscaFact.Text)
        Catch ex As Exception
            Me.FacturasTableAdapter.VerTodasLasFacturas(Me.DataSetProyecto.Facturas)
        End Try

    End Sub

    Private Sub RBdniCliente_CheckedChanged(sender As Object, e As EventArgs) Handles RBdniCliente.CheckedChanged
        txt_BuscaFact.Enabled = False
        txt_BucarDniCliente.Enabled = True
        txt_BuscarDniVendedor.Enabled = False
        btnBUSCAR_FECHA.Enabled = False
        dtpDesde.Enabled = False
        dtpHasta.Enabled = False
        LimpiarCampos()
        Me.FacturasTableAdapter.VerTodasLasFacturas(Me.DataSetProyecto.Facturas)
    End Sub



    Private Sub txt_BucarDniCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_BucarDniCliente.KeyPress
        Validacion.validarSoloNumeros(e)


        If e.KeyChar = Chr(13) Then

            If txt_BucarDniCliente.TextLength = 0 Then


                MsgBox("Disculpe,Ingrese un dni de cliente que desea buscar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERROR")

            Else
                Dim cliente = txt_BucarDniCliente.Text
                If Me.FacturasTableAdapter.BuscarFacturaPorDniCliente(Me.DataSetProyecto.Facturas, txt_BucarDniCliente.Text) = False Then
                    MsgBox("Disculpe,El cliente cuyo dni ingreso no realizo ninguna compra o no existe!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informacion")

                    Me.FacturasTableAdapter.VerTodasLasFacturas(Me.DataSetProyecto.Facturas)

                End If
                Me.ReportViewer1.RefreshReport()


                e.Handled = True
            End If
        End If

    End Sub

    Private Sub txt_BucarDniCliente_TextChanged(sender As Object, e As EventArgs) Handles txt_BucarDniCliente.TextChanged
        Try
            Me.FacturasTableAdapter.BuscarFacturaPorDniCliente(Me.DataSetProyecto.Facturas, txt_BucarDniCliente.Text)
        Catch ex As Exception
            Me.FacturasTableAdapter.VerTodasLasFacturas(Me.DataSetProyecto.Facturas)
        End Try
    End Sub

#Region "Limpiar campos"
    Public Sub LimpiarCampos()
        txt_BuscaFact.Clear()
        txt_BucarDniCliente.Clear()
        txt_BuscarDniVendedor.Clear()
        dtpHasta.Text = DateTime.Today
        dtpDesde.Text = New DateTime(2018, 8, 10)

    End Sub
#End Region

    Private Sub RBdniVendedor_CheckedChanged(sender As Object, e As EventArgs) Handles RBdniVendedor.CheckedChanged
        txt_BuscaFact.Enabled = False
        txt_BucarDniCliente.Enabled = False
        txt_BuscarDniVendedor.Enabled = True
        btnBUSCAR_FECHA.Enabled = False
        dtpDesde.Enabled = False
        dtpHasta.Enabled = False
        LimpiarCampos()
        Me.FacturasTableAdapter.VerTodasLasFacturas(Me.DataSetProyecto.Facturas)
    End Sub

    Private Sub txt_BuscarDniVendedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_BuscarDniVendedor.KeyPress
        Validacion.validarSoloNumeros(e)


        If e.KeyChar = Chr(13) Then

            If txt_BuscarDniVendedor.TextLength = 0 Then

                MsgBox("Disculpe,Ingrese un dni del vendedor que desea buscar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERROR")

            Else
                Dim vendedor = txt_BuscarDniVendedor.Text
                If Me.FacturasTableAdapter.BuscarFacturaPorDniCliente(Me.DataSetProyecto.Facturas, txt_BuscarDniVendedor.Text) = False Then
                    MsgBox("Disculpe,El vendedor cuyo dni ingreso no realizo ventas o no existe!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informacion")

                    Me.FacturasTableAdapter.VerTodasLasFacturas(Me.DataSetProyecto.Facturas)

                End If
                Me.ReportViewer1.RefreshReport()
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub txt_BuscarDniVendedor_TextChanged(sender As Object, e As EventArgs) Handles txt_BuscarDniVendedor.TextChanged
        Try
            Me.FacturasTableAdapter.BuscarFacturaPorDniCliente(Me.DataSetProyecto.Facturas, txt_BuscarDniVendedor.Text)
        Catch ex As Exception
            Me.FacturasTableAdapter.VerTodasLasFacturas(Me.DataSetProyecto.Facturas)
        End Try
    End Sub

    Private Sub RBfecha_CheckedChanged(sender As Object, e As EventArgs) Handles RBfecha.CheckedChanged
        txt_BuscaFact.Enabled = False
        txt_BucarDniCliente.Enabled = False
        txt_BuscarDniVendedor.Enabled = False
        btnBUSCAR_FECHA.Enabled = True
        dtpDesde.Enabled = True
        dtpHasta.Enabled = True
        LimpiarCampos()
    End Sub

    Private Sub btnBUSCAR_FECHA_Click(sender As Object, e As EventArgs) Handles btnBUSCAR_FECHA.Click
        If dtpDesde.Value > dtpHasta.Value Then
            MsgBox("Disculpe,El rango de fecha de inicio debe ser menor que la fecha de finalizaciòn!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERROR")
            Me.ReportViewer1.RefreshReport()
        Else
            If Me.FacturasTableAdapter.BuscarFacturasPorFechas(Me.DataSetProyecto.Facturas, dtpDesde.Text, dtpHasta.Text) = False Then
                MsgBox("No se realizaron ventas en el rango de fechas ingresada!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informacion")
                Me.ReportViewer1.RefreshReport()
            End If

            Me.ReportViewer1.RefreshReport()
        End If
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        If MessageBox.Show("Estas seguro que desea Salir", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Me.Hide()
            LimpiarCampos()
            Me.Close()

        End If
    End Sub
End Class