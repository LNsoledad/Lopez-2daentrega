Public Class FormLogin

    Dim objUsuario As Eusuarios = New Eusuarios
    Dim objEmpleado As Eempleados = New Eempleados
 

    Dim nomYApe As String

#Region "Propiedades de BOTONES"
    Private Sub BtnIngresar_MouseHover(sender As Object, e As EventArgs) Handles BtnIngresar.MouseHover
        BtnIngresar.Size = New Size(65, 60)
        BtnIngresar.Image = My.Resources.btn_ingresar2_log1
    End Sub

    Private Sub BtnIngresar_MouseLeave(sender As Object, e As EventArgs) Handles BtnIngresar.MouseLeave
        BtnIngresar.Size = New Size(65, 60)
        BtnIngresar.Image = My.Resources.btn_ingresar_log1
    End Sub
    'cuando se esta en el boton
    Private Sub BtnSalir_MouseHover(sender As Object, e As EventArgs) Handles BtnSalir.MouseHover
        BtnSalir.Size = New Size(30, 25)
        BtnSalir.Image = My.Resources.salir

    End Sub

    'cuando se aleja del boton
    Private Sub BtnSalir_MouseLeave(sender As Object, e As EventArgs) Handles BtnSalir.MouseLeave
        BtnSalir.Size = New Size(30, 25)
        BtnSalir.Image = My.Resources.salir1


    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        If MessageBox.Show("Estas seguro que desea Salir", "Cerrar Login", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then


            Me.Close()
            'Aplication.Exit() cierra todo lo que este abierto
            Application.Exit()
        End If
    End Sub
#End Region

    'Validaciones del campo usuario para que ingrese solo numeros

    Private Sub TextUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextUsuario.KeyPress
        validarSoloNumeros(e)
    End Sub

    'Validacion del campo contraseña para que ingrese solo numeros
    Private Sub TextContraseña_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextContraseña.KeyPress
        validarNumerosYLetras(e)
    End Sub

    'condigo para mostrar y no mostrar contraseña
    Private Sub CheckBoxMostrar_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxMostrar.CheckedChanged
        If CheckBoxMostrar.Checked = True Then
            If TextContraseña.PasswordChar = "*" Then
                TextContraseña.PasswordChar = Nothing
                TextContraseña.Focus()

            End If
        Else
            TextContraseña.PasswordChar = "*"
            TextContraseña.Focus()
        End If
    End Sub

    Private Sub Salir(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyData = Keys.Escape Then
            Me.Close()
            Application.[Exit]()
        End If

        If e.KeyData = Keys.Enter Then
            Me.BtnIngresar_Click_1(sender, CType(e, EventArgs))
        End If
    End Sub

    Private Sub BtnIngresar_Click_1(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Dim objUsuario As Usuarios = New Usuarios()

        If TextUsuario.Text.Trim() = "" Then
            MsgBox("Asegúrese de ingresar el Usuario", MsgBoxStyle.Critical, "ERROR")
            TextUsuario.Focus() 'se posiciona en textbox usuario
            CheckBoxMostrar.Checked = False
            Exit Sub
        ElseIf TextContraseña.Text.Trim() = "" Then
            MsgBox("Asegúrese de ingresar la Contraseña", MsgBoxStyle.Critical, "ERROR")
            TextContraseña.Focus() 'se posiciona en textbox contraseña
            CheckBoxMostrar.Checked = False
            Exit Sub
        End If


        '  MsgBox("hola 1")
        'preguntar si el estado del usuario esta activo
        'Try
        Dim oUsuario As Eusuarios = New Eusuarios

        If oUsuario.buscarUsuario(CInt(TextUsuario.Text)) = 1 Then

            ' ---------------------------------------------------

            'If (Validacion.validarUsuario(TextUsuario.Text) And Validacion.validarClave(TextUsuario.Text, TextContraseña.Text)) Then

            DatosImportantes.Mdni = objEmpleado.buscarEmpleado(TextUsuario.Text).Dni_empleados
            DatosImportantes.Mapellido = objEmpleado.buscarEmpleado(TextUsuario.Text).apellido
            DatosImportantes.Mnombre = objEmpleado.buscarEmpleado(TextUsuario.Text).nombre
            ' DatosImportantes.IdUsu = oUsuario.buscarUsuario(TextUsuario.Text).id_usuario
            ' DatosImportantes.IdUsu = oUsuario.buscarUsuario(TextUsuario.Text).id_usuario
            DatosImportantes.IdUsu = oUsuario.dbuscarUsuario(TextUsuario.Text).id_usuario

            'If objUsuario.buscarUsuario(Mdni).estado_usuario = True Then

            MsgBox("Bienvenido " + DatosImportantes.Mapellido + "," + DatosImportantes.Mnombre, MsgBoxStyle.Information, "Bienvenida")


                '--------------------------------------------
                'MsgBox("Bienvenido " + DatosImportantes.Mapellido + "," + DatosImportantes.Mnombre, MsgBoxStyle.Information, "Bienvenida")
                Dim dUsuario As Usuarios = New Usuarios
                dUsuario = oUsuario.dbuscarUsuario(CInt(TextUsuario.Text))

                Select Case dUsuario.id_tipoUsuario
                    Case 1
                        MsgBox("cliente 1")
                        Me.Hide()
                        FormFondo.Hide()
                        FormSuperAdministrador.Show()
                        Me.Hide()
                        FormFondo.Hide()
                        limpiarCampos()
                        Me.Close()
                    Case 2
                        MsgBox("administrador 1")
                        Me.Hide()
                        FormFondo.Hide()
                        FormAdministrador.Show()
                        Me.Hide()
                        FormFondo.Hide()
                        limpiarCampos()
                        Me.Close()
                    Case 3

                        FormSupervisor.Show()
                        Me.Hide()
                        FormFondo.Hide()
                        limpiarCampos()
                        Me.Close()
                    Case 4
                        Me.Hide()
                        FormFondo.Hide()
                        FormVendedor.Show()
                        Me.Hide()
                        FormFondo.Hide()
                        limpiarCampos()
                        Me.Close()
                End Select

            Else
                'mensaje de error, usuario dado de baja

                MsgBox("Disculpe,Usted ya no tiene permitido el ingreso al sistema", MsgBoxStyle.Information, "AVISO")
            'limpiarCampos()

        End If
        Exit Sub

















        'If (Validacion.validarUsuario(TextUsuario.Text) And Validacion.validarClave(TextUsuario.Text, TextContraseña.Text)) Then

        '    DatosImportantes.Mdni = objEmpleado.buscarEmpleado(TextUsuario.Text).Dni_empleados
        '    DatosImportantes.Mapellido = objEmpleado.buscarEmpleado(TextUsuario.Text).apellido
        '    DatosImportantes.Mnombre = objEmpleado.buscarEmpleado(TextUsuario.Text).nombre
        ' DatosImportantes.IdUsu = objUsuario.buscarUsuario(TextUsuario.Text)

        '        If objUsuario.buscarUsuario(Mdni) = True Then

        '            MsgBox("Bienvenido " + DatosImportantes.Mapellido + "," + DatosImportantes.Mnombre, MsgBoxStyle.Information, "Bienvenida")

        '            Dim tipo_usuario As Integer = objUsuario.buscarUsuario(Mdni)

        '            Select Case tipo_usuario
        '                Case 1
        '                    'Me.Hide()
        '                    'FormFondo.Hide()
        '                    FormSuperAdministrador.Show()
        '                    Me.Hide()
        '                    'FormFondo.Hide()
        '                    limpiarCampos()
        '                    Me.Close()
        '                Case 2
        '                    'Me.Hide()
        '                    'FormFondo.Hide()
        '                    FormAdministrador.Show()
        '                    Me.Hide()
        '                    ' FormFondo.Hide()
        '                    limpiarCampos()
        '                    Me.Close()
        '                Case 3

        '                    FormSupervisor.Show()
        '                    Me.Hide()
        '                    'FormFondo.Hide()
        '                    limpiarCampos()
        '                    Me.Close()
        '                Case 4
        '                    'Me.Hide()
        '                    'FormFondo.Hide()
        '                    FormVendedor.Show()
        '                    Me.Hide()
        '                    ' FormFondo.Hide()
        '                    limpiarCampos()
        '                    Me.Close()
        '            End Select

        '        Else
        '            'mensaje de error, usuario dado de baja

        '            MsgBox("Disculpe,Usted ya no tiene permitido el ingreso al sistema", MsgBoxStyle.Information, "AVISO")
        '            'limpiarCampos()

        '        End If


        '    Else
        '        MsgBox("Error en usuario o contraseña", MsgBoxStyle.Critical, "ERROR")
        '        'limpiarCampos()
        '    End If

        'Catch ex As Exception
        '    MsgBox("Hubo un error,disculpe por favor vuelva a ingresar sus datos", MsgBoxStyle.Information, "AVISO")
        '    limpiarCampos()
        'End Try

    End Sub

    Public Sub limpiarCampos()
        TextContraseña.Clear()
        TextUsuario.Clear()
        TextUsuario.Focus()
        CheckBoxMostrar.Checked = False
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'FormBienvenida.Hide()
        'FormBienvenida.Close()
        limpiarCampos()
        'FormFondo.Show()

    End Sub

    Private Sub TextUsuario_TextChanged(sender As Object, e As EventArgs) Handles TextUsuario.TextChanged

    End Sub
End Class