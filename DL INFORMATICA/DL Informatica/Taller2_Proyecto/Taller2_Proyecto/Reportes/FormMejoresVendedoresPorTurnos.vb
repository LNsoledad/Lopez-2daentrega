Public Class FormMejoresVendedoresPorTurnos
    Private Sub FormMejoresVendedoresPorTurnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetProyecto.Empleados' Puede moverla o quitarla según sea necesario.
        'Me.EmpleadosTableAdapter.MejoresVendedores(Me.DataSetProyecto.Empleados)
        CBturno.SelectedValue = -1

    End Sub

    Private Sub btnBUSCAR_Click(sender As Object, e As EventArgs) Handles btnBUSCAR.Click
        If CBturno.Text = "" Then

            MsgBox("Disculpe,debe ingresar un turno pare realizar la busqueda!", MsgBoxStyle.Critical, "ERROR")
            Me.ReportViewer1.RefreshReport()
        Else
            If Me.EmpleadosTableAdapter.MejoresVendedoresPorTurno(Me.DataSetProyecto.Empleados, CBturno.Text) = False Then
                MsgBox("Los vendedores no realizaron ventas en el turno ingresado!")

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