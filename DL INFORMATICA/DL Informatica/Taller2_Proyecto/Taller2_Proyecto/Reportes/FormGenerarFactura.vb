Public Class FormGenerarFactura

    Public Sub mostrarFactura(ByVal idFactura As Integer)
        ' TODO: esta línea de código carga datos en la tabla '.Facturas' Puede moverla o quitarla según sea necesario.
        Me.FacturasTableAdapter.GenerarFactura(Me.DataSetProyecto.Facturas, idFactura)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        If MessageBox.Show("Estas seguro que desea Salir", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Me.Hide()
            Me.Close()

        End If
    End Sub
End Class