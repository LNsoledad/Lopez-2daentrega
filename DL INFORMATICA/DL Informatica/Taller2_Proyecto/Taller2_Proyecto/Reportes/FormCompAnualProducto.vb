Public Class FormCompAnualProducto
    Private Sub FormCompAnualProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetProyecto.COMPORTAMIENTO_ANUAL_ARTICULO' Puede moverla o quitarla según sea necesario.
        Limpiar()
        Me.COMPORTAMIENTO_ANUAL_ARTICULOTableAdapter.EstadisticaProdTodosAños(Me.DataSetProyecto.COMPORTAMIENTO_ANUAL_ARTICULO)
        Me.ReportViewer1.RefreshReport()
    End Sub



    Private Sub BtnVerTodos_Click(sender As Object, e As EventArgs) Handles BtnVerTodos.Click
        Limpiar()
        Me.COMPORTAMIENTO_ANUAL_ARTICULOTableAdapter.EstadisticaProdTodosAños(Me.DataSetProyecto.COMPORTAMIENTO_ANUAL_ARTICULO)
        Me.ReportViewer1.RefreshReport()
        Limpiar()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        FormBuscarCodProdInforme.ShowDialog()
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        If RBcodProd.Checked = True Then
            If tbxCOD.TextLength = 0 Then
                MsgBox("Por favor, seleccione un codigo de producto,gracias!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "INFORMACION")

            Else
                If Me.COMPORTAMIENTO_ANUAL_ARTICULOTableAdapter.EstadisticaProductoAñoCodProd(Me.DataSetProyecto.COMPORTAMIENTO_ANUAL_ARTICULO, tbxCOD.Text, CbxAño.Text) = False Then
                    MsgBox("Diculpe,el producto no tuvo ventas en el año ingresado", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "INFORMACION")
                Else
                    Me.ReportViewer1.RefreshReport()
                End If
            End If

        Else

            If Me.COMPORTAMIENTO_ANUAL_ARTICULOTableAdapter.EstadisticaProductosAño(Me.DataSetProyecto.COMPORTAMIENTO_ANUAL_ARTICULO, CbxAño.Text) = False Then
                    MsgBox("Diculpe,No hubo productos vendidos en el año ingresado", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "INFORMACION")
                Else
                    Me.ReportViewer1.RefreshReport()
                End If


        End If

    End Sub

    Private Sub RBcodProd_CheckedChanged(sender As Object, e As EventArgs) Handles RBcodProd.CheckedChanged
        tbxCOD.Enabled = True
        BtnBuscar.Enabled = True
    End Sub

    Public Sub Limpiar()
        Me.CbxAño.SelectedIndex = 0
        tbxCOD.Clear()
        tbxCOD.Enabled = False
        BtnBuscar.Enabled = False
        RBcodProd.Checked = False
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        If MessageBox.Show("Estas seguro que desea Salir", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Me.Hide()
            Limpiar()
            Me.Close()

        End If
    End Sub
End Class