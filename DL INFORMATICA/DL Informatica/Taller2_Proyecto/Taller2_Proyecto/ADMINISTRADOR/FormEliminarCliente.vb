Public Class FormEliminarCliente

    Dim objCliente As Eclientes = New Eclientes


    Private Sub FormEliminarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Size = New Size(1008, 415)
        CargarGrid()
        ListadoClientes.Visible = True

    End Sub

    Public Sub CargarGrid()
        objCliente.getClientesAll(dtgCLIENTES)

        If dtgCLIENTES.Rows.Count() <> 0 Then
            dtgCLIENTES.Rows(0).Selected = False
            dtgCLIENTES.Visible = True
            LEliminar.Visible = True
            LAlta.Visible = True
            LabelLista.Visible = True
            Linfo.Visible = False

            tbxBUSCAAPE.Enabled = True
            tbxBUSCADNI.Enabled = True
        Else
            dtgCLIENTES.Visible = False
            LEliminar.Visible = False
            LAlta.Visible = False
            LabelLista.Visible = False
            Linfo.Visible = True
            tbxBUSCAAPE.Enabled = False
            tbxBUSCADNI.Enabled = False
        End If


        Try
            dtgCLIENTES.Columns(0).Width = 100
            dtgCLIENTES.Columns(1).Width = 110

        Catch ex As Exception

        End Try

        'hacer invisible algunas columnas
        dtgCLIENTES.Columns(3).Visible = False
            dtgCLIENTES.Columns(4).Visible = False
            dtgCLIENTES.Columns(5).Visible = False
            dtgCLIENTES.Columns(6).Visible = False
            dtgCLIENTES.Columns(7).Visible = False
        dtgCLIENTES.Columns(8).Visible = False
        dtgCLIENTES.Columns(9).Visible = False


    End Sub

    Private Sub dtgCLIENTES_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dtgCLIENTES.CellFormatting
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

        fila = dtgCLIENTES.CurrentRow.Index 'toma el indice de la fila en la cual se hizo doble click

        TextDNI.Text = dtgCLIENTES.Item(0, fila).Value()
        txtAPELLIDO.Text = dtgCLIENTES.Item(1, fila).Value()
        txtNOMBRE.Text = dtgCLIENTES.Item(2, fila).Value()
        txtDIRECCION.Text = dtgCLIENTES.Item(3, fila).Value()
        comboPROVINCIA.Text = dtgCLIENTES.Item(4, fila).Value()
        txtTELEFONO.Text = dtgCLIENTES.Item(5, fila).Value()
        txtEmail.Text = dtgCLIENTES.Item(6, fila).Value()
        TextFecha.Text = dtgCLIENTES.Item(7, fila).Value()
        ComboSexo.Text = dtgCLIENTES.Item(9, fila).Value()

        '------------habilitar botones de dar de baja o de alta de acuerdo con el estado del cliente
        Dim estado As Boolean = dtgCLIENTES.Item(8, fila).Value()

        If estado Then
            btnELIMINAR.Enabled = True
            BtnActivar.Enabled = False
        Else
            BtnActivar.Enabled = True
            btnELIMINAR.Enabled = False
        End If
        '---------------------------------------------------------------------------------------------
        btnLIMPIAR.Enabled = True

        'falta el codigo de preguntar si estado es false del cliente que se cliqueo que se habilite el boton activar

    End Sub



    'los siguientes metodos es para controlar la dimension de la venta
    'Private Sub BtnListar_Click(sender As Object, e As EventArgs) Handles BtnListar.Click
    '    
    '    Me.Size = New Size(1008, 738)
    '    BtnListar.Visible = False
    '    'BtnOcultar.Visible = True


    'End Sub

    'Private Sub BtnOcultar_Click(sender As Object, e As EventArgs) Handles BtnOcultar.Click

    '    Me.Size = New Size(1008, 415)
    '    BtnListar.Visible = True
    'End Sub

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

    Private Sub btnELIMINAR_Click(sender As Object, e As EventArgs) Handles btnELIMINAR.Click
        Try
            Dim mensaje As String = "Esta seguro que desea dar de baja al cliente seleccionado?"
            If (Validacion.EstaUdSeguro(mensaje)) Then

                Dim cliente = tomarCamposArmarCliente()
                objCliente.eliminarCliente(cliente.Dni_clientes)
                CargarGrid()




                MsgBox("El Cliente " + txtNOMBRE.Text + " " + txtAPELLIDO.Text + " se dio de baja correctamente", 64, "AVISO")

                Limpiar()

                BtnActivar.Enabled = False
                btnELIMINAR.Enabled = False
                btnLIMPIAR.Enabled = False

                'para posicionarse en la fila modificada
                dtgCLIENTES.FirstDisplayedScrollingRowIndex = fila
                dtgCLIENTES.Refresh()
                dtgCLIENTES.CurrentCell = dtgCLIENTES.Rows(fila).Cells(1)
                dtgCLIENTES.Rows(fila).Selected = True

            End If

        Catch ex As Exception

            'MessageBox.Show(ex.ToString())
            MsgBox("El Cliente no se puedo dar de Baja", 64, "Guardar")


        End Try


    End Sub


    Private Sub Limpiar()
        txtAPELLIDO.Clear()
        txtDIRECCION.Clear()
        txtEmail.Clear()
        txtNOMBRE.Clear()
        txtTELEFONO.Clear()
        comboPROVINCIA.ResetText()
        'comboPROVINCIA.SelectedValue = -1
        ComboSexo.ResetText()

        TextFecha.Clear()
        TextDNI.Clear()


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
                'btnMODIFICAR.Enabled = False
                btnLIMPIAR.Enabled = False

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

    Private Function tomarCamposArmarCliente() As Clientes
        Dim unCliente As Clientes = New Clientes()
        Dim estado As Boolean = dtgCLIENTES.Item(8, fila).Value()

        unCliente.Dni_clientes = CInt(TextDNI.Text)
        unCliente.nombre = txtNOMBRE.Text
        unCliente.apellido = txtAPELLIDO.Text
        unCliente.direccion = txtDIRECCION.Text
        unCliente.id_provincia = CInt(comboPROVINCIA.SelectedValue) 'de esta manera porque enabled=true
        unCliente.telefono = txtTELEFONO.Text
        unCliente.email = txtEmail.Text
        unCliente.fecha_alta = TextFecha.Text
        unCliente.estado_cliente = estado
        unCliente.sexo = ComboSexo.Text
        Return unCliente
    End Function

    Private Sub btnLIMPIAR_Click(sender As Object, e As EventArgs) Handles btnLIMPIAR.Click

        Dim mensaje As String = "Desea borrar todos los campos?"
        If (Validacion.EstaUdSeguro(mensaje)) Then
            Limpiar()
            btnLIMPIAR.Enabled = False
            BtnActivar.Enabled = False
            btnELIMINAR.Enabled = False


        End If
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        If MessageBox.Show("Estas seguro que desea Salir", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Me.Hide()
            'FormVendedor.Show()
            'Application.[Exit]()
            Limpiar()

            Me.Close()

        End If
    End Sub

    Private Sub BtnAyuda_Click(sender As Object, e As EventArgs) Handles BtnAyuda.Click
        Dim mensaje As String = "Para Dar de Baja: Doble click en la fila del cliente cuyo estado está tildado y luego click en boton Dar de Baja" & vbNewLine & vbNewLine &
                           "Para Dar de Alta: Doble click en la fila del cliente cuyo estado no está tildado y luego click en boton Dar de Alta"
        Dim titulo As String = "Por Favor, leer estas sugerencias..."
        MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


End Class