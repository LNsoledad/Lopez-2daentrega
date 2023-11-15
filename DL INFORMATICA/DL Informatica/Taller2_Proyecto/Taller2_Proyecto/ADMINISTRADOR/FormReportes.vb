Public Class FormReportes

    Private Sub FormReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tip()
    End Sub


    Sub Tip()


        ToolTip1.SetToolTip(btnMOV_ANUAL_ART, "Permite ver Cantidad Vendida, Monto Facturado, Ganancia de un artículo seleccionado, entre otras cosas ")

        ToolTip1.SetToolTip(btnClientesCantidad, "Lista de Clientes que mas compras por cantidad de productos comprados")
        ToolTip1.SetToolTip(btnClientesMonto, "Lista de Clientes que mas compras por Monto gastado en productos")

        ToolTip1.SetToolTip(BtnMejorVendFecha, "Lista un ranking de los mejores vendedores en un cierto periodo")
        ToolTip1.SetToolTip(BtnMejorVendTurno, "Lista un ranking de los mejores vendedores en un cierto turno")

        ToolTip1.SetToolTip(BtnProductoNoVendido, "Lista los articulos que no se vendieron en un determinado periodo, capital estancado de cada uno")
        ToolTip1.SetToolTip(btnProdMasVendFecha, "Lista de los articulos mas vendidos, informacion como cantidad vendida en un cierto periodo")
        ToolTip1.SetToolTip(btnProdMasVendMarca, "Lista de los articulos mas vendidos, informacion como cantidad vendida por marca")
        ToolTip1.SetToolTip(btnProdMasVendCat, "Lista de los articulos mas vendidos, informacion como cantidad vendida por categoria")

        ToolTip1.SetToolTip(BtnVentaDiaria, "Permite ver Cantidad de operaciones, Monto de ventas y Ganancia de un dia determinado")

    End Sub
    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        If MessageBox.Show("Estas seguro que desea Salir", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Me.Hide()
            Me.Close()

        End If
    End Sub

    Private Sub btnClientesCantidad_Click(sender As Object, e As EventArgs)
        FormMejoresClientesPorCantComprada.ShowDialog()
    End Sub

    Private Sub btnClientesMonto_Click(sender As Object, e As EventArgs) Handles btnClientesMonto.Click
        FormMejoresClientesPorMonto.ShowDialog()
    End Sub

    Private Sub btnIFactura_Click(sender As Object, e As EventArgs) Handles btnIFactura.Click
        FormInformeFacturas.ShowDialog()
    End Sub

    Private Sub BtnMejorVendFecha_Click(sender As Object, e As EventArgs) Handles BtnMejorVendFecha.Click
        FormMejoresVendedores.ShowDialog()
    End Sub

    Private Sub BtnMejorVendTurno_Click(sender As Object, e As EventArgs) Handles BtnMejorVendTurno.Click
        FormMejoresVendedoresPorTurnos.ShowDialog()
    End Sub

    Private Sub btnProdMasVendMarca_Click(sender As Object, e As EventArgs) Handles btnProdMasVendMarca.Click
        FormProductosMasVendidosPorMarca.ShowDialog()
    End Sub

    Private Sub btnProdMasVendCat_Click(sender As Object, e As EventArgs) Handles btnProdMasVendCat.Click
        FormProductosMasVendidosPorCat.ShowDialog()
    End Sub

    Private Sub btnProdMasVendFecha_Click(sender As Object, e As EventArgs) Handles btnProdMasVendFecha.Click
        FormProductosMasVendidosPorFecha.ShowDialog()
    End Sub

    Private Sub BtnProductoNoVendido_Click(sender As Object, e As EventArgs) Handles BtnProductoNoVendido.Click
        FormProductosSinVentas.ShowDialog()
    End Sub

    Private Sub BtnVentaDiaria_Click(sender As Object, e As EventArgs) Handles BtnVentaDiaria.Click
        FormVentasPorDia.ShowDialog()
    End Sub

    Private Sub btnMOV_ANUAL_ART_Click(sender As Object, e As EventArgs) Handles btnMOV_ANUAL_ART.Click
        FormCompAnualProducto.ShowDialog()
    End Sub
End Class