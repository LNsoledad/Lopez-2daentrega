Imports System.ComponentModel

Public Class FormGestionarEmpleados


    Dim objUsuario As Eusuarios = New Eusuarios
    Dim objEmpleado As Eempleados = New Eempleados
    Dim objProvincia As Eprovincias = New Eprovincias


    Private Sub FormGestionarEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpiar()
        txtDni.Focus()
        txtDni.Enabled = True

        btnLIMPIAR.Enabled = False
        btnAGREGAR.Enabled = True
        BtnActivar.Enabled = False
        btnELIMINAR.Enabled = False
        btnMODIFICAR.Enabled = False

        TextFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        'Mostrar()
        'achicar la ventana para no mostrar la lista de empleados
        'Me.Size = New Size(1008, 402)
        'aca deberiamos poner el codigo para que nos muestre los datos del datagrid
        CargarGrid()
        CargarProvincia()

    End Sub

    Public Sub CargarGrid()
        objEmpleado.getEmpleadosAll(dtgEMPLEADOS)


        If dtgEMPLEADOS.Rows.Count() <> 0 Then
            dtgEMPLEADOS.Rows(0).Selected = False 'para que no este seleccionada ninguna fila
            LModificar.Visible = True
            LEliminar.Visible = True
            Label11.Visible = True
            dtgEMPLEADOS.Visible = True
            Linfo.Visible = False
            tbxBUSCAAPE.Enabled = True
            tbxBUSCADNI.Enabled = True

        Else
            LModificar.Visible = False
            LEliminar.Visible = False
            Label11.Visible = False
            dtgEMPLEADOS.Visible = False
            Linfo.Visible = True
            tbxBUSCAAPE.Enabled = False
            tbxBUSCADNI.Enabled = False
            Exit Sub
        End If

        dtgEMPLEADOS.Columns(8).Visible = False

        Try
            dtgEMPLEADOS.Columns(0).Width = 90
            dtgEMPLEADOS.Columns(1).Width = 100
            dtgEMPLEADOS.Columns(2).Width = 130
            dtgEMPLEADOS.Columns(3).Width = 150
            dtgEMPLEADOS.Columns(4).Width = 150
            dtgEMPLEADOS.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dtgEMPLEADOS.Columns(5).Width = 90
            dtgEMPLEADOS.Columns(6).Width = 105
            dtgEMPLEADOS.Columns(7).Width = 110
            'dtgEMPLEADOS.Columns(8).Width = 200
            'dtgEMPLEADOS.Columns(9).Width = 80
            dtgEMPLEADOS.Columns(10).Width = 86 'columna sexo
            dtgEMPLEADOS.Columns(11).Width = 80 'columna turno
        Catch ex As Exception

        End Try


    End Sub

    Public Sub CargarProvincia()
        objProvincia.cargarBox(ComboPROVINCIA)
    End Sub


    'codigo que asocia la provincia con la caracteristica de telefono de la misma
    Private Sub ComboPROVINCIA_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboPROVINCIA.SelectedValueChanged

        Dim caseSwitch As String = ComboPROVINCIA.Text

        Select Case (caseSwitch)

            Case "Chaco"
                txtTELEFONO.Text = "3722"
                Exit Sub
            Case "Corrientes"
                txtTELEFONO.Text = "3794"
                Exit Sub
            Case "Formosa"
                txtTELEFONO.Text = "3717"
                Exit Sub
            Case "Misiones"
                txtTELEFONO.Text = "3752"
                Exit Sub
            Case "Bs. As."
                txtTELEFONO.Text = "1149"
                Exit Sub
            Case "Santa Fe"
                txtTELEFONO.Text = "3424"
                Exit Sub
            Case "Cordoba"
                txtTELEFONO.Text = "3514"
                Exit Sub
            Case Else
                txtTELEFONO.Text = ""
                Exit Sub
        End Select

    End Sub

    Private Sub dtgEMPLEADOS_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dtgEMPLEADOS.CellFormatting
        Dim valor As Boolean
        For i As Integer = 0 To dtgEMPLEADOS.Rows.Count() - 1
            valor = dtgEMPLEADOS.Rows(i).Cells(8).Value
            If valor = False Then
                dtgEMPLEADOS.Rows(i).DefaultCellStyle.BackColor = Color.MediumVioletRed
            Else
                dtgEMPLEADOS.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
            End If
        Next
    End Sub


    Dim fila As Integer 'variable global que obtendra el indice de la fila que se clickeo
    Private Sub dtgEMPLEADOS_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgEMPLEADOS.CellDoubleClick

        txtDni.Enabled = False
        txtAPELLIDO.Focus()

        btnAGREGAR.Enabled = False

        fila = dtgEMPLEADOS.CurrentRow.Index 'toma el indice de la fila en la cual se hizo doble click

        txtDni.Text = dtgEMPLEADOS.Item(0, fila).Value()
        txtAPELLIDO.Text = dtgEMPLEADOS.Item(1, fila).Value()
        txtNOMBRE.Text = dtgEMPLEADOS.Item(2, fila).Value()
        txtDIRECCION.Text = dtgEMPLEADOS.Item(3, fila).Value()
        DTPfechaNac.Text = dtgEMPLEADOS.Item(4, fila).Value()
        ComboPROVINCIA.Text = dtgEMPLEADOS.Item(5, fila).Value()
        TextFecha.Text = dtgEMPLEADOS.Item(6, fila).Value()
        txtTELEFONO.Text = dtgEMPLEADOS.Item(7, fila).Value()
        txtEmail.Text = dtgEMPLEADOS.Item(9, fila).Value()
        ComboSexo.Text = dtgEMPLEADOS.Item(10, fila).Value()
        ComboTurno.Text = dtgEMPLEADOS.Item(11, fila).Value

        '------------habilitar botones de dar de baja o de alta de acuerdo con el estado del empleado

        Dim estado As Boolean = dtgEMPLEADOS.Item(8, fila).Value()

        If estado Then

            Dim mensajeModificar As String = "Desea Modificar el Empleado?"
            If (Validacion.EstaUdSeguro(mensajeModificar)) Then
                btnAGREGAR.Enabled = False
                BtnActivar.Enabled = False
                btnELIMINAR.Enabled = False
                btnLIMPIAR.Enabled = True

                btnMODIFICAR.Enabled = True

                'habilitar campos de textos
                txtAPELLIDO.Enabled = True
                txtNOMBRE.Enabled = True
                txtDIRECCION.Enabled = True
                ComboPROVINCIA.Enabled = True
                txtTELEFONO.Enabled = True
                DTPfechaNac.Enabled = True
                txtEmail.Enabled = True
                ComboSexo.Enabled = True
                ComboTurno.Enabled = True
                Exit Sub

            End If

            Dim mensajeBaja As String = "Desea Dar de Baja el Empleado?"
            If (Validacion.EstaUdSeguro(mensajeBaja)) Then
                BtnActivar.Enabled = False
                btnELIMINAR.Enabled = True
                btnLIMPIAR.Enabled = True
                btnAGREGAR.Enabled = False
                btnMODIFICAR.Enabled = False

                'inhabilitar campos
                txtAPELLIDO.Enabled = False
                txtNOMBRE.Enabled = False
                txtDIRECCION.Enabled = False
                ComboPROVINCIA.Enabled = False
                txtTELEFONO.Enabled = False
                DTPfechaNac.Enabled = False
                txtEmail.Enabled = False
                ComboSexo.Enabled = False
                ComboTurno.Enabled = False
                Exit Sub


            End If


        Else

            Dim mensajeModificar As String = "Desea Modificar el Empleado?"
            If (Validacion.EstaUdSeguro(mensajeModificar)) Then
                btnAGREGAR.Enabled = False
                BtnActivar.Enabled = False
                btnELIMINAR.Enabled = False
                btnLIMPIAR.Enabled = True

                btnMODIFICAR.Enabled = True

                'habilitar campos de textos
                txtAPELLIDO.Enabled = True
                txtNOMBRE.Enabled = True
                txtDIRECCION.Enabled = True
                ComboPROVINCIA.Enabled = True
                txtTELEFONO.Enabled = True
                DTPfechaNac.Enabled = True
                txtEmail.Enabled = True
                ComboSexo.Enabled = True
                ComboTurno.Enabled = True
                Exit Sub

            End If

            Dim mensajeAlta As String = "Desea Dar de Alta el Empleado?"
            If (Validacion.EstaUdSeguro(mensajeAlta)) Then
                BtnActivar.Enabled = True
                btnLIMPIAR.Enabled = True
                btnAGREGAR.Enabled = False
                btnMODIFICAR.Enabled = False
                btnELIMINAR.Enabled = False

                'inhabilitar campos
                txtAPELLIDO.Enabled = False
                txtNOMBRE.Enabled = False
                txtDIRECCION.Enabled = False
                ComboPROVINCIA.Enabled = False
                txtTELEFONO.Enabled = False
                DTPfechaNac.Enabled = False
                txtEmail.Enabled = False
                ComboSexo.Enabled = False
                ComboTurno.Enabled = False
                Exit Sub


            End If



        End If 'cierre del if estado

        Limpiar()
        btnAGREGAR.Enabled = True

        'habilitar campos de textos
        txtAPELLIDO.Enabled = True
        txtNOMBRE.Enabled = True
        txtDIRECCION.Enabled = True
        ComboPROVINCIA.Enabled = True
        txtTELEFONO.Enabled = True
        DTPfechaNac.Enabled = True
        txtEmail.Enabled = True
        ComboSexo.Enabled = True
        ComboTurno.Enabled = True

        txtDni.Enabled = True
        txtDni.Focus()

    End Sub



#Region "Mostrar y ocultar lista"
    'los siguientes metodos es para controlar la dimension de la venta
    'Private Sub BtnListar_Click(sender As Object, e As EventArgs)
    '    ListadoEmpleados.Visible = True
    '    Me.Size = New Size(1008, 738)
    '    BtnListar.Visible = False
    '    'BtnOcultar.Visible = True


    'End Sub

    'Private Sub BtnOcultar_Click(sender As Object, e As EventArgs)

    '    Me.Size = New Size(1008, 402)
    '    BtnListar.Visible = True
    'End Sub

#End Region



    Private Sub btnLIMPIAR_Click(sender As Object, e As EventArgs) Handles btnLIMPIAR.Click

        Dim mensaje As String = "Desea borrar todos los campos?"
        If (Validacion.EstaUdSeguro(mensaje)) Then
            Limpiar()
            btnLIMPIAR.Enabled = False
            btnMODIFICAR.Enabled = False
            btnELIMINAR.Enabled = False
            BtnActivar.Enabled = False
            btnAGREGAR.Enabled = True
            txtDni.Enabled = True
            txtDni.Focus()
        End If


    End Sub

    Private Sub Limpiar()
        txtAPELLIDO.Clear()
        txtDIRECCION.Clear()
        DTPfechaNac.ResetText()
        TextFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        txtNOMBRE.Clear()
        txtDni.Clear()
        txtTELEFONO.Clear()
        ComboPROVINCIA.SelectedValue = -1
        ComboSexo.ResetText()
        ComboTurno.ResetText()
        txtEmail.Clear()

        'habilitar campos de textos
        txtAPELLIDO.Enabled = True
        txtNOMBRE.Enabled = True
        txtDIRECCION.Enabled = True
        ComboPROVINCIA.Enabled = True
        txtTELEFONO.Enabled = True
        DTPfechaNac.Enabled = True
        txtEmail.Enabled = True
        ComboSexo.Enabled = True
        ComboTurno.Enabled = True

        tbxBUSCADNI.Clear()
        tbxBUSCAAPE.Clear()

    End Sub


    Private Sub btnAGREGAR_Click(sender As Object, e As EventArgs) Handles btnAGREGAR.Click
        Dim ask As MsgBoxResult

        If txtDni.Text = "" Or txtAPELLIDO.Text = "" Or txtNOMBRE.Text = "" Or ComboPROVINCIA.Text = "" Or txtTELEFONO.Text = "" Or DTPfechaNac.Text = "" Or txtDIRECCION.Text = "" Or TextFecha.Text = "" Or txtEmail.Text = "" Or ComboSexo.Text = "" Or ComboTurno.Text = "" Then
            MsgBox("Por favor,Complete todos los campos", MsgBoxStyle.Critical, "Error")
            Exit Sub

        Else

            If txtDni.Text.Length < 8 Then
                MsgBox("Por favor, Complete DNI:8 numeros", MsgBoxStyle.Critical, "Error DNI")
                txtDni.Focus()
                Exit Sub
            End If

            If txtTELEFONO.Text.Length < 10 Then
                MsgBox("Por favor,Complete el Telefono:10 numeros", MsgBoxStyle.Critical, "Error Telefono")
                txtTELEFONO.Focus()
                Exit Sub
            End If

            Dim bln As Boolean = IsValidEmail(txtEmail.Text)
            If bln = False Then
                Validacion.AccionErronea("Disculpen, El  email que ingresó no tiene el formato correcto" & vbNewLine &
                    "Por favor,ingrese de esta manera: nombre@dominio; Ejemplo: nombre@gmail.com")
                txtEmail.Focus()
                Exit Sub
            End If

            'usar la validacion PrimeraLetraEnMayuscula antes de guardar

            Try
                If ExisteEmpleadoGrid(txtDni.Text) Then
                    MsgBox("Disculpe el Empleado/a que desea agregar ya existe, por favor, ingrese otro DNI", MsgBoxStyle.Critical, "Error,Dni Ya existe")
                    'Limpiar()
                    txtDni.Focus()

                    Exit Sub
                Else
                    Dim apellido As String = Validacion.PrimeraLetraEnMayuscula(txtAPELLIDO.Text)
                    Dim nombre As String = Validacion.PrimeraLetraEnMayuscula(txtNOMBRE.Text)
                    Dim direccion As String = Validacion.PrimeraLetraEnMayuscula(txtDIRECCION.Text)

                    Dim nuevoEmpleado As Eempleados = New Eempleados(CInt(txtDni.Text), apellido, nombre, direccion, txtTELEFONO.Text, TextFecha.Text, DTPfechaNac.Text, True, CInt(ComboPROVINCIA.SelectedValue), txtEmail.Text, ComboSexo.Text, ComboTurno.Text)
                    'se llama la contructor con parametros

                    ask = MsgBox("Seguro que desea insertar un/a nuevo/a Empleado/a?", 36, "Confirmar Insercion")

                    If ask = vbYes Then
                        If nuevoEmpleado.guardarEmpleado() Then
                            MsgBox("El Empleado " + apellido + " " + nombre + " se inserto correctamente", 64, "Guardar")

                            CargarGrid()
                            'limpiar todos los controles
                            'llamar a la funcion Limpiar()
                            Limpiar()

                        End If

                    End If

                End If

            Catch ex As Exception
                MsgBox("El Empleado/a " + txtNOMBRE.Text + " " + txtAPELLIDO.Text + " no se puedo agregar", 64, "Guardar")
                btnLIMPIAR.Enabled = True
                'MessageBox.Show(ex.ToString())
                ' MessageBox.Show("Error en Base de Datos. no esta disponible")
            End Try


        End If

    End Sub

    Private Sub btnMODIFICAR_Click(sender As Object, e As EventArgs) Handles btnMODIFICAR.Click

        'verificar esto de los campos vacios
        If txtAPELLIDO.Text = "" Or txtNOMBRE.Text = "" Or ComboPROVINCIA.Text = "" Or txtTELEFONO.Text = "" Or DTPfechaNac.Text = "" Or txtDIRECCION.Text = "" Or txtEmail.Text = "" Or ComboSexo.Text = "" Or ComboTurno.Text = "" Then
            MsgBox("Por favor,Complete todos los campos", MsgBoxStyle.Critical, "Error")
            Exit Sub
        Else

            If txtDni.Text.Length < 8 Then
                MsgBox("Por favor, Complete DNI:8 numeros", MsgBoxStyle.Critical, "Error DNI")
                txtDni.Focus()
                Exit Sub
            End If

            If txtTELEFONO.Text.Length < 10 Then
                MsgBox("Por favor,Complete el Telefono:10 numeros", MsgBoxStyle.Critical, "Error Telefono")
                txtTELEFONO.Focus()
                Exit Sub
            End If

            Dim bln As Boolean = IsValidEmail(txtEmail.Text)
            If bln = False Then
                Validacion.AccionErronea("Disculpen, El  email que ingresó no tiene el formato correcto" & vbNewLine &
                    "Por favor,ingrese de esta manera: nombre@dominio; Ejemplo: nombre@gmail.com")
                txtEmail.Focus()
                Exit Sub
            End If

            Try

                Dim mensaje As String = "¿Seguro que queres Modificar el Empleado/a: " + txtNOMBRE.Text + "  " + txtAPELLIDO.Text & vbNewLine &
                                            "Con el DNI Nº:  " + txtDni.Text + " ?"
                If (Validacion.EstaUdSeguro(mensaje)) Then


                    Dim empleado = tomarCamposArmarEmpleado()
                    objEmpleado.actualizarEmpleado(empleado)
                    CargarGrid()


                    MsgBox("El Empleado/a " + txtNOMBRE.Text + "  " + txtAPELLIDO.Text & vbNewLine &
                                            "Con el DNI Nº:  " + txtDni.Text + " se modifico correctamente", vbOKOnly, "AVISO")

                    Limpiar()

                    BtnActivar.Enabled = False
                    btnELIMINAR.Enabled = False
                    btnMODIFICAR.Enabled = False
                    btnLIMPIAR.Enabled = False
                    btnAGREGAR.Enabled = True

                    txtDni.Enabled = True
                    txtDni.Focus()

                    'hacer foco en el modificado para posicionarse en la fila modificada
                    dtgEMPLEADOS.FirstDisplayedScrollingRowIndex = fila
                    dtgEMPLEADOS.Refresh()
                    dtgEMPLEADOS.CurrentCell = dtgEMPLEADOS.Rows(fila).Cells(0)
                    dtgEMPLEADOS.Rows(fila).Selected = True



                End If

            Catch ex As Exception

                '//MessageBox.Show(ex.ToString());
                MsgBox("El Empleado/a " + txtNOMBRE.Text + " " + txtAPELLIDO.Text + " no se puedo modificar", 64, "Guardar")
                btnLIMPIAR.Enabled = True

            End Try

        End If

    End Sub


    Private Sub btnELIMINAR_Click(sender As Object, e As EventArgs) Handles btnELIMINAR.Click
        Try
            Dim mensaje As String = "Esta seguro que desea dar de baja al Empleado seleccionado?"
            If (Validacion.EstaUdSeguro(mensaje)) Then

                Dim empleado = tomarCamposArmarEmpleado()
                objEmpleado.eliminarEmpleado(empleado.Dni_empleados)
                CargarGrid()
                MsgBox("El Empleado " + txtNOMBRE.Text + " " + txtAPELLIDO.Text + " se dio de baja correctamente", 64, "AVISO")

                'si se da de baja como empleado y como usuario esta dado de alta se lo debe comunicar al super Administrador
                'para que se lo de baja como usuario
                Dim usuario As Usuarios = New Usuarios
                If objUsuario.existeUsuario(empleado.Dni_empleados) Then
                    usuario = objUsuario.dbuscarUsuario(empleado.Dni_empleados)

                    If usuario.Estado_usuario = True Then
                        MsgBox("Por favor,Comuniquese con el super adminisrador para dar de baja al empleado como usuario tambien,gracias", vbInformation, "INFORMAR")

                        'objUsuario.eliminarUsuario(empleado.dni_empleado)
                    End If

                End If

                Limpiar()

                BtnActivar.Enabled = False
                btnELIMINAR.Enabled = False
                btnMODIFICAR.Enabled = False
                btnLIMPIAR.Enabled = False
                btnAGREGAR.Enabled = True

                'habilitar campos de textos
                txtAPELLIDO.Enabled = True
                txtNOMBRE.Enabled = True
                txtDIRECCION.Enabled = True
                ComboPROVINCIA.Enabled = True
                txtTELEFONO.Enabled = True
                DTPfechaNac.Enabled = True
                txtEmail.Enabled = True
                ComboSexo.Enabled = True
                ComboTurno.Enabled = True


                txtDni.Enabled = True
                txtDni.Focus()


                'para posicionarse en la fila modificada
                dtgEMPLEADOS.FirstDisplayedScrollingRowIndex = fila
                dtgEMPLEADOS.Refresh()
                dtgEMPLEADOS.CurrentCell = dtgEMPLEADOS.Rows(fila).Cells(1)
                dtgEMPLEADOS.Rows(fila).Selected = True

            End If

        Catch ex As Exception

            'MessageBox.Show(ex.ToString())
            MessageBox.Show("No se pudo dar de baja el Empleado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)


        End Try

    End Sub

    Private Sub BtnActivar_Click(sender As Object, e As EventArgs) Handles BtnActivar.Click
        Try
            Dim mensaje As String = "Esta seguro que desea dar de alta al Empleado seleccionado?"
            If (Validacion.EstaUdSeguro(mensaje)) Then

                Dim empleado = tomarCamposArmarEmpleado()
                objEmpleado.DarDeAltaEmpleado(empleado.Dni_empleados)
                CargarGrid()

                MsgBox("El Empleado " + txtNOMBRE.Text + " " + txtAPELLIDO.Text + " se dio de alta correctamente", 64, "AVISO")

                Limpiar()

                BtnActivar.Enabled = False
                btnELIMINAR.Enabled = False
                btnMODIFICAR.Enabled = False
                btnLIMPIAR.Enabled = False
                btnAGREGAR.Enabled = True

                'habilitar campos de textos
                txtAPELLIDO.Enabled = True
                txtNOMBRE.Enabled = True
                txtDIRECCION.Enabled = True
                ComboPROVINCIA.Enabled = True
                txtTELEFONO.Enabled = True
                DTPfechaNac.Enabled = True
                txtEmail.Enabled = True
                ComboSexo.Enabled = True
                ComboTurno.Enabled = True

                txtDni.Enabled = True
                txtDni.Focus()


                'para posicionarse en la fila modificada
                dtgEMPLEADOS.FirstDisplayedScrollingRowIndex = fila
                dtgEMPLEADOS.Refresh()
                dtgEMPLEADOS.CurrentCell = dtgEMPLEADOS.Rows(fila).Cells(1)
                dtgEMPLEADOS.Rows(fila).Selected = True


            End If

        Catch ex As Exception

            'MessageBox.Show(ex.ToString())
            MessageBox.Show("No se pudo dar de alta el Empleado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)


        End Try

    End Sub



#Region "BUSCAR EMPLEADOS"
    Public Sub Buscar()

        If tbxBUSCAAPE.Text = "" Or tbxBUSCADNI.Text = "" Then

            CargarGrid()

        End If

        If tbxBUSCAAPE.Text <> "" Then
            objEmpleado.FiltrarEmpleadosApellidos(dtgEMPLEADOS, tbxBUSCAAPE.Text)
            'dtgEMPLEADOS.Rows(0).Selected = False 'para que no este seleccionada ninguna fila
        End If

        If tbxBUSCADNI.Text <> "" Then
            objEmpleado.FiltrarEmpleadoDNI(dtgEMPLEADOS, tbxBUSCADNI.Text)
            'dtgEMPLEADOS.Rows(0).Selected = False 'para que no este seleccionada ninguna fila
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
        CargarGrid()
    End Sub

    Private Sub tbxBUSCADNI_MouseClick(sender As Object, e As MouseEventArgs) Handles tbxBUSCADNI.MouseClick
        tbxBUSCAAPE.Clear()
        CargarGrid()
    End Sub

    Private Sub tbxBUSCAAPE_GotFocus(sender As Object, e As EventArgs) Handles tbxBUSCAAPE.GotFocus
        tbxBUSCADNI.Clear()
        CargarGrid()
    End Sub

    Private Sub tbxBUSCADNI_GotFocus(sender As Object, e As EventArgs) Handles tbxBUSCADNI.GotFocus
        tbxBUSCAAPE.Clear()
        CargarGrid()
    End Sub
#End Region


#Region "CERRAR VENTANA"
    'para el boton X de la parte superior de la ventana
    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        If MessageBox.Show("Estas seguro que desea Salir", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
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


#Region "VALIDACIONES"
    'VALIDACIONES A LOS CONTROLES
    Private Sub txtDni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDni.KeyPress
        validarSoloNumeros(e)
        If Asc(e.KeyChar) = 13 Then 'Asc es codigo ASCII, si se presiona ENTER codigo ASCII=13
            txtAPELLIDO.Focus()

        End If

    End Sub

    Private Sub txtAPELLIDO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAPELLIDO.KeyPress
        validarSoloLetras(e)

        If Asc(e.KeyChar) = 13 Then 'Asc es codigo ASCII, si se presiona ENTER codigo ASCII=13
            txtNOMBRE.Focus()

        End If
    End Sub

    Private Sub txtNOMBRE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNOMBRE.KeyPress
        validarSoloLetras(e)
        If Asc(e.KeyChar) = 13 Then 'Asc es codigo ASCII, si se presiona ENTER codigo ASCII=13
            txtDIRECCION.Focus()

        End If
    End Sub
    Private Sub txtDIRECCION_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDIRECCION.KeyPress
        validarNumerosYLetras1(e)
        If Asc(e.KeyChar) = 13 Then 'Asc es codigo ASCII, si se presiona ENTER codigo ASCII=13
            ComboPROVINCIA.Focus()

        End If
    End Sub

    Private Sub ComboPROVINCIA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboPROVINCIA.KeyPress
        If Asc(e.KeyChar) = 13 Then 'Asc es codigo ASCII, si se presiona ENTER codigo ASCII=13
            txtTELEFONO.Focus()
        End If
    End Sub
    Private Sub txtTELEFONO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTELEFONO.KeyPress
        validarSoloNumeros(e)
        If Asc(e.KeyChar) = 13 Then 'Asc es codigo ASCII, si se presiona ENTER codigo ASCII=13
            DTPfechaNac.Focus()

        End If
    End Sub

    Private Sub DTPfechaNac_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DTPfechaNac.KeyPress
        If Asc(e.KeyChar) = 13 Then 'Asc es codigo ASCII, si se presiona ENTER codigo ASCII=13
            btnAGREGAR.Focus()
        End If
    End Sub

#End Region


#Region "Otros metodos"
    Private Function tomarCamposArmarEmpleado() As Empleados
        Dim unEmpleado As Empleados = New Empleados()
        Dim estado As Boolean = dtgEMPLEADOS.Item(8, fila).Value()

        unEmpleado.Dni_empleados = CInt(txtDni.Text)
        unEmpleado.nombre = Validacion.PrimeraLetraEnMayuscula(txtNOMBRE.Text)
        unEmpleado.apellido = Validacion.PrimeraLetraEnMayuscula(txtAPELLIDO.Text)
        unEmpleado.direccion = Validacion.PrimeraLetraEnMayuscula(txtDIRECCION.Text)
        unEmpleado.id_provincia = CInt(ComboPROVINCIA.SelectedValue.ToString())
        unEmpleado.telefono = txtTELEFONO.Text
        unEmpleado.fecha_Nacimiento = DTPfechaNac.Text
        unEmpleado.fecha_ingreso = TextFecha.Text
        unEmpleado.estado_emplead = estado
        unEmpleado.email = txtEmail.Text
        unEmpleado.sexo = ComboSexo.Text
        unEmpleado.turno = ComboTurno.Text

        Return unEmpleado
    End Function


    Public Function ExisteEmpleadoGrid(ByVal num_dni As String) As Boolean

        Dim existeEmpleado As Boolean = False

        If Not dtgEMPLEADOS.RowCount = 0 Then


            For i As Integer = 0 To dtgEMPLEADOS.Rows.Count - 1

                If dtgEMPLEADOS.Item(0, i).Value = num_dni Then
                    existeEmpleado = True
                End If
            Next
            Return existeEmpleado

        Else
            Return False
        End If

    End Function

    Private Sub BtnAyuda_Click(sender As Object, e As EventArgs) Handles BtnAyuda.Click
        Dim mensaje As String = "Para Guardar: Llene los campos y click en boton Guardar" & vbNewLine & vbNewLine &
                           "Para Modificar:Doble click en la fila del Empleado que desea modificar y click en boton Modificar" & vbNewLine & vbNewLine &
                           "Para Dar de alta: Doble click en la fila del Empleado cuyo estado no está tildado y luego click en boton Dar de Alta" & vbNewLine & vbNewLine &
                            "Para Dar de Baja: Doble click en la fila del Empleado cuyo estado esta tildado y luego click en boton Dar de Baja"
        Dim titulo As String = "Por Favor, leer estas sugerencias..."
        MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub





    'Private Sub txtDni_TextChanged(sender As Object, e As EventArgs) Handles txtDni.TextChanged
    '    Try

    '        If ExisteEmpleadoGrid(txtDni.Text) Then
    '            MsgBox("Disculpe el Empleado que desea agregar ya existe, por favor ingrese otro DNI")
    '            Limpiar()
    '            txtDni.Clear()
    '            txtDni.Focus()
    '            Exit Sub
    '        End If
    '    Catch ex As Exception

    '    End Try


    'End Sub

#End Region


End Class