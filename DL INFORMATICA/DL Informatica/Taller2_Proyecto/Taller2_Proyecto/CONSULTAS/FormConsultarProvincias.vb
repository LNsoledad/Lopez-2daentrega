Public Class FormConsultarProvincias

    Dim objProvincia As Eprovincias = New Eprovincias


    Private Sub FormConsultarProvincias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGrid()

    End Sub

    Public Sub CargarGrid()
        objProvincia.getProvinciasAll(DGVprovincias)
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        If MessageBox.Show("Estas seguro que desea Salir", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Me.Hide()

            'Application.[Exit]()       
            Me.Close()

        End If
    End Sub
End Class