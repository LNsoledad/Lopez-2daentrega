Public Class FormBuscarCliente

    Dim objCliente As Eclientes = New Eclientes

    Private Sub FormConsultarClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarGrid()

    End Sub

    Public Sub cargarGrid()
        objCliente.getClientesActivos(dtgCLIENTES)

        If dtgCLIENTES.Rows.Count() <> 0 Then
            dtgCLIENTES.Rows(0).Selected = False
            dtgCLIENTES.Visible = True

            Label2.Visible = True
            Linfo.Visible = False
            tbxBUSCAAPE.Enabled = True
            tbxBUSCADNI.Enabled = True
        Else
            dtgCLIENTES.Visible = False

            Label2.Visible = False
            Linfo.Visible = True
            tbxBUSCAAPE.Enabled = False
            tbxBUSCADNI.Enabled = False
        End If

        Try
            dtgCLIENTES.Columns(0).Width = 60
            dtgCLIENTES.Columns(1).Width = 80
            dtgCLIENTES.Columns(2).Width = 100
            'dtgCLIENTES.Columns(3).Width = 150
            'dtgCLIENTES.Columns(6).Width = 170
            'dtgCLIENTES.Columns(7).Width = 95
        Catch ex As Exception

        End Try
        dtgCLIENTES.Columns(3).Visible = False
        dtgCLIENTES.Columns(4).Visible = False
        dtgCLIENTES.Columns(5).Visible = False
        dtgCLIENTES.Columns(6).Visible = False
        dtgCLIENTES.Columns(7).Visible = False
        dtgCLIENTES.Columns(8).Visible = False
        dtgCLIENTES.Columns(9).Visible = False
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        If MessageBox.Show("Estas seguro que desea Salir", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Me.Hide()
            'FormVendedor.Show()
            'Application.[Exit]()
            tbxBUSCAAPE.Clear()
            tbxBUSCADNI.Clear()
            Me.Close()

        End If
    End Sub

#Region "Busqueda de Cliente"
    Public Sub Buscar()

        If tbxBUSCAAPE.Text = "" Or tbxBUSCADNI.Text = "" Then

            cargarGrid()

        End If

        If tbxBUSCAAPE.Text <> "" Then
            objCliente.FiltrarClientesApellidosActivos(dtgCLIENTES, tbxBUSCAAPE.Text)
        End If

        If tbxBUSCADNI.Text <> "" Then
            objCliente.FiltrarClienteDNIActivos(dtgCLIENTES, tbxBUSCADNI.Text)
        End If

    End Sub

    Private Sub tbxBUSCAAPE_TextChanged(sender As Object, e As EventArgs) Handles tbxBUSCAAPE.TextChanged
        Buscar()
    End Sub

    Private Sub tbxBUSCADNI_TextChanged(sender As Object, e As EventArgs) Handles tbxBUSCADNI.TextChanged
        Buscar()

    End Sub

    Private Sub tbxBUSCAAPE_MouseClick(sender As Object, e As MouseEventArgs) Handles tbxBUSCAAPE.MouseClick
        tbxBUSCADNI.Clear()
        cargarGrid()
    End Sub

    Private Sub tbxBUSCADNI_MouseClick(sender As Object, e As MouseEventArgs) Handles tbxBUSCADNI.MouseClick
        tbxBUSCAAPE.Clear()
        cargarGrid()
    End Sub

    Private Sub tbxBUSCAAPE_GotFocus(sender As Object, e As EventArgs) Handles tbxBUSCAAPE.GotFocus
        tbxBUSCADNI.Clear()
        cargarGrid()
    End Sub

    Private Sub tbxBUSCADNI_GotFocus(sender As Object, e As EventArgs) Handles tbxBUSCADNI.GotFocus
        tbxBUSCAAPE.Clear()
        cargarGrid()
    End Sub


#End Region

#Region "Carga datagrid a Factura"

    Private Sub dtgCLIENTES_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgCLIENTES.CellDoubleClick

        Dim registro As Integer = Me.dtgCLIENTES.CurrentRow.Index '//captura el indice de la fila que fue seleccionada

        Dim dni As Integer = Me.dtgCLIENTES.Rows(registro).Cells(0).Value

        Dim apellido As String = Me.dtgCLIENTES.Rows(registro).Cells(1).Value

        Dim nombre As String = Me.dtgCLIENTES.Rows(registro).Cells(2).Value


        '//para llevar al formulario anterior que es de facturacion
        FormFacturacion.tbxCLIENTE_cod.Text = dni
        FormFacturacion.tbxCLIENTE_ape.Text = apellido
        FormFacturacion.tbxCLIENTE_nom.Text = nombre


        Me.Close()
    End Sub


#End Region

End Class