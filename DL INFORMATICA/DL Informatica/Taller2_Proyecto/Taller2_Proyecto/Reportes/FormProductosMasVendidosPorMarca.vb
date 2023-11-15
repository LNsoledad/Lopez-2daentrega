Public Class FormProductosMasVendidosPorMarca

    Dim objProducto As Eproductos = New Eproductos

    Private Sub FormProductosMasVendidosPorMarca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetProyecto.Productos' Puede moverla o quitarla según sea necesario.
        'Me.ProductosTableAdapter.ProductosMasVendidos(Me.DataSetProyecto.Productos)
        CargarMarcas()
        CBmarca.SelectedValue = 0
        Me.ReportViewer1.RefreshReport()
    End Sub

    Public Sub CargarMarcas()
        objProducto.cargarBoxMarcas(CBmarca)
    End Sub

    Private Sub btnBUSCAR_Click(sender As Object, e As EventArgs) Handles btnBUSCAR.Click
        If CBmarca.Text = "" Then

            MsgBox("Disculpe,debe ingresar una categoria pare realizar la busqueda!", MsgBoxStyle.Critical, "ERROR")
            Me.ReportViewer1.RefreshReport()
        Else
            If Me.ProductosTableAdapter.ProductosMasVendidosMarca(Me.DataSetProyecto.Productos, CBmarca.Text) = False Then
                MsgBox("No se vendieron productos de la marca ingresada!")

                Me.ReportViewer1.RefreshReport()

            End If
            Me.ReportViewer1.RefreshReport()

        End If

    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        If MessageBox.Show("Estas seguro que desea Salir", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Me.Hide()
            'LimpiarCampos()
            Me.Close()

        End If

    End Sub
End Class