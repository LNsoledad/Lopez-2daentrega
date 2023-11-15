
Public Class FormModifStockPrecio

    Dim objProducto As Eproductos = New Eproductos

    Private Sub FormModifStockPrecio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGrid()
        CargarCategorias()
        CargarMarcas()
    End Sub


    Public Sub CargarGrid()
        objProducto.getProductosActivos(dtgPRODUCTOS)
        dtgPRODUCTOS.Rows(0).Selected = False
        Try
            dtgPRODUCTOS.Columns(0).Width = 80
            dtgPRODUCTOS.Columns(1).Width = 570
            dtgPRODUCTOS.Columns(2).Width = 140
            dtgPRODUCTOS.Columns(3).Width = 120
            dtgPRODUCTOS.Columns(4).Width = 50
            dtgPRODUCTOS.Columns(6).Width = 70
            'dtgPRODUCTOS.Columns(2).Visible = False '//para que no aparezca la columna categoria, que no se muestre pero que esta en el datagrid, pero se necesita para hacer un producto
            'dtgPRODUCTOS.Columns(3).Visible = False 'para que no aparezca la columna marca en el datagrid
        Catch ex As Exception

        End Try

    End Sub

    Public Sub CargarCategorias()
        objProducto.cargarBoxCategorias(cbxCategoria)
    End Sub

    Public Sub CargarMarcas()
        objProducto.cargarBoxMarcas(cbxMARCA)
    End Sub

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



#Region "Limpiar"
    Private Sub btnLIMPIAR_Click(sender As Object, e As EventArgs) Handles btnLIMPIAR.Click
        Dim mensaje As String = "Desea borrar todos los campos?"

        If (Validacion.EstaUdSeguro(mensaje)) Then
            Limpiar()
            btnLIMPIAR.Enabled = False
            BtnModificar.Enabled = False
            txtSTOCK.Enabled = False
            txtPRECIO.Enabled = False
        End If


    End Sub

    Private Sub Limpiar()
        txtCODIGO.Clear()
        txtDESCRIPCION.Clear()
        cbxCategoria.ResetText()
        cbxMARCA.ResetText()
        txtSTOCK.Clear()
        txtPRECIO.Clear()

        tbxBUSCACodigo.Clear()
        tbxBUSCADescripcion.Clear()


    End Sub

#End Region

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        Try

            Dim mensaje As String = "¿Seguro que queres Modificar el Producto: " + txtDESCRIPCION.Text & vbNewLine &
                                        "Con el codigo Nº:  " + txtCODIGO.Text + " ?"
            If (Validacion.EstaUdSeguro(mensaje)) Then

                Dim producto = tomarCamposArmarProducto()
                objProducto.actualizarProducto(producto)
                CargarGrid()

                MsgBox("El Producto " + txtDESCRIPCION.Text & vbNewLine &
                                        "Con el Codigo Nº:  " + txtCODIGO.Text + " se modifico correctamente", MsgBoxStyle.Information, "AVISO")
                Limpiar()

                BtnModificar.Enabled = False
                btnLIMPIAR.Enabled = False


                txtSTOCK.Enabled = False
                txtPRECIO.Enabled = False


                'hacer foco en el modificado(falta)
                'para posicionarse en la fila modificada
                dtgPRODUCTOS.FirstDisplayedScrollingRowIndex = fila
                dtgPRODUCTOS.Refresh()
                dtgPRODUCTOS.CurrentCell = dtgPRODUCTOS.Rows(fila).Cells(0)
                dtgPRODUCTOS.Rows(fila).Selected = True

                BtnModificar.Enabled = False

            End If

        Catch ex As Exception

            '//MessageBox.Show(ex.ToString());
            MsgBox("El Producto " + txtDESCRIPCION.Text + " no se puedo modificar", 64, "Guardar")
            Limpiar()


        End Try
    End Sub

#Region "Carga grid a campos"
    Dim fila As Integer 'variable global que obtendra el indice de la fila que se clickeo


    Private Sub dtgPRODUCTOS_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgPRODUCTOS.CellDoubleClick

        fila = dtgPRODUCTOS.CurrentRow.Index 'toma el indice de la fila en la cual se hizo doble click

        txtCODIGO.Text = dtgPRODUCTOS.Item(0, fila).Value()
        txtDESCRIPCION.Text = dtgPRODUCTOS.Item(1, fila).Value()
        cbxCategoria.Text = dtgPRODUCTOS.Item(2, fila).Value()
        cbxMARCA.Text = dtgPRODUCTOS.Item(3, fila).Value()

        txtSTOCK.Text = dtgPRODUCTOS.Item(4, fila).Value()
        txtPRECIO.Text = dtgPRODUCTOS.Item(5, fila).Value()


        txtPRECIO.Enabled = True
        Me.txtSTOCK.Enabled = True
        BtnModificar.Enabled = True
        btnLIMPIAR.Enabled = True


    End Sub
#End Region

#Region "Buscar Productos"

    Public Sub Buscar()

        If tbxBUSCADescripcion.Text = "" Or tbxBUSCACodigo.Text = "" Then

            CargarGrid()

        End If

        If tbxBUSCADescripcion.Text <> "" Then
            objProducto.FiltrarProductosDescripcionActivos(dtgPRODUCTOS, tbxBUSCADescripcion.Text)
        End If

        If tbxBUSCACodigo.Text <> "" Then
            objProducto.FiltrarProductosCodigoActivos(dtgPRODUCTOS, tbxBUSCACodigo.Text)
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

#Region "Cambio de colores boton"
    Private Sub BtnModificar_MouseEnter(sender As Object, e As EventArgs) Handles BtnModificar.MouseEnter
        BtnModificar.BackColor = Color.LimeGreen
    End Sub

    '-------------------------------------------------------------------------------------------------------------
    '---los botones cambian al color limeGreen cuando se aleja de los mismos---------------------------------
    Private Sub BtnModificar_MouseLeave(sender As Object, e As EventArgs) Handles BtnModificar.MouseLeave
        BtnModificar.BackColor = Color.LightGreen
    End Sub
#End Region

#Region "Validaciones"
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
        End If

    End Sub

    Dim contarComa As Integer = 0
    Private Sub txtPRECIO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPRECIO.KeyPress

        If Asc(e.KeyChar) = 46 Then 'Asc es codigo ASCII, si se presiona punto codigo ASCII=46
            MessageBox.Show("Por favor utilice la coma para separacion decimal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'txtPRECIO.Clear()
            txtPRECIO.Focus()
        ElseIf Asc(e.KeyChar) = 44 Then 'Asc es codigo ASCII, si se presiona coma codigo ASCII=43
            contarComa = contarComa + 1
            If contarComa > 1 Then
                MessageBox.Show("Por favor utilice solo una coma para separacion decimal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'txtPRECIO.Clear()
                txtPRECIO.Focus()
            End If
        End If

    End Sub



#End Region

#Region "Otros metodos"
    Private Function tomarCamposArmarProducto() As Productos

        Dim unProductoMoficado As Productos = New Productos()
        Dim estado As Boolean = dtgPRODUCTOS.Item(6, fila).Value()

        unProductoMoficado.id_producto = CInt(txtCODIGO.Text)
        unProductoMoficado.descripcion = txtDESCRIPCION.Text

        unProductoMoficado.stock = txtSTOCK.Text
        unProductoMoficado.precio = txtPRECIO.Text
        unProductoMoficado.estado = estado


        unProductoMoficado.id_categoria = CInt(cbxCategoria.SelectedValue.ToString)
        unProductoMoficado.id_marca = CInt(cbxMARCA.SelectedValue.ToString)
        Return unProductoMoficado


    End Function





#End Region

End Class