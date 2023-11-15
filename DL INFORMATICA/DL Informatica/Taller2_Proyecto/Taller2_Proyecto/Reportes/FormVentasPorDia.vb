Public Class FormVentasPorDia
    Private Sub FormVentasPorDia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetProyecto.TOTAL_VENTAS' Puede moverla o quitarla según sea necesario.
        'Me.TOTAL_VENTASTableAdapter.TotalVentaDia(Me.DataSetProyecto.TOTAL_VENTAS)
        DtpDia.Text = DateTime.Today
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnBUSCAR_Click(sender As Object, e As EventArgs) Handles btnBUSCAR.Click
        If Me.TOTAL_VENTASTableAdapter.TotalVentaDia(Me.DataSetProyecto.TOTAL_VENTAS, DtpDia.Text) = False Then
            MsgBox(" Disculpe, NO SE REGISTRARON VENTAS EN ESA FECHA, por favor elija otra fecha", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informacion")
            Me.ReportViewer1.RefreshReport()
        Else
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