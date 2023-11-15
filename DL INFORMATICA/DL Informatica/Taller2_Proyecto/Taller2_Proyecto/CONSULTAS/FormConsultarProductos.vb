Imports System.ComponentModel

Public Class FormConsultarProductos

    Dim objProducto As Eproductos = New Eproductos

    Private Sub FormConsultarProductos_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargarGrid()
    End Sub

    Public Sub cargarGrid()
        objProducto.getProductosActivos(dtgPRODUCTOS)
        'dtgPRODUCTOS.Columns(2).Visible = False 'no aparezca la columna de categorias
        'dtgPRODUCTOS.Columns(6).Visible = False

        If dtgPRODUCTOS.Rows.Count() <> 0 Then
            dtgPRODUCTOS.Rows(0).Selected = False
            dtgPRODUCTOS.Visible = True
            Label2.Visible = True
            Linfo.Visible = False
            tbxBUSCACodigo.Enabled = True
            tbxBUSCADescripcion.Enabled = True
        Else
            dtgPRODUCTOS.Visible = False
            Label2.Visible = False
            Linfo.Visible = True
            tbxBUSCACodigo.Enabled = False
            tbxBUSCADescripcion.Enabled = False
        End If


        Try
            'redimensionar algunas columnaas
            dtgPRODUCTOS.Columns(0).Width = 80
            dtgPRODUCTOS.Columns(1).Width = 530
            dtgPRODUCTOS.Columns(3).Width = 110
            dtgPRODUCTOS.Columns(4).Width = 80
            dtgPRODUCTOS.Columns(5).Width = 60
            dtgPRODUCTOS.Columns(6).Width = 80
            dtgPRODUCTOS.Columns(7).Width = 80 'columna precio_venta
            'alineacion del texto de las columnas
            dtgPRODUCTOS.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dtgPRODUCTOS.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dtgPRODUCTOS.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dtgPRODUCTOS.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dtgPRODUCTOS.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dtgPRODUCTOS.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dtgPRODUCTOS.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dtgPRODUCTOS.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Catch ex As Exception

        End Try



    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        If MessageBox.Show("Estas seguro que desea Salir", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Me.Hide()
            'FormVendedor.Show()
            'Application.[Exit]()
            tbxBUSCACodigo.Clear()
            tbxBUSCADescripcion.Clear()
            Me.Close()

        End If
    End Sub

#Region "Busqueda de Productos"
    Public Sub Buscar()

        If tbxBUSCADescripcion.Text = "" Or tbxBUSCACodigo.Text = "" Then

            cargarGrid()

        End If

        If tbxBUSCADescripcion.Text <> "" Then
            objProducto.FiltrarProductosDescripcionActivos(dtgPRODUCTOS, tbxBUSCADescripcion.Text)
        End If

        If tbxBUSCACodigo.Text <> "" Then
            objProducto.FiltrarProductosCodigoActivos(dtgPRODUCTOS, tbxBUSCACodigo.Text)
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