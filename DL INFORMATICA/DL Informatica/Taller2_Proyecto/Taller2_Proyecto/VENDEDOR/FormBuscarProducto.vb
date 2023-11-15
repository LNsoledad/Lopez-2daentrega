Public Class FormBuscarProducto

    Dim objProducto As Eproductos = New Eproductos

    Private Sub FormBuscarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarGrid()
    End Sub

    Public Sub cargarGrid()
        objProducto.getProductosActivosConStock(dtgPRODUCTOSActivos)
        If dtgPRODUCTOSActivos.Rows.Count() <> 0 Then
            dtgPRODUCTOSActivos.Rows(0).Selected = False
            dtgPRODUCTOSActivos.Visible = True
            Label2.Visible = True
            Linfo.Visible = False
            tbxBUSCACodigo.Enabled = True
            tbxBUSCADescripcion.Enabled = True
        Else
            dtgPRODUCTOSActivos.Visible = False
            Label2.Visible = False
            Linfo.Visible = True
            tbxBUSCACodigo.Enabled = False
            tbxBUSCADescripcion.Enabled = False
        End If

        'dtgPRODUCTOS.Columns(2).Visible = False 'columna Categorias no aparece
        Try
            dtgPRODUCTOSActivos.Columns(0).Width = 100
            dtgPRODUCTOSActivos.Columns(1).Width = 570
            dtgPRODUCTOSActivos.Columns(2).Width = 120
            dtgPRODUCTOSActivos.Columns(3).Width = 50
            dtgPRODUCTOSActivos.Columns(4).Width = 90

            'alineamiento del contenido de las celdas
            dtgPRODUCTOSActivos.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dtgPRODUCTOSActivos.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dtgPRODUCTOSActivos.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dtgPRODUCTOSActivos.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Catch ex As Exception

        End Try



    End Sub

#Region "Carga datagrid a Factura"

    Private Sub dtgPRODUCTOSActivos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgPRODUCTOSActivos.CellContentClick

        Dim registro As Integer = Me.dtgPRODUCTOSActivos.CurrentRow.Index '//captura el indice de la fila que fue seleccionada

        Dim codigo As Integer = Me.dtgPRODUCTOSActivos.Rows(registro).Cells(0).Value

        Dim descripcion As String = Me.dtgPRODUCTOSActivos.Rows(registro).Cells(1).Value

        Dim precio As Double = Me.dtgPRODUCTOSActivos.Rows(registro).Cells(4).Value


        '//para llevar al formulario anterior que es de facturacion
        FormFacturacion.txtCod.Text = codigo
        FormFacturacion.txtDescripcion.Text = descripcion
        FormFacturacion.txtPRECIO.Text = precio

        FormFacturacion.txtCANTIDAD.Enabled = True
        FormFacturacion.txtCANTIDAD.Focus()
        FormFacturacion.btnAGREGAR_PRODUCTO.Enabled = True
        FormFacturacion.BtnLimpiar.Enabled = True

        Me.Close()
    End Sub


#End Region



#Region "Cerrar Ventana"
    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click


        If MessageBox.Show("Estas seguro que desea Salir", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Me.Hide()

            'Application.[Exit]()
            tbxBUSCACodigo.Clear()
            tbxBUSCADescripcion.Clear()
            Me.Close()

        End If
    End Sub
#End Region


#Region "Busqueda de Productos"
    Public Sub Buscar()

        If tbxBUSCADescripcion.Text = "" Or tbxBUSCACodigo.Text = "" Then

            cargarGrid()

        End If

        If tbxBUSCADescripcion.Text <> "" Then
            objProducto.FiltrarProductosDescripcionActivos(dtgPRODUCTOSActivos, tbxBUSCADescripcion.Text)
            dtgPRODUCTOSActivos.Columns(2).Visible = False 'columna Categorias no aparece
            dtgPRODUCTOSActivos.Columns(6).Visible = False 'columna Estado no aparece
        End If

        If tbxBUSCACodigo.Text <> "" Then
            objProducto.FiltrarProductosCodigoActivos(dtgPRODUCTOSActivos, tbxBUSCACodigo.Text)
            dtgPRODUCTOSActivos.Columns(2).Visible = False 'columna Categorias no aparece
            dtgPRODUCTOSActivos.Columns(6).Visible = False 'columna Estado no aparece
        End If


    End Sub

    Private Sub tbxBUSCADescripcion_TextChanged(sender As Object, e As EventArgs) Handles tbxBUSCADescripcion.TextChanged
        Buscar()
    End Sub

    Private Sub tbxBUSCACodigo_TextChanged(sender As Object, e As EventArgs) Handles tbxBUSCACodigo.TextChanged
        Buscar()

    End Sub

    Private Sub tbxBUSCADescripcion_MouseClick(sender As Object, e As MouseEventArgs) Handles tbxBUSCADescripcion.MouseClick
        tbxBUSCACodigo.Clear()
        cargarGrid()
    End Sub

    Private Sub tbxBUSCACodigo_MouseClick(sender As Object, e As MouseEventArgs) Handles tbxBUSCACodigo.MouseClick
        tbxBUSCADescripcion.Clear()
        cargarGrid()
    End Sub

    Private Sub tbxBUSCADescripcion_GotFocus(sender As Object, e As EventArgs) Handles tbxBUSCADescripcion.GotFocus
        tbxBUSCACodigo.Clear()
        cargarGrid()
    End Sub

    Private Sub tbxBUSCACodigo_GotFocus(sender As Object, e As EventArgs) Handles tbxBUSCACodigo.GotFocus
        tbxBUSCADescripcion.Clear()
        cargarGrid()
    End Sub

#End Region


End Class