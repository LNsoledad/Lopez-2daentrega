Imports System.ComponentModel

Public Class FormConsultarUsuarios



    Dim objUsuario As Eusuarios = New Eusuarios

    Private Sub FormConsultarUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarGrid()
    End Sub


    Public Sub cargarGrid()
        objUsuario.getUsuariosActivos(dtgUSUARIOS)
        ' dtgUSUARIOS.Columns(0).Visible = False 'no aparece la columna de id_usuario
        Me.dtgUSUARIOS.Columns(4).Visible = False
        Me.dtgUSUARIOS.Columns(5).Visible = False 'no aparezca en la tabla la contraseña


        If dtgUSUARIOS.Rows.Count() <> 0 Then
            dtgUSUARIOS.Rows(0).Selected = False 'para que no este seleccionada ninguna fila
            LinfoUsuario.Visible = False
            Label2.Visible = True
            dtgUSUARIOS.Visible = True
            txtBuscarApe.Enabled = True
            txtBuscarDNI.Enabled = True

        Else
            LinfoUsuario.Visible = True
            Label2.Visible = False
            dtgUSUARIOS.Visible = False
            txtBuscarApe.Enabled = False
            txtBuscarDNI.Enabled = False
            Exit Sub
        End If

        Try
            dtgUSUARIOS.Columns(0).Width = 100
            dtgUSUARIOS.Columns(1).Width = 100
            dtgUSUARIOS.Columns(2).Width = 150
            dtgUSUARIOS.Columns(3).Width = 170

            'dtgUSUARIOS.Columns(4).Width = 65
        Catch ex As Exception

        End Try


    End Sub


#Region "Busqueda de Usuario"
    Public Sub Buscar()

        If txtBuscarApe.Text = "" Or txtBuscarDNI.Text = "" Then

            cargarGrid()

        End If

        If txtBuscarApe.Text <> "" Then
            objUsuario.FiltrarUsuariosApellidosActivos(dtgUSUARIOS, txtBuscarApe.Text)
        End If

        If txtBuscarDNI.Text <> "" Then
            objUsuario.FiltrarUsuarioDNIActivos(dtgUSUARIOS, txtBuscarDNI.Text)
        End If

    End Sub

    Private Sub txtBuscarApe_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarApe.TextChanged
        Buscar()
    End Sub

    Private Sub txtBuscarDNI_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarDNI.TextChanged
        Buscar()

    End Sub

    Private Sub txtBuscarApe_MouseClick(sender As Object, e As MouseEventArgs) Handles txtBuscarApe.MouseClick
        txtBuscarDNI.Clear()
        cargarGrid()
    End Sub

    Private Sub txtBuscarDNI_MouseClick(sender As Object, e As MouseEventArgs) Handles txtBuscarDNI.MouseClick
        txtBuscarApe.Clear()
        cargarGrid()
    End Sub

    Private Sub txtBuscarApe_GotFocus(sender As Object, e As EventArgs) Handles txtBuscarApe.GotFocus
        txtBuscarDNI.Clear()
        cargarGrid()
    End Sub

    Private Sub txtBuscarDNI_GotFocus(sender As Object, e As EventArgs) Handles txtBuscarDNI.GotFocus
        txtBuscarApe.Clear()
        cargarGrid()
    End Sub

#End Region

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        If MessageBox.Show("Estas seguro que desea Salir", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Me.Hide()

            'Application.[Exit]()
            txtBuscarApe.Clear()
            txtBuscarDNI.Clear()
            Me.Close()

        End If
    End Sub
End Class