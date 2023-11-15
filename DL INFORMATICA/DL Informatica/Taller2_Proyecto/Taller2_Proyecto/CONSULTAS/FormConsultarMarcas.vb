Public Class FormConsultarMarcas

    Dim objMarca As Emarcas = New Emarcas
    Private Sub FormConsultarMarcas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGrid()

    End Sub

    Public Sub CargarGrid()
        objMarca.getMarcasAll(DGVmarcas)
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        If MessageBox.Show("Estas seguro que desea Salir", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Me.Hide()
            'FormGestionarProductos.Show()
            'Application.[Exit]()       
            Me.Close()

        End If
    End Sub
End Class