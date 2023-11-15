Public Class FormProductosMasVendidosPorCat

    Dim objProducto As Eproductos = New Eproductos
    Private Sub FormProductosMasVendidosPorCat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetProyecto.Productos' Puede moverla o quitarla según sea necesario.
        'Me.ProductosTableAdapter.ProductosMasVendidosCategoria(Me.DataSetProyecto.Productos)
        CargarCategorias()
        CBcategoria.SelectedValue = 0
        Me.ReportViewer1.RefreshReport()
    End Sub



    Public Sub CargarCategorias()
        objProducto.cargarBoxCategorias(CBcategoria)
    End Sub

    Private Sub btnBUSCAR_Click(sender As Object, e As EventArgs) Handles btnBUSCAR.Click
        If CBcategoria.Text = "" Then

            MsgBox("Disculpe,debe ingresar una categoria pare realizar la busqueda!", MsgBoxStyle.Critical, "ERROR")
            Me.ReportViewer1.RefreshReport()
        Else
            If Me.ProductosTableAdapter.ProductosMasVendidosCategoria(Me.DataSetProyecto.Productos, CBcategoria.Text) = False Then
                MsgBox("No se vendieron productos de la categoria ingresada!")

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