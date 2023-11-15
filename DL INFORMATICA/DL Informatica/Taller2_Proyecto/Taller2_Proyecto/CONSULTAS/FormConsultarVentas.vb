Public Class FormConsultarVentas


    'Falta cargar el datagrid y hacer las busquedas por cada uno de los campos e inclusive por fecha
    Private Sub FormConsultarVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetProyecto.VerFacturas' Puede moverla o quitarla según sea necesario.
        Me.VerFacturasTableAdapter.VerTodasLasFacturas(Me.DataSetProyecto.VerFacturas)
        dtpHasta.Text = DateTime.Today
        dtpDesde.Text = New DateTime(2023, 8, 10)
    End Sub

    Private Sub dtgLISTAFACTURAS_DoubleClick(sender As Object, e As EventArgs) Handles dtgLISTAFACTURAS.DoubleClick
        Dim fil As Integer = Me.dtgLISTAFACTURAS.CurrentRow.Index

        'obtengo el numero de factura
        Dim idFactura As Integer = Me.dtgLISTAFACTURAS.Rows(fil).Cells(0).Value

        Dim reporteFactura = New FormGenerarFactura()
        reporteFactura.mostrarFactura(idFactura)
        reporteFactura.ShowDialog()
    End Sub



    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        If MessageBox.Show("Estas seguro que desea Salir", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Me.Hide()
            LimpiarCampos()
            Me.Close()

        End If
    End Sub

    Private Sub RBNumFact_CheckedChanged(sender As Object, e As EventArgs) Handles RBNumFact.CheckedChanged
        txt_BuscaFact.Enabled = True
        txt_BucarDniCliente.Enabled = False
        txt_BuscarDniVendedor.Enabled = False
        btnBUSCAR_FECHA.Enabled = False
        dtpDesde.Enabled = False
        dtpHasta.Enabled = False
        LimpiarCampos()
        Me.VerFacturasTableAdapter.VerTodasLasFacturas(Me.DataSetProyecto.VerFacturas)
    End Sub

    Private Sub txt_BuscaFact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_BuscaFact.KeyPress
        Validacion.validarSoloNumeros(e)
    End Sub

    Private Sub txt_BuscaFact_TextChanged(sender As Object, e As EventArgs) Handles txt_BuscaFact.TextChanged
        Try
            Me.VerFacturasTableAdapter.BuscarFactPorId(Me.DataSetProyecto.VerFacturas, txt_BuscaFact.Text)
        Catch ex As Exception
            Me.VerFacturasTableAdapter.VerTodasLasFacturas(Me.DataSetProyecto.VerFacturas)
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
        Me.VerFacturasTableAdapter.VerTodasLasFacturas(Me.DataSetProyecto.VerFacturas)
    End Sub



    Private Sub txt_BucarDniCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_BucarDniCliente.KeyPress
        Validacion.validarSoloNumeros(e)

    End Sub

    Private Sub txt_BucarDniCliente_TextChanged(sender As Object, e As EventArgs) Handles txt_BucarDniCliente.TextChanged
        Try
            Me.VerFacturasTableAdapter.BuscarFactDniCliente(Me.DataSetProyecto.VerFacturas, txt_BucarDniCliente.Text)
        Catch ex As Exception
            Me.VerFacturasTableAdapter.VerTodasLasFacturas(Me.DataSetProyecto.VerFacturas)
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
        Me.VerFacturasTableAdapter.VerTodasLasFacturas(Me.DataSetProyecto.VerFacturas)
    End Sub

    Private Sub txt_BuscarDniVendedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_BuscarDniVendedor.KeyPress
        Validacion.validarSoloNumeros(e)


    End Sub

    Private Sub txt_BuscarDniVendedor_TextChanged(sender As Object, e As EventArgs) Handles txt_BuscarDniVendedor.TextChanged
        Try
            Me.VerFacturasTableAdapter.BuscarFactDniVendedor(Me.DataSetProyecto.VerFacturas, txt_BuscarDniVendedor.Text)
        Catch ex As Exception
            Me.VerFacturasTableAdapter.VerTodasLasFacturas(Me.DataSetProyecto.VerFacturas)
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
        Else
            If Me.VerFacturasTableAdapter.BuscarFactFecha(Me.DataSetProyecto.VerFacturas, dtpDesde.Text, dtpHasta.Text) = False Then
                MsgBox("No se realizaron ventas en el rango de fechas ingresada!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informacion")
            End If
        End If
    End Sub
End Class