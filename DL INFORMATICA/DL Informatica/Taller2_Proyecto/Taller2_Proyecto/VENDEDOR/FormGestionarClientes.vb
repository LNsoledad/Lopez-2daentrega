Imports System.ComponentModel
Imports System.IO

Public Class FormGestionarClientes

    Dim objCliente As Eclientes = New Eclientes
    Dim objProvincia As Eprovincias = New Eprovincias

#Region "VALIDACIONES"
    'VALIDACIONES A LOS CONTROLES
    Private Sub TextDNI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextDNI.KeyPress
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
            txtEmail.Focus()

        End If
    End Sub

    Private Sub txtEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmail.KeyPress
        If Asc(e.KeyChar) = 13 Then 'Asc es codigo ASCII, si se presiona ENTER codigo ASCII=13
            btnAGREGAR.Focus()



        End If
    End Sub

#End Region

    Private Sub btnAGREGAR_Click(sender As Object, e As EventArgs) Handles btnAGREGAR.Click

        Dim ask As MsgBoxResult

        If TextDNI.Text = "" Or txtAPELLIDO.Text = "" Or txtNOMBRE.Text = "" Or ComboPROVINCIA.Text = "" Or txtTELEFONO.Text = "" Or txtEmail.Text = "" Or txtDIRECCION.Text = "" Or ComboSexo.Text = "" Then
            MsgBox("Por favor,Complete todos los campos", MsgBoxStyle.Critical, "Error")
            Exit Sub

        Else

            If TextDNI.Text.Length < 8 Then
                MsgBox("Por favor,Complete DNI:8 numeros", MsgBoxStyle.Critical, "Error DNI")
                TextDNI.Focus()
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
                If ExisteClienteGrid(TextDNI.Text) Then
                    MsgBox("Disculpe el Cliente que desea agregar ya existe, por favor ingrese otro DNI", MsgBoxStyle.Critical, "Error,el Dni Ya existe")
                    'Limpiar()
                    btnLIMPIAR.Enabled = True
                    TextDNI.Focus()
                    TextDNI.BackColor = Color.OrangeRed
                    Exit Sub
                Else
                    Dim apellido As String = Validacion.PrimeraLetraEnMayuscula(txtAPELLIDO.Text)
                    Dim nombre As String = Validacion.PrimeraLetraEnMayuscula(txtNOMBRE.Text)
                    Dim direccion As String = Validacion.PrimeraLetraEnMayuscula(txtDIRECCION.Text)

                    Dim nuevoCliente As Eclientes = New Eclientes(CInt(TextDNI.Text), apellido, nombre, direccion, txtTELEFONO.Text, txtEmail.Text, TextFecha.Text, True, CInt(ComboPROVINCIA.SelectedValue), ComboSexo.Text)
                    'se llama la contructor con parametros

                    ask = MsgBox("Seguro que desea insertar un nuevo Cliente?", 36, "Confirmar Insercion")

                    If ask = vbYes Then
                        If nuevoCliente.guardarCliente() Then
                            MsgBox("El Cliente " + txtNOMBRE.Text + " " + txtAPELLIDO.Text + " se inserto correctamente", 64, "Guardar")

                            btnLIMPIAR.Enabled = False
                            TextDNI.BackColor = Color.White

                            CargarGrid()
                            'limpiar todos los controles
                            'llamar a la funcion Limpiar()
                            Limpiar()
                        End If

                    End If

                End If

            Catch ex As Exception
                MsgBox("El Cliente no se puedo agregar", 64, "Guardar")
                btnLIMPIAR.Enabled = True
                'MessageBox.Show(ex.ToString())
                ' MessageBox.Show("Error en Base de Datos. no esta disponible")
            End Try

        End If

    End Sub



    Private Sub btnMODIFICAR_Click(sender As Object, e As EventArgs) Handles btnMODIFICAR.Click

        'verificar esto de los campos vacios
        If TextDNI.Text = "" Or txtAPELLIDO.Text = "" Or txtNOMBRE.Text = "" Or ComboPROVINCIA.Text = "" Or txtTELEFONO.Text = "" Or txtEmail.Text = "" Or txtDIRECCION.Text = "" Or ComboSexo.Text = "" Then
            MsgBox("Por favor,Complete todos los campos", MsgBoxStyle.Critical, "Error")
            Exit Sub
        Else

            If TextDNI.Text.Length < 8 Then
                MsgBox("Por favor,Complete DNI:8 numeros", MsgBoxStyle.Critical, "Error DNI")
                TextDNI.Focus()
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

                Dim mensaje As String = "¿Seguro que queres Modificar el CLiente: " + txtNOMBRE.Text + "  " + txtAPELLIDO.Text & vbNewLine &
                                        "Con el DNI Nº:  " + TextDNI.Text + " ?"
                If (Validacion.EstaUdSeguro(mensaje)) Then


                    Dim cliente = tomarCamposArmarCliente()
                    objCliente.actualizarCliente(cliente)
                    CargarGrid()

                    MsgBox("Cliente " + txtNOMBRE.Text + "  " + txtAPELLIDO.Text & vbNewLine &
                                        "Con el DNI Nº:  " + TextDNI.Text + " se modifico correctamente", MsgBoxStyle.Information, "AVISO")
                    Limpiar()

                    BtnActivar.Enabled = False
                    btnMODIFICAR.Enabled = False
                    btnLIMPIAR.Enabled = False
                    btnAGREGAR.Enabled = True

                    TextDNI.Enabled = True
                    TextDNI.Focus()


                    'hacer foco en el modificado(falta)
                    'para posicionarse en la fila modificada
                    dtgCLIENTES.FirstDisplayedScrollingRowIndex = fila
                    dtgCLIENTES.Refresh()
                    dtgCLIENTES.CurrentCell = dtgCLIENTES.Rows(fila).Cells(0)
                    dtgCLIENTES.Rows(fila).Selected = True


                End If

            Catch ex As Exception

                '//MessageBox.Show(ex.ToString());
                MsgBox("El Cliente " + txtNOMBRE.Text + " " + txtAPELLIDO.Text + " no se puedo modificar", 64, "Guardar")
                btnLIMPIAR.Enabled = True

            End Try


        End If
    End Sub

    Private Sub btnLIMPIAR_Click(sender As Object, e As EventArgs) Handles btnLIMPIAR.Click

        'ver si se puede activar cuando algunos de los campoes tiene algo cargado


        Dim mensaje As String = "Desea borrar todos los campos?"
        If (Validacion.EstaUdSeguro(mensaje)) Then
            Limpiar()
            btnLIMPIAR.Enabled = False
            btnMODIFICAR.Enabled = False
            btnAGREGAR.Enabled = True
            BtnActivar.Enabled = False

            TextDNI.Enabled = True
            TextDNI.Focus()
            TextDNI.BackColor = Color.White
            'habilitar campos
            txtAPELLIDO.Enabled = True
            txtNOMBRE.Enabled = True
            txtDIRECCION.Enabled = True
            ComboPROVINCIA.Enabled = True
            txtTELEFONO.Enabled = True
            txtEmail.Enabled = True
            ComboSexo.Enabled = True

        End If


    End Sub

    Private Sub Limpiar()
        txtAPELLIDO.Clear()
        txtDIRECCION.Clear()
        txtEmail.Clear()
        txtNOMBRE.Clear()
        txtTELEFONO.Clear()
        ComboPROVINCIA.SelectedValue = -1
        'TextDNI.Focus()
        TextDNI.Clear()
        TextFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        ComboSexo.ResetText()

        'TextDNI.Enabled = True

        tbxBUSCADNI.Clear()
        tbxBUSCAAPE.Clear()



    End Sub

#Region "mostrar y ocultar lista"
    'los siguientes metodos es para controlar la dimension de la venta
    'Private Sub BtnListar_Click(sender As Object, e As EventArgs)
    '    ListadoClientes.Visible = True
    '    Me.Size = New Size(1008, 738)
    '    BtnListar.Visible = False
    '    'BtnOcultar.Visible = True


    'End Sub

    'Private Sub BtnOcultar_Click(sender As Object, e As EventArgs)

    '    Me.Size = New Size(1008, 415)
    '    BtnListar.Visible = True
    'End Sub
#End Region

    Private Sub dtgCLIENTES_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dtgCLIENTES.CellFormatting
        'If Me.dtgCLIENTES.Columns(e.ColumnIndex).Name = "Estado" Then

        '    'If e.Value = False Then
        '    '    e.CellStyle.BackColor = Color.MediumVioletRed
        '    'Else
        '    '    e.CellStyle.BackColor = Color.LightGreen
        '    'End If

        'End If
        Dim valor As Boolean
        For i As Integer = 0 To dtgCLIENTES.Rows.Count() - 1
            valor = dtgCLIENTES.Rows(i).Cells(8).Value
            If valor = False Then
                dtgCLIENTES.Rows(i).DefaultCellStyle.BackColor = Color.MediumVioletRed
            Else
                dtgCLIENTES.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
            End If
        Next
    End Sub


    Dim fila As Integer 'variable global que obtendra el indice de la fila que se clickeo
    Private Sub dtgCLIENTES_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgCLIENTES.CellDoubleClick

        TextDNI.Enabled = False
        txtAPELLIDO.Focus()

        btnAGREGAR.Enabled = False
        btnLIMPIAR.Enabled = True

        fila = dtgCLIENTES.CurrentRow.Index 'toma el indice de la fila en la cual se hizo doble click

        TextDNI.Text = dtgCLIENTES.Item(0, fila).Value()
        txtAPELLIDO.Text = dtgCLIENTES.Item(1, fila).Value()
        txtNOMBRE.Text = dtgCLIENTES.Item(2, fila).Value()
        txtDIRECCION.Text = dtgCLIENTES.Item(3, fila).Value()
        ComboPROVINCIA.Text = dtgCLIENTES.Item(4, fila).Value()
        txtTELEFONO.Text = dtgCLIENTES.Item(5, fila).Value()
        txtEmail.Text = dtgCLIENTES.Item(6, fila).Value()
        TextFecha.Text = dtgCLIENTES.Item(7, fila).Value()
        ComboSexo.Text = dtgCLIENTES.Item(9, fila).Value()



        '------------habilitar botones de dar  de alta de acuerdo con el estado del cliente



        Dim estado As Boolean = dtgCLIENTES.Item(8, fila).Value()

        If estado Then
            BtnActivar.Enabled = False
            btnMODIFICAR.Enabled = True

            'habilitar campos de textos
            txtAPELLIDO.Enabled = True
            txtNOMBRE.Enabled = True
            txtDIRECCION.Enabled = True
            ComboPROVINCIA.Enabled = True
            txtTELEFONO.Enabled = True
            txtEmail.Enabled = True
            ComboSexo.Enabled = True

        Else
            Dim mensajeAlta As String = "Desea Dar de Alta el Cliente?"
            If (Validacion.EstaUdSeguro(mensajeAlta)) Then
                BtnActivar.Enabled = True
                btnLIMPIAR.Enabled = True
                btnAGREGAR.Enabled = False
                btnMODIFICAR.Enabled = False

                'inhabilitar campos
                txtAPELLIDO.Enabled = False
                txtNOMBRE.Enabled = False
                txtDIRECCION.Enabled = False
                ComboPROVINCIA.Enabled = False
                txtTELEFONO.Enabled = False
                txtEmail.Enabled = False
                ComboSexo.Enabled = False
                Exit Sub

            End If

            Dim mensajeEliminar As String = "Desea Modificar el Cliente?"
            If (Validacion.EstaUdSeguro(mensajeEliminar)) Then
                BtnActivar.Enabled = False
                btnLIMPIAR.Enabled = True
                btnAGREGAR.Enabled = False
                btnMODIFICAR.Enabled = True

                'habilitar campos de textos
                txtAPELLIDO.Enabled = True
                txtNOMBRE.Enabled = True
                txtDIRECCION.Enabled = True
                ComboPROVINCIA.Enabled = True
                txtTELEFONO.Enabled = True
                txtEmail.Enabled = True
                ComboSexo.Enabled = True
                Exit Sub

            End If

            Limpiar()
            TextDNI.Enabled = True
            TextDNI.Focus()
            btnAGREGAR.Enabled = True
            BtnActivar.Enabled = False
            btnMODIFICAR.Enabled = False

            'habilitar campos de textos

            txtAPELLIDO.Enabled = True
            txtNOMBRE.Enabled = True
            txtDIRECCION.Enabled = True
            ComboPROVINCIA.Enabled = True
            txtTELEFONO.Enabled = True
            txtEmail.Enabled = True
            ComboSexo.Enabled = True

            TextDNI.Enabled = True
            TextDNI.Focus()

        End If



        'falta el codigo de preguntar si estado es false del cliente que se cliqueo que se habilite el boton activar

    End Sub

    Private Sub BtnActivar_Click(sender As Object, e As EventArgs) Handles BtnActivar.Click
        Try
            Dim mensaje As String = "Esta seguro que desea dar de alta al cliente seleccionado?"
            If (Validacion.EstaUdSeguro(mensaje)) Then

                Dim cliente = tomarCamposArmarCliente()
                objCliente.DarDeAltaCliente(cliente.Dni_clientes)
                CargarGrid()

                MsgBox("El Cliente " + txtNOMBRE.Text + " " + txtAPELLIDO.Text + " se dio de alta correctamente", 64, "AVISO")

                Limpiar()


                BtnActivar.Enabled = False
                btnMODIFICAR.Enabled = False
                btnLIMPIAR.Enabled = False
                btnAGREGAR.Enabled = True

                'habilitar campos de textos
                txtAPELLIDO.Enabled = True
                txtNOMBRE.Enabled = True
                txtDIRECCION.Enabled = True
                ComboPROVINCIA.Enabled = True
                txtTELEFONO.Enabled = True
                txtEmail.Enabled = True
                ComboSexo.Enabled = True

                TextDNI.Enabled = True
                TextDNI.Focus()

                'para posicionarse en la fila modificada
                dtgCLIENTES.FirstDisplayedScrollingRowIndex = fila
                dtgCLIENTES.Refresh()
                dtgCLIENTES.CurrentCell = dtgCLIENTES.Rows(fila).Cells(1)
                dtgCLIENTES.Rows(fila).Selected = True

            End If

        Catch ex As Exception

            'MessageBox.Show(ex.ToString())
            MsgBox("El Cliente no se puedo dar de alta", 64, "Guardar")


        End Try

    End Sub


    Private Sub BtnAyuda_Click(sender As Object, e As EventArgs) Handles BtnAyuda.Click
        Dim mensaje As String = "Para Guardar: Llene los campos y click en boton Guardar" & vbNewLine & vbNewLine &
                            "Para Modificar:Doble click en la fila del cliente a modificar y click en boton Modificar" & vbNewLine & vbNewLine &
                            "Para Dar de alta: Doble click en la fila del cliente cuyo estado no está tildado y luego click en boton Dar de Alta"
        Dim titulo As String = "Por Favor, leer estas sugerencias..."
        MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

#Region "CARGA DE FORMULARIO"
    Private Sub FormGestionarClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpiar()

        TextDNI.Focus()
        TextDNI.Enabled = True
        TextDNI.BackColor = Color.White

        btnLIMPIAR.Enabled = False
        btnMODIFICAR.Enabled = False
        BtnActivar.Enabled = False
        btnAGREGAR.Enabled = True

        TextFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        'Mostrar()
        ' Me.Size = New Size(1008, 415)
        'aca deberiamos poner el codigo para que nos muestre los datos del datagrid
        CargarGrid()

        CargarProvincia()

    End Sub

    Public Sub CargarGrid()
        objCliente.getClientesAll(dtgCLIENTES)

        If dtgCLIENTES.Rows.Count() <> 0 Then
            dtgCLIENTES.Rows(0).Selected = False
            dtgCLIENTES.Visible = True
            LModificar.Visible = True
            LDarAlta.Visible = True
            Llistado.Visible = True
            Linfo.Visible = False
            tbxBUSCAAPE.Enabled = True
            tbxBUSCADNI.Enabled = True
        Else
            dtgCLIENTES.Visible = False
            LModificar.Visible = False
            LDarAlta.Visible = False
            Llistado.Visible = False
            Linfo.Visible = True
            tbxBUSCAAPE.Enabled = False
            tbxBUSCADNI.Enabled = False
        End If

        dtgCLIENTES.Columns(8).Visible = False
        Try
            dtgCLIENTES.Columns(0).Width = 80
            dtgCLIENTES.Columns(1).Width = 100
            dtgCLIENTES.Columns(2).Width = 130
            dtgCLIENTES.Columns(3).Width = 150
            dtgCLIENTES.Columns(4).Width = 90
            dtgCLIENTES.Columns(5).Width = 90
            dtgCLIENTES.Columns(6).Width = 170
            dtgCLIENTES.Columns(7).Width = 95
        Catch ex As Exception

        End Try


    End Sub

    Public Sub CargarProvincia()
        objProvincia.cargarBox(ComboPROVINCIA)
    End Sub

#End Region


#Region "CERRAR VENTANA"
    'para el boton X de la parte superior de la ventana
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



    'codigo que asocia la provincia con la caracteristica de telefono de la misma
    Private Sub ComboPROVINCIA_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboPROVINCIA.SelectedValueChanged

        '    Dim caseSwitch As Integer = Integer.TryParse(ComboPROVINCIA.SelectedValue.ToString(), caseSwitch)
        '    Dim caseSwitch As Integer = CInt(ComboPROVINCIA.SelectedValue)

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


#Region "BUSCAR CLIENTES"
    Public Sub Buscar()

        If tbxBUSCAAPE.Text = "" Or tbxBUSCADNI.Text = "" Then

            CargarGrid()

        End If

        If tbxBUSCAAPE.Text <> "" Then
            objCliente.FiltrarClientesApellidos(dtgCLIENTES, tbxBUSCAAPE.Text)
        End If

        If tbxBUSCADNI.Text <> "" Then
            objCliente.FiltrarClienteDNI(dtgCLIENTES, tbxBUSCADNI.Text)
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


#Region "Otros metodos"
    Private Function tomarCamposArmarCliente() As Clientes
        Dim unCliente As Clientes = New Clientes()
        Dim estado As Boolean = dtgCLIENTES.Item(8, fila).Value()

        unCliente.Dni_clientes = CInt(TextDNI.Text)
        unCliente.nombre = Validacion.PrimeraLetraEnMayuscula(txtNOMBRE.Text)
        unCliente.apellido = Validacion.PrimeraLetraEnMayuscula(txtAPELLIDO.Text)
        unCliente.direccion = Validacion.PrimeraLetraEnMayuscula(txtDIRECCION.Text)
        unCliente.id_provincia = CInt(ComboPROVINCIA.SelectedValue.ToString())
        unCliente.telefono = txtTELEFONO.Text
        unCliente.email = txtEmail.Text
        unCliente.fecha_alta = TextFecha.Text
        unCliente.estado_cliente = estado
        unCliente.sexo = ComboSexo.Text
        Return unCliente
    End Function


    Public Function ExisteClienteGrid(ByVal num_dni As String) As Boolean

        Dim existeCliente As Boolean = False

        If Not dtgCLIENTES.RowCount = 0 Then


            For i As Integer = 0 To dtgCLIENTES.Rows.Count - 1

                If dtgCLIENTES.Item(0, i).Value = num_dni Then
                    existeCliente = True
                End If
            Next
            Return existeCliente

        Else
            Return False
        End If

    End Function

    Private Sub lblEMAIL_Click(sender As Object, e As EventArgs) Handles lblEMAIL.Click

    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged

    End Sub



    'Private Sub TextDNI_TextChanged(sender As Object, e As EventArgs) Handles TextDNI.TextChanged
    '    Try

    '        If ExisteClienteGrid(TextDNI.Text) Then
    '            MsgBox("Disculpe el Cliente que desea agregar ya existe, por favor ingrese otro DNI")
    '            Limpiar()
    '            TextDNI.Clear()
    '            TextDNI.Focus()
    '            Exit Sub
    '        End If
    '    Catch ex As Exception

    '    End Try


    'End Sub




#End Region


End Class