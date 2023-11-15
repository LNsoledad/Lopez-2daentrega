Public Class FormBuscarCategorias
    Dim objCategoria As Ecategorias = New Ecategorias
    Private Sub FormBuscarCategorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGrid()

    End Sub

    Public Sub CargarGrid()
        objCategoria.getCategoriasAll(DGVcategorias)
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