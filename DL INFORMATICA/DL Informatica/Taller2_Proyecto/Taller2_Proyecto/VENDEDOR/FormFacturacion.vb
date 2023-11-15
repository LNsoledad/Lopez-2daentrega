Imports System.ComponentModel

Public Class FormFacturacion
    Dim objEmpleado As Eempleados = New Eempleados

    Dim linea As Integer
    Dim producto_v As Integer
    Dim descripcion_v As String
    Dim cantidad_v As Integer
    Dim precio_v As Decimal
    Dim subTotal_v As Decimal = 0
    Dim total_v As Decimal = 0
    Dim objFactura As Facturas = New Facturas

    Dim objProducto As Eproductos = New Eproductos

    Dim unaFactura As Facturas = New Facturas
    ' Private objFactura As New Facturas()




    '-----------reloj digital en pantalla
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblHORAS.Text = TimeOfDay.TimeOfDay.ToString
    End Sub

    '--------------metodo para controlar los botones y evitar mal funcionamiento
    Private Sub controlarBotones()
        If Me.dtgVentas.Rows().Count = 0 Then
            Me.btnEliminar.Enabled = False
            Me.btnCANCELAR.Enabled = False
            Me.btnFACTURAR.Enabled = False
            Me.BtnEditar.Enabled = False

        Else
            'Me.btnEliminar.Enabled = True
            Me.btnCANCELAR.Enabled = True
            Me.btnFACTURAR.Enabled = True

        End If
    End Sub


    '---------------busca un articulo en el datagrid de detalles
    Private Function VerArticuloDelDetalle(ByVal cod As String) As Boolean
        Dim todas = Me.dtgVentas.Rows

        For Each row As DataGridViewRow In todas

            If (row.Cells(2).Value) = cod Then
                Return True

            End If
        Next
        Return False
    End Function


    '---metodo para actualizar stock cuando eliminamos un producto del detalle
    Private Sub actualizaTotal()
        Dim fila As Integer = Me.dtgVentas.CurrentRow.Index
        Dim subtotal As Decimal = Me.dtgVentas.Rows(fila).Cells(4).Value
        total_v = total_v - subtotal

        lblTotal.Text = total_v

    End Sub

    '_______INICIO  DE FORMULARIO, CUANDO SE EJECUTA_____________




    Private Sub FormFacturacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tbxDNI_USUARIO.Text = Mdni
        '  tbxFACTURA_N.Text = objFactura.id_factura + 1
        TxtNombre.Text = Mapellido + ", " + Mnombre
        tbxFecha.Text = Date.Today
        Me.dtgVentas.Columns(0).Visible = False 'columna codigo no aparece en detalle
        cargarGrid()

        Try
            'propiedad del dtgVentas 
            dtgVentas.Columns(1).Width = 570
            dtgVentas.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dtgVentas.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dtgVentas.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Catch ex As Exception

        End Try


        controlarBotones()

        'verificar el numero de factura y que este asignado el usuario

    End Sub



#Region "Botones"

    '-------------formulario de gestion de clientes
    Private Sub btnNUEVO_Cli_Click(sender As Object, e As EventArgs) Handles btnNUEVO_Cli.Click
        FormGestionarClientes.ShowDialog()
    End Sub


    '--------llama al formulario de consulta clientes para buscar cliente y traerlo a la facturacion
    Private Sub btnBUSCA_CLI_Click(sender As Object, e As EventArgs) Handles btnBUSCA_CLI.Click
        FormBuscarCliente.ShowDialog()

    End Sub

    Private Sub BtnBuscarProducto_Click(sender As Object, e As EventArgs) Handles BtnBuscarProducto.Click
        FormBuscarProducto.ShowDialog()
    End Sub

    '-------------BOTON LIMPIAR, solo limpia los campos (textBox)
    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click

        Limpiar()

        btnAGREGAR_PRODUCTO.Enabled = False
        txtCANTIDAD.Enabled = False
        BtnLimpiar.Enabled = False


    End Sub

    Public Sub Limpiar()
        txtCod.Clear()
        txtDescripcion.Clear()
        txtCANTIDAD.Clear()
        txtPRECIO.Clear()
        tbxFACTURA_N.Clear()

        tbxBuscaDesc.Clear()
        tbxBuscaCod.Clear()
    End Sub

    Public Sub LimpiarCampos()
        txtCod.Clear()
        txtDescripcion.Clear()
        txtCANTIDAD.Clear()
        txtPRECIO.Clear()
        lblTotal.Text = 0

        tbxCLIENTE_cod.Clear()
        tbxCLIENTE_ape.Clear()
        tbxCLIENTE_nom.Clear()

        btnEliminar.Enabled = False
        BtnEditar.Enabled = False

        tbxBuscaDesc.Clear()
        tbxBuscaCod.Clear()
    End Sub
    '--boton eliminar detalle----
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Dim ask As MsgBoxResult
        ask = MsgBox("¿ESTA SEGURO DE ELIMINAR EL ARTICULO DEL DETALLE? ", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1 +
           MsgBoxStyle.Question, "confirmacion")
        If MsgBoxResult.Yes = ask Then

            Dim fila As Integer = Me.dtgVentas.CurrentRow.Index

            actualizaTotal() 'actualizamos el total 

            Me.dtgVentas.Rows.Remove(Me.dtgVentas.CurrentRow)

            controlarBotones()
            txtCANTIDAD.Enabled = False
        End If
    End Sub

    '----boton editar detalle------
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        '//saca del datagrid y los envia los datos en los campos y descuenta el total, luego se vuelve a agregar

        Dim ask As MsgBoxResult
        ask = MsgBox("¿ESTA SEGURO DE EDITAR EL ARTICULO DEL DETALLE? ", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1 +
           MsgBoxStyle.Question, "confirmacion")
        If MsgBoxResult.Yes = ask Then
            Dim fila As Integer = Me.dtgVentas.CurrentRow.Index

            txtCod.Text = Me.dtgVentas.Rows(fila).Cells(0).Value '//lleva lo del datagrid a los campos
            txtDescripcion.Text = Me.dtgVentas.Rows(fila).Cells(1).Value  'descripcion
            txtPRECIO.Text = Me.dtgVentas.Rows(fila).Cells(3).Value '//precio
            txtCANTIDAD.Text = Me.dtgVentas.Rows(fila).Cells(2).Value 'cantidad

            '//actualizar total

            Dim subtotal As Decimal = Me.dtgVentas.Rows(fila).Cells(4).Value '//4 es la posicion donde se encuentra el subtotal

            total_v = total_v - subtotal

            lblTotal.Text = total_v '//6 es el numero de textbox de total, actualizamos total

            Me.dtgVentas.Rows.Remove(Me.dtgVentas.CurrentRow)

            controlarBotones()

            btnAGREGAR_PRODUCTO.Enabled = True
            BtnLimpiar.Enabled = True
            txtCANTIDAD.Enabled = True
        End If
    End Sub


    '-------------BOTON CANCELA VENTA (limpia el carrito)
    Private Sub btnCANCELAR_Click(sender As System.Object, e As System.EventArgs) Handles btnCANCELAR.Click
        Dim ask As MsgBoxResult
        ask = MsgBox("¿ESTA SEGURO DE CANCELAR LA VENTA? ", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1 +
           MsgBoxStyle.Question, "confirmacion")
        If MsgBoxResult.Yes = ask Then
            Dim restar As Decimal = total_v
            For i As Integer = 0 To dtgVentas.Rows.Count - 1

                Me.dtgVentas.Rows.Clear()

            Next
            total_v = restar - restar
            lblTotal.Text = total_v

            controlarBotones() 'Controla los botones para inhabilitar e habilitar

            tbxCLIENTE_cod.Clear()
            tbxCLIENTE_ape.Clear()
            tbxCLIENTE_nom.Clear()
        End If


    End Sub


    Private Sub btnFACTURAR_Click(sender As Object, e As EventArgs) Handles btnFACTURAR.Click

        Try
            If tbxCLIENTE_cod.Text = "" Then
                MsgBox("Por favor cargue un cliente", MsgBoxStyle.Critical, "ERROR")
                Exit Sub
            End If

            Dim mensaje = "Se realizará la Venta..." & vbNewLine &
                    "Se genera una Factura;¿Esta Seguro de realizar esta acción?"

            If (Validacion.EstaUdSeguro(mensaje)) Then


                '//LLamo al metodo crearFactura() que encapsula la creacion y asignacion
                '//de valores correspondientes a una nueva Factura
                'crearFactura()
                Dim objFactura As Efactura = New Efactura
                Dim idFactura As Integer = objFactura.ObtenerUltimaFactura()
                idFactura = idFactura + 1
                Dim unaFactura As Facturas = New Facturas


                With unaFactura
                    .id_factura = idFactura
                    .id_usuario = DatosImportantes.IdUsu
                    .Dni_cliente = CInt(tbxCLIENTE_cod.Text)
                    .fecha_factura = CDate(tbxFecha.Text)
                    .Total_factura = CDec(lblTotal.Text)
                    .estado_factura = 1

                End With



                '//Mando a guardar a base de datos
                If (objFactura.GuardarFactura(unaFactura)) Then
                    '
                    MsgBox("La factura se genero correctamente", MsgBoxStyle.Information, "Venta exitosa")
                    '//Si el proceso de venta fue exitoso debo mostrar el formulario factura limpio

                    btnCANCELAR.Enabled = False
                    btnFACTURAR.Enabled = False

                Else
                    MsgBox("La factura no se genero correctamente", MsgBoxStyle.Critical, "ERROR")
                    Exit Sub
                End If
                Dim objDetalleFactura As Edetalle_factura = New Edetalle_factura

                Dim unDetalle As DetalleFacturas = New DetalleFacturas

                If (objDetalleFactura.guardarDetalle(dtgVentas, idFactura)) Then
                    MsgBox("Se guardo el datalle")
                Else
                    MsgBox("Error, no se guardo")
                End If




                ' tbxFACTURA_N.Text = idFactura


                'For i As Integer = 0 To dtgVentas.RowCount - 1

                '    '       '//guardo cada valor
                '    Dim idProducto As Integer = CInt(dtgVentas.Item(0, i).Value)
                '    Dim cantidad As Integer = CInt(dtgVentas.Item(2, i).Value)
                '    Dim precio As Decimal = CDec(dtgVentas.Item(3, i).Value)
                '    Dim subtotal As Decimal = CDec(dtgVentas.Item(4, i).Value)

                '//Creo un detalle
                '    Dim lineaDeVenta As Edetalle_factura = New Edetalle_factura(idFactura, idProducto, cantidad, precio, subtotal)

                '//Guardo el detalle

                'lineaDeVenta.guardarDetalle()


                ' MsgBox("ghgh")

                ' Next

                'Dim mensaje2 As String = "SE GENERO LA VENTA EXITOSAMENTE ¿Desea IMPRIMIR la Factura?"
                'If (Validacion.EstaUdSeguro(mensaje2)) Then

                '    Dim reporteFactura = New FormGenerarFactura()
                '    reporteFactura.mostrarFactura(idFactura)
                '    reporteFactura.ShowDialog()

                'End If
                '//Limpio mi detalle de productos porque la venta se generó y fue exitosa
                Limpiar()
                LimpiarCampos()
                dtgVentas.Rows.Clear()

                cargarGrid()

            End If '//Fin de aceptar que esta seguro de generar la venta


        Catch ex As Exception

            MessageBox.Show(ex.ToString())
            'MessageBox.Show("No se pudo generar la Factura", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information)


        End Try '//Fin de try generar factura

    End Sub
#End Region


#Region "datagrid productos"
    Public Sub cargarGrid()
        objProducto.getProductosActivosConStock(dtgPRODUCTOS)

        If dtgPRODUCTOS.Rows.Count() <> 0 Then
            dtgPRODUCTOS.Rows(0).Selected = False
            dtgPRODUCTOS.Visible = True
            Label1.Visible = True
            Linfo.Visible = False
            tbxBuscaCod.Enabled = True
            tbxBuscaDesc.Enabled = True
        Else
            dtgPRODUCTOS.Visible = False
            Label1.Visible = False
            Linfo.Visible = True
            tbxBuscaCod.Enabled = False
            tbxBuscaDesc.Enabled = False
        End If

        Try
            'redimensionar las columnas
            dtgPRODUCTOS.Columns(0).Width = 50
            dtgPRODUCTOS.Columns(1).Width = 250
            dtgPRODUCTOS.Columns(2).Width = 75
            dtgPRODUCTOS.Columns(3).Width = 30
            dtgPRODUCTOS.Columns(4).Width = 90
            'alineacion del texto de la columnas
            dtgPRODUCTOS.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dtgPRODUCTOS.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dtgPRODUCTOS.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dtgPRODUCTOS.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Catch ex As Exception

        End Try

    End Sub


    Public Sub Buscar()

        If tbxBuscaDesc.Text = "" Or tbxBuscaCod.Text = "" Then

            cargarGrid()

        End If

        If tbxBuscaDesc.Text <> "" Then
            objProducto.FiltrarProductosDescripcion1(dtgPRODUCTOS, tbxBuscaDesc.Text)
        End If

        If tbxBuscaCod.Text <> "" Then
            objProducto.FiltrarProductosCodigo1(dtgPRODUCTOS, tbxBuscaCod.Text)
        End If


    End Sub

    Private Sub tbxBUSCADesc_TextChanged(sender As Object, e As EventArgs) Handles tbxBuscaDesc.TextChanged
        Buscar()
    End Sub

    Private Sub tbxBUSCACod_TextChanged(sender As Object, e As EventArgs) Handles tbxBuscaCod.TextChanged
        Buscar()

    End Sub

    Private Sub tbxBUSCADesc_MouseClick(sender As Object, e As MouseEventArgs) Handles tbxBuscaDesc.MouseClick
        tbxBuscaCod.Clear()
        cargarGrid()
    End Sub

    Private Sub tbxBUSCACod_MouseClick(sender As Object, e As MouseEventArgs) Handles tbxBuscaCod.MouseClick
        tbxBuscaDesc.Clear()
        cargarGrid()
    End Sub

    Private Sub tbxBUSCADesc_GotFocus(sender As Object, e As EventArgs) Handles tbxBuscaDesc.GotFocus
        tbxBuscaCod.Clear()
        cargarGrid()
    End Sub

    Private Sub tbxBUSCACodigo_GotFocus(sender As Object, e As EventArgs) Handles tbxBuscaCod.GotFocus
        tbxBuscaDesc.Clear()
        cargarGrid()
    End Sub
#End Region

    '------------------cuando hago un CLICK en alguna fila del datagrid de PRODUCTOS
    Private Sub dtgPRODUCTOS_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgPRODUCTOS.CellClick
        Dim fil As Integer = Me.dtgPRODUCTOS.CurrentRow.Index 'Para obtener el indice de la fila seleccionada


        txtCod.Text = Me.dtgPRODUCTOS.Rows(fil).Cells(0).Value
        txtDescripcion.Text = Me.dtgPRODUCTOS.Rows(fil).Cells(1).Value
        txtPRECIO.Text = Me.dtgPRODUCTOS.Rows(fil).Cells(4).Value
        txtCANTIDAD.Text = 0

        btnAGREGAR_PRODUCTO.Enabled = True
        BtnLimpiar.Enabled = True
        txtCANTIDAD.Enabled = True


    End Sub

    '-----------------------------LISTA DE DATALLES-----------------------------------
    Private Sub dtgVentas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgVentas.CellClick
        Me.BtnEditar.Enabled = True
        btnEliminar.Enabled = True
    End Sub

    '-------------------------------------------------------------------------------------------------------------------------
    Private Sub btnAGREGAR_PRODUCTO_Click(sender As Object, e As EventArgs) Handles btnAGREGAR_PRODUCTO.Click
        '//verificar que los campos no esten vacios , todos los campos de producto

        '//controla que la cantidad sea menor o igual al stock para poder realizar la venta

        '//cuando se agregar limpiar los campos


        If (txtCANTIDAD.Text = "") Then
            MsgBox("Por favor,Agregue la cantidad que desea del producto", MsgBoxStyle.Critical, "Error")
            txtCANTIDAD.Clear()
            txtCANTIDAD.Focus()
            Exit Sub
        ElseIf txtCANTIDAD.Text = 0 Then
            MsgBox("Por favor,Agregue la cantidad que desea del producto", MsgBoxStyle.Critical, "ERROR")
            txtCANTIDAD.Clear()
            txtCANTIDAD.Focus()
            Exit Sub
        ElseIf objProducto.obtenerUnProducto(txtCod.Text).stock < CInt(txtCANTIDAD.Text) Then
            'mensaje de error, no hay stock suficiente
            MsgBox("NO HAY SUFICIENTE STOCK, VERIFIQUE DISPONIBLILIAD.", MsgBoxStyle.Critical, "ERROR")
            txtCANTIDAD.Clear()
            txtCANTIDAD.Focus()
            Exit Sub
        End If

        If Not ExisteProductoGrid(txtCod.Text) Then
            '//variables definidas globalmente

            producto_v = CInt(txtCod.Text)
            descripcion_v = txtDescripcion.Text
            precio_v = CDec(txtPRECIO.Text)
            cantidad_v = CInt(txtCANTIDAD.Text)

            subTotal_v = cantidad_v * precio_v

            total_v = total_v + subTotal_v

            Me.dtgVentas.Rows.Add(producto_v, descripcion_v, cantidad_v, precio_v, subTotal_v) '//agrego al datagrid



            Me.dtgVentas.Columns(0).Visible = False '//para que no aparezca la columna codigo, que no se muestre pero que esta en el datagrid, pero se necesita para hacer factura detalle

            'propiedades del dategrid acomodando el tamaño de columnaas
            Me.dtgVentas.Columns(1).Width = 570 'columna de descripcion

            Me.lblTotal.Text = total_v 'Actualizamos el total de ventas


            controlarBotones() 'Activa los botones de detalles

            '//limpiar los campos
            Limpiar()
            BtnLimpiar.Enabled = False
            btnAGREGAR_PRODUCTO.Enabled = False
            txtCANTIDAD.Enabled = False

        Else
            MsgBox("El producto que desea ingresar ya estar cargado," & vbNewLine &
                   "para modificarlo haga clic en la fila y luego en el boton editar detalle ", MsgBoxStyle.Information, "AVISO")
            Limpiar()
            txtCANTIDAD.Enabled = False
        End If

    End Sub




#Region "Cierre de formulario"
    Private Sub btncerrar1_Click(sender As Object, e As EventArgs) Handles btncerrar1.Click
        If MessageBox.Show("Estas seguro que desea Salir", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Me.Hide()
            'FormVendedor.Show()
            'Application.[Exit]()
            Limpiar()
            LimpiarCampos()
            '//Limpio mi detalle de productos porque la venta se generó y fue exitosa
            dtgVentas.Rows.Clear()
            Me.Close()

        End If
    End Sub

#End Region

#Region "VALIDACION"

    '--------------------tbx cantidad
    Private Sub tbxCANTIDAD_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCANTIDAD.KeyPress
        Validacion.validarSoloNumeros(e)
    End Sub

#End Region


#Region "otros metodos"


    Private Sub crearFactura()

        '//Tomo los datos necesarios para armar una factura
        '//id_factura no necesito porque es auto incremental
        '//El dni del empleado Usuario que gestiona la venta
        Dim dniEmpleado As Integer = CInt(tbxDNI_USUARIO.Text)
        '//El dni del cliente que compra
        Dim dniCliente As Integer = CInt(tbxCLIENTE_cod.Text)
        '//Fecha. Utilizo la fecha actual
        Dim fecha As DateTime = DateTime.Now '// DateTime.Now da fecha y hora actual
        Dim total As Decimal = CDec(lblTotal.Text)

        '//Creo un tipo de objeto Factura vacio
        Dim unaFactura As Facturas = New Facturas()

        ' //Le asigno los valores correspondientes que obtengo del formulario de ventas
        ' //y de la interaccion del usuario
        unaFactura.id_usuario = DatosImportantes.IdUsu
        unaFactura.dni_cliente = dniCliente
        unaFactura.fecha_factura = fecha
        unaFactura.total_factura = total
        unaFactura.estado_factura = True

    End Sub

    Public Function ExisteProductoGrid(ByVal codigo As String) As Boolean
        Dim existeProducto As Boolean = False

        If Not dtgVentas.RowCount = 0 Then


            For i As Integer = 0 To dtgVentas.Rows.Count - 1

                If dtgVentas.Item(0, i).Value = codigo Then
                    existeProducto = True
                End If
            Next
            Return existeProducto
        Else
            Return False
        End If

    End Function

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub tbxDNI_USUARIO_TextChanged(sender As Object, e As EventArgs) Handles tbxDNI_USUARIO.TextChanged

    End Sub

    Private Sub panel2_Paint(sender As Object, e As PaintEventArgs) Handles panel2.Paint

    End Sub

    Private Sub tbxFecha_TextChanged(sender As Object, e As EventArgs) Handles tbxFecha.TextChanged

    End Sub








#End Region

End Class