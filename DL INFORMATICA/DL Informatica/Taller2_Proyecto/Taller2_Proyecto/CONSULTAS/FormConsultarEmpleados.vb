Imports System.ComponentModel

Public Class FormConsultarEmpleados

    Dim objEmpleado As Eempleados = New Eempleados

    Private Sub FormConsultarEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarGrid()
    End Sub

    Public Sub cargarGrid()
        objEmpleado.getEmpleadosActivos(dtgEmpleados)

        If dtgEmpleados.Rows.Count() <> 0 Then
            dtgEmpleados.Rows(0).Selected = False 'para que no este seleccionada ninguna fila

            Label2.Visible = True
            dtgEmpleados.Visible = True
            Linfo.Visible = False
            tbxBUSCAAPE.Enabled = True
            tbxBUSCADNI.Enabled = True

        Else

            Label2.Visible = False
            dtgEmpleados.Visible = False
            Linfo.Visible = True
            tbxBUSCAAPE.Enabled = False
            tbxBUSCADNI.Enabled = False
            Exit Sub
        End If

        dtgEmpleados.Columns(8).Visible = False 'columna de estado no esta visible

        Try
            dtgEmpleados.Columns(0).Width = 90
            dtgEmpleados.Columns(1).Width = 110
            dtgEmpleados.Columns(2).Width = 170
            dtgEmpleados.Columns(3).Width = 160
            dtgEmpleados.Columns(4).Width = 150
            dtgEmpleados.Columns(5).Width = 115
            dtgEmpleados.Columns(6).Width = 110
            dtgEmpleados.Columns(7).Width = 110
            dtgEmpleados.Columns(10).Width = 75 'columna turno
        Catch ex As Exception

        End Try
        dtgEmpleados.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        If MessageBox.Show("Estas seguro que desea Salir", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Me.Hide()

            'Application.[Exit]()
            tbxBUSCAAPE.Clear()
            tbxBUSCADNI.Clear()
            Me.Close()

        End If
    End Sub

#Region "Busqueda de empleado"

    Public Sub Buscar()

        If tbxBUSCAAPE.Text = "" Or tbxBUSCADNI.Text = "" Then

            cargarGrid()

        End If

        If tbxBUSCAAPE.Text <> "" Then
            objEmpleado.FiltrarEmpleadosApellidosActivos(dtgEmpleados, tbxBUSCAAPE.Text)
        End If

        If tbxBUSCADNI.Text <> "" Then
            objEmpleado.FiltrarEmpleadoDNIActivos(dtgEmpleados, tbxBUSCADNI.Text)
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

    Private Sub ListadoEmpleados_Enter(sender As Object, e As EventArgs) Handles ListadoEmpleados.Enter

    End Sub




#End Region


End Class