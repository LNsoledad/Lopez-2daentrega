Imports System.ComponentModel

Public Class FormGestionarProductos

    Dim objProducto As Eproductos = New Eproductos

    Private Sub FormGestionarProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpiar()
        txtCODIGO.Enabled = True
        txtCODIGO.Focus()

        BtnAgregar.Enabled = True
        BtnEliminar.Enabled = False
        BtnModificar.Enabled = False
        BtnActivar.Enabled = False

        CargarGrid()
        CargarCategorias()
        CargarMarcas()
        CargarOrigenes()
        CargarProveedores()

    End Sub

    Public Sub CargarGrid()
        objProducto.getProductosAll(dtgPRODUCTOS)
        dtgPRODUCTOS.Columns(7).Visible = False

        If dtgPRODUCTOS.Rows.Count() <> 0 Then
            dtgPRODUCTOS.Rows(0).Selected = False
            dtgPRODUCTOS.Visible = True
            Label9.Visible = True
            Linfo.Visible = False
            tbxBUSCACodigo.Enabled = True
            tbxBUSCADescripcion.Enabled = True
        Else
            dtgPRODUCTOS.Visible = False
            Label9.Visible = False
            Linfo.Visible = True
            tbxBUSCACodigo.Enabled = False
            tbxBUSCADescripcion.Enabled = False
        End If

        Try
            dtgPRODUCTOS.Columns(0).Width = 80
            dtgPRODUCTOS.Columns(1).Width = 450
            dtgPRODUCTOS.Columns(2).Width = 140
            dtgPRODUCTOS.Columns(3).Width = 100
            dtgPRODUCTOS.Columns(4).Width = 50
            dtgPRODUCTOS.Columns(5).Width = 90
            dtgPRODUCTOS.Columns(6).Width = 90
            'dtgPRODUCTOS.Columns(7).Width = 80
            dtgPRODUCTOS.Columns(8).Width = 100
            dtgPRODUCTOS.Columns(9).Width = 130

        Catch ex As Exception
        End Try

        'alineamiento del contenido de las columnas
        dtgPRODUCTOS.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dtgPRODUCTOS.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dtgPRODUCTOS.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dtgPRODUCTOS.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dtgPRODUCTOS.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dtgPRODUCTOS.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'dtgPRODUCTOS.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dtgPRODUCTOS.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dtgPRODUCTOS.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Public Sub CargarCategorias()
        objProducto.cargarBoxCategorias(cbxCategoria)
    End Sub

    Public Sub CargarMarcas()
        objProducto.cargarBoxMarcas(cbxMARCA)
    End Sub

    Public Sub CargarOrigenes()
        objProducto.cargarBoxOrigen(ComboOrigen)
    End Sub

    Public Sub CargarProveedores()
        objProducto.cargarBoxProveedores(ComboProveedor)
    End Sub

    Private Sub btnLIMPIAR_Click(sender As Object, e As EventArgs) Handles btnLIMPIAR.Click
        Dim mensaje As String = "Desea borrar todos los campos?"
        If (Validacion.EstaUdSeguro(mensaje)) Then
            Limpiar()
            btnLIMPIAR.Enabled = False
            BtnModificar.Enabled = False
            BtnActivar.Enabled = False
            BtnEliminar.Enabled = False
            BtnAgregar.Enabled = True

            txtCODIGO.Focus()
            txtCODIGO.Enabled = True
        End If
    End Sub

    Private Sub Limpiar()
        txtCODIGO.Focus()
        txtCODIGO.Enabled = True

        txtCODIGO.Clear()
        txtDESCRIPCION.Clear()
        cbxCategoria.SelectedValue = -1
        cbxMARCA.SelectedValue = -1
        txtSTOCK.Clear()
        txtPRECIO.Clear()
        TextPrecioCosto.Clear()
        ComboOrigen.SelectedValue = -1
        ComboProveedor.SelectedValue = -1

        'habilitar campos
        txtDESCRIPCION.Enabled = True
        cbxCategoria.Enabled = True
        cbxMARCA.Enabled = True
        txtSTOCK.Enabled = True
        txtPRECIO.Enabled = True
        TextPrecioCosto.Enabled = True
        ComboOrigen.Enabled = True
        ComboProveedor.Enabled = True

        tbxBUSCADescripcion.Clear()
        tbxBUSCACodigo.Clear()

    End Sub

    Private Sub dtgPRODUCTOS_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dtgPRODUCTOS.CellFormatting
        Dim valor As Boolean
        For i As Integer = 0 To dtgPRODUCTOS.Rows.Count() - 1
            valor = dtgPRODUCTOS.Rows(i).Cells(6).Value
            If valor = False Then
                dtgPRODUCTOS.Rows(i).DefaultCellStyle.BackColor = Color.MediumVioletRed
            Else
                dtgPRODUCTOS.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
            End If
        Next
    End Sub


    Dim fila As Integer 'variable global que obtendra el indice de la fila que se clickeo
    Private Sub dtgPRODUCTOS_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgPRODUCTOS.CellDoubleClick

        fila = dtgPRODUCTOS.CurrentRow.Index 'toma el indice de la fila en la cual se hizo doble click

        txtCODIGO.Text = dtgPRODUCTOS.Item(0, fila).Value()
        txtDESCRIPCION.Text = dtgPRODUCTOS.Item(1, fila).Value()
        cbxCategoria.Text = dtgPRODUCTOS.Item(2, fila).Value()
        cbxMARCA.Text = dtgPRODUCTOS.Item(3, fila).Value()
        txtSTOCK.Text = dtgPRODUCTOS.Item(4, fila).Value()
        TextPrecioCosto.Text = dtgPRODUCTOS.Item(5, fila).Value()
        txtPRECIO.Text = dtgPRODUCTOS.Item(6, fila).Value()
        ComboOrigen.Text = dtgPRODUCTOS.Item(8, fila).Value()
        ComboProveedor.Text = dtgPRODUCTOS.Item(9, fila).Value()



        ''------------habilitar botones de dar  de alta de acuerdo con el estado del producto
        txtCODIGO.Enabled = False

        Dim estado As Boolean = dtgPRODUCTOS.Item(7, fila).Value()

        If estado Then

            Dim mensajeEliminar As String = "Desea Modificar el Producto?"
            If (Validacion.EstaUdSeguro(mensajeEliminar)) Then
                BtnAgregar.Enabled = False
                BtnActivar.Enabled = False
                BtnEliminar.Enabled = False
                btnLIMPIAR.Enabled = True

                BtnModificar.Enabled = True

                Exit Sub

            End If

            Dim mensajeBaja As String = "Desea Dar de Baja el Producto?"
            If (Validacion.EstaUdSeguro(mensajeBaja)) Then
                BtnActivar.Enabled = False
                BtnEliminar.Enabled = True
                btnLIMPIAR.Enabled = True
                BtnAgregar.Enabled = False
                BtnModificar.Enabled = False

                'inhabilitar campos
                txtDESCRIPCION.Enabled = False
                cbxCategoria.Enabled = False
                cbxMARCA.Enabled = False
                txtSTOCK.Enabled = False
                txtPRECIO.Enabled = False
                ComboOrigen.Enabled = False
                ComboProveedor.Enabled = False
                TextPrecioCosto.Enabled = False

                Exit Sub


            End If


        Else

            Dim mensajeEliminar As String = "Desea Modificar el Producto?"
            If (Validacion.EstaUdSeguro(mensajeEliminar)) Then
                BtnAgregar.Enabled = False
                BtnActivar.Enabled = False
                BtnEliminar.Enabled = False
                btnLIMPIAR.Enabled = True

                BtnModificar.Enabled = True

                Exit Sub

            End If

            Dim mensajeAlta As String = "Desea Dar de Alta el Producto?"
            If (Validacion.EstaUdSeguro(mensajeAlta)) Then
                BtnActivar.Enabled = True
                btnLIMPIAR.Enabled = True
                BtnAgregar.Enabled = False
                BtnModificar.Enabled = False
                BtnEliminar.Enabled = False

                'inhabilitar campos
                txtDESCRIPCION.Enabled = False
                cbxCategoria.Enabled = False
                cbxMARCA.Enabled = False
                txtSTOCK.Enabled = False
                txtPRECIO.Enabled = False
                ComboOrigen.Enabled = False
                ComboProveedor.Enabled = False
                TextPrecioCosto.Enabled = False
                Exit Sub


            End If



        End If 'cierre del if estado

        Limpiar()
        txtCODIGO.Enabled = True
        txtCODIGO.Focus()
        BtnAgregar.Enabled = True

        BtnModificar.Enabled = False
        'btnLIMPIAR.Enabled = True
        'BtnAgregar.Enabled = False

    End Sub


    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim ask As MsgBoxResult

        If txtCODIGO.Text = "" Or txtDESCRIPCION.Text = "" Or cbxCategoria.Text = "" Or cbxMARCA.Text = "" Or txtSTOCK.Text = "" Or txtPRECIO.Text = "" Or ComboOrigen.Text = "" Or ComboProveedor.Text = "" Or TextPrecioCosto.Text = "" Then
            MsgBox("Por favor,Complete todos los campos", MsgBoxStyle.Critical, "Error")
            Exit Sub

        Else
            If contarComaVenta > 1 Then
                MessageBox.Show("Por favor utilice solo una coma para separacion decimal en el precio de venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'txtPRECIO.Clear()
                txtPRECIO.Focus()
                Exit Sub
            End If

            If contarComaCosto > 1 Then
                MessageBox.Show("Por favor utilice solo una coma para separacion decimal en el precio de costo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'txtPRECIO.Clear()
                TextPrecioCosto.Focus()
            Exit Sub
        End If

            If txtPRECIO.Text = 0 Then
                MsgBox("Por favor ingrese precio de venta, distinto de 0(cero)", MsgBoxStyle.Critical, "ERROR")
                Exit Sub
            ElseIf txtPRECIO.Text = "" Then
                MsgBox("Por favor ingrese precio de venta", MsgBoxStyle.Critical, "ERROR")
                Exit Sub
            End If

            If TextPrecioCosto.Text = 0 Then
                MsgBox("Por favor ingrese precio de costo, distinto de 0(cero)", MsgBoxStyle.Critical, "ERROR")
                Exit Sub
            ElseIf TextPrecioCosto.Text = "" Then
                MsgBox("Por favor ingrese precio de costo", MsgBoxStyle.Critical, "ERROR")
                Exit Sub
            End If

            If txtSTOCK.Text = 0 Then
                MsgBox("Por favor ingrese stock, distinto de 0(cero)", MsgBoxStyle.Critical, "ERROR")
                Exit Sub
            ElseIf txtSTOCK.Text = "" Then
                MsgBox("Por favor ingrese stock", MsgBoxStyle.Critical, "ERROR")
                Exit Sub
            End If



                Try
                If ExisteProductoGrid(txtCODIGO.Text) Then
                    MsgBox("Disculpe el Producto que desea agregar ya existe, por favor ingrese otro codigo", MsgBoxStyle.Critical, "Error,el Codigo Ya existe")
                    'Limpiar()
                    txtCODIGO.Focus()
                    Exit Sub
                Else

                    Dim nuevoProducto As Eproductos = New Eproductos(CInt(txtCODIGO.Text), txtDESCRIPCION.Text, CInt(cbxCategoria.SelectedValue), CInt(cbxMARCA.SelectedValue), txtSTOCK.Text, txtPRECIO.Text, True, CInt(ComboOrigen.SelectedValue), CInt(ComboProveedor.SelectedValue), TextPrecioCosto.Text)
                    'se llama la contructor con parametros

                    ask = MsgBox("Seguro que desea insertar un nuevo Producto?", 36, "Confirmar Insercion")

                    If ask = vbYes Then
                        If nuevoProducto.guardarproducto() Then
                            MsgBox("El Producto " + txtDESCRIPCION.Text + " se inserto correctamente", 64, "Guardar")

                            CargarGrid()
                            'limpiar todos los controles
                            'llamar a la funcion Limpiar()
                            Limpiar()

                        End If

                    End If

                End If

            Catch ex As Exception
                MsgBox("El Producto no se puedo agregar", 64, "Guardar")
                btnLIMPIAR.Enabled = True
                'MessageBox.Show(ex.ToString())
                ' MessageBox.Show("Error en Base de Datos. no esta disponible")
            End Try

        End If

    End Sub


    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            Dim mensaje As String = "Esta seguro que desea dar de baja al Producto seleccionado?"
            If (Validacion.EstaUdSeguro(mensaje)) Then

                Dim producto = tomarCamposArmarProducto()
                objProducto.eliminarProducto(producto.id_producto)
                CargarGrid()

                MsgBox("El Producto " + txtDESCRIPCION.Text + " se dio de baja correctamente", 64, "AVISO")

                Limpiar()

                BtnActivar.Enabled = False
                BtnEliminar.Enabled = False
                BtnModificar.Enabled = False
                btnLIMPIAR.Enabled = False
                BtnAgregar.Enabled = True

                txtCODIGO.Enabled = True
                txtCODIGO.Focus()

                'para posicionarse en la fila modificada
                dtgPRODUCTOS.FirstDisplayedScrollingRowIndex = fila
                dtgPRODUCTOS.Refresh()
                dtgPRODUCTOS.CurrentCell = dtgPRODUCTOS.Rows(fila).Cells(1)
                dtgPRODUCTOS.Rows(fila).Selected = True


            End If

        Catch ex As Exception

            'MessageBox.Show(ex.ToString())
            MessageBox.Show("No se pudo dar de baja el Producto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)


        End Try

    End Sub


    Private Sub BtnActivar_Click(sender As Object, e As EventArgs) Handles BtnActivar.Click

        Try
            Dim mensaje As String = "Esta seguro que desea dar de baja al Producto seleccionado?"
            If (Validacion.EstaUdSeguro(mensaje)) Then

                Dim producto = tomarCamposArmarProducto()
                objProducto.DarDeAltaProducto(producto.id_producto)
                CargarGrid()

                MsgBox("El Producto " + txtDESCRIPCION.Text + " se dio de alta correctamente", 64, "AVISO")

                Limpiar()

                BtnActivar.Enabled = False
                BtnEliminar.Enabled = False
                BtnModificar.Enabled = False
                btnLIMPIAR.Enabled = False
                BtnAgregar.Enabled = True

                txtCODIGO.Enabled = True
                txtCODIGO.Focus()


                'para posicionarse en la fila modificada
                dtgPRODUCTOS.FirstDisplayedScrollingRowIndex = fila
                dtgPRODUCTOS.Refresh()
                dtgPRODUCTOS.CurrentCell = dtgPRODUCTOS.Rows(fila).Cells(1)
                dtgPRODUCTOS.Rows(fila).Selected = True

            End If

        Catch ex As Exception

            'MessageBox.Show(ex.ToString())
            MessageBox.Show("No se pudo dar de alta el Producto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If txtCODIGO.Text = "" Or txtDESCRIPCION.Text = "" Or cbxCategoria.Text = "" Or cbxMARCA.Text = "" Or txtSTOCK.Text = "" Or txtPRECIO.Text = "" Or ComboOrigen.Text = "" Or ComboProveedor.Text = "" Or TextPrecioCosto.Text = "" Then
            MsgBox("Por favor,Complete todos los campos", MsgBoxStyle.Critical, "Error")
            Exit Sub

        Else

            If contarComaVenta > 1 Then
                MessageBox.Show("Por favor utilice solo una coma para separacion decimal en el precio de venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'txtPRECIO.Clear()
                txtPRECIO.Focus()
                Exit Sub
            End If

            If contarComaCosto > 1 Then
                MessageBox.Show("Por favor utilice solo una coma para separacion decimal en el precio de costo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'txtPRECIO.Clear()
                TextPrecioCosto.Focus()
                Exit Sub
            End If

            If txtPRECIO.Text = 0 Then
                MsgBox("Por favor ingrese precio de venta, distinto de 0(cero)", MsgBoxStyle.Critical, "ERROR")
                Exit Sub
            ElseIf txtPRECIO.Text = "" Then
                MsgBox("Por favor ingrese precio de venta", MsgBoxStyle.Critical, "ERROR")
                Exit Sub
            End If


            If TextPrecioCosto.Text = 0 Then
                MsgBox("Por favor ingrese precio de costo, distinto de 0(cero)", MsgBoxStyle.Critical, "ERROR")
                Exit Sub
            ElseIf TextPrecioCosto.Text = "" Then
                MsgBox("Por favor ingrese precio de costo", MsgBoxStyle.Critical, "ERROR")
                Exit Sub
            End If

            If txtSTOCK.Text = 0 Then
                MsgBox("Por favor ingrese stock, distinto de 0(cero)", MsgBoxStyle.Critical, "ERROR")
                Exit Sub
            ElseIf txtSTOCK.Text = "" Then
                MsgBox("Por favor ingrese stock", MsgBoxStyle.Critical, "ERROR")
                Exit Sub
            End If


            Try


                Dim mensaje As String = "¿Seguro que queres Modificar el Producto: " + txtDESCRIPCION.Text & vbNewLine &
                                            "Con el Codigo Nº:  " + txtCODIGO.Text + " ?"
                If (Validacion.EstaUdSeguro(mensaje)) Then


                    Dim producto = tomarCamposArmarProducto()
                    objProducto.actualizarProducto(producto)
                    CargarGrid()

                    MsgBox("El Producto " + txtDESCRIPCION.Text & vbNewLine &
                                            "Con el Codigo Nº:  " + txtCODIGO.Text + " se modifico correctamente", MsgBoxStyle.Information, "AVISO")
                    Limpiar()

                    BtnActivar.Enabled = False
                    BtnEliminar.Enabled = False
                    BtnModificar.Enabled = False
                    btnLIMPIAR.Enabled = False
                    BtnAgregar.Enabled = True

                    txtCODIGO.Enabled = True
                    txtCODIGO.Focus()

                    'hacer foco en el modificado(falta)
                    'para posicionarse en la fila modificada
                    dtgPRODUCTOS.FirstDisplayedScrollingRowIndex = fila
                    dtgPRODUCTOS.Refresh()
                    dtgPRODUCTOS.CurrentCell = dtgPRODUCTOS.Rows(fila).Cells(0)
                    dtgPRODUCTOS.Rows(fila).Selected = True

                End If

            Catch ex As Exception

                '//MessageBox.Show(ex.ToString());
                MsgBox("El Producto " + txtDESCRIPCION.Text + " no se puedo modificar", 64, "Guardar")
                btnLIMPIAR.Enabled = True

            End Try

        End If
    End Sub



#Region "VALIDACIONES"
    'VALIDACIONES A LOS CONTROLES
    Private Sub txtCODIGO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCODIGO.KeyPress
        validarSoloNumeros(e)
        If Asc(e.KeyChar) = 13 Then 'Asc es codigo ASCII, si se presiona ENTER codigo ASCII=13
            txtDESCRIPCION.Focus()

        End If

    End Sub

    Private Sub txtDESCRIPCION_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDESCRIPCION.KeyPress
        Validacion.validarNumerosYLetras1(e)

        If Asc(e.KeyChar) = 13 Then 'Asc es codigo ASCII, si se presiona ENTER codigo ASCII=13
            cbxMARCA.Focus()

        End If
    End Sub

    Private Sub cbxCategoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxCategoria.KeyPress
        If Asc(e.KeyChar) = 13 Then 'Asc es codigo ASCII, si se presiona ENTER codigo ASCII=13
            cbxMARCA.Focus()

        End If
    End Sub
    Private Sub cbxMARCA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxMARCA.KeyPress
        If Asc(e.KeyChar) = 13 Then 'Asc es codigo ASCII, si se presiona ENTER codigo ASCII=13
            txtSTOCK.Focus()

        End If
    End Sub

    Private Sub txtSTOCK_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSTOCK.KeyPress
        validarSoloNumeros(e)
        'If Not EsEntero(txtSTOCK.Text) Then
        '    MsgBox("Stock debe ser un numero entero", MsgBoxStyle.Exclamation, "Informacion")
        'End If
        If Asc(e.KeyChar) = 13 Then 'Asc es codigo ASCII, si se presiona ENTER codigo ASCII=13
            txtPRECIO.Focus()
        End If
    End Sub


    Private Sub txtPRECIO_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPRECIO.KeyUp
        If Not Validacion.ValidarCampoDecimal(sender) Then
            MessageBox.Show("Por favor ingrese un numero entero o un decimal (00,00)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPRECIO.Focus()
            'txtPRECIO.Clear()
        End If

    End Sub

    Private Sub TextPrecioCosto_KeyUp(sender As Object, e As KeyEventArgs) Handles TextPrecioCosto.KeyUp
        If Not Validacion.ValidarCampoDecimal(sender) Then
            MessageBox.Show("Por favor ingrese un numero entero o un decimal (00,00)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'TextPrecioCosto.Clear()
            TextPrecioCosto.Focus()
        End If

    End Sub

    Dim contarComaVenta As Integer = 0 'Cantidad de veces que se apreto la tecla coma
    Private Sub txtPRECIO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPRECIO.KeyPress
        'Validacion.validarSoloDecimales(e, txtPRECIO)
        If Asc(e.KeyChar) = 46 Then 'Asc es codigo ASCII, si se presiona punto codigo ASCII=46
            MessageBox.Show("Por favor utilice la coma para separacion decimal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'txtPRECIO.Clear()
            txtPRECIO.Focus()
        ElseIf Asc(e.KeyChar) = 44 Then 'Asc es codigo ASCII, si se presiona coma codigo ASCII=43
            contarComaVenta = contarComaVenta + 1
            If contarComaVenta > 1 Then
                MessageBox.Show("Por favor utilice solo una coma para separacion decimal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'txtPRECIO.Clear()
                txtPRECIO.Focus()
            End If
        ElseIf Asc(e.KeyChar) = 13 Or Asc(e.KeyChar) = 127 Then


        End If

    End Sub

    Dim contarComaCosto As Integer = 0 'Cantidad de veces que se apreto la tecla coma
    Private Sub TextPrecioCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextPrecioCosto.KeyPress

        If Asc(e.KeyChar) = 46 Then 'Asc es codigo ASCII, si se presiona punto codigo ASCII=46
            MessageBox.Show("Por favor utilice la coma para separacion decimal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'txtPRECIO.Clear()
            TextPrecioCosto.Focus()
        ElseIf Asc(e.KeyChar) = 44 Then 'Asc es codigo ASCII, si se presiona coma codigo ASCII=43
            contarComaCosto = contarComaCosto + 1
            If contarComaCosto > 1 Then
                MessageBox.Show("Por favor utilice solo una coma para separacion decimal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'txtPRECIO.Clear()
                TextPrecioCosto.Focus()
            End If
        End If

    End Sub


#End Region

#Region "Buscar Productos"

    Public Sub Buscar()

        If tbxBUSCADescripcion.Text = "" Or tbxBUSCACodigo.Text = "" Then

            CargarGrid()

        End If

        If tbxBUSCADescripcion.Text <> "" Then
            objProducto.FiltrarProductosDescripcion(dtgPRODUCTOS, tbxBUSCADescripcion.Text)
            'dtgPRODUCTOS.Rows(0).Selected = False 'no este seleccionada ninguna fila
        End If

        If tbxBUSCACodigo.Text <> "" Then
            objProducto.FiltrarProductosCodigo(dtgPRODUCTOS, tbxBUSCACodigo.Text)
            'dtgPRODUCTOS.Rows(0).Selected = False
        End If


    End Sub

    Private Sub tbxBUSCADescripcion_TextChanged(sender As Object, e As EventArgs) Handles tbxBUSCADescripcion.TextChanged
        Buscar()
    End Sub

    Private Sub tbxBUSCACodigo_TextChanged(sender As Object, e As EventArgs) Handles tbxBUSCACodigo.TextChanged
        Buscar()

    End Sub

    Private Sub tbxBUSCADescripcion_MouseClick(sender As Object, e As MouseEventArgs) Handles tbxBUSCADescripcion.MouseClick
        tbxBUSCACodigo.Clear()
        CargarGrid()
    End Sub

    Private Sub tbxBUSCACodigo_MouseClick(sender As Object, e As MouseEventArgs) Handles tbxBUSCACodigo.MouseClick
        tbxBUSCADescripcion.Clear()
        CargarGrid()
    End Sub

    Private Sub tbxBUSCADescripcion_GotFocus(sender As Object, e As EventArgs) Handles tbxBUSCADescripcion.GotFocus
        tbxBUSCACodigo.Clear()
        CargarGrid()
    End Sub

    Private Sub tbxBUSCACodigo_GotFocus(sender As Object, e As EventArgs) Handles tbxBUSCACodigo.GotFocus
        tbxBUSCADescripcion.Clear()
        CargarGrid()
    End Sub

#End Region

#Region "Cambios de colores de botones"

    '---los botones cambian al color DarkGreen cuando se esta sobre los mismos---------------------------------
    Private Sub BtnAgregar_MouseEnter(sender As Object, e As EventArgs) Handles BtnAgregar.MouseEnter
        BtnAgregar.BackColor = Color.LimeGreen
    End Sub

    Private Sub BtnEliminar_MouseEnter(sender As Object, e As EventArgs) Handles BtnEliminar.MouseEnter
        BtnEliminar.BackColor = Color.LimeGreen
    End Sub

    Private Sub BtnActivar_MouseEnter(sender As Object, e As EventArgs) Handles BtnActivar.MouseEnter
        BtnActivar.BackColor = Color.LimeGreen
    End Sub

    Private Sub BtnModificar_MouseEnter(sender As Object, e As EventArgs) Handles BtnModificar.MouseEnter
        BtnModificar.BackColor = Color.LimeGreen
    End Sub

    '-------------------------------------------------------------------------------------------------------------
    '---los botones cambian al color limeGreen cuando se aleja de los mismos---------------------------------
    Private Sub BtnModificar_MouseLeave(sender As Object, e As EventArgs) Handles BtnModificar.MouseLeave
        BtnModificar.BackColor = Color.LightGreen
    End Sub

    Private Sub BtnAgregar_MouseLeave(sender As Object, e As EventArgs) Handles BtnAgregar.MouseLeave
        BtnAgregar.BackColor = Color.LightGreen
    End Sub

    Private Sub BtnEliminar_MouseLeave(sender As Object, e As EventArgs) Handles BtnEliminar.MouseLeave
        BtnEliminar.BackColor = Color.LightGreen
    End Sub

    Private Sub BtnActivar_MouseLeave(sender As Object, e As EventArgs) Handles BtnActivar.MouseLeave
        BtnActivar.BackColor = Color.LightGreen
    End Sub


#End Region

#Region "CERRAR VENTANA"
    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        If MessageBox.Show("Estas seguro que desea Salir", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Me.Hide()
            'FormSupervisor.Show()
            'Application.[Exit]()
            tbxBUSCADescripcion.Clear()
            tbxBUSCACodigo.Clear()
            Limpiar()

            Me.Close()

        End If
    End Sub
#End Region

#Region "Otros metodos"
    Private Function tomarCamposArmarProducto() As Productos
        Dim unProducto As Productos = New Productos()
        Dim estado As Boolean = dtgPRODUCTOS.Item(6, fila).Value()

        unProducto.id_producto = CInt(txtCODIGO.Text)
        unProducto.descripcion = txtDESCRIPCION.Text
        unProducto.id_categoria = CInt(cbxCategoria.SelectedValue.ToString())
        unProducto.id_marca = CInt(cbxMARCA.SelectedValue.ToString())
        unProducto.stock = txtSTOCK.Text
        unProducto.precio = txtPRECIO.Text
        unProducto.estado = estado
        unProducto.precio_costo = TextPrecioCosto.Text
        unProducto.id_origen = CInt(ComboOrigen.SelectedValue.ToString())
        unProducto.id_proveedor = CInt(ComboProveedor.SelectedValue.ToString())

        Return unProducto
    End Function

    Public Function ExisteProductoGrid(ByVal codigo As String) As Boolean
        Dim existeProducto As Boolean = False

        If Not dtgPRODUCTOS.RowCount = 0 Then

            For i As Integer = 0 To dtgPRODUCTOS.Rows.Count - 1

                If dtgPRODUCTOS.Item(0, i).Value = codigo Then
                    existeProducto = True
                End If
            Next
            Return existeProducto
        Else
            Return False
        End If

    End Function

    Private Sub BtnAyuda_Click(sender As Object, e As EventArgs) Handles BtnAyuda.Click
        Dim mensaje As String = "Para Guardar: Llene los campos y click en boton Guardar" & vbNewLine & vbNewLine &
                          "Para Modificar:Doble click en la fila del Producto que desea modificar y click en boton Modificar" & vbNewLine & vbNewLine &
                          "Para Dar de alta: Doble click en la fila del Producto cuyo estado no esta tildado y luego click en boton Dar de Alta" & vbNewLine & vbNewLine &
                           "Para Dar de Baja: Doble click en la fila del Producto cuyo estado esta tildado y luego click en boton Dar de Baja"
        Dim titulo As String = "Por Favor, leer estas sugerencias..."
        MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub









    'Private Sub txtCODIGO_TextChanged(sender As Object, e As EventArgs) Handles txtCODIGO.TextChanged
    '    Try

    '        If ExisteProductoGrid(txtCODIGO.Text) Then
    '            MsgBox("Disculpe el Producto que desea agregar ya existe, por favor ingrese otro DNI")
    '            Limpiar()
    '            txtCODIGO.Clear()
    '            txtCODIGO.Focus()
    '            Exit Sub
    '        End If
    '    Catch ex As Exception

    '    End Try


    'End Sub

#End Region


End Class