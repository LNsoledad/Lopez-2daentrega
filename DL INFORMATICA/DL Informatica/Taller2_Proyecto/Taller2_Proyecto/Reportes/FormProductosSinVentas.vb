Public Class FormProductosSinVentas
    Private Sub FormProductosSinVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetProyecto.ProductosSinVentas' Puede moverla o quitarla según sea necesario.
        'Me.ProductosSinVentasTableAdapter.ProductosSinVentas(Me.DataSetProyecto.ProductosSinVentas)

        dtpHASTA.Value = DateTime.Today
        dtpDESDE.Value = New DateTime(2018, 8, 10)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnBUSCAR_Click(sender As Object, e As EventArgs) Handles btnBUSCAR.Click

        Dim fecha_inicio As Date = Convert.ToDateTime(dtpDESDE.Value)
        Dim fecha_final As Date = Convert.ToDateTime(dtpHASTA.Value)

        If dtpDESDE.Value > dtpHASTA.Value Then

            MsgBox("Disculpe,El rango de fecha de inicio debe ser menor que la fecha de finalizaciòn!", MsgBoxStyle.Critical, "ERROR")
            Me.ReportViewer1.RefreshReport()
        Else



            If Me.ProductosSinVentasTableAdapter.Fill(Me.DataSetProyecto.ProductosSinVentas, fecha_inicio, fecha_final) = False Then
                MsgBox("No hubo productos sin vender en el rango de fechas ingresada!")

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