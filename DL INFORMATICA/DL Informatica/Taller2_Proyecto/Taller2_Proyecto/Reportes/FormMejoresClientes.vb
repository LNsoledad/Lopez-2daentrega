Public Class FormMejoresClientes
    Private Sub FormMejoresClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetProyecto.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.MostrarMejoresClientes(Me.DataSetProyecto.Clientes)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        If MessageBox.Show("Estas seguro que desea Salir", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Me.Hide()

            Me.Close()

        End If
    End Sub
End Class