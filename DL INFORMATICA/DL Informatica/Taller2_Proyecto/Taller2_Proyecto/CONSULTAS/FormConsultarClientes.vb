
Imports System.ComponentModel

Public Class FormConsultarClientes

    Dim objCliente As Eclientes = New Eclientes

    Private Sub FormConsultarClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarGrid()

    End Sub

    Public Sub cargarGrid()
        objCliente.getClientesActivos(dtgCLIENTES) 'llamamos al metodo getClientesActivos para que nos traiga de la base de datos todos los clientes activos
        dtgCLIENTES.Columns(8).Visible = False

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
            dtgCLIENTES.Columns(0).Width = 90
            dtgCLIENTES.Columns(1).Width = 120
            dtgCLIENTES.Columns(2).Width = 160
            dtgCLIENTES.Columns(3).Width = 180
            dtgCLIENTES.Columns(4).Width = 100
            dtgCLIENTES.Columns(5).Width = 100
            dtgCLIENTES.Columns(6).Width = 190
            dtgCLIENTES.Columns(7).Width = 100
            dtgCLIENTES.Columns(9).Width = 110
        Catch ex As Exception

        End Try

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



End Class