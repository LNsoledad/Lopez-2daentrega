Public Class FormListarFacturas
    Private Sub FormListarFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetProyecto.VerFacturas' Puede moverla o quitarla según sea necesario.
        Me.VerFacturasTableAdapter.VerTodasLasFacturas(Me.DataSetProyecto.VerFacturas)


        'deshabilito boton de busqueda por codigo de factura
        Me.btnBuscarID_factura.Visible = False
    End Sub

    Private Sub dtgLISTAFACTURAS_DoubleClick(sender As Object, e As EventArgs) Handles dtgLISTAFACTURAS.DoubleClick
        Dim fil As Integer = Me.dtgLISTAFACTURAS.CurrentRow.Index

        'obtengo el numero de factura
        Dim idFactura As Integer = Me.dtgLISTAFACTURAS.Rows(fil).Cells(0).Value

        Dim reporteFactura = New FormGenerarFactura()
        reporteFactura.mostrarFactura(idFactura)
        reporteFactura.ShowDialog()
    End Sub

    Private Sub tbxBUSCAAPE_CLI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxBUSCAAPE_CLI.KeyPress
        Validacion.validarSoloLetras(e)
    End Sub

    Private Sub tbxBUSCAAPE_CLI_TextChanged(sender As Object, e As EventArgs) Handles tbxBUSCAAPE_CLI.TextChanged
        Me.VerFacturasTableAdapter.BuscarFactApellidoCliente(DataSetProyecto.VerFacturas, tbxBUSCAAPE_CLI.Text)
        tbxBUSCA_FACTURA.Clear()

    End Sub



    Private Sub btnBuscarID_factura_Click(sender As Object, e As EventArgs) Handles btnBuscarID_factura.Click
        If tbxBUSCA_FACTURA.Text = Nothing Then

            MsgBox("Disculpe,DEBE INGRESAR EL numero de factura QUE DESEA BUSCAR", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERROR")
        Else
            If Me.VerFacturasTableAdapter.BuscarFactPorId(Me.DataSetProyecto.VerFacturas, tbxBUSCA_FACTURA.Text) = False Then

                MsgBox("Disculpe NO existe el NUMERO de factura ingresado,por favor VERIFIQUE el dato ingreso!", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1 +
                                MsgBoxStyle.Information, "Mensaje")
                Me.VerFacturasTableAdapter.VerTodasLasFacturas(Me.DataSetProyecto.VerFacturas)

            End If
        End If
    End Sub

    Private Sub tbxBUSCA_FACTURA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxBUSCA_FACTURA.KeyPress
        Validacion.validarSoloNumeros(e)
        tbxBUSCAAPE_CLI.Clear()

        Me.VerFacturasTableAdapter.VerTodasLasFacturas(Me.DataSetProyecto.VerFacturas)
        If e.KeyChar = Chr(13) Then

            If tbxBUSCA_FACTURA.TextLength = 0 Then


                MsgBox("Por favor,ingrese el Numero de FACTURA a buscar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERROR")

            Else
                Dim factura = tbxBUSCA_FACTURA.Text
                If Me.VerFacturasTableAdapter.BuscarFactPorId(Me.DataSetProyecto.VerFacturas, factura) = False Then

                    MsgBox("¿NO existe FACTURA CON ESE CODIGO, VERIFIQUE DATO INGRESADO?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1 +
                                    MsgBoxStyle.Information, "Mensaje")
                    Me.VerFacturasTableAdapter.VerTodasLasFacturas(Me.DataSetProyecto.VerFacturas)

                End If
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BtnVerTodas_Click(sender As Object, e As EventArgs) Handles BtnVerTodas.Click
        tbxBUSCAAPE_CLI.Clear()
        tbxBUSCA_FACTURA.Clear()
        Me.VerFacturasTableAdapter.VerTodasLasFacturas(Me.DataSetProyecto.VerFacturas)
    End Sub
End Class