Imports System.ComponentModel

Public Class FormGestionarUsuarios

    Dim objUsuario As Eusuarios = New Eusuarios
    Dim objTipoUsuario As EtipoUsuario = New EtipoUsuario
    Dim objEmpleado As Eempleados = New Eempleados


    Private Sub FormGestionarUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpiar()

        CargarTipoUsuarios()
        CargarGridUsuarios()
        CargarGridEmpleados()
    End Sub


    Public Sub CargarTipoUsuarios()
        objTipoUsuario.cargarBox(cbxUsuario)
    End Sub

    Public Sub CargarGridUsuarios()
        objUsuario.getUsuariosAll(dtgUSUARIOS)
        Me.dtgUSUARIOS.Columns(0).Visible = False '//para que no aparezca la columna codigo, que no se muestre pero que esta en el datagrid, pero se necesita para saber de que usuario se trata
        Me.dtgUSUARIOS.Columns(5).Visible = False 'columna Estado
        Me.dtgUSUARIOS.Columns(6).Visible = False 'no aparezca en la tabla la contraseña

        If dtgUSUARIOS.Rows.Count() <> 0 Then
            dtgUSUARIOS.Rows(0).Selected = False 'para que no este seleccionada ninguna fila
            LinfoUsuario.Visible = False
            Label7.Visible = True
            dtgUSUARIOS.Visible = True
            txtBuscarApe.Enabled = True
            txtBuscarDNI.Enabled = True
        Else
            LinfoUsuario.Visible = True
            Label7.Visible = False
            dtgUSUARIOS.Visible = False
            txtBuscarApe.Enabled = False
            txtBuscarDNI.Enabled = False
            Exit Sub
        End If

        Try
            dtgUSUARIOS.Columns(1).Width = 110 'columna DNI
            dtgUSUARIOS.Columns(2).Width = 110
            dtgUSUARIOS.Columns(3).Width = 150
            'dtgUSUARIOS.Columns(4).Width = 110 'columna TipoUsuario
            'dtgUSUARIOS.Columns(5).Width = 80 'columna Estado
        Catch ex As Exception

        End Try

    End Sub



    Public Sub CargarGridEmpleados()
        objEmpleado.getEmpleadosActivos(dtgEMPLEADOS)


        If dtgEMPLEADOS.Rows.Count <> 0 Then
            dtgEMPLEADOS.Rows(0).Selected = False 'para que no este seleccionada ninguna fila

            Linfo.Visible = False
            Label1.Visible = True
            Label4.Visible = True
            dtgEMPLEADOS.Visible = True

            tbxBUSCAAPE.Enabled = True
            tbxBUSCADNI.Enabled = True
        Else
            Linfo.Visible = True
            Label1.Visible = False
            Label4.Visible = False
            dtgEMPLEADOS.Visible = False

            tbxBUSCAAPE.Enabled = False
            tbxBUSCADNI.Enabled = False
            Exit Sub
        End If

        Try
            Me.dtgEMPLEADOS.Columns(3).Visible = False
            Me.dtgEMPLEADOS.Columns(4).Visible = False
            Me.dtgEMPLEADOS.Columns(5).Visible = False
            Me.dtgEMPLEADOS.Columns(6).Visible = False
            Me.dtgEMPLEADOS.Columns(7).Visible = False
            Me.dtgEMPLEADOS.Columns(8).Visible = False
            Me.dtgEMPLEADOS.Columns(9).Visible = False
            Me.dtgEMPLEADOS.Columns(10).Visible = False
        Catch ex As Exception

        End Try



    End Sub

#Region "VALIDACION DE CLAVE"

    Private Sub txtCLAVE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCLAVE.KeyPress
        'validarSoloNumeros(e)
        validarNumerosYLetras(e)
    End Sub


#End Region


#Region "CERRAR VENTANA"
    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        If MessageBox.Show("Estas seguro que desea Salir", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Me.Hide()
            'FormVendedor.Show()
            'Application.[Exit]()
            tbxBUSCAAPE.Clear()
            tbxBUSCADNI.Clear()
            Limpiar()

            Me.Close()

        End If
    End Sub

#End Region


    Dim fila As Integer 'variable global que obtendra el indice de la fila que se clickeo

    Private Sub dtgEMPLEADOS_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgEMPLEADOS.CellDoubleClick
        fila = dtgEMPLEADOS.CurrentRow.Index 'toma el indice de la fila en la cual se hizo doble click

        txtDNI.Text = dtgEMPLEADOS.Item(0, fila).Value()
        txtAPE.Text = dtgEMPLEADOS.Item(1, fila).Value()
        txtNOM.Text = dtgEMPLEADOS.Item(2, fila).Value()

        txtCLAVE.Clear()
        cbxUsuario.SelectedValue = -1

        BtnLimpiar.Enabled = True
            btnAGREGAR.Enabled = True
            BtnActivar.Enabled = False
            btnELIMINAR.Enabled = False
        btnMODIFICAR.Enabled = False

        txtCLAVE.Enabled = True
        cbxUsuario.Enabled = True




    End Sub

    Private Sub dtgUSUARIOS_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dtgUSUARIOS.CellFormatting
        Dim valor As Boolean
        Try
            For i As Integer = 0 To dtgUSUARIOS.Rows.Count() - 1
                valor = dtgUSUARIOS.Rows(i).Cells(5).Value
                If valor = False Then
                    dtgUSUARIOS.Rows(i).DefaultCellStyle.BackColor = Color.MediumVioletRed
                Else
                    dtgUSUARIOS.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
                End If
            Next
        Catch ex As Exception

        End Try

    End Sub


    Dim idUsuario As Integer 'Para saber que el id usuario que fue seleccionado
    Private Sub dtgUSUARIOS_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgUSUARIOS.CellDoubleClick
        fila = dtgUSUARIOS.CurrentRow.Index 'toma el indice de la fila en la cual se hizo doble click

        idUsuario = dtgUSUARIOS.Item(0, fila).Value()

        txtDNI.Text = dtgUSUARIOS.Item(1, fila).Value()
        txtAPE.Text = dtgUSUARIOS.Item(2, fila).Value()
        txtNOM.Text = dtgUSUARIOS.Item(3, fila).Value()
        cbxUsuario.Text = dtgUSUARIOS.Item(4, fila).Value()
        txtCLAVE.Text = dtgUSUARIOS.Item(6, fila).Value()

        Dim estado As Boolean = dtgUSUARIOS.Item(5, fila).Value()

        If estado Then

            Dim mensajeModificar As String = "Desea Modificar el Usuario?"
            If (Validacion.EstaUdSeguro(mensajeModificar)) Then
                btnAGREGAR.Enabled = False
                BtnActivar.Enabled = False
                btnELIMINAR.Enabled = False
                BtnLimpiar.Enabled = True

                btnMODIFICAR.Enabled = True

                'habilitar campos de textos
                txtCLAVE.Enabled = True
                cbxUsuario.Enabled = True


                Exit Sub

            End If

            Dim mensajeBaja As String = "Desea Dar de Baja el Usuario?"
            If (Validacion.EstaUdSeguro(mensajeBaja)) Then
                BtnActivar.Enabled = False
                btnELIMINAR.Enabled = True
                BtnLimpiar.Enabled = True
                btnAGREGAR.Enabled = False
                btnMODIFICAR.Enabled = False

                'inhabilitar campos
                txtCLAVE.Enabled = False
                cbxUsuario.Enabled = False


                Exit Sub


            End If


        Else

            Dim mensajeModificar As String = "Desea Modificar el Usuario?"
            If (Validacion.EstaUdSeguro(mensajeModificar)) Then
                btnAGREGAR.Enabled = False
                BtnActivar.Enabled = False
                btnELIMINAR.Enabled = False
                BtnLimpiar.Enabled = True

                btnMODIFICAR.Enabled = True

                'habilitar campos de textos
                txtCLAVE.Enabled = True
                cbxUsuario.Enabled = True

                Exit Sub

            End If

            Dim mensajeAlta As String = "Desea Dar de Alta el Usuario?"
            If (Validacion.EstaUdSeguro(mensajeAlta)) Then
                BtnActivar.Enabled = True
                BtnLimpiar.Enabled = True
                btnAGREGAR.Enabled = False
                btnMODIFICAR.Enabled = False
                btnELIMINAR.Enabled = False

                'inhabilitar campos
                txtCLAVE.Enabled = False
                cbxUsuario.Enabled = False

                Exit Sub


            End If



        End If 'cierre del if estado

        Limpiar()

        txtCLAVE.Enabled = False
        cbxUsuario.Enabled = False


    End Sub

    Private Sub Limpiar()
        txtAPE.Clear()
        txtNOM.Clear()
        txtCLAVE.Clear()
        cbxUsuario.SelectedValue = -1
        txtDNI.Clear()
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Limpiar()
        BtnLimpiar.Enabled = False
        btnAGREGAR.Enabled = False
        BtnActivar.Enabled = False
        btnELIMINAR.Enabled = False
        btnMODIFICAR.Enabled = False
        txtCLAVE.Enabled = False
        cbxUsuario.Enabled = False
    End Sub

    Private Sub btnAGREGAR_Click(sender As Object, e As EventArgs) Handles btnAGREGAR.Click
        Dim ask As MsgBoxResult

        If txtDNI.Text = "" Or txtAPE.Text = "" Or txtNOM.Text = "" Or cbxUsuario.Text = "" Or txtCLAVE.Text = "" Then
            MsgBox("Por favor,Complete todos los campos", MsgBoxStyle.Critical, "Error")
            Exit Sub

        Else
            If ValidarClave1(txtCLAVE) Then

                ' usar la validacion PrimeraLetraEnMayuscula antes de guardar
                Try
                    If ExisteUsuarioGrid(txtDNI.Text) Then
                        MsgBox("Disculpe el empleado que desea agregar ya es un usuario", MsgBoxStyle.Critical, "Error")

                        Limpiar()

                        txtCLAVE.Enabled = False
                        cbxUsuario.Enabled = False
                        btnAGREGAR.Enabled = False
                        BtnLimpiar.Enabled = False

                        Exit Sub
                    Else
                        'Dim contra_encriptada As String = Funciones.Encriptar(txtCLAVE.Text)

                        Dim nuevoUsuario As Eusuarios = New Eusuarios(CInt(txtDNI.Text), txtCLAVE.Text, CInt(cbxUsuario.SelectedValue.ToString()), True)
                        'se llama la contructor con parametros

                        ask = MsgBox("Seguro que desea que el empleado sea un usuario?", 36, "Confirmar Insercion")

                        If ask = vbYes Then
                            If nuevoUsuario.guardarUsuario() Then
                                MsgBox("El Empleado " + txtNOM.Text + " " + txtAPE.Text + " es un nuevo usuario ", 64, "Guardar")

                                CargarGridUsuarios()
                                'limpiar todos los controles
                                'llamar a la funcion Limpiar()
                                Limpiar()
                                btnAGREGAR.Enabled = False
                                BtnLimpiar.Enabled = False

                                txtCLAVE.Enabled = False
                                cbxUsuario.Enabled = False

                            End If

                        End If

                    End If

                Catch ex As Exception
                    MsgBox("El Empleado " + txtNOM.Text + " " + txtAPE.Text + " no se puedo agregar como usuario", 64, "Guardar")
                    BtnLimpiar.Enabled = True
                    'MessageBox.Show(ex.ToString())
                    ' MessageBox.Show("Error en Base de Datos. no esta disponible")
                End Try

            End If

        End If

    End Sub



    Private Sub btnELIMINAR_Click(sender As Object, e As EventArgs) Handles btnELIMINAR.Click

        Try
            Dim mensaje As String = "Esta seguro que desea dar de baja al Usuario seleccionado?"
            If (Validacion.EstaUdSeguro(mensaje)) Then

                Dim usuario = tomarCamposArmarUsuario()
                objUsuario.eliminarUsuario(usuario.dni_Empleados)
                CargarGridUsuarios()

                MsgBox("El Usuario se dio de baja correctamente", 64, "AVISO")

                Limpiar()

                BtnActivar.Enabled = False
                btnELIMINAR.Enabled = False
                btnMODIFICAR.Enabled = False
                BtnLimpiar.Enabled = False
                btnAGREGAR.Enabled = False

                'habilitar campos de textos
                txtCLAVE.Enabled = False
                cbxUsuario.Enabled = False

                'para posicionarse en la fila modificada
                dtgUSUARIOS.FirstDisplayedScrollingRowIndex = fila
                dtgUSUARIOS.Refresh()
                dtgUSUARIOS.CurrentCell = dtgUSUARIOS.Rows(fila).Cells(1)
                dtgUSUARIOS.Rows(fila).Selected = True


            End If

        Catch ex As Exception

            'MessageBox.Show(ex.ToString())
            MsgBox("No se pudo dar de baja el Usuario", MsgBoxStyle.Critical, "ERROR")


        End Try

    End Sub

    Private Sub BtnActivar_Click(sender As Object, e As EventArgs) Handles BtnActivar.Click

        Try
            Dim mensaje As String = "Esta seguro que desea dar de alta al Usuario seleccionado?"
            If (Validacion.EstaUdSeguro(mensaje)) Then

                Dim usuario = tomarCamposArmarUsuario()

                'si se da de alta como usuario y el empleado esta dado de baja se lo comunica al administrador de la situacion
                Dim empleado As Empleados = New Empleados
                empleado = objEmpleado.buscarEmpleado(usuario.dni_Empleados)
                If empleado.estado_emplead = False Then
                    MsgBox("Disculpe no puede dar de alta este usuario, porque como empleado esta dado de baja,por favor comuniquese con el administrador", vbCritical, "ERROR")
                    'objEmpleado.DarDeAltaEmpleado(usuario.dni_empleado)
                    'CargarGridEmpleados()
                    BtnActivar.Enabled = False
                    Limpiar()
                    BtnLimpiar.Enabled = False
                    Exit Sub
                End If


                objUsuario.DarDeAltaUsuario(usuario.dni_Empleados)
                CargarGridUsuarios()

                MsgBox("El Usuario se dio de alta correctamente", 64, "AVISO")

                    Limpiar()

                    BtnActivar.Enabled = False
                    btnELIMINAR.Enabled = False
                    btnMODIFICAR.Enabled = False
                    BtnLimpiar.Enabled = False
                    btnAGREGAR.Enabled = False

                    'habilitar campos de textos
                    txtCLAVE.Enabled = False
                    cbxUsuario.Enabled = False

                    'para posicionarse en la fila modificada
                    dtgUSUARIOS.FirstDisplayedScrollingRowIndex = fila
                    dtgUSUARIOS.Refresh()
                    dtgUSUARIOS.CurrentCell = dtgUSUARIOS.Rows(fila).Cells(1)
                    dtgUSUARIOS.Rows(fila).Selected = True


                End If

        Catch ex As Exception

            'MessageBox.Show(ex.ToString())
            MsgBox("No se pudo dar de alta el Usuario", MsgBoxStyle.Critical, "ERROR")


        End Try

    End Sub

    Private Sub btnMODIFICAR_Click(sender As Object, e As EventArgs) Handles btnMODIFICAR.Click


        Try
            If txtCLAVE.Text = "" Or cbxUsuario.Text = "" Then
                MsgBox("por favor,complete todos los campos", MsgBoxStyle.Critical, "aviso")
                Exit Sub
            End If

            If ValidarClave1(txtCLAVE) Then

                Dim mensaje As String = "¿seguro que queres modificar el usuario: " + txtNOM.Text + "  " + txtAPE.Text & vbNewLine &
                                        "con el dni nº:  " + txtDNI.Text + " ?"
                If (Validacion.EstaUdSeguro(mensaje)) Then


                    Dim usuario = tomarCamposArmarUsuario()
                    objUsuario.actualizarUsuario(usuario)
                    CargarGridUsuarios()

                    'hacer foco en el modificado(falta)
                    'para posicionarse en la fila modificada
                    dtgUSUARIOS.FirstDisplayedScrollingRowIndex = fila
                    dtgUSUARIOS.Refresh()
                    dtgUSUARIOS.CurrentCell = dtgUSUARIOS.Rows(fila).Cells(1)
                    dtgUSUARIOS.Rows(fila).Selected = True


                    MsgBox("El usuario se modifico correctamente", MsgBoxStyle.Information, "aviso")
                    Limpiar()

                    BtnActivar.Enabled = False
                    btnMODIFICAR.Enabled = False
                    btnELIMINAR.Enabled = False
                    BtnLimpiar.Enabled = False
                    btnAGREGAR.Enabled = False

                    txtDNI.Enabled = False
                    txtCLAVE.Enabled = False
                    cbxUsuario.Enabled = False
                    'txtDNI.Focus()

                End If 'cierre de esta seguro

            End If 'cieere de validar clave

        Catch ex As Exception

            '//messagebox.show(ex.tostring());
            MsgBox("El Usuario  no se puedo modificar", 64, "guardar")
            BtnLimpiar.Enabled = True

        End Try



    End Sub

#Region "Busqueda de Usuario"
    Public Sub BuscarUsuario()

        If txtBuscarApe.Text = "" Or txtBuscarDNI.Text = "" Then

            CargarGridUsuarios()

        End If

        If txtBuscarApe.Text <> "" Then
            objUsuario.FiltrarUsuariosApellidos(dtgUSUARIOS, txtBuscarApe.Text)
        End If

        If txtBuscarDNI.Text <> "" Then
            objUsuario.FiltrarUsuarioDNI(dtgUSUARIOS, txtBuscarDNI.Text)
        End If

    End Sub

    Private Sub txtBuscarApe_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarApe.TextChanged
        BuscarUsuario()
    End Sub

    Private Sub txtBuscarDNI_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarDNI.TextChanged
        BuscarUsuario()

    End Sub

    Private Sub txtBuscarApe_MouseClick(sender As Object, e As MouseEventArgs) Handles txtBuscarApe.MouseClick
        txtBuscarDNI.Clear()
        CargarGridUsuarios()
    End Sub

    Private Sub txtBuscarDNI_MouseClick(sender As Object, e As MouseEventArgs) Handles txtBuscarDNI.MouseClick
        txtBuscarApe.Clear()
        CargarGridUsuarios()
    End Sub

    Private Sub txtBuscarApe_GotFocus(sender As Object, e As EventArgs) Handles txtBuscarApe.GotFocus
        txtBuscarDNI.Clear()
        CargarGridUsuarios()
    End Sub

    Private Sub txtBuscarDNI_GotFocus(sender As Object, e As EventArgs) Handles txtBuscarDNI.GotFocus
        txtBuscarApe.Clear()
        CargarGridUsuarios()
    End Sub

#End Region


#Region "Buscar Empleados"
    Public Sub Buscar()

        If tbxBUSCAAPE.Text = "" Or tbxBUSCADNI.Text = "" Then

            CargarGridEmpleados()

        End If

        If tbxBUSCAAPE.Text <> "" Then
            objEmpleado.FiltrarEmpleadosApellidos(dtgEMPLEADOS, tbxBUSCAAPE.Text)
        End If

        If tbxBUSCADNI.Text <> "" Then
            objEmpleado.FiltrarEmpleadoDNI(dtgEMPLEADOS, tbxBUSCADNI.Text)
        End If

    End Sub


    Private Sub tbxBUSCAAPE_TextChanged(sender As Object, e As EventArgs) Handles tbxBUSCAAPE.TextChanged
        Buscar()
    End Sub

    Private Sub tbxBUSCADNI_TextChanged(sender As Object, e As EventArgs) Handles tbxBUSCADNI.TextChanged
        Buscar()

    End Sub

    Private Sub tbxBUSCAAPE_MouseClick(sender As Object, e As MouseEventArgs) Handles tbxBUSCAAPE.MouseClick
        tbxBUSCADNI.Clear()
        CargarGridEmpleados()
    End Sub

    Private Sub tbxBUSCADNI_MouseClick(sender As Object, e As MouseEventArgs) Handles tbxBUSCADNI.MouseClick
        tbxBUSCAAPE.Clear()
        CargarGridEmpleados()
    End Sub

    Private Sub tbxBUSCAAPE_GotFocus(sender As Object, e As EventArgs) Handles tbxBUSCAAPE.GotFocus
        tbxBUSCADNI.Clear()
        CargarGridEmpleados()
    End Sub

    Private Sub tbxBUSCADNI_GotFocus(sender As Object, e As EventArgs) Handles tbxBUSCADNI.GotFocus
        tbxBUSCAAPE.Clear()
        CargarGridEmpleados()
    End Sub


#End Region


#Region "Otros metodos"
    Private Function tomarCamposArmarUsuario() As Usuarios

        Dim unUsuario As Usuarios = New Usuarios()
        Dim id_usuario As Integer = dtgUSUARIOS.Item(0, fila).Value
        Dim estado As Boolean = dtgUSUARIOS.Item(5, fila).Value()

        unUsuario.id_usuario = id_usuario
        unUsuario.dni_Empleados = CInt(txtDNI.Text)
        unUsuario.contraseña = txtCLAVE.Text
        unUsuario.id_tipoUsuario = CInt(cbxUsuario.SelectedValue.ToString())
        unUsuario.estado_usuario = estado
        Return unUsuario
    End Function


    Public Function ExisteUsuarioGrid(ByVal num_dni As String) As Boolean

        Dim existeUsuario As Boolean = False

        If Not dtgUSUARIOS.RowCount = 0 Then

            For i As Integer = 0 To dtgUSUARIOS.Rows.Count - 1

                If dtgUSUARIOS.Item(1, i).Value = num_dni Then 'item(1,i), 1 es la columna del dni
                    existeUsuario = True
                End If
            Next

            Return existeUsuario

        Else
            Return False
        End If

    End Function

    Private Sub BtnAyudaEmpleado_Click(sender As Object, e As EventArgs) Handles BtnAyudaEmpleado.Click
        Dim mensaje As String = "Para Agregar un Empelado como Usuario: Doble click en la fila del Empleado que desea transforma en usuario" & vbNewLine &
                                "luego llenar los campos de contraseña y tipo de usuario y apretar el boton Agregar"
        Dim titulo As String = "Por Favor, leer estas sugerencias..."
        MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtnAyudaUsuario_Click(sender As Object, e As EventArgs) Handles BtnAyudaUsuario.Click
        Dim mensaje As String = "Para Modificar:Doble click en la fila del Usuario que desea modificar y click en boton Modificar" & vbNewLine & vbNewLine &
                           "Para Dar de alta: Doble click en la fila del Usuario cuyo estado no está tildado y luego click en boton Dar de Alta" & vbNewLine & vbNewLine &
                            "Para Dar de Baja: Doble click en la fila del Usuario cuyo estado esta tildado y luego click en boton Dar de Baja"
        Dim titulo As String = "Por Favor, leer estas sugerencias..."
        MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub



    'Private Sub txtDni_TextChanged(sender As Object, e As EventArgs) Handles txtDNI.TextChanged
    '    Try

    '        If ExisteUsuarioGrid(txtDNI.Text) Then
    '            MsgBox("Disculpe el Empleado que desea agregar como usuario ya existe, por favor seleccione otro empleado")
    '            Limpiar()
    '            txtDNI.Clear()
    '            txtDNI.Focus()
    '            Exit Sub
    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub
#End Region

End Class